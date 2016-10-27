namespace hospitalManagementSystem
{
    partial class AssignDoctorShifts
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
            this.dataGridViewAssignDoctorShift = new System.Windows.Forms.DataGridView();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelHeightFeet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelHeightInch = new System.Windows.Forms.Label();
            this.labelHeightInFt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.dataGridViewDoctor = new System.Windows.Forms.DataGridView();
            this.comboBoxDoctorShift = new System.Windows.Forms.ComboBox();
            this.labelDoctorShift = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignDoctorShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAssignDoctorShift
            // 
            this.dataGridViewAssignDoctorShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignDoctorShift.Location = new System.Drawing.Point(12, 327);
            this.dataGridViewAssignDoctorShift.Name = "dataGridViewAssignDoctorShift";
            this.dataGridViewAssignDoctorShift.Size = new System.Drawing.Size(1170, 150);
            this.dataGridViewAssignDoctorShift.TabIndex = 0;
            this.dataGridViewAssignDoctorShift.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAssignDoctorShift_CellContentClick);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(1199, 544);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(209, 23);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelHeightFeet
            // 
            this.labelHeightFeet.AutoSize = true;
            this.labelHeightFeet.Location = new System.Drawing.Point(1188, 143);
            this.labelHeightFeet.Name = "labelHeightFeet";
            this.labelHeightFeet.Size = new System.Drawing.Size(0, 13);
            this.labelHeightFeet.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1196, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Department:";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(1308, 90);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDepartment.TabIndex = 77;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.comboBoxSex.Location = new System.Drawing.Point(1308, 143);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSex.TabIndex = 76;
            this.comboBoxSex.Text = "Select";
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Location = new System.Drawing.Point(1308, 273);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNationality.TabIndex = 75;
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Location = new System.Drawing.Point(1196, 276);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(59, 13);
            this.labelNationality.TabIndex = 74;
            this.labelNationality.Text = "Nationality:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(1196, 302);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 73;
            this.labelAddress.Text = "Address:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(1196, 250);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 72;
            this.labelEmail.Text = "Email:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(1196, 224);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(44, 13);
            this.labelWeight.TabIndex = 71;
            this.labelWeight.Text = "Weight:";
            // 
            // labelHeightInch
            // 
            this.labelHeightInch.AutoSize = true;
            this.labelHeightInch.Location = new System.Drawing.Point(1196, 198);
            this.labelHeightInch.Name = "labelHeightInch";
            this.labelHeightInch.Size = new System.Drawing.Size(94, 13);
            this.labelHeightInch.TabIndex = 70;
            this.labelHeightInch.Text = "Height (In Inches):";
            // 
            // labelHeightInFt
            // 
            this.labelHeightInFt.AutoSize = true;
            this.labelHeightInFt.Location = new System.Drawing.Point(1196, 172);
            this.labelHeightInFt.Name = "labelHeightInFt";
            this.labelHeightInFt.Size = new System.Drawing.Size(83, 13);
            this.labelHeightInFt.TabIndex = 69;
            this.labelHeightInFt.Text = "Height (In Feet):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1196, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Sex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1196, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Age:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1196, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(1196, 41);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 65;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(1308, 299);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 64;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(1308, 247);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 63;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(1308, 221);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 62;
            // 
            // textBoxHeightInch
            // 
            this.textBoxHeightInch.Location = new System.Drawing.Point(1308, 195);
            this.textBoxHeightInch.Name = "textBoxHeightInch";
            this.textBoxHeightInch.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeightInch.TabIndex = 61;
            // 
            // textBoxHeightFt
            // 
            this.textBoxHeightFt.Location = new System.Drawing.Point(1308, 169);
            this.textBoxHeightFt.Name = "textBoxHeightFt";
            this.textBoxHeightFt.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeightFt.TabIndex = 60;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(1308, 117);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 59;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(1308, 64);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 58;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(1308, 38);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 57;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(1308, 12);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 56;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(1196, 15);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 13);
            this.labelPhone.TabIndex = 55;
            this.labelPhone.Text = "Phone:";
            // 
            // dataGridViewDoctor
            // 
            this.dataGridViewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctor.Location = new System.Drawing.Point(12, 15);
            this.dataGridViewDoctor.Name = "dataGridViewDoctor";
            this.dataGridViewDoctor.Size = new System.Drawing.Size(1170, 300);
            this.dataGridViewDoctor.TabIndex = 79;
            this.dataGridViewDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctor_CellContentClick);
            // 
            // comboBoxDoctorShift
            // 
            this.comboBoxDoctorShift.FormattingEnabled = true;
            this.comboBoxDoctorShift.Location = new System.Drawing.Point(1308, 327);
            this.comboBoxDoctorShift.Name = "comboBoxDoctorShift";
            this.comboBoxDoctorShift.Size = new System.Drawing.Size(253, 21);
            this.comboBoxDoctorShift.TabIndex = 80;
            // 
            // labelDoctorShift
            // 
            this.labelDoctorShift.AutoSize = true;
            this.labelDoctorShift.Location = new System.Drawing.Point(1196, 330);
            this.labelDoctorShift.Name = "labelDoctorShift";
            this.labelDoctorShift.Size = new System.Drawing.Size(66, 13);
            this.labelDoctorShift.TabIndex = 81;
            this.labelDoctorShift.Text = "Doctor Shift:";
            // 
            // AssignDoctorShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 601);
            this.Controls.Add(this.labelDoctorShift);
            this.Controls.Add(this.comboBoxDoctorShift);
            this.Controls.Add(this.dataGridViewDoctor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.comboBoxNationality);
            this.Controls.Add(this.labelNationality);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelHeightInch);
            this.Controls.Add(this.labelHeightInFt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.labelHeightFeet);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.dataGridViewAssignDoctorShift);
            this.Name = "AssignDoctorShifts";
            this.Text = "AssignDoctorShifts";
            this.Load += new System.EventHandler(this.AssignDoctorShifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignDoctorShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAssignDoctorShift;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelHeightFeet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.ComboBox comboBoxNationality;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHeightInch;
        private System.Windows.Forms.Label labelHeightInFt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.DataGridView dataGridViewDoctor;
        private System.Windows.Forms.ComboBox comboBoxDoctorShift;
        private System.Windows.Forms.Label labelDoctorShift;
    }
}