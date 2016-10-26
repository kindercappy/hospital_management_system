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
    public partial class ExistingPatient : Form
    {

        //SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        int Id = 0;

        public ExistingPatient()
        {
            InitializeComponent();
            displayData();
        }

       
        // METHODS
        //display data in dataGridView
        private void displayData()
        {
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Patient_Select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewExistingPatient.DataSource = dt;
          
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


        // EVENTS
        private void ExistingPatient_Load(object sender, EventArgs e)
        {
            
            Patient patient = new Patient();
            try
            {
                //ExistingPatient Department comboBox
                this.comboBoxDepartment.DataSource = DepartmentDoctorManager.getDepartmentList();
                this.comboBoxDepartment.DisplayMember = "departmentName";
                this.comboBoxDepartment.ValueMember = "departmentId";
                //ExistingPatient Nationality comboBox
                this.comboBoxNationality.DataSource = NationalityManager.getNationalityList();
                this.comboBoxNationality.DisplayMember = "nationalityName";
                this.comboBoxNationality.ValueMember = "nationalityId";

                //this.comboBoxUser1.DataSource = PatientManager.getPatientList();
                //this.comboBoxUser1.DisplayMember = "userInfo";
                //this.comboBoxUser1.ValueMember = "patientId";

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewExistingPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //display data in textboxes, comboboxes when record selected in datagridview
            Id = Convert.ToInt32(dataGridViewExistingPatient.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxFirstName.Text = dataGridViewExistingPatient.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridViewExistingPatient.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxDepartment.SelectedValue = Convert.ToInt32(dataGridViewExistingPatient.Rows[e.RowIndex].Cells[3].Value.ToString());
            textBoxAge.Text = dataGridViewExistingPatient.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBoxSex.Text = dataGridViewExistingPatient.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxHeightFt.Text = dataGridViewExistingPatient.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBoxHeightInch.Text = dataGridViewExistingPatient.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBoxWeight.Text = dataGridViewExistingPatient.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBoxPhone.Text = dataGridViewExistingPatient.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBoxEmail.Text = dataGridViewExistingPatient.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBoxAddress.Text = dataGridViewExistingPatient.Rows[e.RowIndex].Cells[11].Value.ToString();
            comboBoxNationality.SelectedValue = Convert.ToInt32(dataGridViewExistingPatient.Rows[e.RowIndex].Cells[12].Value.ToString());

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            
            string str = "";
            if(textBoxFirstName.Text == "")
            {
                str = str + "First Name ";    
            }
            if (textBoxLastName.Text == "")
            {
                str = str  + Environment.NewLine + "Last Name ";
            }
            if (comboBoxDepartment.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Department ";
            }
            if (textBoxAge.Text =="")
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
            if (str.Length >= 0)
            {
                MessageBox.Show(str + Environment.NewLine + "(REQUIRED)");
            }
            else
            {
                //Insert the patient data here
                Patient patient = new Patient();
                try
                {
                    patient.firstName = this.textBoxFirstName.Text;
                    patient.lastName = this.textBoxLastName.Text;
                    patient.department = Int32.Parse(this.comboBoxDepartment.SelectedValue.ToString());
                    patient.age = Convert.ToInt32(this.textBoxAge.Text);
                    patient.sex = this.comboBoxSex.Text;
                    patient.heightFt = Convert.ToInt32(this.textBoxHeightFt.Text);
                    patient.heightInch = Convert.ToInt32(this.textBoxHeightInch.Text);
                    patient.weight = Convert.ToInt32(this.textBoxWeight.Text);
                    patient.phone = Convert.ToInt64(this.textBoxPhone.Text);
                    patient.email = this.textBoxEmail.Text;
                    patient.address = this.textBoxAddress.Text;
                    patient.natioinality = Int32.Parse(this.comboBoxNationality.SelectedValue.ToString());
                    PatientManager.patientSave(patient);
                    MessageBox.Show("Success");
                    displayData();
                    clearData();
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //updates patient data
            Patient patient = new Patient();
            try
            {
                patient.patientId = Id;
                patient.firstName = this.textBoxFirstName.Text;
                patient.lastName = this.textBoxLastName.Text;
                patient.department = Int32.Parse(this.comboBoxDepartment.SelectedValue.ToString());
                patient.age = Convert.ToInt32(this.textBoxAge.Text);
                patient.sex = this.comboBoxSex.Text;
                patient.heightFt = Convert.ToInt32(this.textBoxHeightFt.Text);
                patient.heightInch = Convert.ToInt32(this.textBoxHeightInch.Text);
                patient.weight = Convert.ToInt32(this.textBoxWeight.Text);
                patient.phone = Convert.ToInt64(this.textBoxPhone.Text);
                patient.email = this.textBoxEmail.Text;
                patient.address = this.textBoxAddress.Text;
                patient.natioinality = Int32.Parse(this.comboBoxNationality.SelectedValue.ToString());
                PatientManager.patientUpdate(patient);
                MessageBox.Show("Success");
                displayData();
                clearData();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            try
            {
                patient.patientId = Id;
                PatientManager.patientDelete(patient);
                MessageBox.Show("Deleted");
                displayData();
                clearData();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

