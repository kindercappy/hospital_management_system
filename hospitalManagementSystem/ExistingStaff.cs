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
    public partial class ExistingStaff : Form
    {
        //SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        int Id = 0;

        public ExistingStaff()
        {
            InitializeComponent();
            
            
        }
        // METHODS
        //display staff in dataGridView
        private void displayStaff()
        {
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Staff_Select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewExistingStaff.DataSource = dt;
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
            Id = 0;
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExistingStaff_Load(object sender, EventArgs e)
        {
            try
            {
                //display staff in dataGridView
                displayStaff();
                //ExistingStaff Department comboBox
                this.comboBoxDepartment.DisplayMember = "departmentName";
                this.comboBoxDepartment.ValueMember = "departmentId";
                this.comboBoxDepartment.DataSource = DepartmentDoctorManager.getDepartmentList();
                //ExistingStaff Nationality comboBox
                this.comboBoxNationality.DisplayMember = "nationalityName";
                this.comboBoxNationality.ValueMember = "nationalityId";
                this.comboBoxNationality.DataSource = NationalityManager.getNationalityList();
                //Staff shifts combobox
                this.comboBoxStaffShift.DataSource = StaffShiftsManager.getStaffShifts();
                this.comboBoxStaffShift.DisplayMember = "fullDetails";
                this.comboBoxStaffShift.ValueMember = "shiftId";
                //sets colour for alternate rowns for dataGridViewExsitingDoctor
                this.dataGridViewExistingStaff.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;
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


        //dataGridView cellContentClick
        private void dataGridViewExistingStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridViewExistingStaff.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxFirstName.Text = dataGridViewExistingStaff.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridViewExistingStaff.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxDepartment.SelectedValue = Convert.ToInt32(dataGridViewExistingStaff.Rows[e.RowIndex].Cells[3].Value.ToString());
            textBoxAge.Text = dataGridViewExistingStaff.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBoxSex.Text = dataGridViewExistingStaff.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxHeightFt.Text = dataGridViewExistingStaff.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBoxHeightInch.Text = dataGridViewExistingStaff.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBoxWeight.Text = dataGridViewExistingStaff.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBoxPhone.Text = dataGridViewExistingStaff.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBoxEmail.Text = dataGridViewExistingStaff.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBoxAddress.Text = dataGridViewExistingStaff.Rows[e.RowIndex].Cells[11].Value.ToString();
            comboBoxNationality.SelectedValue = Convert.ToInt32(dataGridViewExistingStaff.Rows[e.RowIndex].Cells[12].Value.ToString());
            comboBoxStaffShift.SelectedValue = Convert.ToInt32(dataGridViewExistingStaff.Rows[e.RowIndex].Cells[13].Value.ToString());
        }

        private void buttonInsert_Click(object sender, EventArgs e)
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
                //Insert the patient data here
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
                    displayStaff();
                    clearData();
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //updates staff data
            Staff staff = new Staff();
            try
            {
                staff.staffId = Id;
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

                StaffManager.staffUpdate(staff);
                MessageBox.Show("Success");
                displayStaff();
                clearData();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
        //    cmd = new SqlCommand("DELETE StaffSample WHERE Id=@Id", con);
        //    cmd.Connection = Common.getConnection();
        //    cmd.Parameters.AddWithValue("@Id", Id);
        //    cmd.ExecuteNonQuery();
        //    MessageBox.Show("Deleted");
        //    displayStaffShift();
        //    clearData();
        }
    }
}
