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

        private void AssignDoctorShifts_Load(object sender, EventArgs e)
        {
            displayShifts();
            displayDoctor();
            dataGridViewDoctor.Columns[0].Visible = false;
            dataGridViewDoctorShift.Columns[0].Visible = false;
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
        }
        //dataGridView Doctor
        private void dataGridViewDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridViewDoctor.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxFirstName.Text = dataGridViewDoctor.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridViewDoctor.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxDepartment.SelectedValue = Convert.ToInt32(dataGridViewDoctor.Rows[e.RowIndex].Cells[3].Value.ToString());
            textBoxAge.Text = dataGridViewDoctor.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBoxSex.Text = dataGridViewDoctor.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxHeightFt.Text = dataGridViewDoctor.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBoxHeightInch.Text = dataGridViewDoctor.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBoxWeight.Text = dataGridViewDoctor.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBoxPhone.Text = dataGridViewDoctor.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBoxEmail.Text = dataGridViewDoctor.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBoxAddress.Text = dataGridViewDoctor.Rows[e.RowIndex].Cells[11].Value.ToString();
            comboBoxNationality.SelectedValue = Convert.ToInt32(dataGridViewDoctor.Rows[e.RowIndex].Cells[12].Value.ToString());
            comboBoxDoctorShift.SelectedValue = Convert.ToInt32(dataGridViewDoctor.Rows[e.RowIndex].Cells[13].Value.ToString());

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
            if (textBoxSearch.Text.Length > 0)
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    Doctor doctor = new Doctor();
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    cmd.Connection = Common.getConnection();
                    cmd.CommandText = "Doctor_Search";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter sFirstName = new SqlParameter("@firstName", textBoxSearch.Text);
                    sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
                    cmd.Parameters.Add(sFirstName);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dataGridViewDoctor.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please enter doctor to search");
            }
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
    }
}
