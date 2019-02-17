using LicenceManager.Core;
using LicenceManager.Core.Licences;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenceManager.UI
{
    public partial class Form1 : Form
    {
        DataModels.KookClinicLicenceManager _licenceManagerDatabase =
            new DataModels.KookClinicLicenceManager();
        private LicenceGenerator _licenceGenerator;
        public Form1()
        {
            InitializeComponent();
            _licenceGenerator = new LicenceGenerator();
        }

        private void _generateButton_Click(object sender, EventArgs e)
        {
            if (_serialTextbox.Text == string.Empty)
            {
                MessageBox.Show("serial can not be empty!!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_customerTextbox.Text == string.Empty)
            {
                MessageBox.Show("customer name can not be empty!!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_LicenceTypeCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("please select licence type.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LicenceType licenceType;
            licenceType =(LicenceType) _LicenceTypeCombobox.SelectedIndex;
            var licence = new Licence
            {
                CustomerName = _customerTextbox.Text,
                Trial = _trialCheckbox.Checked,
                CreationDate = DateTime.Now,
                TrialDays = (int)_trialDaysNumericUpDown.Value,
                Type = licenceType
            };
            var licencePackString = _licenceGenerator.Generate(licence, _serialTextbox.Text);
            setInDatabase(licencePackString);
            saveLicencePackAsFile(licencePackString);
        }

        private void setInDatabase(string licencePackString)
        {
            DataModels.Licence licence = new DataModels.Licence();
            licence.CreationDate = DateTime.Now;
            licence.CustomerCode = _customerCodeTextbox.Text;
            licence.CustomerName = _customerTextbox.Text;
            licence.Id = Guid.NewGuid();
            licence.IsTrial = _trialCheckbox.Checked;
            licence.LicencePack = licencePackString;
            licence.Serial = _serialTextbox.Text;
            licence.TrialDaysCount = (int)_trialDaysNumericUpDown.Value;
            licence.LicenceType = _LicenceTypeCombobox.SelectedIndex;
            _licenceManagerDatabase.Licences.Add(licence);
            _licenceManagerDatabase.SaveChanges();
        }

        private void saveLicencePackAsFile(string licencePackString)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.loc)|*.loc";
            saveFileDialog.Title = "save lock as file";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, licencePackString);
            }
            saveFileDialog.Dispose();
        }

        private void _trialCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            _trialDaysNumericUpDown.Enabled = _trialCheckbox.Checked;
        }
    }
}
