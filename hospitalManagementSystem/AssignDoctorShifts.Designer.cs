﻿namespace hospitalManagementSystem
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
            this.dataGridViewDoctorShift = new System.Windows.Forms.DataGridView();
            this.buttonAssign = new System.Windows.Forms.Button();
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
            this.buttonShiftRefresh = new System.Windows.Forms.Button();
            this.buttonShiftSearch = new System.Windows.Forms.Button();
            this.textBoxShiftSearch = new System.Windows.Forms.TextBox();
            this.labelShift = new System.Windows.Forms.Label();
            this.labelSearchPhone = new System.Windows.Forms.Label();
            this.textBoxSearchPhone = new System.Windows.Forms.TextBox();
            this.labelSearchId = new System.Windows.Forms.Label();
            this.textBoxSearchId = new System.Windows.Forms.TextBox();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoctorShift
            // 
            this.dataGridViewDoctorShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctorShift.Location = new System.Drawing.Point(277, 274);
            this.dataGridViewDoctorShift.Name = "dataGridViewDoctorShift";
            this.dataGridViewDoctorShift.Size = new System.Drawing.Size(344, 203);
            this.dataGridViewDoctorShift.TabIndex = 0;
            this.dataGridViewDoctorShift.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctorShift_CellClick);
            this.dataGridViewDoctorShift.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAssignDoctorShift_CellContentClick);
            // 
            // buttonAssign
            // 
            this.buttonAssign.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAssign.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAssign.ForeColor = System.Drawing.Color.Navy;
            this.buttonAssign.Location = new System.Drawing.Point(12, 587);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(275, 52);
            this.buttonAssign.TabIndex = 3;
            this.buttonAssign.Text = "Assign";
            this.buttonAssign.UseVisualStyleBackColor = false;
            this.buttonAssign.Click += new System.EventHandler(this.buttonSubmit_Click);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Department:";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(128, 323);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDepartment.TabIndex = 77;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.comboBoxSex.Location = new System.Drawing.Point(128, 376);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSex.TabIndex = 76;
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Location = new System.Drawing.Point(128, 506);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNationality.TabIndex = 75;
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNationality.Location = new System.Drawing.Point(9, 509);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(71, 13);
            this.labelNationality.TabIndex = 74;
            this.labelNationality.Text = "Nationality:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(9, 535);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(56, 13);
            this.labelAddress.TabIndex = 73;
            this.labelAddress.Text = "Address:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(9, 483);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 13);
            this.labelEmail.TabIndex = 72;
            this.labelEmail.Text = "Email:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.Location = new System.Drawing.Point(9, 457);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(51, 13);
            this.labelWeight.TabIndex = 71;
            this.labelWeight.Text = "Weight:";
            // 
            // labelHeightInch
            // 
            this.labelHeightInch.AutoSize = true;
            this.labelHeightInch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeightInch.Location = new System.Drawing.Point(9, 431);
            this.labelHeightInch.Name = "labelHeightInch";
            this.labelHeightInch.Size = new System.Drawing.Size(113, 13);
            this.labelHeightInch.TabIndex = 70;
            this.labelHeightInch.Text = "Height (In Inches):";
            // 
            // labelHeightInFt
            // 
            this.labelHeightInFt.AutoSize = true;
            this.labelHeightInFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeightInFt.Location = new System.Drawing.Point(9, 405);
            this.labelHeightInFt.Name = "labelHeightInFt";
            this.labelHeightInFt.Size = new System.Drawing.Size(100, 13);
            this.labelHeightInFt.TabIndex = 69;
            this.labelHeightInFt.Text = "Height (In Feet):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Sex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Age:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(9, 274);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(71, 13);
            this.labelFirstName.TabIndex = 65;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(128, 532);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(121, 21);
            this.textBoxAddress.TabIndex = 64;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(128, 480);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(121, 20);
            this.textBoxEmail.TabIndex = 63;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(128, 454);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(121, 20);
            this.textBoxWeight.TabIndex = 62;
            // 
            // textBoxHeightInch
            // 
            this.textBoxHeightInch.Location = new System.Drawing.Point(128, 428);
            this.textBoxHeightInch.Name = "textBoxHeightInch";
            this.textBoxHeightInch.Size = new System.Drawing.Size(121, 20);
            this.textBoxHeightInch.TabIndex = 61;
            // 
            // textBoxHeightFt
            // 
            this.textBoxHeightFt.Location = new System.Drawing.Point(128, 402);
            this.textBoxHeightFt.Name = "textBoxHeightFt";
            this.textBoxHeightFt.Size = new System.Drawing.Size(121, 20);
            this.textBoxHeightFt.TabIndex = 60;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(128, 350);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(121, 20);
            this.textBoxAge.TabIndex = 59;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(128, 297);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(121, 20);
            this.textBoxLastName.TabIndex = 58;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(128, 271);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(121, 20);
            this.textBoxFirstName.TabIndex = 57;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(128, 245);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(121, 20);
            this.textBoxPhone.TabIndex = 56;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(9, 248);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(47, 13);
            this.labelPhone.TabIndex = 55;
            this.labelPhone.Text = "Phone:";
            // 
            // dataGridViewDoctor
            // 
            this.dataGridViewDoctor.AllowUserToAddRows = false;
            this.dataGridViewDoctor.AllowUserToDeleteRows = false;
            this.dataGridViewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctor.Location = new System.Drawing.Point(12, 33);
            this.dataGridViewDoctor.Name = "dataGridViewDoctor";
            this.dataGridViewDoctor.ReadOnly = true;
            this.dataGridViewDoctor.Size = new System.Drawing.Size(1364, 150);
            this.dataGridViewDoctor.TabIndex = 79;
            this.dataGridViewDoctor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctor_CellClick);
            this.dataGridViewDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctor_CellContentClick);
            this.dataGridViewDoctor.SelectionChanged += new System.EventHandler(this.dataGridViewDoctor_SelectionChanged);
            this.dataGridViewDoctor.Click += new System.EventHandler(this.dataGridViewDoctor_Click);
            // 
            // comboBoxDoctorShift
            // 
            this.comboBoxDoctorShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoctorShift.FormattingEnabled = true;
            this.comboBoxDoctorShift.Location = new System.Drawing.Point(128, 560);
            this.comboBoxDoctorShift.Name = "comboBoxDoctorShift";
            this.comboBoxDoctorShift.Size = new System.Drawing.Size(253, 21);
            this.comboBoxDoctorShift.TabIndex = 80;
            // 
            // labelDoctorShift
            // 
            this.labelDoctorShift.AutoSize = true;
            this.labelDoctorShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctorShift.Location = new System.Drawing.Point(9, 563);
            this.labelDoctorShift.Name = "labelDoctorShift";
            this.labelDoctorShift.Size = new System.Drawing.Size(79, 13);
            this.labelDoctorShift.TabIndex = 81;
            this.labelDoctorShift.Text = "Doctor Shift:";
            // 
            // buttonShiftRefresh
            // 
            this.buttonShiftRefresh.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonShiftRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonShiftRefresh.ForeColor = System.Drawing.Color.Navy;
            this.buttonShiftRefresh.Location = new System.Drawing.Point(633, 242);
            this.buttonShiftRefresh.Name = "buttonShiftRefresh";
            this.buttonShiftRefresh.Size = new System.Drawing.Size(150, 23);
            this.buttonShiftRefresh.TabIndex = 88;
            this.buttonShiftRefresh.Text = "Refresh";
            this.buttonShiftRefresh.UseVisualStyleBackColor = false;
            this.buttonShiftRefresh.Click += new System.EventHandler(this.buttonShiftRefresh_Click);
            // 
            // buttonShiftSearch
            // 
            this.buttonShiftSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonShiftSearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonShiftSearch.ForeColor = System.Drawing.Color.Navy;
            this.buttonShiftSearch.Location = new System.Drawing.Point(477, 243);
            this.buttonShiftSearch.Name = "buttonShiftSearch";
            this.buttonShiftSearch.Size = new System.Drawing.Size(150, 23);
            this.buttonShiftSearch.TabIndex = 87;
            this.buttonShiftSearch.Text = "Search";
            this.buttonShiftSearch.UseVisualStyleBackColor = false;
            this.buttonShiftSearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxShiftSearch
            // 
            this.textBoxShiftSearch.Location = new System.Drawing.Point(353, 245);
            this.textBoxShiftSearch.Name = "textBoxShiftSearch";
            this.textBoxShiftSearch.Size = new System.Drawing.Size(118, 20);
            this.textBoxShiftSearch.TabIndex = 86;
            // 
            // labelShift
            // 
            this.labelShift.AutoSize = true;
            this.labelShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShift.Location = new System.Drawing.Point(274, 247);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(73, 13);
            this.labelShift.TabIndex = 89;
            this.labelShift.Text = "Shift Name:";
            // 
            // labelSearchPhone
            // 
            this.labelSearchPhone.AutoSize = true;
            this.labelSearchPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchPhone.Location = new System.Drawing.Point(389, 9);
            this.labelSearchPhone.Name = "labelSearchPhone";
            this.labelSearchPhone.Size = new System.Drawing.Size(91, 13);
            this.labelSearchPhone.TabIndex = 142;
            this.labelSearchPhone.Text = "Search Phone:";
            // 
            // textBoxSearchPhone
            // 
            this.textBoxSearchPhone.Location = new System.Drawing.Point(486, 6);
            this.textBoxSearchPhone.Name = "textBoxSearchPhone";
            this.textBoxSearchPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchPhone.TabIndex = 141;
            // 
            // labelSearchId
            // 
            this.labelSearchId.AutoSize = true;
            this.labelSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchId.Location = new System.Drawing.Point(211, 9);
            this.labelSearchId.Name = "labelSearchId";
            this.labelSearchId.Size = new System.Drawing.Size(68, 13);
            this.labelSearchId.TabIndex = 140;
            this.labelSearchId.Text = "Search ID:";
            // 
            // textBoxSearchId
            // 
            this.textBoxSearchId.Location = new System.Drawing.Point(283, 6);
            this.textBoxSearchId.Name = "textBoxSearchId";
            this.textBoxSearchId.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchId.TabIndex = 139;
            // 
            // labelSearchName
            // 
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchName.Location = new System.Drawing.Point(12, 9);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(87, 13);
            this.labelSearchName.TabIndex = 138;
            this.labelSearchName.Text = "Search Name:";
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(105, 6);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchName.TabIndex = 137;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonRefresh.ForeColor = System.Drawing.Color.Navy;
            this.buttonRefresh.Location = new System.Drawing.Point(748, 6);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(150, 23);
            this.buttonRefresh.TabIndex = 136;
            this.buttonRefresh.Text = "Reset";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click_1);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.Navy;
            this.buttonSearch.Location = new System.Drawing.Point(592, 6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(150, 23);
            this.buttonSearch.TabIndex = 135;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // AssignDoctorShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1602, 831);
            this.Controls.Add(this.labelSearchPhone);
            this.Controls.Add(this.textBoxSearchPhone);
            this.Controls.Add(this.labelSearchId);
            this.Controls.Add(this.textBoxSearchId);
            this.Controls.Add(this.labelSearchName);
            this.Controls.Add(this.textBoxSearchName);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelShift);
            this.Controls.Add(this.buttonShiftRefresh);
            this.Controls.Add(this.buttonShiftSearch);
            this.Controls.Add(this.textBoxShiftSearch);
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
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.dataGridViewDoctorShift);
            this.Name = "AssignDoctorShifts";
            this.Text = "AssignDoctorShifts";
            this.Load += new System.EventHandler(this.AssignDoctorShifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoctorShift;
        private System.Windows.Forms.Button buttonAssign;
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
        private System.Windows.Forms.Button buttonShiftRefresh;
        private System.Windows.Forms.Button buttonShiftSearch;
        private System.Windows.Forms.TextBox textBoxShiftSearch;
        private System.Windows.Forms.Label labelShift;
        private System.Windows.Forms.Label labelSearchPhone;
        private System.Windows.Forms.TextBox textBoxSearchPhone;
        private System.Windows.Forms.Label labelSearchId;
        private System.Windows.Forms.TextBox textBoxSearchId;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSearch;
    }
}