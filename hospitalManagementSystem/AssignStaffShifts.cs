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
using System.Data.SqlClient;

namespace hospitalManagementSystem
{
    public partial class AssignStaffShifts : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        int staffId = 0;
        public AssignStaffShifts()
        {
            InitializeComponent();
        }
        //METHODS
        //displays shifts
        private void displayShifts()
        {
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Staff_Shift_Select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewStaffShift.DataSource = dt;
        }
        //displays staff
        private void displayStaff()
        {
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Staff_Select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewStaff.DataSource = dt;
        }
        //clear textBoxSearch Name, ID, Phone
        private void clearSearchBoxes()
        {
            textBoxSearchName.Text = "";
            textBoxSearchId.Text = "";
            textBoxSearchPhone.Text = "";
        }
        private void toUpperCaseLabels()
        {
            labelStaff.Text = labelStaff.Text.ToUpper();
            labelStaffShifts.Text = labelStaffShifts.Text.ToUpper();
        }
        private void AssignStaffShifts_Load(object sender, EventArgs e)
        {           
            try
            {
                //display staff in dataGridView
                displayStaff();
                displayShifts();
                toUpperCaseLabels();
                // Department comboBox
                this.comboBoxDepartment.DisplayMember = "departmentName";
                this.comboBoxDepartment.ValueMember = "departmentId";
                this.comboBoxDepartment.DataSource = DepartmentStaffManager.getDepartmentList();
                // Nationality comboBox
                this.comboBoxNationality.DisplayMember = "nationalityName";
                this.comboBoxNationality.ValueMember = "nationalityId";
                this.comboBoxNationality.DataSource = NationalityManager.getNationalityList();
                // shift combobox
                this.comboBoxStaffShift.DataSource = StaffShiftsManager.getStaffShifts();
                this.comboBoxStaffShift.DisplayMember = "fullDetails";
                this.comboBoxStaffShift.ValueMember = "shiftId";
                //sets colour for alternate rowns for dataGridViewStaff
                this.dataGridViewStaff.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
                //sets colour for laternate rows for datagridviewstaffshift
                this.dataGridViewStaffShift.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
                //Setting comboboxes to -1 index so no item apperas on load
                this.comboBoxDepartment.SelectedIndex = -1;
                this.comboBoxNationality.SelectedIndex = -1;
                this.comboBoxSex.SelectedIndex = -1;
                this.comboBoxStaffShift.SelectedIndex = -1;
                this.labelHeader.Width = this.Width;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxSearchName.Text.Length >0 ||
                    textBoxSearchId.Text.Length > 0 || textBoxSearchPhone.Text.Length > 0)
                {
                    //search name
                    if (textBoxSearchName.Text.Length > 0)
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        using (SqlDataAdapter da = new SqlDataAdapter())
                            using(DataTable dt = new DataTable())
                        {
                            cmd.Connection = Common.getConnection();
                            cmd.CommandText = "Staff_Search_Name";
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                            SqlParameter sFirstName = new SqlParameter("@firstName", this.textBoxSearchName.Text);
                            sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
                            cmd.Parameters.Add(sFirstName);

                            da.SelectCommand = cmd;
                            da.Fill(dt);
                            dataGridViewStaff.DataSource = dt;
                            clearSearchBoxes();
                        }
                    }
                    //search Id
                    if (textBoxSearchId.Text.Length > 0)
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        using (DataTable dt = new DataTable())
                        {
                            cmd.Connection = Common.getConnection();
                            cmd.CommandText = "Staff_Search_Id";
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                            SqlParameter iStaffId = new SqlParameter("@staffId", this.textBoxSearchId.Text);
                            iStaffId.SqlDbType = System.Data.SqlDbType.Int;
                            cmd.Parameters.Add(iStaffId);

                            da.SelectCommand = cmd;
                            da.Fill(dt);
                            dataGridViewStaff.DataSource = dt;
                            clearSearchBoxes();
                        }
                    }
                    //search phone
                    if (textBoxSearchPhone.Text.Length > 0)
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        using (DataTable dt = new DataTable())
                        {
                            cmd.Connection = Common.getConnection();
                            cmd.CommandText = "Staff_Search_Phone";
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                            SqlParameter bPhone = new SqlParameter("@phone", this.textBoxSearchPhone);
                            bPhone.SqlDbType = System.Data.SqlDbType.BigInt;
                            cmd.Parameters.Add(bPhone);

                            da.SelectCommand = cmd;
                            da.Fill(dt);
                            dataGridViewStaff.DataSource = dt;
                            clearSearchBoxes();
                        }
                    }
                }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            displayStaff();
        }
        private void buttonShiftSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxShiftSearch.Text.Length > 0)
                {
                    using (SqlCommand cmd = new SqlCommand())
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    using (DataTable dt = new DataTable())
                    {
                        cmd.Connection = Common.getConnection();
                        cmd.CommandText = "Staff_Shift_Search";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //shift name
                        SqlParameter sShiftName = new SqlParameter("@shiftName", this.textBoxShiftSearch.Text);
                        sShiftName.SqlDbType = System.Data.SqlDbType.NVarChar;
                        cmd.Parameters.Add(sShiftName);

                        da.SelectCommand = cmd;
                        da.Fill(dt);
                        dataGridViewStaffShift.DataSource = dt;
                    }
                }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridViewStaff_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dataGridViewStaff.CurrentRow != null && this.dataGridViewStaff.CurrentRow.Index != -1)
            {
                try
                {
                    staffId = Convert.ToInt32(dataGridViewStaff.CurrentRow.Cells[0].Value.ToString());
                    textBoxFirstName.Text = dataGridViewStaff.CurrentRow.Cells[1].Value.ToString();
                    textBoxLastName.Text = dataGridViewStaff.CurrentRow.Cells[2].Value.ToString();
                    comboBoxDepartment.SelectedValue = Convert.ToInt32(dataGridViewStaff.CurrentRow.Cells[3].Value.ToString());
                    textBoxAge.Text = dataGridViewStaff.CurrentRow.Cells[4].Value.ToString();
                    comboBoxSex.Text = dataGridViewStaff.CurrentRow.Cells[5].Value.ToString();
                    textBoxHeightFt.Text = dataGridViewStaff.CurrentRow.Cells[6].Value.ToString();
                    textBoxHeightInch.Text = dataGridViewStaff.CurrentRow.Cells[7].Value.ToString();
                    textBoxWeight.Text = dataGridViewStaff.CurrentRow.Cells[8].Value.ToString();
                    textBoxPhone.Text = dataGridViewStaff.CurrentRow.Cells[9].Value.ToString();
                    textBoxEmail.Text = dataGridViewStaff.CurrentRow.Cells[10].Value.ToString();
                    textBoxAddress.Text = dataGridViewStaff.CurrentRow.Cells[11].Value.ToString();
                    comboBoxNationality.SelectedValue = Convert.ToInt32(dataGridViewStaff.CurrentRow.Cells[12].Value.ToString());
                    comboBoxStaffShift.SelectedValue = Convert.ToInt32(dataGridViewStaff.CurrentRow.Cells[13].Value.ToString());
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void textBoxSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void textBoxSearchId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBoxSearchPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
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
        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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

        private void AssignStaffShifts_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelSearchPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
