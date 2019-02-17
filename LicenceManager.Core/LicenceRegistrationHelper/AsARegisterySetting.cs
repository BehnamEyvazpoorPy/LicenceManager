using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenceManager.Core.LicenceRegistrationHelper
{
    class AsARegisterySetting : ILicenceRegistrationHelper
    {
        public bool CheckForLicenceRegistration()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\KookClinic");
            string licencePackString = key.GetValue("LicencePackString").ToString();
            key.Close();
            return licencePackString != string.Empty;
        }

        public string GetLicence()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\KookClinic");
            string licencePackString = key.GetValue("LicencePackString").ToString();
            key.Close();
            return licencePackString;
        }

        public void Register(string licencePackString)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\KookClinic");
            key.SetValue("LicencePackString", licencePackString);
            key.Close();
        }
    }
}
