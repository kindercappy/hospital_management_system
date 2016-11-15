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
    public partial class StaffShifts : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        int idShift = 0;

        public StaffShifts()
        {
            InitializeComponent();
        }
        private void displayStaffShift()
        {
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Staff_Shift_Select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewShifts.DataSource = dt;
        }
        private void StaffShifts_Load(object sender, EventArgs e)
        {
            displayStaffShift();
            //sets alternate rows color of datagridviewsshifts
            this.dataGridViewShifts.AlternatingRowsDefaultCellStyle.BackColor = Color.Red;
        }

        private void buttonNewShift_Click(object sender, EventArgs e)
        {
            StaffShiftsHL staffShift = new StaffShiftsHL();
            try
            {
                staffShift.shiftName = this.textBoxShiftName.Text;
                staffShift.from = TimeSpan.Parse(this.textBoxFrom.Text);
                staffShift.to = TimeSpan.Parse(this.textBoxTo.Text);
                StaffShiftsManager.staffShiftSave(staffShift);
                MessageBox.Show("Success");
                displayStaffShift();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewShifts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewShifts_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewShifts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idShift = Convert.ToInt32(dataGridViewShifts.Rows[e.RowIndex].Cells[0].Value.ToString());
                textBoxShiftName.Text = dataGridViewShifts.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxFrom.Text = dataGridViewShifts.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxTo.Text = dataGridViewShifts.Rows[e.RowIndex].Cells[3].Value.ToString();
            }catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
