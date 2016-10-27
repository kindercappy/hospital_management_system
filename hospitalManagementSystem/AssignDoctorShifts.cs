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
        int IdShift = 0;
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
            dataGridViewAssignDoctorShift.DataSource = dt;
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
            this.comboBoxDoctorShift.ValueMember = "shiftsId";
        }

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
            //if (comboBoxDoctorShift.SelectedValue == null)
            //{
            //    MessageBox.Show("Enter shift");
            //}
            //else
            //{
            //    comboBoxDoctorShift.SelectedValue = Convert.ToInt32(dataGridViewDoctor.Rows[e.RowIndex].Cells[13].Value.ToString());
            //}

        }
            
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
                DoctorManager.doctorSaveShift(doctor);
                MessageBox.Show("Updates");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        private void dataGridViewAssignDoctorShift_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
