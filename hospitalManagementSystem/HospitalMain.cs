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
            //Sql connection to database
            sqlConnection();
        }

        //Sql connection method
        public void sqlConnection()
        {
            string connectionString = "Data Source =CAPPY; Initial Catalog= hospitalManagementSystem; Integrated Security = SSPI; ";
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                //MessageBox.Show("Connected");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection string");
            }
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
