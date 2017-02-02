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
        private void clearSearchBoxes()
        {
            this.textBoxSearchName.Text = "";
            this.textBoxSearchId.Text = "";
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
        private void toUpperCaseLabels()
        {
            labelShifts.Text = labelShifts.Text.ToUpper();
        }


        private void DoctorShifts_Load(object sender, EventArgs e)
        {
            displayDoctor();
            displayDataShifts();
            setDataGridViewShiftsHeaders();
            notSortableDataGridViewShifts();
            toUpperCaseLabels();
            //this.dataGridViewShifts.Columns[0].Visible = false;
            //sets alternate color of datagridviewshifts
            this.dataGridViewShifts.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
            //datagridview shifts full row select
            this.dataGridViewShifts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.labelHeader.Width = this.Width;
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(this.textBoxSearchName.Text.Length>0 || this.textBoxSearchId.Text.Length > 0)
            {
                //Search by Name
                if (this.textBoxSearchName.Text.Length > 0)
                {
                    DoctorShiftsHL docShi = new DoctorShiftsHL();
                    docShi.shiftName = this.textBoxSearchName.Text;
                    DataTable dt = new DataTable();
                    dt = DoctorShiftsManager.getDoctorShiftListByName(docShi);
                    dataGridViewShifts.DataSource = dt;
                    clearSearchBoxes();
                }
                //Search by Id
                if (this.textBoxSearchId.Text.Length > 0)
                {
                    DoctorShiftsHL docShi = new DoctorShiftsHL();
                    docShi.shiftId = Convert.ToInt32(this.textBoxSearchId.Text);
                    DataTable dt = new DataTable();
                    dt = DoctorShiftsManager.getDoctorShiftListById(docShi);
                    dataGridViewShifts.DataSource = dt;
                    clearSearchBoxes();                   
                }
             }
            else
            {
                MessageBox.Show("Please enter a value to search!");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            displayDataShifts();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void DoctorShifts_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
