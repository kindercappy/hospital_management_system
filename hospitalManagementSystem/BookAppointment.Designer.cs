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
            this.labelBookAppointment = new System.Windows.Forms.Label();
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
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxAppTime = new System.Windows.Forms.TextBox();
            this.buttonBookAppointment = new System.Windows.Forms.Button();
            this.dataGridViewDoctor = new System.Windows.Forms.DataGridView();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.labelPatient = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxDoctor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNewFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNewLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNewAge = new System.Windows.Forms.TextBox();
            this.comboBoxNewSex = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxNewNationality = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonNewPatient = new System.Windows.Forms.Button();
            this.dateTimePickerAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPatient
            // 
            this.dataGridViewPatient.AllowUserToAddRows = false;
            this.dataGridViewPatient.AllowUserToDeleteRows = false;
            this.dataGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatient.Location = new System.Drawing.Point(19, 119);
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            this.dataGridViewPatient.ReadOnly = true;
            this.dataGridViewPatient.Size = new System.Drawing.Size(1150, 150);
            this.dataGridViewPatient.TabIndex = 0;
            this.dataGridViewPatient.SelectionChanged += new System.EventHandler(this.dataGridViewPatient_SelectionChanged);
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(174, 62);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchName.TabIndex = 1;
            this.textBoxSearchName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchName_KeyPress);
            // 
            // labelSearchName
            // 
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelSearchName.Location = new System.Drawing.Point(8, 62);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(160, 25);
            this.labelSearchName.TabIndex = 3;
            this.labelSearchName.Text = "Search Name:";
            // 
            // labelSearchId
            // 
            this.labelSearchId.AutoSize = true;
            this.labelSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelSearchId.Location = new System.Drawing.Point(280, 62);
            this.labelSearchId.Name = "labelSearchId";
            this.labelSearchId.Size = new System.Drawing.Size(122, 25);
            this.labelSearchId.TabIndex = 6;
            this.labelSearchId.Text = "Search ID:";
            // 
            // textBoxSearchId
            // 
            this.textBoxSearchId.Location = new System.Drawing.Point(404, 62);
            this.textBoxSearchId.Name = "textBoxSearchId";
            this.textBoxSearchId.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchId.TabIndex = 4;
            this.textBoxSearchId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchId_KeyPress);
            // 
            // labelSearchPhone
            // 
            this.labelSearchPhone.AutoSize = true;
            this.labelSearchPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelSearchPhone.Location = new System.Drawing.Point(510, 62);
            this.labelSearchPhone.Name = "labelSearchPhone";
            this.labelSearchPhone.Size = new System.Drawing.Size(167, 25);
            this.labelSearchPhone.TabIndex = 9;
            this.labelSearchPhone.Text = "Search Phone:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.Navy;
            this.buttonSearch.Location = new System.Drawing.Point(789, 53);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(175, 36);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchPhone
            // 
            this.textBoxSearchPhone.Location = new System.Drawing.Point(683, 62);
            this.textBoxSearchPhone.Name = "textBoxSearchPhone";
            this.textBoxSearchPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchPhone.TabIndex = 7;
            this.textBoxSearchPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchPhone_KeyPress);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonRefresh.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRefresh.ForeColor = System.Drawing.Color.Navy;
            this.buttonRefresh.Location = new System.Drawing.Point(970, 53);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(175, 36);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelBookAppointment
            // 
            this.labelBookAppointment.AutoSize = true;
            this.labelBookAppointment.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookAppointment.Location = new System.Drawing.Point(390, 286);
            this.labelBookAppointment.Name = "labelBookAppointment";
            this.labelBookAppointment.Size = new System.Drawing.Size(246, 32);
            this.labelBookAppointment.TabIndex = 11;
            this.labelBookAppointment.Text = "Book Appointment";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(732, 317);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(177, 20);
            this.textBoxFirstName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(391, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(388, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(732, 422);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(177, 20);
            this.textBoxLastName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(391, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Department:";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(732, 343);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(177, 21);
            this.comboBoxDepartment.TabIndex = 17;
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(391, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Age:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(732, 448);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(177, 20);
            this.textBoxAge.TabIndex = 18;
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.comboBoxSex.Location = new System.Drawing.Point(732, 474);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(177, 21);
            this.comboBoxSex.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(388, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Sex:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(390, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(732, 396);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(177, 20);
            this.textBoxPhone.TabIndex = 28;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(388, 500);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(345, 25);
            this.label16.TabIndex = 43;
            this.label16.Text = "Appointment Time (HH:MM:SS):";
            // 
            // textBoxAppTime
            // 
            this.textBoxAppTime.Location = new System.Drawing.Point(732, 527);
            this.textBoxAppTime.Name = "textBoxAppTime";
            this.textBoxAppTime.Size = new System.Drawing.Size(177, 20);
            this.textBoxAppTime.TabIndex = 42;
            // 
            // buttonBookAppointment
            // 
            this.buttonBookAppointment.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBookAppointment.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBookAppointment.ForeColor = System.Drawing.Color.Navy;
            this.buttonBookAppointment.Location = new System.Drawing.Point(391, 564);
            this.buttonBookAppointment.Name = "buttonBookAppointment";
            this.buttonBookAppointment.Size = new System.Drawing.Size(518, 52);
            this.buttonBookAppointment.TabIndex = 46;
            this.buttonBookAppointment.Text = "Book Appointment";
            this.buttonBookAppointment.UseVisualStyleBackColor = false;
            this.buttonBookAppointment.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // dataGridViewDoctor
            // 
            this.dataGridViewDoctor.AllowUserToAddRows = false;
            this.dataGridViewDoctor.AllowUserToDeleteRows = false;
            this.dataGridViewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctor.Location = new System.Drawing.Point(950, 318);
            this.dataGridViewDoctor.Name = "dataGridViewDoctor";
            this.dataGridViewDoctor.ReadOnly = true;
            this.dataGridViewDoctor.Size = new System.Drawing.Size(344, 159);
            this.dataGridViewDoctor.TabIndex = 47;
            this.dataGridViewDoctor.SelectionChanged += new System.EventHandler(this.dataGridViewDoctor_SelectionChanged);
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctor.Location = new System.Drawing.Point(944, 283);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(99, 32);
            this.labelDoctor.TabIndex = 48;
            this.labelDoctor.Text = "Doctor";
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatient.Location = new System.Drawing.Point(11, 84);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(104, 32);
            this.labelPatient.TabIndex = 49;
            this.labelPatient.Text = "Patient";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(391, 373);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 25);
            this.label17.TabIndex = 51;
            this.label17.Text = "Doctor:";
            // 
            // textBoxDoctor
            // 
            this.textBoxDoctor.Location = new System.Drawing.Point(732, 370);
            this.textBoxDoctor.Name = "textBoxDoctor";
            this.textBoxDoctor.Size = new System.Drawing.Size(177, 20);
            this.textBoxDoctor.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(13, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 32);
            this.label7.TabIndex = 52;
            this.label7.Text = "New Patient";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(12, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 54;
            this.label8.Text = "First Name:";
            // 
            // textBoxNewFirstName
            // 
            this.textBoxNewFirstName.Location = new System.Drawing.Point(151, 317);
            this.textBoxNewFirstName.Name = "textBoxNewFirstName";
            this.textBoxNewFirstName.Size = new System.Drawing.Size(177, 20);
            this.textBoxNewFirstName.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(12, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 56;
            this.label9.Text = "Last Name:";
            // 
            // textBoxNewLastName
            // 
            this.textBoxNewLastName.Location = new System.Drawing.Point(151, 396);
            this.textBoxNewLastName.Name = "textBoxNewLastName";
            this.textBoxNewLastName.Size = new System.Drawing.Size(177, 20);
            this.textBoxNewLastName.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(12, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 58;
            this.label11.Text = "Age:";
            // 
            // textBoxNewAge
            // 
            this.textBoxNewAge.Location = new System.Drawing.Point(151, 343);
            this.textBoxNewAge.Name = "textBoxNewAge";
            this.textBoxNewAge.Size = new System.Drawing.Size(177, 20);
            this.textBoxNewAge.TabIndex = 57;
            this.textBoxNewAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewAge_KeyPress);
            // 
            // comboBoxNewSex
            // 
            this.comboBoxNewSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewSex.FormattingEnabled = true;
            this.comboBoxNewSex.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.comboBoxNewSex.Location = new System.Drawing.Point(151, 425);
            this.comboBoxNewSex.Name = "comboBoxNewSex";
            this.comboBoxNewSex.Size = new System.Drawing.Size(177, 21);
            this.comboBoxNewSex.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(14, 419);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 25);
            this.label12.TabIndex = 59;
            this.label12.Text = "Sex:";
            // 
            // comboBoxNewNationality
            // 
            this.comboBoxNewNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewNationality.FormattingEnabled = true;
            this.comboBoxNewNationality.Location = new System.Drawing.Point(151, 369);
            this.comboBoxNewNationality.Name = "comboBoxNewNationality";
            this.comboBoxNewNationality.Size = new System.Drawing.Size(177, 21);
            this.comboBoxNewNationality.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(12, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 25);
            this.label13.TabIndex = 61;
            this.label13.Text = "Natiionality:";
            // 
            // buttonNewPatient
            // 
            this.buttonNewPatient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonNewPatient.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonNewPatient.ForeColor = System.Drawing.Color.Navy;
            this.buttonNewPatient.Location = new System.Drawing.Point(19, 451);
            this.buttonNewPatient.Name = "buttonNewPatient";
            this.buttonNewPatient.Size = new System.Drawing.Size(309, 52);
            this.buttonNewPatient.TabIndex = 63;
            this.buttonNewPatient.Text = "New Patient";
            this.buttonNewPatient.UseVisualStyleBackColor = false;
            this.buttonNewPatient.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerAppointmentTime
            // 
            this.dateTimePickerAppointmentTime.Location = new System.Drawing.Point(732, 502);
            this.dateTimePickerAppointmentTime.Name = "dateTimePickerAppointmentTime";
            this.dateTimePickerAppointmentTime.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAppointmentTime.TabIndex = 64;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBack.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.Navy;
            this.buttonBack.Location = new System.Drawing.Point(11, 681);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(209, 43);
            this.buttonBack.TabIndex = 65;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeader.BackColor = System.Drawing.Color.CadetBlue;
            this.labelHeader.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(738, 39);
            this.labelHeader.TabIndex = 84;
            this.labelHeader.Text = "Book Appointment";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1954, 799);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dateTimePickerAppointmentTime);
            this.Controls.Add(this.buttonNewPatient);
            this.Controls.Add(this.comboBoxNewNationality);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxNewSex);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxNewAge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxNewLastName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxNewFirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxDoctor);
            this.Controls.Add(this.labelPatient);
            this.Controls.Add(this.labelDoctor);
            this.Controls.Add(this.dataGridViewDoctor);
            this.Controls.Add(this.buttonBookAppointment);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxAppTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxPhone);
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
            this.Controls.Add(this.labelBookAppointment);
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
            this.Text = " ";
            this.Deactivate += new System.EventHandler(this.BookAppointment_Deactivate);
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
        private System.Windows.Forms.Label labelBookAppointment;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxAppTime;
        private System.Windows.Forms.Button buttonBookAppointment;
        private System.Windows.Forms.DataGridView dataGridViewDoctor;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxDoctor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNewFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNewLastName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNewAge;
        private System.Windows.Forms.ComboBox comboBoxNewSex;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxNewNationality;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonNewPatient;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentTime;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelHeader;
    }
}