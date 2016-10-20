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
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.newPatient, this);
            panelHospitalMain.SendToBack();
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
        private void btnNewDoctor_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.newDoctor, this);
            panelHospitalMain.SendToBack();
        }
        private void newDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.newDoctor, this);
            panelHospitalMain.SendToBack();
        }

        private void btnExistingDoctor_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.existingDoctor, this);
            panelHospitalMain.SendToBack();
        }
        private void existingDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.existingDoctor, this);
            panelHospitalMain.SendToBack();
        }
        private void buttonDoctorShifts_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.doctorShifts, this);
            panelHospitalMain.SendToBack();
        }
        private void doctorShiftsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowMaximizeSubForm(CommonFormOperation.doctorShifts, this);
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

        public void showPanel()
        {
            HospitalMain hm = new HospitalMain();
            hm.panelHospitalMain.BringToFront();

        }

    }
}

