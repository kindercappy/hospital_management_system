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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //HospitalMain hospitalMain = new HospitalMain();
            //hospitalMain.ShowDialog();
            //this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
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
                StaffManager.Staff_Save(staff);
                MessageBox.Show("Success");
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
