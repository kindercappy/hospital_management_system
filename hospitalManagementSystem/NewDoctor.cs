﻿using System;
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
            this.comboBoxDoctorShift.SelectedIndex = -1;

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
            if (comboBoxDoctorShift.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Select a Shift";
            }
            //validate email
            if(this.textBoxEmail.Text.Length > 0)
            {
                if (!Common.isValidEmail(this.textBoxEmail.Text))
                {
                    str = str + Environment.NewLine + "Please enter valie Email";
                }
            }
            if (str.Length > 0)
            {
                MessageBox.Show(str + Environment.NewLine + "(REQUIRED)");
            }
            else
            {
                Doctor doc = NewMethod();
                try
                {
                    doc.firstName = this.textBoxFirstName.Text;
                    doc.lastName = this.textBoxLastName.Text;
                    doc.department = Int32.Parse(this.comboBoxDepartment.SelectedValue.ToString());
                    doc.age = Convert.ToInt32(this.textBoxAge.Text);
                    doc.sex = this.comboBoxSex.Text;
                    //heightFt
                    if (Int32.TryParse(textBoxHeightFt.Text, out int resultHeightFt))
                    {
                        doc.heightFt = Int32.Parse(this.textBoxHeightFt.Text);
                    }
                    else
                    {
                        doc.heightFt = Int32.Parse(resultHeightFt.ToString());
                    }
                    //heightInch
                    if (Int32.TryParse(textBoxHeightInch.Text, out int resultHeightInch))
                    {
                        doc.heightInch = Int32.Parse(this.textBoxHeightInch.Text);
                    }
                    else
                    {
                        doc.heightInch = Int32.Parse(resultHeightInch.ToString());
                    }
                    //weight
                    if (Decimal.TryParse(this.textBoxWeight.Text, out decimal resultWeight))
                    {
                        doc.weight = Convert.ToDecimal(this.textBoxWeight.Text);
                    }
                    else
                    {
                        doc.weight = Convert.ToDecimal(resultWeight.ToString());
                    }

                    //phone
                    if (Int64.TryParse(this.textBoxPhone.Text, out long resultPhone))
                    {
                        doc.phone = Int64.Parse(this.textBoxPhone.Text);
                    }
                    else
                    {
                        doc.phone = Int64.Parse(resultPhone.ToString());
                    }
                    doc.email = this.textBoxEmail.Text;
                    doc.address = this.textBoxAddress.Text;
                    doc.natioinality = Int32.Parse(this.comboBoxNationality.SelectedValue.ToString());
                    doc.shift = Int32.Parse(this.comboBoxDoctorShift.SelectedValue.ToString());
                    DoctorManager.doctorSave(doc);
                    MessageBox.Show("Success");
                    clearData();
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private static Doctor NewMethod()
        {
            return new Doctor();
        }

        private void NewDoctor_Load(object sender, EventArgs e)
        {
            try
            {
                entries();
                //NewDoctor Department comboBox
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
                this.labelHeader.Width = this.Width;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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

        private void NewDoctor_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
