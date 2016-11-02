namespace hospitalManagementSystem
{
    partial class BookAppointment
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
            this.dataGridViewPatient = new System.Windows.Forms.DataGridView();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.labelSearchId = new System.Windows.Forms.Label();
            this.textBoxSearchId = new System.Windows.Forms.TextBox();
            this.labelSearchPhone = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchPhone = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHeightFt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHeightInch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxAppTime = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.dataGridViewDoctor = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxDoctor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPatient
            // 
            this.dataGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatient.Location = new System.Drawing.Point(12, 58);
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            this.dataGridViewPatient.Size = new System.Drawing.Size(1544, 150);
            this.dataGridViewPatient.TabIndex = 0;
            this.dataGridViewPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatient_CellContentClick);
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(261, 6);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchName.TabIndex = 1;
            // 
            // labelSearchName
            // 
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Location = new System.Drawing.Point(180, 9);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(75, 13);
            this.labelSearchName.TabIndex = 3;
            this.labelSearchName.Text = "Search Name:";
            // 
            // labelSearchId
            // 
            this.labelSearchId.AutoSize = true;
            this.labelSearchId.Location = new System.Drawing.Point(12, 9);
            this.labelSearchId.Name = "labelSearchId";
            this.labelSearchId.Size = new System.Drawing.Size(56, 13);
            this.labelSearchId.TabIndex = 6;
            this.labelSearchId.Text = "Search Id:";
            // 
            // textBoxSearchId
            // 
            this.textBoxSearchId.Location = new System.Drawing.Point(74, 6);
            this.textBoxSearchId.Name = "textBoxSearchId";
            this.textBoxSearchId.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchId.TabIndex = 4;
            // 
            // labelSearchPhone
            // 
            this.labelSearchPhone.AutoSize = true;
            this.labelSearchPhone.Location = new System.Drawing.Point(367, 9);
            this.labelSearchPhone.Name = "labelSearchPhone";
            this.labelSearchPhone.Size = new System.Drawing.Size(78, 13);
            this.labelSearchPhone.TabIndex = 9;
            this.labelSearchPhone.Text = "Search Phone:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.Navy;
            this.buttonSearch.Location = new System.Drawing.Point(554, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(150, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchPhone
            // 
            this.textBoxSearchPhone.Location = new System.Drawing.Point(448, 6);
            this.textBoxSearchPhone.Name = "textBoxSearchPhone";
            this.textBoxSearchPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchPhone.TabIndex = 7;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonRefresh.ForeColor = System.Drawing.Color.Navy;
            this.buttonRefresh.Location = new System.Drawing.Point(710, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(150, 23);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Patient Information";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(113, 234);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(177, 20);
            this.textBoxFirstName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(402, 234);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(177, 20);
            this.textBoxLastName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Department:";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(113, 260);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(177, 21);
            this.comboBoxDepartment.TabIndex = 17;
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Age:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(402, 260);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(177, 20);
            this.textBoxAge.TabIndex = 18;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.comboBoxSex.Location = new System.Drawing.Point(402, 286);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(177, 21);
            this.comboBoxSex.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Sex:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(859, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Height (In Feet):";
            // 
            // textBoxHeightFt
            // 
            this.textBoxHeightFt.Location = new System.Drawing.Point(948, 317);
            this.textBoxHeightFt.Name = "textBoxHeightFt";
            this.textBoxHeightFt.Size = new System.Drawing.Size(177, 20);
            this.textBoxHeightFt.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(847, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Height (In Inches):";
            // 
            // textBoxHeightInch
            // 
            this.textBoxHeightInch.Location = new System.Drawing.Point(948, 237);
            this.textBoxHeightInch.Name = "textBoxHeightInch";
            this.textBoxHeightInch.Size = new System.Drawing.Size(177, 20);
            this.textBoxHeightInch.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(859, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Weight:";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(948, 343);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(177, 20);
            this.textBoxWeight.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(113, 313);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(177, 20);
            this.textBoxPhone.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(859, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(948, 369);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(177, 20);
            this.textBoxEmail.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(847, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Address:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(948, 263);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(177, 20);
            this.textBoxAddress.TabIndex = 34;
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Location = new System.Drawing.Point(948, 394);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(177, 21);
            this.comboBoxNationality.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(859, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Nationality:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(847, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "From:";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(948, 289);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(177, 20);
            this.textBoxFrom.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(859, 424);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "To:";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(948, 421);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(177, 20);
            this.textBoxTo.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(301, 317);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Appointment Time:";
            // 
            // textBoxAppTime
            // 
            this.textBoxAppTime.Location = new System.Drawing.Point(402, 313);
            this.textBoxAppTime.Multiline = true;
            this.textBoxAppTime.Name = "textBoxAppTime";
            this.textBoxAppTime.Size = new System.Drawing.Size(177, 78);
            this.textBoxAppTime.TabIndex = 42;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSubmit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.Navy;
            this.buttonSubmit.Location = new System.Drawing.Point(12, 339);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(384, 52);
            this.buttonSubmit.TabIndex = 46;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // dataGridViewDoctor
            // 
            this.dataGridViewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctor.Location = new System.Drawing.Point(591, 234);
            this.dataGridViewDoctor.Name = "dataGridViewDoctor";
            this.dataGridViewDoctor.Size = new System.Drawing.Size(250, 262);
            this.dataGridViewDoctor.TabIndex = 47;
            this.dataGridViewDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctor_CellContentClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(588, 211);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 17);
            this.label18.TabIndex = 48;
            this.label18.Text = "Doctor";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(9, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 17);
            this.label19.TabIndex = 49;
            this.label19.Text = "Patient";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 292);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "Doctor:";
            // 
            // textBoxDoctor
            // 
            this.textBoxDoctor.Location = new System.Drawing.Point(113, 287);
            this.textBoxDoctor.Name = "textBoxDoctor";
            this.textBoxDoctor.Size = new System.Drawing.Size(177, 20);
            this.textBoxDoctor.TabIndex = 50;
            // 
            // BookAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 799);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxDoctor);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dataGridViewDoctor);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxAppTime);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.comboBoxNationality);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxHeightInch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxHeightFt);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelSearchPhone);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchPhone);
            this.Controls.Add(this.labelSearchId);
            this.Controls.Add(this.textBoxSearchId);
            this.Controls.Add(this.labelSearchName);
            this.Controls.Add(this.textBoxSearchName);
            this.Controls.Add(this.dataGridViewPatient);
            this.Name = "BookAppointment";
            this.Text = "BookAppointment";
            this.Load += new System.EventHandler(this.BookAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPatient;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.Label labelSearchId;
        private System.Windows.Forms.TextBox textBoxSearchId;
        private System.Windows.Forms.Label labelSearchPhone;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchPhone;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHeightFt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxHeightInch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.ComboBox comboBoxNationality;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxAppTime;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.DataGridView dataGridViewDoctor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxDoctor;
    }
}