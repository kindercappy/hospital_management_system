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
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        //clear data
        private void clearData()
        {
            this.textBoxFirstName.Text = "";
            this.textBoxLastName.Text = "";
            this.textBoxAge.Text = "";
            this.textBoxHeightFt.Text = "";
            this.textBoxHeightInch.Text = "";
            this.textBoxPhone.Text = "";
            this.textBoxWeight.Text = "";
            this.textBoxEmail.Text = "";
            this.textBoxAddress.Text = "";
            this.comboBoxDepartment.SelectedIndex = -1;
            this.comboBoxNationality.SelectedIndex = -1;
            this.comboBoxSex.SelectedIndex = -1;
            this.comboBoxStaffShift.SelectedIndex = -1;

        }
        private void entries()
        {
            this.textBoxFirstName.Text = "Cappy";
            this.textBoxLastName.Text = " Preet";
            this.textBoxAge.Text = "23";
        }       
        private void buttonBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            string str = "";
            if (this.textBoxFirstName.Text == "")
            {
                str = str + "First Name ";
            }
            if (this.textBoxLastName.Text == "")
            {
                str = str + Environment.NewLine + "Last Name ";
            }
            if (this.comboBoxDepartment.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Department ";
            }
            if (this.textBoxAge.Text == "")
            {
                str = str + Environment.NewLine + "Age ";
            }
            if (this.comboBoxSex.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Sex ";
            }

            if (this.comboBoxNationality.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Nationality";
            }
            if (this.comboBoxStaffShift.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Staff Shift";
            }
            //validate email
            if (this.textBoxEmail.Text.Length > 0)
            {
                if (!Common.isValidEmail(this.textBoxEmail.Text))
                {
                    
                    str = str + Environment.NewLine +"Please enter valid Email" ;
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
                int resultWeight;
                long resultPhone;
                Staff staff = new Staff();
                try
                {
                    staff.firstName = this.textBoxFirstName.Text;
                    staff.lastName = this.textBoxLastName.Text;
                    staff.department = Int32.Parse(this.comboBoxDepartment.SelectedValue.ToString());
                    staff.age = Convert.ToInt32(this.textBoxAge.Text);
                    staff.sex = this.comboBoxSex.Text;

                    //heightFt
                    if (Int32.TryParse(this.textBoxHeightFt.Text, out resultHeightFt))
                         {
                        staff.heightFt = Int32.Parse(this.textBoxHeightFt.Text);
                         }
                     else
                         {
                        staff.heightFt = Int32.Parse(resultHeightFt.ToString());
                         }

                    //heightInch
                    if(Int32.TryParse(this.textBoxHeightInch.Text,out resultHeightInch))
                    {
                    staff.heightInch = Int32.Parse(this.textBoxHeightInch.Text);
                    }
                    else
                    {
                        staff.heightInch = Int32.Parse(resultHeightInch.ToString());
                    }

                    //weight
                    if(Int32.TryParse(this.textBoxWeight.Text,out resultWeight))
                    {
                        staff.weight = Int32.Parse(this.textBoxWeight.Text);
                    }
                    else
                    {
                        staff.weight = Int32.Parse(resultWeight.ToString());
                    }

                    //phone
                    if(Int64.TryParse(this.textBoxPhone.Text ,out resultPhone))
                    {
                        staff.phone = Int64.Parse(this.textBoxPhone.Text);
                    }
                    else
                    {
                        staff.phone = Int64.Parse(resultPhone.ToString());
                    }


                    staff.email = this.textBoxEmail.Text;
                    staff.address = this.textBoxAddress.Text;
                    staff.natioinality = Int32.Parse(this.comboBoxNationality.SelectedValue.ToString());
                    staff.staffShift = Convert.ToInt32(this.comboBoxStaffShift.SelectedValue.ToString());
                    StaffManager.staffSave(staff);
                    MessageBox.Show("Success");
                    clearData();
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void NewStaff_Load(object sender, EventArgs e)
        {
            try
            {
                entries();
                //NewPatient Department comboBox
                this.comboBoxDepartment.DataSource = DepartmentStaffManager.getDepartmentList();
                this.comboBoxDepartment.DisplayMember = "departmentName";
                this.comboBoxDepartment.ValueMember = "departmentId";

                //NewPatient Nationality comboBox
                this.comboBoxNationality.DataSource = NationalityManager.getNationalityList();
                this.comboBoxNationality.DisplayMember = "nationalityName";
                this.comboBoxNationality.ValueMember = "nationalityId";

                //Staff shifts combobox
                this.comboBoxStaffShift.DataSource = StaffShiftsManager.getStaffShifts();
                this.comboBoxStaffShift.DisplayMember = "fullDetails";
                this.comboBoxStaffShift.ValueMember = "shiftId";

                //Setting comboboxes to -1 index so no item apperas on load
                this.comboBoxDepartment.SelectedIndex = -1;
                this.comboBoxNationality.SelectedIndex = -1;
                this.comboBoxSex.SelectedIndex = -1;
                this.comboBoxStaffShift.SelectedIndex = -1;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void NewStaff_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
