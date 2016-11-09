using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HospitalLibrary;

namespace hospitalManagementSystem
{
    public partial class NewDoctor : Form
    {
        public NewDoctor()
        {
            InitializeComponent();
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
            if(comboBoxDoctorShift.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Select a Shift";
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
                    doc.shift = Int32.Parse(this.comboBoxDoctorShift.SelectedValue.ToString());
                    DoctorManager.doctorSave(doc);
                    MessageBox.Show("Success");
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void NewDoctor_Load(object sender, EventArgs e)
        {
            try
            {   //NewDoctor Department comboBox
                this.comboBoxDepartment.DataSource = DepartmentDoctorManager.getDepartmentList();
                this.comboBoxDepartment.DisplayMember = "departmentName";
                this.comboBoxDepartment.ValueMember = "departmentId";
                //NewDoctor Nationality comboBox
                this.comboBoxNationality.DataSource = NationalityManager.getNationalityList();
                this.comboBoxNationality.DisplayMember = "nationalityName";
                this.comboBoxNationality.ValueMember = "nationalityId";

                //DoctorShifts Doctor Shifts comboBox
                this.comboBoxDoctorShift.DataSource = DoctorShiftsManager.getDoctorShifts();
                this.comboBoxDoctorShift.DisplayMember = "fullDetails";
                this.comboBoxDoctorShift.ValueMember = "shiftId";

                //Setting comboboxes to -1 index so no item apperas on load
                this.comboBoxDepartment.SelectedIndex = -1;
                this.comboBoxDoctorShift.SelectedIndex = -1;
                this.comboBoxNationality.SelectedIndex = -1;
                this.comboBoxSex.SelectedIndex = -1;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
