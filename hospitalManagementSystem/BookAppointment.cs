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
        int patId = 0;
        int docId = 0;
        int docNewId = 0;
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
        //clears data from boxes
        private void clearData()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxAge.Text = "";
            textBoxDoctor.Text = "";
            textBoxAppTime.Text = "";
            comboBoxSex.SelectedIndex = -1;
            comboBoxDepartment.SelectedIndex = -1;
        }
        // clear textBoxSearch Id, Name, Phone
        private void clearSearchBoxes()
        {
            textBoxSearchName.Text = "";
            textBoxSearchId.Text = "";
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
            
            //displaying Patient list in dataGridViewPatient
            displayPatient();
            //Department ComboBox
            this.comboBoxDepartment.DisplayMember = "departmentName";
            this.comboBoxDepartment.ValueMember = "departmentId";
            this.comboBoxDepartment.DataSource = DepartmentDoctorManager.getDepartmentList();
            //ExistingDoctor Nationality comboBox
            this.comboBoxNewNationality.DisplayMember = "nationalityName";
            this.comboBoxNewNationality.ValueMember = "nationalityId";
            this.comboBoxNewNationality.DataSource = NationalityManager.getNationalityList();
            //dataGridViewDoctor alternateRow colorChanged
            this.dataGridViewDoctor.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
            //dataGridViewPatient alternateRow colorChanged
            this.dataGridViewPatient.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
            //comboBox
            this.comboBoxDepartment.SelectedIndex = -1;
            this.comboBoxNewNationality.SelectedIndex = -1;
            //textBoxTime scrollBars
            textBoxAppTime.ScrollBars = ScrollBars.Vertical;
            //dataGridViewDoctor is Visible = False
            this.dataGridViewDoctor.Visible = false;

        }

        //button Search onClick event
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearchName.Text.Length > 0 || textBoxSearchId.Text.Length > 0 ||  textBoxSearchPhone.Text.Length > 0)
                {
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
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //button Refresh onClick event
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            displayPatient();
        }

        //Submit button onClock event
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                Appointment app = new Appointment();
                app.firstName = this.textBoxFirstName.Text;
                app.lastName = this.textBoxLastName.Text;
                app.departmentId = Int32.Parse(this.comboBoxDepartment.SelectedValue.ToString());
                app.age = Convert.ToInt32(this.textBoxAge.Text);
                app.doctorId = docId;
                app.sex = this.comboBoxSex.Text;
                app.phone = Convert.ToInt64(this.textBoxPhone.Text);
                app.appTime = TimeSpan.Parse(this.textBoxAppTime.Text);
                app.patientId = patId;
                AppointmentManager.appointmentSave(app);
                MessageBox.Show("Success");
                displayPatient();
                clearSearchBoxes();
                clearData();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //comboBocDepartment SelectedIndexChanged
        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBoxDepartment.SelectedIndex >= 0)
                {

                    this.dataGridViewDoctor.Visible = true;
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

        //dataGridViewPateint cellContentClick
        private void dataGridViewPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            patId = Convert.ToInt32(dataGridViewPatient.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxFirstName.Text = dataGridViewPatient.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridViewPatient.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxAge.Text = dataGridViewPatient.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxPhone.Text = dataGridViewPatient.Rows[e.RowIndex].Cells[8].Value.ToString();
            comboBoxSex.Text = dataGridViewPatient.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        //dataGridView cellContentClick
        private void dataGridViewDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            docId = Convert.ToInt32(dataGridViewDoctor.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxDoctor.Text = dataGridViewDoctor.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            try
            {
                patient.firstName = this.textBoxNewFirstName.Text;
                patient.lastName = this.textBoxNewLastName.Text;
                patient.age = Convert.ToInt32(this.textBoxNewAge.Text);
                patient.sex = this.comboBoxNewSex.Text;
                patient.natioinality = Int32.Parse(this.comboBoxNewNationality.SelectedValue.ToString());
                PatientManager.patientAppSave(patient);
                MessageBox.Show("Success");
                displayPatient();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSearchId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxSearchPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
