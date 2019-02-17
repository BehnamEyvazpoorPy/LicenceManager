namespace LicenceManager.UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._generateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._customerTextbox = new System.Windows.Forms.TextBox();
            this._trialCheckbox = new System.Windows.Forms.CheckBox();
            this._trialDaysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._LicenceTypeCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._serialTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._customerCodeTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._trialDaysNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _generateButton
            // 
            this._generateButton.Location = new System.Drawing.Point(213, 289);
            this._generateButton.Name = "_generateButton";
            this._generateButton.Size = new System.Drawing.Size(190, 45);
            this._generateButton.TabIndex = 0;
            this._generateButton.Text = "Generate";
            this._generateButton.UseVisualStyleBackColor = true;
            this._generateButton.Click += new System.EventHandler(this._generateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer :";
            // 
            // _customerTextbox
            // 
            this._customerTextbox.Location = new System.Drawing.Point(213, 131);
            this._customerTextbox.Name = "_customerTextbox";
            this._customerTextbox.Size = new System.Drawing.Size(468, 27);
            this._customerTextbox.TabIndex = 2;
            // 
            // _trialCheckbox
            // 
            this._trialCheckbox.AutoSize = true;
            this._trialCheckbox.Location = new System.Drawing.Point(213, 185);
            this._trialCheckbox.Name = "_trialCheckbox";
            this._trialCheckbox.Size = new System.Drawing.Size(57, 24);
            this._trialCheckbox.TabIndex = 3;
            this._trialCheckbox.Text = "Trial";
            this._trialCheckbox.UseVisualStyleBackColor = true;
            this._trialCheckbox.CheckedChanged += new System.EventHandler(this._trialCheckbox_CheckedChanged);
            // 
            // _trialDaysNumericUpDown
            // 
            this._trialDaysNumericUpDown.Location = new System.Drawing.Point(276, 182);
            this._trialDaysNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._trialDaysNumericUpDown.Name = "_trialDaysNumericUpDown";
            this._trialDaysNumericUpDown.Size = new System.Drawing.Size(127, 27);
            this._trialDaysNumericUpDown.TabIndex = 4;
            this._trialDaysNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._trialDaysNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // _LicenceTypeCombobox
            // 
            this._LicenceTypeCombobox.FormattingEnabled = true;
            this._LicenceTypeCombobox.Items.AddRange(new object[] {
            "Full",
            "FinancialAudit",
            "Medical",
            "MedicalArchive"});
            this._LicenceTypeCombobox.Location = new System.Drawing.Point(213, 234);
            this._LicenceTypeCombobox.Name = "_LicenceTypeCombobox";
            this._LicenceTypeCombobox.Size = new System.Drawing.Size(190, 28);
            this._LicenceTypeCombobox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Licence Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Serial :";
            // 
            // _serialTextbox
            // 
            this._serialTextbox.Location = new System.Drawing.Point(213, 29);
            this._serialTextbox.Name = "_serialTextbox";
            this._serialTextbox.Size = new System.Drawing.Size(468, 27);
            this._serialTextbox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Customer code :";
            // 
            // _customerCodeTextbox
            // 
            this._customerCodeTextbox.Location = new System.Drawing.Point(213, 77);
            this._customerCodeTextbox.Name = "_customerCodeTextbox";
            this._customerCodeTextbox.Size = new System.Drawing.Size(468, 27);
            this._customerCodeTextbox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(770, 366);
            this.Controls.Add(this._LicenceTypeCombobox);
            this.Controls.Add(this._trialDaysNumericUpDown);
            this.Controls.Add(this._trialCheckbox);
            this.Controls.Add(this._serialTextbox);
            this.Controls.Add(this._customerCodeTextbox);
            this.Controls.Add(this._customerTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._generateButton);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Licence generator";
            ((System.ComponentModel.ISupportInitialize)(this._trialDaysNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _generateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _customerTextbox;
        private System.Windows.Forms.CheckBox _trialCheckbox;
        private System.Windows.Forms.NumericUpDown _trialDaysNumericUpDown;
        private System.Windows.Forms.ComboBox _LicenceTypeCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _serialTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _customerCodeTextbox;
    }
}

