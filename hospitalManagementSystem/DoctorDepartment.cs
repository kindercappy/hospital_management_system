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
    public partial class DoctorDepartment : Form
    {
        int doctorDepartmentId;
        //METODS
        private void clearTextBoxes()
        {
            this.textBoxDepartmentName.Text = "";
        }
        private void displayDoctorDepartment()
        {
            DataTable dt = new DataTable();
            dt = DepartmentDoctorManager.doctorDepartmentSelect();
            this.dataGridViewDoctorDepartment.DataSource = dt;
        }
        private void notSortableDataGridViewDoctorDepartment()
        {
            foreach (DataGridViewColumn col in this.dataGridViewDoctorDepartment.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void fullRowSelectDataGridViewStaffDepartment()
        {
            this.dataGridViewDoctorDepartment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void setDataGridViewStaffDepartmentHeaders()
        {
            this.dataGridViewDoctorDepartment.Columns[0].HeaderText = "Department";
            this.dataGridViewDoctorDepartment.Columns[1].HeaderText = "Department ID";
        }
        private void toUpperCaseLabels()
        {
            labelDoctorDepartment.Text = labelDoctorDepartment.Text.ToUpper();
        }
        public DoctorDepartment()
        {
            InitializeComponent();
        }
        private void DoctorDepartment_Load(object sender, EventArgs e)
        {
            displayDoctorDepartment();
            notSortableDataGridViewDoctorDepartment();
            fullRowSelectDataGridViewStaffDepartment();
            setDataGridViewStaffDepartmentHeaders();
            toUpperCaseLabels();
            this.dataGridViewDoctorDepartment.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
        }
        private void buttonNewDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                DepartmentDoctor depDoc = new DepartmentDoctor();
                depDoc.departmentName = this.textBoxDepartmentName.Text;
                DepartmentDoctorManager.doctorDepartmentInsert(depDoc);
                MessageBox.Show("Success");
                displayDoctorDepartment();
                clearTextBoxes();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DepartmentDoctor depDoc = new DepartmentDoctor();
                depDoc.departmentId = doctorDepartmentId;
                depDoc.departmentName = this.textBoxDepartmentName.Text;
                DepartmentDoctorManager.doctorDepartmentUpdate(depDoc);
                MessageBox.Show("Updated");
                displayDoctorDepartment();
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
                DepartmentDoctor depDoc = new DepartmentDoctor();
                depDoc.departmentId = doctorDepartmentId;
                DepartmentDoctorManager.doctorDepartmentDelete(depDoc);
                MessageBox.Show("Deleted");
                displayDoctorDepartment();
                clearTextBoxes();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            try
            {

                clearTextBoxes();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridViewDoctorDepartment_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewDoctorDepartment.CurrentRow != null && this.dataGridViewDoctorDepartment.CurrentRow.Index != -1)
            {

                try
                {
                    this.textBoxDepartmentName.Text = this.dataGridViewDoctorDepartment.CurrentRow.Cells[0].Value.ToString();
                    doctorDepartmentId = Convert.ToInt32(this.dataGridViewDoctorDepartment.CurrentRow.Cells[1].Value.ToString());

                }
                catch (System.Exception ex)
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

        private void DoctorDepartment_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
