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
                //Setting comboboxes to -1 index so no item apperas on load
                this.comboBoxDepartment.SelectedIndex = -1;
                this.comboBoxNationality.SelectedIndex = -1;
                this.comboBoxSex.SelectedIndex = -1;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
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
                Patient patient = new Patient();
                try
                {
                    patient.firstName = this.textBoxFirstName.Text;
                    patient.lastName = this.textBoxLastName.Text;
                    //patient.department = Int32.Parse(this.comboBoxDepartment.SelectedValue.ToString());
                    patient.age = Convert.ToInt32(this.textBoxAge.Text);
                    patient.sex = this.comboBoxSex.Text;
                    patient.heightFt = Convert.ToInt32(this.textBoxHeightFt.Text);
                    patient.heightInch = Convert.ToInt32(this.textBoxHeightInch.Text);
                    patient.weight = Convert.ToInt32(this.textBoxWeight.Text);
                    patient.phone = Convert.ToInt64(this.textBoxPhone.Text);
                    patient.email = this.textBoxEmail.Text;
                    patient.address = this.textBoxAddress.Text;
                    patient.natioinality = Int32.Parse(this.comboBoxNationality.SelectedValue.ToString());
                    patient.from = TimeSpan.Parse(this.textBoxFrom.Text);
                    patient.to = TimeSpan.Parse(this.textBoxTo.Text);
                    PatientManager.patientSave(patient);
                    MessageBox.Show("Success");
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
