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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
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
            //if(this.textBoxHeightFt.Text == "")
            //{
            //    this.textBoxHeightFt.Text = "0";
            //}
            //if(this.textBoxHeightInch.Text == "")
            //{
            //    this.textBoxHeightInch.Text = "0";
            //}
            if (this.comboBoxNationality.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Nationality";
            }
            if(this.comboBoxStaffShift.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Staff Shift";
            }
            if (str.Length > 0)
            {
                MessageBox.Show(str + Environment.NewLine + "(REQUIRED)");
            }
            else
            {
                int resultHeightFt;
                int resultHeightinch;
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
                    if (Int32.TryParse(this.textBoxHeightFt.Text, out resultHeightFt))
                         {
                            staff.heightFt = Int32.Parse(this.textBoxHeightFt.Text);
                         }
                     else
                         {
                            staff.heightFt = Int32.Parse(resultHeightFt.ToString());
                         }
                    if(Int32.TryParse(this.textBoxHeightInch.Text,out resultHeightinch))
                    {

                    staff.heightInch = Int32.Parse(this.textBoxHeightInch.Text);
                    }
                    else
                    {
                        staff.heightInch = Int32.Parse(resultHeightinch.ToString());
                    }
                    if(Int32.TryParse(this.textBoxWeight.Text,out resultWeight))
                    {

                    staff.weight = Int32.Parse(this.textBoxWeight.Text);
                    }
                    else
                    {
                        staff.weight = Int32.Parse(resultWeight.ToString());
                    }
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

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
