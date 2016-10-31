using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalLibrary;
using System.Data.SqlClient;

namespace hospitalManagementSystem
{
    public partial class BookAppointment : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        int Id = 0;
        public BookAppointment()
        {
            InitializeComponent();
        }
        // METHODS
        //display data in dataGridView
        private void displayPatient()
        {
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Patient_Select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewPatient.DataSource = dt;
        }
        // clear textBoxSearch Id, Name, Phone
        private void clearSearchBoxes()
        {
            textBoxSearchId.Text = "";
            textBoxSearchName.Text = "";
            textBoxSearchPhone.Text = "";
        }

        private void BookAppointment_Load(object sender, EventArgs e)
        {
            displayPatient();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearchId.Text.Length > 0 || textBoxSearchName.Text.Length > 0 || textBoxSearchPhone.Text.Length > 0)
            {
                //Search by Id
                if (textBoxSearchId.Text.Length > 0)
                {
                    using (SqlCommand cmd = new SqlCommand())
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    using (DataTable dt = new DataTable())
                    {
                        Patient patient = new Patient();
                        cmd.Connection = Common.getConnection();
                        cmd.CommandText = "Patient_Search_Id";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlParameter iPatientId = new SqlParameter("@patientId", textBoxSearchId.Text);
                        iPatientId.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(iPatientId);
                        da.SelectCommand = cmd;
                        da.Fill(dt);
                        dataGridViewPatient.DataSource = dt;
                        clearSearchBoxes();
                    }
                }
                //Search by Name
                if (textBoxSearchName.Text.Length > 0)
                {
                    using (SqlCommand cmd = new SqlCommand())
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    using (DataTable dt = new DataTable())
                    {
                        Patient patient = new Patient();
                        cmd.Connection = Common.getConnection();
                        cmd.CommandText = "Patient_Search_Name";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlParameter sFirstName = new SqlParameter("@firstName", textBoxSearchName.Text);
                        sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
                        cmd.Parameters.Add(sFirstName);

                        da.SelectCommand = cmd;
                        da.Fill(dt);
                        dataGridViewPatient.DataSource = dt;
                        clearSearchBoxes();
                    }
                }
                //Search by Phone
                if(textBoxSearchPhone.Text.Length > 0)
                {
                    using (SqlCommand cmd = new SqlCommand())
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    using (DataTable dt = new DataTable())
                    {
                        Patient patient = new Patient();
                        cmd.Connection = Common.getConnection();
                        cmd.CommandText = "Patient_Search_Phone";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlParameter bPhone = new SqlParameter("@phone", textBoxSearchPhone.Text);
                        bPhone.SqlDbType = System.Data.SqlDbType.BigInt;
                        cmd.Parameters.Add(bPhone);

                        da.SelectCommand = cmd;
                        da.Fill(dt);
                        dataGridViewPatient.DataSource = dt;
                        clearSearchBoxes();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a value to search!");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            displayPatient();
        }
    }
}
