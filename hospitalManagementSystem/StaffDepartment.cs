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

namespace hospitalManagementSystem
{
    public partial class StaffDepartment : Form
    {
        int staffDepartmentId;

        //METHODS
        private void displayStaffDepartment()
        {
            DataTable dt = new DataTable();
            dt = DepartmentStaffManager.staffDepartmentSelect();
            this.dataGridViewStaffDepartment.DataSource = dt;
        }
        private void notSortableDataGridViewStaffDepartment()
        {
            foreach(DataGridViewColumn col in this.dataGridViewStaffDepartment.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void fullRowSelectDataGridViewStaffDepartment()
        {
            this.dataGridViewStaffDepartment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void setDataGridViewStaffDepartmentHeaders()
        {
            this.dataGridViewStaffDepartment.Columns[0].HeaderText = "Department";
            this.dataGridViewStaffDepartment.Columns[1].HeaderText = "Department ID";
        }
        private void clearTextBoxes()
        {
            this.textBoxDepartmentName.Text = "";
        }
        private void toUpperCaseLabels()
        {
            labelStaffDepartment.Text = labelStaffDepartment.Text.ToUpper();
        }
        public StaffDepartment()
        {
            InitializeComponent();
        }

        private void StaffDepartment_Load(object sender, EventArgs e)
        {
            try
            {
                displayStaffDepartment();
                notSortableDataGridViewStaffDepartment();
                fullRowSelectDataGridViewStaffDepartment();
                setDataGridViewStaffDepartmentHeaders();
                toUpperCaseLabels();
                this.dataGridViewStaffDepartment.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonNewDepatment_Click(object sender, EventArgs e)
        {
            try
            {
                DepartmentStaff depStaff = new DepartmentStaff();
            depStaff.departmentName = this.textBoxDepartmentName.Text;
            DepartmentStaffManager.staffDepartmentInsert(depStaff);
            MessageBox.Show("Success");
            displayStaffDepartment();
            clearTextBoxes();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {

            DepartmentStaff depStaff = new DepartmentStaff();
            depStaff.departmentId = staffDepartmentId;
            depStaff.departmentName = this.textBoxDepartmentName.Text;
            DepartmentStaffManager.staffDepartmentUpdate(depStaff);
            MessageBox.Show("Updated");
            displayStaffDepartment();
            clearTextBoxes();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {

            DepartmentStaff depStaff = new DepartmentStaff();
            depStaff.departmentId = staffDepartmentId;
            DepartmentStaffManager.staffDepartmentDelete(depStaff);
            MessageBox.Show("Success");
            displayStaffDepartment();
            clearTextBoxes();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }
        private void dataGridViewStaffDepartment_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dataGridViewStaffDepartment.CurrentRow != null || this.dataGridViewStaffDepartment.CurrentRow.Index != -1)
            {
                try
                {
                    this.textBoxDepartmentName.Text = this.dataGridViewStaffDepartment.CurrentRow.Cells[0].Value.ToString();
                    staffDepartmentId = Convert.ToInt32(this.dataGridViewStaffDepartment.CurrentRow.Cells[1].Value.ToString());

                }
                catch(System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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

        private void StaffDepartment_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
