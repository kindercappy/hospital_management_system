using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalLibrary;

namespace hospitalManagementSystem
{
    public partial class AssignDoctorShifts : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        //int IdShift = 0;
        int Id = 0;

        public AssignDoctorShifts()
        {
            InitializeComponent();
        }

        //METHODS
        //displays shifts
        private void displayShifts()
        {
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Doctor_Shift_Select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewDoctorShift.DataSource = dt;
        }

        //displays doctors
        private void displayDoctor()
        {
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Doctor_Select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewDoctor.DataSource = dt;
        }
        //clears search boxes
        private void clearSearchBoxes()
        {
            textBoxSearchName.Text = "";
            textBoxSearchId.Text = "";
            textBoxSearchPhone.Text = "";
        }
        // set headers of datagridviewDoctor
        private void setDataGridViewDoctorHeaders()
        {
            this.dataGridViewDoctor.Columns[0].HeaderText = "Doctor ID";
            this.dataGridViewDoctor.Columns[1].HeaderText = "First Name";
            this.dataGridViewDoctor.Columns[2].HeaderText = "Last Name";
            this.dataGridViewDoctor.Columns[3].HeaderText = "Department";
            this.dataGridViewDoctor.Columns[4].HeaderText = "Age";
            this.dataGridViewDoctor.Columns[5].HeaderText = "Sex";
            this.dataGridViewDoctor.Columns[6].HeaderText = "Height (Feet)";
            this.dataGridViewDoctor.Columns[7].HeaderText = "Height (Inch)";
            this.dataGridViewDoctor.Columns[8].HeaderText = "Weight";
            this.dataGridViewDoctor.Columns[9].HeaderText = "Phone";
            this.dataGridViewDoctor.Columns[10].HeaderText = "Email";
            this.dataGridViewDoctor.Columns[11].HeaderText = "Address";
            this.dataGridViewDoctor.Columns[12].HeaderText = "Nationality ID";
            this.dataGridViewDoctor.Columns[13].HeaderText = "Doctor Shift ID";
        }
        private void setDataGridViewDoctorShiftHeaders()
        {
            this.dataGridViewDoctorShift.Columns[0].HeaderText = "Shift ID";
            this.dataGridViewDoctorShift.Columns[1].HeaderText = "Shift Name";
            this.dataGridViewDoctorShift.Columns[2].HeaderText = "From";
            this.dataGridViewDoctorShift.Columns[3].HeaderText = "To";
        }
        private void notSortableDataGridViewDoctor()
        {
            
            foreach (DataGridViewColumn col in dataGridViewDoctor.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            
        }
        private void fullRowSelectDataGridViewDoctorShift()
        {
            this.dataGridViewDoctorShift.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        private void AssignDoctorShifts_Load(object sender, EventArgs e)
        {
            displayShifts();
            displayDoctor();
            setDataGridViewDoctorHeaders();
            setDataGridViewDoctorShiftHeaders();
            notSortableDataGridViewDoctor();
            fullRowSelectDataGridViewDoctorShift();
            //dataGridViewDoctor.Columns[0].Visible = false;
            //dataGridViewDoctorShift.Columns[0].Visible = false;
            //ExistingDoctor Depertment comboBox
            this.comboBoxDepartment.DataSource = DepartmentDoctorManager.getDepartmentList();
            this.comboBoxDepartment.DisplayMember = "departmentName";
            this.comboBoxDepartment.ValueMember = "departmentId";

            //ExistingDoctor Nationality comboBox
            this.comboBoxNationality.DataSource = NationalityManager.getNationalityList();
            this.comboBoxNationality.DisplayMember = "nationalityName";
            this.comboBoxNationality.ValueMember = "nationalityId";

            //DoctorShifts Doctor Shifts comboBox
            this.comboBoxDoctorShift.DataSource = DoctorShiftsManager.getDoctorShifts();
            this.comboBoxDoctorShift.DisplayMember = "fullDetails";
            this.comboBoxDoctorShift.ValueMember = "shiftId";
            //sets colour for alternate rowns for dataGridViewDoctor
            this.dataGridViewDoctor.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
            //sets color for alternate rows for datagridviewdoctorshifts
            this.dataGridViewDoctorShift.AlternatingRowsDefaultCellStyle.BackColor = Color.Red;
            //hide Doctor Id column
            this.dataGridViewDoctor.Columns[0].Visible = false;
            //hide shift Id column
            this.dataGridViewDoctorShift.Columns[0].Visible = false;
            //allowUsersToAddRows =false
            this.dataGridViewDoctor.AllowUserToAddRows = false;
            this.dataGridViewDoctorShift.AllowUserToAddRows = false;
            //make datagridview readonly
            this.dataGridViewDoctor.ReadOnly = true;
            this.dataGridViewDoctorShift.ReadOnly = true;
            //datagrid full row select
        }
        //dataGridView Doctor
        private void dataGridViewDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        // Doctor
        //button doctor assign    
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            try
            {
                doctor.doctorId = Id;
                doctor.firstName = this.textBoxFirstName.Text;
                doctor.lastName = this.textBoxLastName.Text;
                doctor.department = Int32.Parse(this.comboBoxDepartment.SelectedValue.ToString());
                doctor.age = Convert.ToInt32(this.textBoxAge.Text);
                doctor.sex = this.comboBoxSex.Text;
                doctor.heightFt = Convert.ToInt32(this.textBoxHeightFt.Text);
                doctor.heightInch = Convert.ToInt32(this.textBoxHeightInch.Text);
                doctor.weight = Convert.ToInt32(this.textBoxWeight.Text);
                doctor.phone = Convert.ToInt64(this.textBoxPhone.Text);
                doctor.email = this.textBoxEmail.Text;
                doctor.address = this.textBoxAddress.Text;
                doctor.natioinality = Int32.Parse(this.comboBoxNationality.SelectedValue.ToString());
                doctor.shift = Int32.Parse(this.comboBoxDoctorShift.SelectedValue.ToString());
                DoctorManager.doctorUpdate(doctor);
                MessageBox.Show("Updated");
                displayDoctor();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        private void dataGridViewAssignDoctorShift_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //button doctor search
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            displayDoctor();
        }

        // Shift
        //button shift search
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBoxShiftSearch.Text.Length > 0)
            {
                using (SqlCommand cmd = new SqlCommand())
                using (SqlDataAdapter da = new SqlDataAdapter())
                    using(DataTable dt = new DataTable())
                {
                    DoctorShifts docshi = new DoctorShifts();
                    cmd.Connection = Common.getConnection();
                    cmd.CommandText = "Doctor_Shift_Search";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //shift name
                    SqlParameter sShiftName = new SqlParameter("@shiftName", textBoxShiftSearch.Text);
                    sShiftName.SqlDbType = System.Data.SqlDbType.NVarChar;
                    cmd.Parameters.Add(sShiftName);

                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dataGridViewDoctorShift.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please enter shift to search");
            }
        }
        //button shift refresh
        private void buttonShiftRefresh_Click(object sender, EventArgs e)
        {
            displayShifts();
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(textBoxSearchName.Text.Length >0 || textBoxSearchId.Text.Length > 0 || textBoxSearchPhone.Text.Length > 0)
                {
                    //search name
                    if (textBoxSearchName.Text.Length > 0)
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        using (DataTable dt = new DataTable())
                        {
                            cmd.Connection = Common.getConnection();
                            cmd.CommandText = "Doctor_Search_Name";
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                            SqlParameter sFirstName = new SqlParameter("@firstName", this.textBoxSearchName.Text);
                            sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
                            cmd.Parameters.Add(sFirstName);

                            da.SelectCommand = cmd;
                            da.Fill(dt);
                            dataGridViewDoctor.DataSource = dt;
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
                            cmd.CommandText = "Doctor_Search_Id";
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                            SqlParameter iStaffId = new SqlParameter("@staffId", this.textBoxSearchId.Text);
                            iStaffId.SqlDbType = System.Data.SqlDbType.Int;
                            cmd.Parameters.Add(iStaffId);

                            da.SelectCommand = cmd;
                            da.Fill(dt);
                            dataGridViewDoctor.DataSource = dt;
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
                            cmd.CommandText = "Doctor_Search_Phone";
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                            SqlParameter bPhone = new SqlParameter("@phone", this.textBoxSearchPhone);
                            bPhone.SqlDbType = System.Data.SqlDbType.BigInt;
                            cmd.Parameters.Add(bPhone);

                            da.SelectCommand = cmd;
                            da.Fill(dt);
                            dataGridViewDoctor.DataSource = dt;
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

        private void buttonRefresh_Click_1(object sender, EventArgs e)
        {
            displayDoctor();
        }

        private void dataGridViewDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewDoctor_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDoctorShift_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewDoctor_SelectionChanged(object sender, EventArgs e)
        {
            
            if(this.dataGridViewDoctor.CurrentRow != null && this.dataGridViewDoctor.CurrentRow.Index != -1)
            {

                try
                {
                    Id = Convert.ToInt32(this.dataGridViewDoctor.CurrentRow.Cells[0].Value.ToString());
                    textBoxFirstName.Text = this.dataGridViewDoctor.CurrentRow.Cells[1].Value.ToString();
                    textBoxLastName.Text = this.dataGridViewDoctor.CurrentRow.Cells[2].Value.ToString();
                    comboBoxDepartment.SelectedValue = Convert.ToInt32(this.dataGridViewDoctor.CurrentRow.Cells[3].Value.ToString());
                    textBoxAge.Text = this.dataGridViewDoctor.CurrentRow.Cells[4].Value.ToString();
                    comboBoxSex.Text = this.dataGridViewDoctor.CurrentRow.Cells[5].Value.ToString();
                    textBoxHeightFt.Text = this.dataGridViewDoctor.CurrentRow.Cells[6].Value.ToString();
                    textBoxHeightInch.Text = this.dataGridViewDoctor.CurrentRow.Cells[7].Value.ToString();
                    textBoxWeight.Text = this.dataGridViewDoctor.CurrentRow.Cells[8].Value.ToString();
                    textBoxPhone.Text = this.dataGridViewDoctor.CurrentRow.Cells[9].Value.ToString();
                    textBoxEmail.Text = this.dataGridViewDoctor.CurrentRow.Cells[10].Value.ToString();
                    textBoxAddress.Text = this.dataGridViewDoctor.CurrentRow.Cells[11].Value.ToString();
                    comboBoxNationality.SelectedValue = Convert.ToInt32(this.dataGridViewDoctor.CurrentRow.Cells[12].Value.ToString());
                    comboBoxDoctorShift.SelectedValue = Convert.ToInt32(this.dataGridViewDoctor.CurrentRow.Cells[13].Value.ToString());
                }
                catch(System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridViewDoctorShift_SelectionChanged(object sender, EventArgs e)
        {
            
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
    }
}
