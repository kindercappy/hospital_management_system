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
        public ExistingPatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HospitalMain hospitalMain = new HospitalMain();
            hospitalMain.ShowDialog();
            this.Close();
        }

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

                this.comboBoxUser1.DataSource = PatientManager.getPatientList();
                this.comboBoxUser1.DisplayMember = "userInfo";
                this.comboBoxUser1.ValueMember = "patientId";

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxUser1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxUser1.SelectedIndex > -1)
                {
                    int value = Convert.ToInt32(comboBoxUser1.SelectedValue);
                    Patient pat = new Patient();
                    pat = PatientManager.Patien_Select(value);
                    this.textBoxFirstName.Text = pat.firstName;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

