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
        //CommonFormOperation cfo = new CommonFormOperation();

        public HospitalMain()
        {
            InitializeComponent();
            
        }

        private void HospitalMain_Load(object sender, EventArgs e)
        {
            //HospitalMain hm = new HospitalMain();
            //if(hm.Activated == true)
            //{

            //}
            

        }


        //Patient
        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            panelHospitalMain.Visible = false;
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.newPatient, this);
            //panelHospitalMain.SendToBack();
        }

        private void btnExistingPatient_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.existingPatient, this);
            panelHospitalMain.SendToBack();
        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.newPatient, this);
            panelHospitalMain.SendToBack();
        }
        private void existingPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.existingPatient, this);
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

        //Staff
        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.newStaff, this);
            panelHospitalMain.SendToBack();
        }
        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.newStaff, this);
            panelHospitalMain.SendToBack();
        }

        private void btnExistingStaff_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.existingStaff, this);
            panelHospitalMain.SendToBack();
        }

        private void existingStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.existingStaff, this);
            panelHospitalMain.SendToBack();
        }



        private void HospitalMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void HospitalMain_Activated(object sender, EventArgs e)
        {
            //panelHospitalMain.Visible = true;
            
        }

        private void HospitalMain_Shown(object sender, EventArgs e)
        {
            //panelHospitalMain.Show();
            //panelHospitalMain.BringToFront();
        }

        
    }
}

