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


        // Button click open NewPatient Form
        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            NewPatient newPatient = new NewPatient();
            newPatient.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btnExistingPatient_Click(object sender, EventArgs e)
        {
            ExistingPatient existingPatient = new ExistingPatient();
            existingPatient.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btnNewDoctor_Click(object sender, EventArgs e)
        {
            NewDoctor newDoctor = new NewDoctor();
            newDoctor.ShowDialog();
            this.Close();
        }

        private void btnExistingDoctor_Click(object sender, EventArgs e)
        {
            ExistingDoctor existingDoc = new ExistingDoctor();
            existingDoc.ShowDialog();
            this.Close();
        }

        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            NewStaff newStaff = new NewStaff();
            newStaff.ShowDialog();
            this.Close();
        }

        private void btnExistingStaff_Click(object sender, EventArgs e)
        {
            ExistingStaff existingStaff = new ExistingStaff();
            existingStaff.ShowDialog();
            this.Close();
        }
    }
}

