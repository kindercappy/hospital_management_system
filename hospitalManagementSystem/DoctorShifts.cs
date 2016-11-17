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
        private void setDataGridViewShiftsHeaders()
        {
            this.dataGridViewShifts.Columns[0].HeaderText = "Shift ID";
            this.dataGridViewShifts.Columns[1].HeaderText = "Shift Name";
            this.dataGridViewShifts.Columns[2].HeaderText = "From";
            this.dataGridViewShifts.Columns[3].HeaderText = "To";

        }
        private void notSortableDataGridViewShifts()
        {
            foreach(DataGridViewColumn col in dataGridViewShifts.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void reloadForm()
        {
            
            dataGridViewShifts.Update();
        }

        private void DoctorShifts_Load(object sender, EventArgs e)
        {
            displayDoctor();
            displayDataShifts();
            setDataGridViewShiftsHeaders();
            notSortableDataGridViewShifts();
            this.dataGridViewShifts.Columns[0].Visible = false;
            //sets alternate color of datagridviewshifts
            this.dataGridViewShifts.AlternatingRowsDefaultCellStyle.BackColor = Color.Red;
            //datagridview shifts full row select
            this.dataGridViewShifts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void dataGridViewShifts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewShifts_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dataGridViewShifts.CurrentRow != null && this.dataGridViewShifts.CurrentRow.Index != -1)
            {
                try
                {
                    IdShift = Convert.ToInt32(dataGridViewShifts.CurrentRow.Cells[0].Value.ToString());
                    textBoxShiftsName.Text = dataGridViewShifts.CurrentRow.Cells[1].Value.ToString();
                    textBoxFrom.Text = dataGridViewShifts.CurrentRow.Cells[2].Value.ToString();
                    textBoxTo.Text = dataGridViewShifts.CurrentRow.Cells[3].Value.ToString();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
