namespace hospitalManagementSystem
{
    partial class HospitalMain
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
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.btnExistingPatient = new System.Windows.Forms.Button();
            this.lblPatient = new System.Windows.Forms.Label();
            this.btnNewDoctor = new System.Windows.Forms.Button();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.btnExistingDoctor = new System.Windows.Forms.Button();
            this.lblStaff = new System.Windows.Forms.Label();
            this.btnNewStaff = new System.Windows.Forms.Button();
            this.btnExistingStaff = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existingDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeShiftsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignShiftsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existingPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existingStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNewShifts = new System.Windows.Forms.Button();
            this.panelHospitalMain = new System.Windows.Forms.Panel();
            this.buttonBookAppointment = new System.Windows.Forms.Button();
            this.buttonAssignShifts = new System.Windows.Forms.Button();
            this.buttonAssignShift = new System.Windows.Forms.Button();
            this.buttonNewShift = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelHospitalMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNewPatient.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNewPatient.ForeColor = System.Drawing.Color.Navy;
            this.btnNewPatient.Location = new System.Drawing.Point(3, 32);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(150, 23);
            this.btnNewPatient.TabIndex = 1;
            this.btnNewPatient.Text = "New Patient";
            this.btnNewPatient.UseVisualStyleBackColor = false;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // btnExistingPatient
            // 
            this.btnExistingPatient.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExistingPatient.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExistingPatient.ForeColor = System.Drawing.Color.Navy;
            this.btnExistingPatient.Location = new System.Drawing.Point(159, 32);
            this.btnExistingPatient.Name = "btnExistingPatient";
            this.btnExistingPatient.Size = new System.Drawing.Size(150, 23);
            this.btnExistingPatient.TabIndex = 2;
            this.btnExistingPatient.Text = "Existing Patient";
            this.btnExistingPatient.UseVisualStyleBackColor = false;
            this.btnExistingPatient.Click += new System.EventHandler(this.btnExistingPatient_Click);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.Location = new System.Drawing.Point(126, 12);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(59, 17);
            this.lblPatient.TabIndex = 4;
            this.lblPatient.Text = "Patient";
            // 
            // btnNewDoctor
            // 
            this.btnNewDoctor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNewDoctor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNewDoctor.ForeColor = System.Drawing.Color.Navy;
            this.btnNewDoctor.Location = new System.Drawing.Point(330, 32);
            this.btnNewDoctor.Name = "btnNewDoctor";
            this.btnNewDoctor.Size = new System.Drawing.Size(150, 23);
            this.btnNewDoctor.TabIndex = 4;
            this.btnNewDoctor.Text = "New Doctor";
            this.btnNewDoctor.UseVisualStyleBackColor = false;
            this.btnNewDoctor.Click += new System.EventHandler(this.btnNewDoctor_Click);
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.Location = new System.Drawing.Point(453, 12);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(56, 17);
            this.lblDoctor.TabIndex = 6;
            this.lblDoctor.Text = "Doctor";
            // 
            // btnExistingDoctor
            // 
            this.btnExistingDoctor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExistingDoctor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExistingDoctor.ForeColor = System.Drawing.Color.Navy;
            this.btnExistingDoctor.Location = new System.Drawing.Point(486, 32);
            this.btnExistingDoctor.Name = "btnExistingDoctor";
            this.btnExistingDoctor.Size = new System.Drawing.Size(150, 23);
            this.btnExistingDoctor.TabIndex = 5;
            this.btnExistingDoctor.Text = "Existing Doctor";
            this.btnExistingDoctor.UseVisualStyleBackColor = false;
            this.btnExistingDoctor.Click += new System.EventHandler(this.btnExistingDoctor_Click);
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(790, 12);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(42, 17);
            this.lblStaff.TabIndex = 10;
            this.lblStaff.Text = "Staff";
            // 
            // btnNewStaff
            // 
            this.btnNewStaff.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNewStaff.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNewStaff.ForeColor = System.Drawing.Color.Navy;
            this.btnNewStaff.Location = new System.Drawing.Point(657, 32);
            this.btnNewStaff.Name = "btnNewStaff";
            this.btnNewStaff.Size = new System.Drawing.Size(150, 23);
            this.btnNewStaff.TabIndex = 8;
            this.btnNewStaff.Text = "New Staff";
            this.btnNewStaff.UseVisualStyleBackColor = false;
            this.btnNewStaff.Click += new System.EventHandler(this.btnNewStaff_Click);
            // 
            // btnExistingStaff
            // 
            this.btnExistingStaff.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExistingStaff.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExistingStaff.ForeColor = System.Drawing.Color.Navy;
            this.btnExistingStaff.Location = new System.Drawing.Point(813, 32);
            this.btnExistingStaff.Name = "btnExistingStaff";
            this.btnExistingStaff.Size = new System.Drawing.Size(150, 23);
            this.btnExistingStaff.TabIndex = 9;
            this.btnExistingStaff.Text = "Existing Staff";
            this.btnExistingStaff.UseVisualStyleBackColor = false;
            this.btnExistingStaff.Click += new System.EventHandler(this.btnExistingStaff_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.staffToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDoctorToolStripMenuItem,
            this.existingDoctorToolStripMenuItem,
            this.makeShiftsToolStripMenuItem,
            this.assignShiftsToolStripMenuItem});
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.doctorToolStripMenuItem.Text = "Doctor";
            // 
            // newDoctorToolStripMenuItem
            // 
            this.newDoctorToolStripMenuItem.Name = "newDoctorToolStripMenuItem";
            this.newDoctorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newDoctorToolStripMenuItem.Text = "New Doctor";
            this.newDoctorToolStripMenuItem.Click += new System.EventHandler(this.newDoctorToolStripMenuItem_Click);
            // 
            // existingDoctorToolStripMenuItem
            // 
            this.existingDoctorToolStripMenuItem.Name = "existingDoctorToolStripMenuItem";
            this.existingDoctorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.existingDoctorToolStripMenuItem.Text = "Existing Doctor";
            this.existingDoctorToolStripMenuItem.Click += new System.EventHandler(this.existingDoctorToolStripMenuItem_Click);
            // 
            // makeShiftsToolStripMenuItem
            // 
            this.makeShiftsToolStripMenuItem.Name = "makeShiftsToolStripMenuItem";
            this.makeShiftsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.makeShiftsToolStripMenuItem.Text = "Make Shifts";
            this.makeShiftsToolStripMenuItem.Click += new System.EventHandler(this.makeShiftsToolStripMenuItem_Click);
            // 
            // assignShiftsToolStripMenuItem
            // 
            this.assignShiftsToolStripMenuItem.Name = "assignShiftsToolStripMenuItem";
            this.assignShiftsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.assignShiftsToolStripMenuItem.Text = "Assign shifts";
            this.assignShiftsToolStripMenuItem.Click += new System.EventHandler(this.assignShiftsToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPatientToolStripMenuItem,
            this.existingPatientToolStripMenuItem,
            this.bookAppointmentToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // newPatientToolStripMenuItem
            // 
            this.newPatientToolStripMenuItem.Name = "newPatientToolStripMenuItem";
            this.newPatientToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newPatientToolStripMenuItem.Text = "New Patient";
            this.newPatientToolStripMenuItem.Click += new System.EventHandler(this.newPatientToolStripMenuItem_Click);
            // 
            // existingPatientToolStripMenuItem
            // 
            this.existingPatientToolStripMenuItem.Name = "existingPatientToolStripMenuItem";
            this.existingPatientToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.existingPatientToolStripMenuItem.Text = "Existing Patient";
            this.existingPatientToolStripMenuItem.Click += new System.EventHandler(this.existingPatientToolStripMenuItem_Click);
            // 
            // bookAppointmentToolStripMenuItem
            // 
            this.bookAppointmentToolStripMenuItem.Name = "bookAppointmentToolStripMenuItem";
            this.bookAppointmentToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.bookAppointmentToolStripMenuItem.Text = "Book Appointment";
            this.bookAppointmentToolStripMenuItem.Click += new System.EventHandler(this.bookAppointmentToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStaffToolStripMenuItem,
            this.existingStaffToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // newStaffToolStripMenuItem
            // 
            this.newStaffToolStripMenuItem.Name = "newStaffToolStripMenuItem";
            this.newStaffToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newStaffToolStripMenuItem.Text = "New Staff";
            this.newStaffToolStripMenuItem.Click += new System.EventHandler(this.newStaffToolStripMenuItem_Click);
            // 
            // existingStaffToolStripMenuItem
            // 
            this.existingStaffToolStripMenuItem.Name = "existingStaffToolStripMenuItem";
            this.existingStaffToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.existingStaffToolStripMenuItem.Text = "Existing Staff";
            this.existingStaffToolStripMenuItem.Click += new System.EventHandler(this.existingStaffToolStripMenuItem_Click);
            // 
            // buttonNewShifts
            // 
            this.buttonNewShifts.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNewShifts.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonNewShifts.ForeColor = System.Drawing.Color.Navy;
            this.buttonNewShifts.Location = new System.Drawing.Point(330, 61);
            this.buttonNewShifts.Name = "buttonNewShifts";
            this.buttonNewShifts.Size = new System.Drawing.Size(150, 23);
            this.buttonNewShifts.TabIndex = 6;
            this.buttonNewShifts.Text = "New Shifts";
            this.buttonNewShifts.UseVisualStyleBackColor = false;
            this.buttonNewShifts.Click += new System.EventHandler(this.buttonDoctorShifts_Click);
            // 
            // panelHospitalMain
            // 
            this.panelHospitalMain.BackColor = System.Drawing.Color.DarkGray;
            this.panelHospitalMain.Controls.Add(this.buttonBookAppointment);
            this.panelHospitalMain.Controls.Add(this.buttonAssignShifts);
            this.panelHospitalMain.Controls.Add(this.buttonAssignShift);
            this.panelHospitalMain.Controls.Add(this.buttonNewShift);
            this.panelHospitalMain.Controls.Add(this.btnNewPatient);
            this.panelHospitalMain.Controls.Add(this.lblStaff);
            this.panelHospitalMain.Controls.Add(this.btnExistingDoctor);
            this.panelHospitalMain.Controls.Add(this.btnExistingPatient);
            this.panelHospitalMain.Controls.Add(this.btnNewStaff);
            this.panelHospitalMain.Controls.Add(this.lblPatient);
            this.panelHospitalMain.Controls.Add(this.lblDoctor);
            this.panelHospitalMain.Controls.Add(this.buttonNewShifts);
            this.panelHospitalMain.Controls.Add(this.btnExistingStaff);
            this.panelHospitalMain.Controls.Add(this.btnNewDoctor);
            this.panelHospitalMain.Location = new System.Drawing.Point(12, 27);
            this.panelHospitalMain.Name = "panelHospitalMain";
            this.panelHospitalMain.Size = new System.Drawing.Size(1089, 463);
            this.panelHospitalMain.TabIndex = 22;
            // 
            // buttonBookAppointment
            // 
            this.buttonBookAppointment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBookAppointment.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonBookAppointment.ForeColor = System.Drawing.Color.Navy;
            this.buttonBookAppointment.Location = new System.Drawing.Point(3, 61);
            this.buttonBookAppointment.Name = "buttonBookAppointment";
            this.buttonBookAppointment.Size = new System.Drawing.Size(150, 23);
            this.buttonBookAppointment.TabIndex = 3;
            this.buttonBookAppointment.Text = "Book Appointment";
            this.buttonBookAppointment.UseVisualStyleBackColor = false;
            this.buttonBookAppointment.Click += new System.EventHandler(this.buttonBookAppointment_Click);
            // 
            // buttonAssignShifts
            // 
            this.buttonAssignShifts.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAssignShifts.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonAssignShifts.ForeColor = System.Drawing.Color.Navy;
            this.buttonAssignShifts.Location = new System.Drawing.Point(486, 61);
            this.buttonAssignShifts.Name = "buttonAssignShifts";
            this.buttonAssignShifts.Size = new System.Drawing.Size(150, 23);
            this.buttonAssignShifts.TabIndex = 7;
            this.buttonAssignShifts.Text = "Assign Shifts";
            this.buttonAssignShifts.UseVisualStyleBackColor = false;
            this.buttonAssignShifts.Click += new System.EventHandler(this.buttonAssignDoctorShifts_Click);
            // 
            // buttonAssignShift
            // 
            this.buttonAssignShift.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAssignShift.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonAssignShift.ForeColor = System.Drawing.Color.Navy;
            this.buttonAssignShift.Location = new System.Drawing.Point(813, 61);
            this.buttonAssignShift.Name = "buttonAssignShift";
            this.buttonAssignShift.Size = new System.Drawing.Size(150, 23);
            this.buttonAssignShift.TabIndex = 11;
            this.buttonAssignShift.Text = "Assign Shift";
            this.buttonAssignShift.UseVisualStyleBackColor = false;
            this.buttonAssignShift.Click += new System.EventHandler(this.buttonAssignShift_Click);
            // 
            // buttonNewShift
            // 
            this.buttonNewShift.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNewShift.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonNewShift.ForeColor = System.Drawing.Color.Navy;
            this.buttonNewShift.Location = new System.Drawing.Point(657, 61);
            this.buttonNewShift.Name = "buttonNewShift";
            this.buttonNewShift.Size = new System.Drawing.Size(150, 23);
            this.buttonNewShift.TabIndex = 10;
            this.buttonNewShift.Text = "New Shift";
            this.buttonNewShift.UseVisualStyleBackColor = false;
            this.buttonNewShift.Click += new System.EventHandler(this.buttonNewShift_Click);
            // 
            // HospitalMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 522);
            this.Controls.Add(this.panelHospitalMain);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "HospitalMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.HospitalMain_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HospitalMain_FormClosed);
            this.Load += new System.EventHandler(this.HospitalMain_Load);
            this.Shown += new System.EventHandler(this.HospitalMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelHospitalMain.ResumeLayout(false);
            this.panelHospitalMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.Button btnExistingPatient;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Button btnNewDoctor;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Button btnExistingDoctor;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Button btnNewStaff;
        private System.Windows.Forms.Button btnExistingStaff;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existingDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existingPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existingStaffToolStripMenuItem;
        private System.Windows.Forms.Button buttonNewShifts;
        private System.Windows.Forms.Panel panelHospitalMain;
        private System.Windows.Forms.Button buttonNewShift;
        private System.Windows.Forms.Button buttonAssignShift;
        private System.Windows.Forms.Button buttonAssignShifts;
        private System.Windows.Forms.ToolStripMenuItem makeShiftsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignShiftsToolStripMenuItem;
        private System.Windows.Forms.Button buttonBookAppointment;
        private System.Windows.Forms.ToolStripMenuItem bookAppointmentToolStripMenuItem;
    }
}

