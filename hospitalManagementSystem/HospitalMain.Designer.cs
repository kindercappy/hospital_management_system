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
            this.doctorShiftsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existingPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existingStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDoctorShifts = new System.Windows.Forms.Button();
            this.labelShifts = new System.Windows.Forms.Label();
            this.buttonStaffShifts = new System.Windows.Forms.Button();
            this.panelHospitalMain = new System.Windows.Forms.Panel();
            this.buttonEditShift = new System.Windows.Forms.Button();
            this.labelMakeShifts = new System.Windows.Forms.Label();
            this.buttonNewShift = new System.Windows.Forms.Button();
            this.buttonAssignDoctorShifts = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelHospitalMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.Location = new System.Drawing.Point(3, 18);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(122, 23);
            this.btnNewPatient.TabIndex = 1;
            this.btnNewPatient.Text = "New Patient";
            this.btnNewPatient.UseVisualStyleBackColor = true;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // btnExistingPatient
            // 
            this.btnExistingPatient.Location = new System.Drawing.Point(141, 18);
            this.btnExistingPatient.Name = "btnExistingPatient";
            this.btnExistingPatient.Size = new System.Drawing.Size(122, 23);
            this.btnExistingPatient.TabIndex = 3;
            this.btnExistingPatient.Text = "Existing Patient";
            this.btnExistingPatient.UseVisualStyleBackColor = true;
            this.btnExistingPatient.Click += new System.EventHandler(this.btnExistingPatient_Click);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(111, 2);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(40, 13);
            this.lblPatient.TabIndex = 4;
            this.lblPatient.Text = "Patient";
            // 
            // btnNewDoctor
            // 
            this.btnNewDoctor.Location = new System.Drawing.Point(3, 60);
            this.btnNewDoctor.Name = "btnNewDoctor";
            this.btnNewDoctor.Size = new System.Drawing.Size(122, 23);
            this.btnNewDoctor.TabIndex = 5;
            this.btnNewDoctor.Text = "New Doctor";
            this.btnNewDoctor.UseVisualStyleBackColor = true;
            this.btnNewDoctor.Click += new System.EventHandler(this.btnNewDoctor_Click);
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(112, 44);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(39, 13);
            this.lblDoctor.TabIndex = 6;
            this.lblDoctor.Text = "Doctor";
            // 
            // btnExistingDoctor
            // 
            this.btnExistingDoctor.Location = new System.Drawing.Point(141, 60);
            this.btnExistingDoctor.Name = "btnExistingDoctor";
            this.btnExistingDoctor.Size = new System.Drawing.Size(122, 23);
            this.btnExistingDoctor.TabIndex = 9;
            this.btnExistingDoctor.Text = "Existing Doctor";
            this.btnExistingDoctor.UseVisualStyleBackColor = true;
            this.btnExistingDoctor.Click += new System.EventHandler(this.btnExistingDoctor_Click);
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(115, 86);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(29, 13);
            this.lblStaff.TabIndex = 10;
            this.lblStaff.Text = "Staff";
            // 
            // btnNewStaff
            // 
            this.btnNewStaff.Location = new System.Drawing.Point(3, 102);
            this.btnNewStaff.Name = "btnNewStaff";
            this.btnNewStaff.Size = new System.Drawing.Size(122, 23);
            this.btnNewStaff.TabIndex = 13;
            this.btnNewStaff.Text = "New Staff";
            this.btnNewStaff.UseVisualStyleBackColor = true;
            this.btnNewStaff.Click += new System.EventHandler(this.btnNewStaff_Click);
            // 
            // btnExistingStaff
            // 
            this.btnExistingStaff.Location = new System.Drawing.Point(141, 102);
            this.btnExistingStaff.Name = "btnExistingStaff";
            this.btnExistingStaff.Size = new System.Drawing.Size(122, 23);
            this.btnExistingStaff.TabIndex = 14;
            this.btnExistingStaff.Text = "Existing Staff";
            this.btnExistingStaff.UseVisualStyleBackColor = true;
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
            this.doctorShiftsToolStripMenuItem});
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
            // doctorShiftsToolStripMenuItem
            // 
            this.doctorShiftsToolStripMenuItem.Name = "doctorShiftsToolStripMenuItem";
            this.doctorShiftsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.doctorShiftsToolStripMenuItem.Text = "Doctor Shifts";
            this.doctorShiftsToolStripMenuItem.Click += new System.EventHandler(this.doctorShiftsToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPatientToolStripMenuItem,
            this.existingPatientToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // newPatientToolStripMenuItem
            // 
            this.newPatientToolStripMenuItem.Name = "newPatientToolStripMenuItem";
            this.newPatientToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newPatientToolStripMenuItem.Text = "New Patient";
            this.newPatientToolStripMenuItem.Click += new System.EventHandler(this.newPatientToolStripMenuItem_Click);
            // 
            // existingPatientToolStripMenuItem
            // 
            this.existingPatientToolStripMenuItem.Name = "existingPatientToolStripMenuItem";
            this.existingPatientToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.existingPatientToolStripMenuItem.Text = "Existing Patient";
            this.existingPatientToolStripMenuItem.Click += new System.EventHandler(this.existingPatientToolStripMenuItem_Click);
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
            // buttonDoctorShifts
            // 
            this.buttonDoctorShifts.Location = new System.Drawing.Point(0, 144);
            this.buttonDoctorShifts.Name = "buttonDoctorShifts";
            this.buttonDoctorShifts.Size = new System.Drawing.Size(125, 23);
            this.buttonDoctorShifts.TabIndex = 17;
            this.buttonDoctorShifts.Text = "New Doctor Shifts";
            this.buttonDoctorShifts.UseVisualStyleBackColor = true;
            this.buttonDoctorShifts.Click += new System.EventHandler(this.buttonDoctorShifts_Click);
            // 
            // labelShifts
            // 
            this.labelShifts.AutoSize = true;
            this.labelShifts.Location = new System.Drawing.Point(115, 128);
            this.labelShifts.Name = "labelShifts";
            this.labelShifts.Size = new System.Drawing.Size(33, 13);
            this.labelShifts.TabIndex = 18;
            this.labelShifts.Text = "Shifts";
            // 
            // buttonStaffShifts
            // 
            this.buttonStaffShifts.Location = new System.Drawing.Point(221, 294);
            this.buttonStaffShifts.Name = "buttonStaffShifts";
            this.buttonStaffShifts.Size = new System.Drawing.Size(122, 23);
            this.buttonStaffShifts.TabIndex = 21;
            this.buttonStaffShifts.Text = "Staff Shifts";
            this.buttonStaffShifts.UseVisualStyleBackColor = true;
            // 
            // panelHospitalMain
            // 
            this.panelHospitalMain.BackColor = System.Drawing.Color.DarkGray;
            this.panelHospitalMain.Controls.Add(this.buttonAssignDoctorShifts);
            this.panelHospitalMain.Controls.Add(this.buttonEditShift);
            this.panelHospitalMain.Controls.Add(this.labelMakeShifts);
            this.panelHospitalMain.Controls.Add(this.buttonNewShift);
            this.panelHospitalMain.Controls.Add(this.btnNewPatient);
            this.panelHospitalMain.Controls.Add(this.buttonStaffShifts);
            this.panelHospitalMain.Controls.Add(this.lblStaff);
            this.panelHospitalMain.Controls.Add(this.btnExistingDoctor);
            this.panelHospitalMain.Controls.Add(this.btnExistingPatient);
            this.panelHospitalMain.Controls.Add(this.labelShifts);
            this.panelHospitalMain.Controls.Add(this.btnNewStaff);
            this.panelHospitalMain.Controls.Add(this.lblPatient);
            this.panelHospitalMain.Controls.Add(this.lblDoctor);
            this.panelHospitalMain.Controls.Add(this.buttonDoctorShifts);
            this.panelHospitalMain.Controls.Add(this.btnExistingStaff);
            this.panelHospitalMain.Controls.Add(this.btnNewDoctor);
            this.panelHospitalMain.Location = new System.Drawing.Point(12, 27);
            this.panelHospitalMain.Name = "panelHospitalMain";
            this.panelHospitalMain.Size = new System.Drawing.Size(604, 495);
            this.panelHospitalMain.TabIndex = 22;
            // 
            // buttonEditShift
            // 
            this.buttonEditShift.Location = new System.Drawing.Point(141, 186);
            this.buttonEditShift.Name = "buttonEditShift";
            this.buttonEditShift.Size = new System.Drawing.Size(122, 23);
            this.buttonEditShift.TabIndex = 26;
            this.buttonEditShift.Text = "Edit Shift";
            this.buttonEditShift.UseVisualStyleBackColor = true;
            // 
            // labelMakeShifts
            // 
            this.labelMakeShifts.AutoSize = true;
            this.labelMakeShifts.Location = new System.Drawing.Point(102, 170);
            this.labelMakeShifts.Name = "labelMakeShifts";
            this.labelMakeShifts.Size = new System.Drawing.Size(63, 13);
            this.labelMakeShifts.TabIndex = 23;
            this.labelMakeShifts.Text = "Make Shifts";
            // 
            // buttonNewShift
            // 
            this.buttonNewShift.Location = new System.Drawing.Point(0, 186);
            this.buttonNewShift.Name = "buttonNewShift";
            this.buttonNewShift.Size = new System.Drawing.Size(122, 23);
            this.buttonNewShift.TabIndex = 22;
            this.buttonNewShift.Text = "New Shift";
            this.buttonNewShift.UseVisualStyleBackColor = true;
            // 
            // buttonAssignDoctorShifts
            // 
            this.buttonAssignDoctorShifts.Location = new System.Drawing.Point(141, 144);
            this.buttonAssignDoctorShifts.Name = "buttonAssignDoctorShifts";
            this.buttonAssignDoctorShifts.Size = new System.Drawing.Size(125, 23);
            this.buttonAssignDoctorShifts.TabIndex = 27;
            this.buttonAssignDoctorShifts.Text = "Assign Doctor Shifts";
            this.buttonAssignDoctorShifts.UseVisualStyleBackColor = true;
            this.buttonAssignDoctorShifts.Click += new System.EventHandler(this.buttonAssignDoctorShifts_Click);
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
        private System.Windows.Forms.Button buttonDoctorShifts;
        private System.Windows.Forms.Label labelShifts;
        private System.Windows.Forms.Button buttonStaffShifts;
        private System.Windows.Forms.Panel panelHospitalMain;
        private System.Windows.Forms.ToolStripMenuItem doctorShiftsToolStripMenuItem;
        private System.Windows.Forms.Label labelMakeShifts;
        private System.Windows.Forms.Button buttonNewShift;
        private System.Windows.Forms.Button buttonEditShift;
        private System.Windows.Forms.Button buttonAssignDoctorShifts;
    }
}

