using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalLibrary;


namespace hospitalManagementSystem
{
    public partial class ExistingDoctor : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        int Id = 0;

        public ExistingDoctor()
        {
            InitializeComponent();
            
        }

        // METHODS

        //display data in dataGridView
        private void displayData()
        {
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Doctor_Select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewExistingDoctor.DataSource = dt;
        }

        //clear data
        private void clearData()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxAge.Text = "";
            textBoxHeightFt.Text = "";
            textBoxHeightInch.Text = "";
            textBoxPhone.Text = "";
            textBoxWeight.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
            Id = 0;
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void ExistingDoctor_Load(object sender, EventArgs e)
        {
            //ExistingDoctor Depertment comboBox
            this.comboBoxDepartment.DataSource = DepartmentDoctorManager.getDepartmentList();
            this.comboBoxDepartment.DisplayMember = "departmentName";
            this.comboBoxDepartment.ValueMember = "departmentId";

            //ExistingDoctor Nationality comboBox
            this.comboBoxNationality.DataSource = NationalityManager.getNationalityList();
            this.comboBoxNationality.DisplayMember = "nationalityName";
            this.comboBoxNationality.ValueMember = "nationalityId";
            displayData();
            this.dataGridViewExistingDoctor.Columns[0].Visible = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length > 0)
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    Doctor doctor = new Doctor();
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    cmd.Connection = Common.getConnection();
                    cmd.CommandText = "Doctor_Search";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter sFirstName = new SqlParameter("@firstName", textBoxSearch.Text);
                    sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
                    cmd.Parameters.Add(sFirstName);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dataGridViewExistingDoctor.DataSource = dt;
                    //displayDoctor();
                }
            }
            else
            {
                MessageBox.Show("Please enter details");
            }

        }

        private void dataGridViewExistingDocotor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridViewExistingDoctor.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxFirstName.Text = dataGridViewExistingDoctor.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridViewExistingDoctor.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxDepartment.SelectedValue = Convert.ToInt32(dataGridViewExistingDoctor.Rows[e.RowIndex].Cells[3].Value.ToString());
            textBoxAge.Text = dataGridViewExistingDoctor.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBoxSex.Text = dataGridViewExistingDoctor.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxHeightFt.Text = dataGridViewExistingDoctor.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBoxHeightInch.Text = dataGridViewExistingDoctor.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBoxWeight.Text = dataGridViewExistingDoctor.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBoxPhone.Text = dataGridViewExistingDoctor.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBoxEmail.Text = dataGridViewExistingDoctor.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBoxAddress.Text = dataGridViewExistingDoctor.Rows[e.RowIndex].Cells[11].Value.ToString();
            comboBoxNationality.SelectedValue = Convert.ToInt32(dataGridViewExistingDoctor.Rows[e.RowIndex].Cells[12].Value.ToString());
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string str = "";
            if (textBoxFirstName.Text == "")
            {
                str = str + "First Name ";
            }
            if (textBoxLastName.Text == "")
            {
                str = str + Environment.NewLine + "Last Name ";
            }
            if (comboBoxDepartment.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Department ";
            }
            if (textBoxAge.Text == "")
            {
                str = str + Environment.NewLine + "Age ";
            }
            if (comboBoxSex.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Sex ";
            }
            if (comboBoxNationality.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Nationality";
            }
            if (str.Length > 0)
            {
                MessageBox.Show(str + Environment.NewLine + "(REQUIRED)");
            }
            else
            {
                Doctor doc = new Doctor();
                try
                {
                    doc.firstName = this.textBoxFirstName.Text;
                    doc.lastName = this.textBoxLastName.Text;
                    doc.department = Int32.Parse(this.comboBoxDepartment.SelectedValue.ToString());
                    doc.age = Convert.ToInt32(this.textBoxAge.Text);
                    doc.sex = this.comboBoxSex.Text;
                    doc.heightFt = Convert.ToInt32(this.textBoxHeightFt.Text);
                    doc.heightInch = Convert.ToInt32(this.textBoxHeightInch.Text);
                    doc.weight = Convert.ToInt32(this.textBoxWeight.Text);
                    doc.phone = Convert.ToInt64(this.textBoxPhone.Text);
                    doc.email = this.textBoxEmail.Text;
                    doc.address = this.textBoxAddress.Text;
                    doc.natioinality = Int32.Parse(this.comboBoxNationality.SelectedValue.ToString());
                    DoctorManager.doctorSave(doc);
                    MessageBox.Show("Success");
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            try
            {
                doctor.doctorId = Id;
                doctor.firstName = this.textBoxFirstName.Text;
                doctor.lastName = this.textBoxLastName.Text;
                doctor.department = Int32.Parse(this.comboBoxDepartment.SelectedValue.ToString());
                doctor.age = Convert.ToInt32(this.textBoxAge.Text);
                doctor.sex = this.comboBoxSex.Text;
                doctor.heightFt = Convert.ToInt32(this.textBoxHeightFt.Text);
                doctor.heightInch = Convert.ToInt32(this.textBoxHeightInch.Text);
                doctor.weight = Convert.ToInt32(this.textBoxWeight.Text);
                doctor.phone = Convert.ToInt64(this.textBoxPhone.Text);
                doctor.email = this.textBoxEmail.Text;
                doctor.address = this.textBoxAddress.Text;
                doctor.natioinality = Int32.Parse(this.comboBoxNationality.SelectedValue.ToString());
                DoctorManager.doctorUpdate(doctor);
                MessageBox.Show("Updates");
                displayData();
                clearData();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            try
            {
                doctor.doctorId = Id;
                DoctorManager.doctorDelete(doctor);
                MessageBox.Show("Deleted");
                displayData();
                clearData();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
}

