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
        //METHODS
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
        //disable datagridviewshifts sorting
        private void dataGridViewShiftsNotSortable()
        {
            foreach(DataGridViewColumn col in dataGridViewShifts.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        //set header datafridview shifts
        private void setHeaderDataGridViewShifts()
        {
            this.dataGridViewShifts.Columns[0].HeaderText = "Shift ID";
            this.dataGridViewShifts.Columns[1].HeaderText = "Shift Name";
            this.dataGridViewShifts.Columns[2].HeaderText = "From";
            this.dataGridViewShifts.Columns[3].HeaderText = "To";
        }
        //datagridviewShifts not sortable
        private void notSortableDataGridViewShifts()
        {
            foreach(DataGridViewColumn col in dataGridViewShifts.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void clearTextBoxes()
        {
            this.textBoxShiftName.Text = "";
            this.textBoxFrom.Text = "";
            this.textBoxTo.Text = "";
        }
        private void clearSearchBoxes()
        {
            this.textBoxSearchName.Text = "";
            this.textBoxSearchId.Text = "";
        }

        private void StaffShifts_Load(object sender, EventArgs e)
        {
            //sets alternate rows color of datagridviewsshifts
            this.dataGridViewShifts.AlternatingRowsDefaultCellStyle.BackColor = Color.Red;
            //disable datagrid sorting header
            this.dataGridViewShifts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //datagridviewshifts read only
            this.dataGridViewShifts.ReadOnly = true;
            displayStaffShift();
            dataGridViewShiftsNotSortable();
            setHeaderDataGridViewShifts();
            notSortableDataGridViewShifts();
            clearTextBoxes();

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
            
        }

        private void dataGridViewShifts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(dataGridViewShifts.CurrentRow != null && dataGridViewShifts.CurrentRow.Index != -1)
                {
                    idShift = Convert.ToInt32(dataGridViewShifts.CurrentRow.Cells[0].Value.ToString());
                    textBoxShiftName.Text = dataGridViewShifts.CurrentRow.Cells[1].Value.ToString();
                    textBoxFrom.Text = dataGridViewShifts.CurrentRow.Cells[2].Value.ToString();
                    textBoxTo.Text = dataGridViewShifts.CurrentRow.Cells[3].Value.ToString();
                }      
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClearTextboxes_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.textBoxSearchName.Text.Length >0 ||this.textBoxSearchId.Text.Length > 0)
                {
                    //search by name
                    if (this.textBoxSearchName.Text.Length > 0)
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        using (DataTable dt = new DataTable())
                        {
                            cmd.Connection = Common.getConnection();
                            cmd.CommandText = "Staff_Shift_Search_Name";
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                            SqlParameter sShiftName = new SqlParameter("@shiftName", this.textBoxSearchName.Text);
                            sShiftName.SqlDbType = System.Data.SqlDbType.NVarChar;
                            cmd.Parameters.Add(sShiftName);

                            da.SelectCommand = cmd;
                            da.Fill(dt);
                            dataGridViewShifts.DataSource = dt;
                            clearSearchBoxes();
                        }
                    }
                    if (this.textBoxSearchId.Text.Length > 0)
                    {
                        //search by id
                        using (SqlCommand cmd = new SqlCommand())
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        using (DataTable dt = new DataTable())
                        {
                            cmd.Connection = Common.getConnection();
                            cmd.CommandText = "Staff_Shift_Search_Id";
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                            SqlParameter iShiftId = new SqlParameter("@shiftId", this.textBoxSearchId.Text);
                            iShiftId.SqlDbType = System.Data.SqlDbType.Int;
                            cmd.Parameters.Add(iShiftId);

                            da.SelectCommand = cmd;
                            da.Fill(dt);
                            dataGridViewShifts.DataSource = dt;
                            clearSearchBoxes();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please enter a value to search!");
                }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            displayStaffShift();
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
    }
}
