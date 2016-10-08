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
            HospitalMain hospitalMain = new HospitalMain();
            hospitalMain.ShowDialog();
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            

            //Doctor sample functionality for textBoxFirstName with sql
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
            DoctorManager.Doctor_Save(doc);
            MessageBox.Show("Success");
            }
            
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
