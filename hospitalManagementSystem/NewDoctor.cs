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
            //Doctor doc = new Doctor();
            //doc.firstName = this.textBoxFirstName.Text;
            //DoctorManager.Doctor_Save(doc);
            //Doctor doc = new Doctor();
            //doc.department = this.comboBoxDepartment.Text;
            //DoctorManager.Doctor_Save(doc.);
            
        }

        private void NewDoctor_Load(object sender, EventArgs e)
        {
            try
            {
                this.comboBoxDepartment.DataSource = DepartmentManager.getDepartmentList();
                this.comboBoxDepartment.DisplayMember = "departmentName";
                this.comboBoxDepartment.ValueMember = "departmentId";

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //try { 
            //this.comboBoxDepartment.DataSource = 
            //this.comboBoxDepartment.DisplayMember = "DepartmentName";
            //this.comboBoxDepartment.ValueMember = "DepartmentID";
            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
