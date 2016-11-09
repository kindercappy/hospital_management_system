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
        int IdShift = 0;
        public DoctorShifts()
        {
            InitializeComponent();
            displayDoctor();
            displayDataShifts();
            this.dataGridViewShifts.Columns[0].Visible = false;
        }
        //METHODS

        //display data for doctorShiftsDataGrid
        private void displayDataShifts()
        {
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Doctor_Shift_Select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewShifts.DataSource = dt;
        }
        //displays data for doctorDataGrid
        private void displayDoctor()
        {
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Doctor_Select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            
        }

        private void reloadForm()
        {
            
            dataGridViewShifts.Update();
        }

        private void DoctorShifts_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewDoctorShifts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonNewShift_Click(object sender, EventArgs e)
        {
            DoctorShiftsHL docshi = new DoctorShiftsHL();
            try
            {
                docshi.shiftName = textBoxShiftsName.Text;
                docshi.from = TimeSpan.Parse(textBoxFrom.Text);
                docshi.to = TimeSpan.Parse(textBoxTo.Text);
                DoctorShiftsManager.doctorShiftSave(docshi);
                MessageBox.Show("Success");
                displayDataShifts();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                docshi.shiftId = IdShift;
                docshi.shiftName = textBoxShiftsName.Text;
                docshi.from = TimeSpan.Parse(textBoxFrom.Text);
                docshi.to = TimeSpan.Parse(textBoxTo.Text);
                DoctorShiftsManager.doctorShiftUpdate(docshi);
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
                docshi.shiftId = IdShift;
                DoctorShiftsManager.doctorShiftDelete(docshi);
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
