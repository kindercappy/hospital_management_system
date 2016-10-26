namespace hospitalManagementSystem
{
    partial class DoctorShifts
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
            this.dataGridViewDoctorShifts = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelHeightInch = new System.Windows.Forms.Label();
            this.labelHeightInFt = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxHeightInch = new System.Windows.Forms.TextBox();
            this.textBoxHeightFt = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.comboBoxShifts = new System.Windows.Forms.ComboBox();
            this.labelDoctorShifts = new System.Windows.Forms.Label();
            this.labelShiftName = new System.Windows.Forms.Label();
            this.textBoxShiftsName = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.buttonNewShift = new System.Windows.Forms.Button();
            this.dataGridViewShifts = new System.Windows.Forms.DataGridView();
            this.buttonInsertShift = new System.Windows.Forms.Button();
            this.buttonUpdateShift = new System.Windows.Forms.Button();
            this.buttonDeleteShift = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorShifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoctorShifts
            // 
            this.dataGridViewDoctorShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctorShifts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDoctorShifts.Name = "dataGridViewDoctorShifts";
            this.dataGridViewDoctorShifts.Size = new System.Drawing.Size(1084, 328);
            this.dataGridViewDoctorShifts.TabIndex = 0;
            this.dataGridViewDoctorShifts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctorShifts_CellContentClick);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonBack.Location = new System.Drawing.Point(1216, 607);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(230, 28);
            this.buttonBack.TabIndex = 55;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(1102, 87);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(65, 13);
            this.labelDepartment.TabIndex = 54;
            this.labelDepartment.Text = "Department:";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(1214, 84);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDepartment.TabIndex = 53;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.comboBoxSex.Location = new System.Drawing.Point(1214, 137);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSex.TabIndex = 52;
            this.comboBoxSex.Text = "Select";
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Location = new System.Drawing.Point(1214, 267);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNationality.TabIndex = 51;
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Location = new System.Drawing.Point(1102, 270);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(59, 13);
            this.labelNationality.TabIndex = 50;
            this.labelNationality.Text = "Nationality:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(1102, 296);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 49;
            this.labelAddress.Text = "Address:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(1102, 244);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 48;
            this.labelEmail.Text = "Email:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(1102, 218);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(44, 13);
            this.labelWeight.TabIndex = 47;
            this.labelWeight.Text = "Weight:";
            // 
            // labelHeightInch
            // 
            this.labelHeightInch.AutoSize = true;
            this.labelHeightInch.Location = new System.Drawing.Point(1102, 192);
            this.labelHeightInch.Name = "labelHeightInch";
            this.labelHeightInch.Size = new System.Drawing.Size(94, 13);
            this.labelHeightInch.TabIndex = 46;
            this.labelHeightInch.Text = "Height (In Inches):";
            // 
            // labelHeightInFt
            // 
            this.labelHeightInFt.AutoSize = true;
            this.labelHeightInFt.Location = new System.Drawing.Point(1102, 166);
            this.labelHeightInFt.Name = "labelHeightInFt";
            this.labelHeightInFt.Size = new System.Drawing.Size(83, 13);
            this.labelHeightInFt.TabIndex = 45;
            this.labelHeightInFt.Text = "Height (In Feet):";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(1102, 140);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(28, 13);
            this.labelSex.TabIndex = 44;
            this.labelSex.Text = "Sex:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(1102, 114);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(29, 13);
            this.labelAge.TabIndex = 43;
            this.labelAge.Text = "Age:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(1102, 61);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 42;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(1102, 35);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 41;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(1214, 293);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 40;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(1214, 241);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 39;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(1214, 215);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 38;
            // 
            // textBoxHeightInch
            // 
            this.textBoxHeightInch.Location = new System.Drawing.Point(1214, 189);
            this.textBoxHeightInch.Name = "textBoxHeightInch";
            this.textBoxHeightInch.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeightInch.TabIndex = 37;
            // 
            // textBoxHeightFt
            // 
            this.textBoxHeightFt.Location = new System.Drawing.Point(1214, 163);
            this.textBoxHeightFt.Name = "textBoxHeightFt";
            this.textBoxHeightFt.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeightFt.TabIndex = 36;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(1214, 111);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 35;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(1214, 58);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 34;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(1214, 32);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 33;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(1214, 6);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 32;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(1102, 9);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 13);
            this.labelPhone.TabIndex = 31;
            this.labelPhone.Text = "Phone:";
            // 
            // comboBoxShifts
            // 
            this.comboBoxShifts.FormattingEnabled = true;
            this.comboBoxShifts.Location = new System.Drawing.Point(1214, 319);
            this.comboBoxShifts.Name = "comboBoxShifts";
            this.comboBoxShifts.Size = new System.Drawing.Size(227, 21);
            this.comboBoxShifts.TabIndex = 56;
            this.comboBoxShifts.SelectedIndexChanged += new System.EventHandler(this.comboBoxShifts_SelectedIndexChanged);
            // 
            // labelDoctorShifts
            // 
            this.labelDoctorShifts.AutoSize = true;
            this.labelDoctorShifts.Location = new System.Drawing.Point(1102, 327);
            this.labelDoctorShifts.Name = "labelDoctorShifts";
            this.labelDoctorShifts.Size = new System.Drawing.Size(68, 13);
            this.labelDoctorShifts.TabIndex = 57;
            this.labelDoctorShifts.Text = "Doctor Shifts";
            // 
            // labelShiftName
            // 
            this.labelShiftName.AutoSize = true;
            this.labelShiftName.Location = new System.Drawing.Point(1102, 404);
            this.labelShiftName.Name = "labelShiftName";
            this.labelShiftName.Size = new System.Drawing.Size(59, 13);
            this.labelShiftName.TabIndex = 58;
            this.labelShiftName.Text = "Shift Name";
            // 
            // textBoxShiftsName
            // 
            this.textBoxShiftsName.Location = new System.Drawing.Point(1192, 404);
            this.textBoxShiftsName.Name = "textBoxShiftsName";
            this.textBoxShiftsName.Size = new System.Drawing.Size(173, 20);
            this.textBoxShiftsName.TabIndex = 59;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(1192, 431);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(173, 20);
            this.textBoxFrom.TabIndex = 60;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(1102, 434);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(84, 13);
            this.labelFrom.TabIndex = 61;
            this.labelFrom.Text = "From (00:00:00):";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(1102, 464);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(74, 13);
            this.labelTo.TabIndex = 62;
            this.labelTo.Text = "To (00:00:00):";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(1192, 457);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(173, 20);
            this.textBoxTo.TabIndex = 63;
            // 
            // buttonNewShift
            // 
            this.buttonNewShift.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonNewShift.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonNewShift.Location = new System.Drawing.Point(12, 518);
            this.buttonNewShift.Name = "buttonNewShift";
            this.buttonNewShift.Size = new System.Drawing.Size(263, 28);
            this.buttonNewShift.TabIndex = 64;
            this.buttonNewShift.Text = "New Shift";
            this.buttonNewShift.UseVisualStyleBackColor = false;
            this.buttonNewShift.Click += new System.EventHandler(this.buttonNewShift_Click);
            // 
            // dataGridViewShifts
            // 
            this.dataGridViewShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShifts.Location = new System.Drawing.Point(12, 346);
            this.dataGridViewShifts.Name = "dataGridViewShifts";
            this.dataGridViewShifts.Size = new System.Drawing.Size(1084, 166);
            this.dataGridViewShifts.TabIndex = 65;
            this.dataGridViewShifts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShifts_CellContentClick);
            // 
            // buttonInsertShift
            // 
            this.buttonInsertShift.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonInsertShift.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonInsertShift.Location = new System.Drawing.Point(12, 582);
            this.buttonInsertShift.Name = "buttonInsertShift";
            this.buttonInsertShift.Size = new System.Drawing.Size(263, 28);
            this.buttonInsertShift.TabIndex = 66;
            this.buttonInsertShift.Text = "Insert Shift";
            this.buttonInsertShift.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateShift
            // 
            this.buttonUpdateShift.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonUpdateShift.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonUpdateShift.Location = new System.Drawing.Point(281, 518);
            this.buttonUpdateShift.Name = "buttonUpdateShift";
            this.buttonUpdateShift.Size = new System.Drawing.Size(263, 28);
            this.buttonUpdateShift.TabIndex = 67;
            this.buttonUpdateShift.Text = "Update Shift";
            this.buttonUpdateShift.UseVisualStyleBackColor = false;
            this.buttonUpdateShift.Click += new System.EventHandler(this.buttonUpdateShift_Click);
            // 
            // buttonDeleteShift
            // 
            this.buttonDeleteShift.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDeleteShift.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonDeleteShift.Location = new System.Drawing.Point(550, 518);
            this.buttonDeleteShift.Name = "buttonDeleteShift";
            this.buttonDeleteShift.Size = new System.Drawing.Size(263, 28);
            this.buttonDeleteShift.TabIndex = 68;
            this.buttonDeleteShift.Text = "Delete Shift";
            this.buttonDeleteShift.UseVisualStyleBackColor = false;
            this.buttonDeleteShift.Click += new System.EventHandler(this.buttonDeleteShift_Click);
            // 
            // DoctorShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 801);
            this.Controls.Add(this.buttonDeleteShift);
            this.Controls.Add(this.buttonUpdateShift);
            this.Controls.Add(this.buttonInsertShift);
            this.Controls.Add(this.dataGridViewShifts);
            this.Controls.Add(this.buttonNewShift);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.textBoxShiftsName);
            this.Controls.Add(this.labelShiftName);
            this.Controls.Add(this.labelDoctorShifts);
            this.Controls.Add(this.comboBoxShifts);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.comboBoxNationality);
            this.Controls.Add(this.labelNationality);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelHeightInch);
            this.Controls.Add(this.labelHeightInFt);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxHeightInch);
            this.Controls.Add(this.textBoxHeightFt);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.dataGridViewDoctorShifts);
            this.Name = "DoctorShifts";
            this.Text = "DoctorShifts";
            this.Load += new System.EventHandler(this.DoctorShifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorShifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoctorShifts;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.ComboBox comboBoxNationality;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHeightInch;
        private System.Windows.Forms.Label labelHeightInFt;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxHeightInch;
        private System.Windows.Forms.TextBox textBoxHeightFt;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.ComboBox comboBoxShifts;
        private System.Windows.Forms.Label labelDoctorShifts;
        private System.Windows.Forms.Label labelShiftName;
        private System.Windows.Forms.TextBox textBoxShiftsName;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Button buttonNewShift;
        private System.Windows.Forms.DataGridView dataGridViewShifts;
        private System.Windows.Forms.Button buttonInsertShift;
        private System.Windows.Forms.Button buttonUpdateShift;
        private System.Windows.Forms.Button buttonDeleteShift;
    }
}