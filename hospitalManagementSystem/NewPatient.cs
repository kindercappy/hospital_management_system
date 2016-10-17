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

namespace hospitalManagementSystem
{
    public partial class NewPatient : Form
    {
        CommonFormOperation cfo = new CommonFormOperation();
        public NewPatient()
        {
            InitializeComponent();
        }

        private void NewPatient_Load(object sender, EventArgs e)
        {
            try
            {
                //NewPatient Department comboBox
                this.comboBoxDepartment.DataSource = DepartmentDoctorManager.getDepartmentList();
                this.comboBoxDepartment.DisplayMember = "departmentName";
                this.comboBoxDepartment.ValueMember = "departmentId";
                //NewPatient Nationality comboBox
                this.comboBoxNationality.DataSource = NationalityManager.getNationalityList();
                this.comboBoxNationality.DisplayMember = "nationalityName";
                this.comboBoxNationality.ValueMember = "nationalityId";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.textBoxFirstName.Text = "Kinder";
            this.textBoxLastName.Text = "Preet";
            this.textBoxAge.Text = "4";
            this.comboBoxSex.Text = "MALE";
            this.textBoxHeightFt.Text = "5";
            this.textBoxHeightInch.Text = "6";
            this.textBoxWeight.Text = "50";
            this.textBoxPhone.Text = "4444444444444";
            this.textBoxEmail.Text = "k@gmail.com";
            this.textBoxAddress.Text = "sdsdsdsds";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //HospitalMain hm = new HospitalMain();
            //this.Close();
            //hm.Show();
            
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
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
                PatientManager.Patient_Save(patient);
                MessageBox.Show("Success");
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
