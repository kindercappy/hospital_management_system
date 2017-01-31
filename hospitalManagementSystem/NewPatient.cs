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
using System.Globalization;

namespace hospitalManagementSystem
{
    public partial class NewPatient : Form
    {
        CommonFormOperation cfo = new CommonFormOperation();
        public NewPatient()
        {
            InitializeComponent();
        }
        //METHODS
        //clear entered data
        private void clearData()
        {
            this.textBoxFirstName.Text = "";
            this.textBoxLastName.Text = "";
            this.comboBoxDepartment.SelectedIndex = -1;
            this.textBoxAge.Text = "";
            this.comboBoxSex.SelectedIndex = -1;
            this.textBoxHeightFt.Text = "";
            this.textBoxHeightInch.Text = "";
            this.textBoxWeight.Text = "";
            this.textBoxPhone.Text = "";
            this.textBoxEmail.Text = "";
            this.textBoxAddress.Text = "";
            this.comboBoxNationality.SelectedIndex = -1;
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
            try
            {
            this.Close();                
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string str = "";
            //DateTime myDate;
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
            if(this.textBoxEmail.Text.Length > 0)
            {
                if (!Common.isValidEmail(this.textBoxEmail.Text))
                {
                    str = str + Environment.NewLine + "Pleaser enter valid Email";
                }
            }
            if (str.Length > 0)
            {
                MessageBox.Show(str + Environment.NewLine + "(REQUIRED)");
            }
            else
            {
                int resultHeightFt;
                int resultHeightInch;
                decimal resultWeight;
                long resultPhone;
                Patient patient = new Patient();
                try
                {
                    patient.firstName = this.textBoxFirstName.Text;
                    patient.lastName = this.textBoxLastName.Text;
                    patient.age = Convert.ToInt32(this.textBoxAge.Text);
                    patient.sex = this.comboBoxSex.Text;
                    //heightFt
                    if(Int32.TryParse(this.textBoxHeightFt.Text,out resultHeightFt))
                    {
                    patient.heightFt = Int32.Parse(this.textBoxHeightFt.Text);
                    }
                    else
                    {
                        patient.heightFt = Int32.Parse(resultHeightFt.ToString());
                    }
                    
                    //heightInch
                    if(Int32.TryParse(this.textBoxHeightInch.Text,out resultHeightInch))
                    {
                    patient.heightInch = Int32.Parse(this.textBoxHeightInch.Text);
                    }
                    else
                    {
                        patient.heightInch = Int32.Parse(resultHeightInch.ToString());
                    }

                    //weight
                    if(decimal.TryParse(this.textBoxWeight.Text,out resultWeight))
                    {
                    patient.weight = Convert.ToDecimal(this.textBoxWeight.Text);
                    }
                    else
                    {
                        patient.weight = Convert.ToDecimal(resultWeight.ToString());
                    }
                    //phone
                    if(Int64.TryParse(this.textBoxPhone.Text,out resultPhone))
                    {
                    patient.phone = Int64.Parse(this.textBoxPhone.Text);
                    }
                    else
                    {
                        patient.phone = Int64.Parse(resultPhone.ToString());
                    }
                    patient.email = this.textBoxEmail.Text;
                    patient.address = this.textBoxAddress.Text;
                    patient.natioinality = Int32.Parse(this.comboBoxNationality.SelectedValue.ToString());
                    PatientManager.patientSave(patient);
                    MessageBox.Show("Success");
                    clearData();
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBoxHeightFt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBoxHeightInch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }            
        }

        private void NewPatient_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
