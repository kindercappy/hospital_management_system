using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using hospitalManagementSystem;
using HospitalLibrary;

namespace hospitalManagementSystem
{
    public partial class HospitalMain : Form
    {
        public HospitalMain()
        {
            InitializeComponent();
        }
        public void panelBringToFront()
        {
            this.panelHospitalMain.BringToFront();
        }
        private void HospitalMain_Load(object sender, EventArgs e)
        {
            panelHospitalMain.BringToFront();
            LoginForm form = new LoginForm();
            form.ShowDialog();
        }

        //Patient
        //New Patient button
        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            //panelHospitalMain.Visible = false;
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.newPatient, this);
            this.panelHospitalMain.SendToBack();
        }
        //Existing Patient button
        private void btnExistingPatient_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.existingPatient, this);
            panelHospitalMain.SendToBack();
        }
        //BookAppointment button
        private void buttonBookAppointment_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.bookApp, this);
            panelHospitalMain.SendToBack();
        }
        // menu New Patient button
        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.newPatient, this);
            panelHospitalMain.SendToBack();
        }
        // menu Exsiting Patient button
        private void existingPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.existingPatient, this);
            panelHospitalMain.SendToBack();
        }
        private void bookAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.bookApp, this);
            panelHospitalMain.SendToBack();
        }

        //Doctor
        // New Doctor Button
        private void btnNewDoctor_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.newDoctor, this);
            panelHospitalMain.SendToBack();
        }
        // menu New Doctor button
        private void newDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.newDoctor, this);
            panelHospitalMain.SendToBack();
        }
        // Existing Doctor Button
        private void btnExistingDoctor_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.existingDoctor, this);
            panelHospitalMain.SendToBack();
        }
        //menu Existing doctor button
        private void existingDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.existingDoctor, this);
            panelHospitalMain.SendToBack();
        }
        // make doctor shifts button
        private void buttonDoctorShifts_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.doctorShifts, this);
            panelHospitalMain.SendToBack();
        }
        // menu make shifts button
        private void makeShiftsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.doctorShifts, this);
            panelHospitalMain.SendToBack();
        }
        // assign doctor shifts button
        private void buttonAssignDoctorShifts_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.assignDoctorShifts, this);
            panelHospitalMain.SendToBack();
        }
        //menu assign shifts button
        private void assignShiftsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.assignDoctorShifts, this);
            panelHospitalMain.SendToBack();
        }
        //doctor department button
        private void buttonDoctorDepartment_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.doctorDepartment, this);
            panelHospitalMain.SendToBack();
        }
        //doctor department menu
        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.doctorDepartment, this);
            panelHospitalMain.SendToBack();
        }

        //Staff
        //New staff button
        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.newStaff, this);
            panelHospitalMain.SendToBack();
        }
        // menu New Staff button
        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.newStaff, this);
            panelHospitalMain.SendToBack();
        }
        //Existing Staff Button
        private void btnExistingStaff_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.existingStaff, this);
            panelHospitalMain.SendToBack();
        }
        //menu Existing Staff button
        private void existingStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.existingStaff, this);
            panelHospitalMain.SendToBack();
        }
        //New Shift button
        private void buttonNewShift_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.staffShifts, this);
            panelHospitalMain.SendToBack();
        }
        //New shift menu
        private void newShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.staffShifts, this);
            panelHospitalMain.SendToBack();
        }
        //Assign Shifts button
        private void buttonAssignShift_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.assignStaffShifts, this);
            panelHospitalMain.SendToBack();
            
        }
        //Assign shifts menu
        private void assignShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.assignStaffShifts, this);
            panelHospitalMain.SendToBack();
        }
        //Staff Department button
        private void buttonStaffDepartment_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.staffDepartment, this);
            panelHospitalMain.SendToBack();
        }
        //staff department menu
        private void departmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.staffDepartment, this);
            panelHospitalMain.SendToBack();
        }



        private void HospitalMain_FormClosed(object sender, FormClosedEventArgs e)
        {  

        }

        private void HospitalMain_Activated(object sender, EventArgs e)
        {
            //panelHospitalMain.BringToFront();
        }

        private void HospitalMain_Shown(object sender, EventArgs e)
        {
           
        }
        //Nationality
        //nationality button
        private void buttonNationality_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.nationality, this);
            panelHospitalMain.SendToBack();
        }
        //nationality menu
        private void nationalityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.nationality, this);
            panelHospitalMain.SendToBack();
        }



    }
}

