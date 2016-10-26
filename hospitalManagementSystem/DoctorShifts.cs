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
    public partial class DoctorShifts : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        int IdDoc = 0;
        int IdShift = 0;
        public DoctorShifts()
        {
            InitializeComponent();
            displayData();
            displayDataShifts();
            this.dataGridViewShifts.Columns[0].Visible = false;
            this.dataGridViewDoctorShifts.Columns[0].Visible = false;
        }
        //METHODS

        //display data for doctorShiftsDataGrid
        private void displayDataShifts()
        {
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Doctor_Shifts_Select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewShifts.DataSource = dt;
        }
        //displays data for doctorDataGrid
        private void displayData()
        {
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Doctor_Select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewDoctorShifts.DataSource = dt;
        }

        private void reloadForm()
        {
            comboBoxShifts.Refresh();
            dataGridViewShifts.Update();
        }

        private void DoctorShifts_Load(object sender, EventArgs e)
        {
            //DoctorShifts Depertment comboBox
            this.comboBoxDepartment.DataSource = DepartmentDoctorManager.getDepartmentList();
            this.comboBoxDepartment.DisplayMember = "departmentName";
            this.comboBoxDepartment.ValueMember = "departmentId";

            //DoctorShifts Nationality comboBox
            this.comboBoxNationality.DataSource = NationalityManager.getNationalityList();
            this.comboBoxNationality.DisplayMember = "nationalityName";
            this.comboBoxNationality.ValueMember = "nationalityId";

            //DoctorShifts Doctor Shifts comboBox
            this.comboBoxShifts.DataSource = DoctorShiftsManager.getDoctorShifts();
            this.comboBoxShifts.DisplayMember = "fullDetails";
            this.comboBoxShifts.ValueMember = "shiftsId";
        }

        private void dataGridViewDoctorShifts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdDoc = Convert.ToInt32(dataGridViewDoctorShifts.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxFirstName.Text = dataGridViewDoctorShifts.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridViewDoctorShifts.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxDepartment.SelectedValue = Convert.ToInt32(dataGridViewDoctorShifts.Rows[e.RowIndex].Cells[3].Value.ToString());
            textBoxAge.Text = dataGridViewDoctorShifts.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBoxSex.Text = dataGridViewDoctorShifts.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxHeightFt.Text = dataGridViewDoctorShifts.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBoxHeightInch.Text = dataGridViewDoctorShifts.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBoxWeight.Text = dataGridViewDoctorShifts.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBoxPhone.Text = dataGridViewDoctorShifts.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBoxEmail.Text = dataGridViewDoctorShifts.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBoxAddress.Text = dataGridViewDoctorShifts.Rows[e.RowIndex].Cells[11].Value.ToString();
            comboBoxNationality.SelectedValue = Convert.ToInt32(dataGridViewDoctorShifts.Rows[e.RowIndex].Cells[12].Value.ToString());
        }

        private void buttonNewShift_Click(object sender, EventArgs e)
        {
            DoctorShiftsHL docshi = new DoctorShiftsHL();
            //try
            //{
                docshi.shiftsName = textBoxShiftsName.Text;
                docshi.from =TimeSpan.Parse(textBoxFrom.Text);
                docshi.to = TimeSpan.Parse(textBoxTo.Text);
                DoctorShiftsManager.doctorShiftsSave(docshi);
                MessageBox.Show("Success");
                
                displayDataShifts();
            //}
            //catch (System.Exception ex)
            //{
                //MessageBox.Show(ex.Message);
            //}
        }

        private void dataGridViewShifts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdShift = Convert.ToInt32(dataGridViewShifts.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxShiftsName.Text = dataGridViewShifts.Rows[e.RowIndex].Cells[1].Value.ToString();

            textBoxFrom.Text = dataGridViewShifts.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxTo.Text = dataGridViewShifts.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void comboBoxShifts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateShift_Click(object sender, EventArgs e)
        {
            DoctorShiftsHL docshi = new DoctorShiftsHL();
            try
            {
                docshi.shiftsId = IdShift;
                docshi.shiftsName = textBoxShiftsName.Text;
                docshi.from = TimeSpan.Parse(textBoxFrom.Text);
                docshi.to = TimeSpan.Parse(textBoxTo.Text);
                DoctorShiftsManager.doctorShiftsUpdate(docshi);
                MessageBox.Show("Success");
                displayDataShifts();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteShift_Click(object sender, EventArgs e)
        {
            DoctorShiftsHL docshi = new DoctorShiftsHL();
            try
            {
                docshi.shiftsId = IdShift;
                DoctorShiftsManager.doctorShiftsDelete(docshi);
                MessageBox.Show("Deleted");
                displayDataShifts();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
