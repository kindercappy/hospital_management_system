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

namespace hospitalManagementSystem
{
    public partial class HospitalMain : Form
    {
        
        public HospitalMain()
        {
            InitializeComponent();
            
        }

        private void HospitalMain_Load(object sender, EventArgs e)
        {

        }


        //Patient
        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            NewPatient newPatient = new NewPatient();
            this.Hide();
            newPatient.ShowDialog();
            this.Close();
        }

        private void btnExistingPatient_Click(object sender, EventArgs e)
        {
            //ExistingPatient existingPatient = new ExistingPatient();
            //existingPatient.ShowDialog();
        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NewPatient newPatient = new NewPatient();
            //newPatient.ShowDialog();
            //this.Close();
        }
        private void existingPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ExistingPatient existingPatient = new ExistingPatient();
            //existingPatient.ShowDialog();
            //this.Hide();
        }


        //Doctor
        private void btnNewDoctor_Click(object sender, EventArgs e)
        {
            //NewDoctor newDoctor = new NewDoctor();
            //newDoctor.ShowDialog();
            //this.Close();
        }
        private void newDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NewDoctor newDoctor = new NewDoctor();
            //newDoctor.ShowDialog();
            //this.Close();
        }

        private void btnExistingDoctor_Click(object sender, EventArgs e)
        {
            //ExistingDoctor existingDoc = new ExistingDoctor();
            //existingDoc.ShowDialog();
            //this.Close();
        }
        private void existingDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ExistingDoctor existingDoc = new ExistingDoctor();
            //existingDoc.ShowDialog();
            //this.Close();
        }



        //Staff
        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            //NewStaff newStaff = new NewStaff();
            //newStaff.ShowDialog();
            //this.Close();
        }

        private void btnExistingStaff_Click(object sender, EventArgs e)
        {
            //ExistingStaff existingStaff = new ExistingStaff();
            //existingStaff.ShowDialog();
            //this.Close();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NewStaff newStaff = new NewStaff();
            //newStaff.ShowDialog();
            //this.Close();
        }

        private void existingStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ExistingStaff existingStaff = new ExistingStaff();
            //existingStaff.ShowDialog();
            //this.Close();
        }

        private void HospitalMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}

