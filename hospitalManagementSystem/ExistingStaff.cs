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
        int staffId = 0;

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
            this.textBoxFirstName.Text = "";
            this.textBoxLastName.Text = "";
            this.textBoxAge.Text = "";
            this.textBoxHeightFt.Text = "";
            this.textBoxHeightInch.Text = "";
            this.textBoxPhone.Text = "";
            this.textBoxWeight.Text = "";
            this.textBoxEmail.Text = "";
            this.textBoxAddress.Text = "";
            staffId = 0;
            this.comboBoxDepartment.SelectedIndex = -1;
            this.comboBoxNationality.SelectedIndex = -1;
            this.comboBoxSex.SelectedIndex = -1;
            this.comboBoxStaffShift.SelectedIndex = -1;
        }
        //set headers of datGridViewExsitingStaff
        private void setDataGridViewStaffHeaders()
        {
            this.dataGridViewExistingStaff.Columns[0].HeaderText = "Staff ID";
            this.dataGridViewExistingStaff.Columns[1].HeaderText = "First Name";
            this.dataGridViewExistingStaff.Columns[2].HeaderText = "Last Name";
            this.dataGridViewExistingStaff.Columns[3].HeaderText = "Department";
            this.dataGridViewExistingStaff.Columns[4].HeaderText = "Age";
            this.dataGridViewExistingStaff.Columns[5].HeaderText = "Sex";
            this.dataGridViewExistingStaff.Columns[6].HeaderText = "Height (Feet)";
            this.dataGridViewExistingStaff.Columns[7].HeaderText = "Height (Inch)";
            this.dataGridViewExistingStaff.Columns[8].HeaderText = "Weight";
            this.dataGridViewExistingStaff.Columns[9].HeaderText = "Phone";
            this.dataGridViewExistingStaff.Columns[10].HeaderText = "Email";
            this.dataGridViewExistingStaff.Columns[11].HeaderText = "Address";
            this.dataGridViewExistingStaff.Columns[12].HeaderText = "Nationality ID";
            this.dataGridViewExistingStaff.Columns[13].HeaderText = "Staff Shift ID";
        }
        private void notSortableDataGridViewExsitingStaff()
        {
            foreach(DataGridViewColumn col in dataGridViewExistingStaff.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExistingStaff_Load(object sender, EventArgs e)
        {
            
                //display staff in dataGridView
                displayStaff();
                //sets header for dataGridViewExistingStaff
                setDataGridViewStaffHeaders();
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
                //hide shift ID column
                this.dataGridViewExistingStaff.Columns[0].Visible = false;
                //datagridview full row select
                this.dataGridViewExistingStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //allowUsersToAddRows = false;
                this.dataGridViewExistingStaff.AllowUserToAddRows = false;
                //make dataGriDViewExistingStaff read only
                this.dataGridViewExistingStaff.ReadOnly = true;
                //Setting comboboxes to -1 index so no item apperas on load
                this.comboBoxDepartment.SelectedIndex = -1;
                this.comboBoxNationality.SelectedIndex = -1;
                this.comboBoxSex.SelectedIndex = -1;
                this.comboBoxStaffShift.SelectedIndex = -1;

                notSortableDataGridViewExsitingStaff();
            
        }


        //dataGridView cellContentClick
        private void dataGridViewExistingStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                    staff.staffId = Int32.Parse(this.comboBoxStaffShift.SelectedValue.ToString());
                    staff.staffShift = Int32.Parse(this.comboBoxStaffShift.SelectedValue.ToString());
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
                staff.staffId = staffId;
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
                staff.staffShift = Int32.Parse(this.comboBoxStaffShift.SelectedValue.ToString());
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
            Staff staff = new Staff();
            try
            {
                staff.staffId = staffId;
                StaffManager.staffDelete(staff);
                MessageBox.Show("Deleted");
                displayStaff();
                clearData();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewExistingStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewExistingStaff_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dataGridViewExistingStaff.CurrentRow !=null && this.dataGridViewExistingStaff.CurrentRow.Index != -1)
            {
                try
                {
                    staffId = Convert.ToInt32(this.dataGridViewExistingStaff.CurrentRow.Cells[0].Value.ToString());
                    textBoxFirstName.Text = this.dataGridViewExistingStaff.CurrentRow.Cells[1].Value.ToString();
                    textBoxLastName.Text = this.dataGridViewExistingStaff.CurrentRow.Cells[2].Value.ToString();
                    comboBoxDepartment.SelectedValue = Convert.ToInt32(this.dataGridViewExistingStaff.CurrentRow.Cells[3].Value.ToString());
                    textBoxAge.Text = this.dataGridViewExistingStaff.CurrentRow.Cells[4].Value.ToString();
                    comboBoxSex.Text = this.dataGridViewExistingStaff.CurrentRow.Cells[5].Value.ToString();
                    textBoxHeightFt.Text = this.dataGridViewExistingStaff.CurrentRow.Cells[6].Value.ToString();
                    textBoxHeightInch.Text = this.dataGridViewExistingStaff.CurrentRow.Cells[7].Value.ToString();
                    textBoxWeight.Text = this.dataGridViewExistingStaff.CurrentRow.Cells[8].Value.ToString();
                    textBoxPhone.Text = this.dataGridViewExistingStaff.CurrentRow.Cells[9].Value.ToString();
                    textBoxEmail.Text = this.dataGridViewExistingStaff.CurrentRow.Cells[10].Value.ToString();
                    textBoxAddress.Text = this.dataGridViewExistingStaff.CurrentRow.Cells[11].Value.ToString();
                    comboBoxNationality.SelectedValue = Convert.ToInt32(this.dataGridViewExistingStaff.CurrentRow.Cells[12].Value.ToString());
                    comboBoxStaffShift.SelectedValue = Convert.ToInt32(this.dataGridViewExistingStaff.CurrentRow.Cells[13].Value.ToString());
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
