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
            this.textBoxRegistration = new System.Windows.Forms.TextBox();
            this.labelDoctorID = new System.Windows.Forms.Label();
            this.comboBoxShifts = new System.Windows.Forms.ComboBox();
            this.labelDoctorShifts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoctorShifts
            // 
            this.dataGridViewDoctorShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctorShifts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDoctorShifts.Name = "dataGridViewDoctorShifts";
            this.dataGridViewDoctorShifts.Size = new System.Drawing.Size(1084, 150);
            this.dataGridViewDoctorShifts.TabIndex = 0;
            this.dataGridViewDoctorShifts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctorShifts_CellContentClick);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonBack.Location = new System.Drawing.Point(1110, 376);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(209, 43);
            this.buttonBack.TabIndex = 55;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(1107, 117);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(65, 13);
            this.labelDepartment.TabIndex = 54;
            this.labelDepartment.Text = "Department:";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(1219, 114);
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
            this.comboBoxSex.Location = new System.Drawing.Point(1219, 167);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSex.TabIndex = 52;
            this.comboBoxSex.Text = "Select";
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Location = new System.Drawing.Point(1219, 297);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNationality.TabIndex = 51;
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Location = new System.Drawing.Point(1107, 300);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(59, 13);
            this.labelNationality.TabIndex = 50;
            this.labelNationality.Text = "Nationality:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(1107, 326);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 49;
            this.labelAddress.Text = "Address:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(1107, 274);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 48;
            this.labelEmail.Text = "Email:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(1107, 248);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(44, 13);
            this.labelWeight.TabIndex = 47;
            this.labelWeight.Text = "Weight:";
            // 
            // labelHeightInch
            // 
            this.labelHeightInch.AutoSize = true;
            this.labelHeightInch.Location = new System.Drawing.Point(1107, 222);
            this.labelHeightInch.Name = "labelHeightInch";
            this.labelHeightInch.Size = new System.Drawing.Size(94, 13);
            this.labelHeightInch.TabIndex = 46;
            this.labelHeightInch.Text = "Height (In Inches):";
            // 
            // labelHeightInFt
            // 
            this.labelHeightInFt.AutoSize = true;
            this.labelHeightInFt.Location = new System.Drawing.Point(1107, 196);
            this.labelHeightInFt.Name = "labelHeightInFt";
            this.labelHeightInFt.Size = new System.Drawing.Size(83, 13);
            this.labelHeightInFt.TabIndex = 45;
            this.labelHeightInFt.Text = "Height (In Feet):";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(1107, 170);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(28, 13);
            this.labelSex.TabIndex = 44;
            this.labelSex.Text = "Sex:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(1107, 144);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(29, 13);
            this.labelAge.TabIndex = 43;
            this.labelAge.Text = "Age:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(1107, 91);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 42;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(1107, 65);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 41;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(1219, 323);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 40;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(1219, 271);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 39;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(1219, 245);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 38;
            // 
            // textBoxHeightInch
            // 
            this.textBoxHeightInch.Location = new System.Drawing.Point(1219, 219);
            this.textBoxHeightInch.Name = "textBoxHeightInch";
            this.textBoxHeightInch.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeightInch.TabIndex = 37;
            // 
            // textBoxHeightFt
            // 
            this.textBoxHeightFt.Location = new System.Drawing.Point(1219, 193);
            this.textBoxHeightFt.Name = "textBoxHeightFt";
            this.textBoxHeightFt.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeightFt.TabIndex = 36;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(1219, 141);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 35;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(1219, 88);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 34;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(1219, 62);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 33;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(1219, 36);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 32;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(1107, 39);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 13);
            this.labelPhone.TabIndex = 31;
            this.labelPhone.Text = "Phone:";
            // 
            // textBoxRegistration
            // 
            this.textBoxRegistration.Location = new System.Drawing.Point(1219, 10);
            this.textBoxRegistration.Name = "textBoxRegistration";
            this.textBoxRegistration.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistration.TabIndex = 30;
            // 
            // labelDoctorID
            // 
            this.labelDoctorID.AutoSize = true;
            this.labelDoctorID.Location = new System.Drawing.Point(1107, 13);
            this.labelDoctorID.Name = "labelDoctorID";
            this.labelDoctorID.Size = new System.Drawing.Size(56, 13);
            this.labelDoctorID.TabIndex = 29;
            this.labelDoctorID.Text = "Doctor ID:";
            // 
            // comboBoxShifts
            // 
            this.comboBoxShifts.FormattingEnabled = true;
            this.comboBoxShifts.Location = new System.Drawing.Point(1219, 349);
            this.comboBoxShifts.Name = "comboBoxShifts";
            this.comboBoxShifts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShifts.TabIndex = 56;
            // 
            // labelDoctorShifts
            // 
            this.labelDoctorShifts.AutoSize = true;
            this.labelDoctorShifts.Location = new System.Drawing.Point(1107, 357);
            this.labelDoctorShifts.Name = "labelDoctorShifts";
            this.labelDoctorShifts.Size = new System.Drawing.Size(68, 13);
            this.labelDoctorShifts.TabIndex = 57;
            this.labelDoctorShifts.Text = "Doctor Shifts";
            // 
            // DoctorShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 801);
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
            this.Controls.Add(this.textBoxRegistration);
            this.Controls.Add(this.labelDoctorID);
            this.Controls.Add(this.dataGridViewDoctorShifts);
            this.Name = "DoctorShifts";
            this.Text = "DoctorShifts";
            this.Load += new System.EventHandler(this.DoctorShifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorShifts)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxRegistration;
        private System.Windows.Forms.Label labelDoctorID;
        private System.Windows.Forms.ComboBox comboBoxShifts;
        private System.Windows.Forms.Label labelDoctorShifts;
    }
}