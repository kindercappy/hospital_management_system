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
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxAge.Text = "";
            textBoxHeightFt.Text = "";
            textBoxHeightInch.Text = "";
            textBoxPhone.Text = "";
            textBoxWeight.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
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
                Staff staff = new Staff();
                try
                {
                    staff.firstName = this.textBoxFirstName.Text;
                    staff.lastName = this.textBoxLastName.Text;
                    staff.department = Int32.Parse(this.comboBoxDepartment.SelectedValue.ToString());
                    staff.age = Convert.ToInt32(this.textBoxAge.Text);
                    staff.sex = this.comboBoxSex.Text;
                    staff.heightFt = Convert.ToInt32(this.textBoxHeightFt.Text);
                    staff.heightInch = Convert.ToInt32(this.textBoxHeightInch.Text);
                    staff.weight = Convert.ToInt32(this.textBoxWeight.Text);
                    staff.phone = Convert.ToInt64(this.textBoxPhone.Text);
                    staff.email = this.textBoxEmail.Text;
                    staff.address = this.textBoxAddress.Text;
                    staff.natioinality = Int32.Parse(this.comboBoxNationality.SelectedValue.ToString());
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
