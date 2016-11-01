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
        //SqlCommand cmd = new SqlCommand();
        //SqlDataAdapter da = new SqlDataAdapter();
        //DataTable dt = new DataTable();
        //int Id = 0;
        public BookAppointment()
        {
            InitializeComponent();
        }
        // METHODS
        //display data in dataGridView
        private void displayPatient()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Patient_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewPatient.DataSource = dt;
            }
        }
        // clear textBoxSearch Id, Name, Phone
        private void clearSearchBoxes()
        {
            textBoxSearchId.Text = "";
            textBoxSearchName.Text = "";
            textBoxSearchPhone.Text = "";
        }
        //private void loadDoctor()
        //{
        //    using (SqlCommand cmd = new SqlCommand())
        //    using (SqlDataAdapter da = new SqlDataAdapter())
        //    using (DataTable dt = new DataTable())
        //    {
        //        cmd.Connection = Common.getConnection();
        //        cmd.CommandText = "Doctor_Select_By_Department";
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        //        SqlParameter iDepartment = new SqlParameter("@department", this.comboBoxDepartment.SelectedValue);
        //        iDepartment.SqlDbType = System.Data.SqlDbType.Int;
        //        cmd.Parameters.Add(iDepartment);

        //        da.SelectCommand = cmd;
        //        da.Fill(dt);
        //        dataGridViewPatient.DataSource = dt;
        //    }
        //}

        private void BookAppointment_Load(object sender, EventArgs e)
        {
            
            //Department ComboBox
            this.comboBoxDepartment.DisplayMember = "departmentName";
            this.comboBoxDepartment.ValueMember = "departmentId";
            this.comboBoxDepartment.DataSource = DepartmentDoctorManager.getDepartmentList();
           
            this.comboBoxDepartment.SelectedIndex = -1;
            displayPatient();

            this.dataGridViewDoctor.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
            this.dataGridViewPatient.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
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
                        cmd.Connection = Common.getConnection();
                        cmd.CommandText = "Patient_Search_Id";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlParameter iPatientId = new SqlParameter("@patientId", this.textBoxSearchId.Text);
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
                        cmd.Connection = Common.getConnection();
                        cmd.CommandText = "Patient_Search_Name";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlParameter sFirstName = new SqlParameter("@firstName", this.textBoxSearchName.Text);
                        sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
                        cmd.Parameters.Add(sFirstName);

                        da.SelectCommand = cmd;
                        da.Fill(dt);
                        dataGridViewPatient.DataSource = dt;
                        clearSearchBoxes();
                    }
                }
                //Search by Phone
                if (textBoxSearchPhone.Text.Length > 0)
                {
                    using (SqlCommand cmd = new SqlCommand())
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    using (DataTable dt = new DataTable())
                    {
                        cmd.Connection = Common.getConnection();
                        cmd.CommandText = "Patient_Search_Phone";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlParameter bPhone = new SqlParameter("@phone", this.textBoxSearchPhone.Text);
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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBoxDepartment.SelectedIndex >= 0)
                {


                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = Common.getConnection();
                        cmd.CommandText = "Doctor_Select_By_Department";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlParameter iDepartment = new SqlParameter("@department", this.comboBoxDepartment.SelectedValue);
                        iDepartment.SqlDbType = System.Data.SqlDbType.Int;
                        cmd.Parameters.Add(iDepartment);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewDoctor.DataSource = dt;
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
