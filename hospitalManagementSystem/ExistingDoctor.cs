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
    public partial class ExistingDoctor : Form
    {
        //SqlDataAdapter da;
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        int Id = 0;

        public ExistingDoctor()
        {
            InitializeComponent();
            this.Text = "Existing Doctor";
        }

        // METHODS

        //display data in dataGridView
        private void displayDoctor()
        {
            dataGridViewExistingDoctor.DataSource = DoctorManager.getDoctorList();
        }
        //clear data
        private void clearAllBoxes()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxAge.Text = "";
            textBoxHeightFt.Text = "";
            textBoxHeightInch.Text = "";
            textBoxPhone.Text = "";
            textBoxWeight.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
            Id = 0;
            comboBoxDepartment.SelectedIndex = -1;
            comboBoxDoctorShift.SelectedIndex = -1;
            comboBoxNationality.SelectedIndex = -1;
            comboBoxSex.SelectedIndex = -1;
            //comboBoxSex.SelectedIndex = -1;

        }
        private void clearSearchBoxes()
        {
            this.textBoxSearchName.Text = "";
            this.textBoxSearchId.Text = "";
            this.textBoxSearchPhone.Text = "";
        }
        private void notSortableDataGridViewExistingDoctor()
        {
            foreach(DataGridViewColumn col in this.dataGridViewExistingDoctor.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void setdatGridViewEixsitngHeaders()
        {
            this.dataGridViewExistingDoctor.Columns[0].HeaderText = "Doctor ID";
            this.dataGridViewExistingDoctor.Columns[1].HeaderText = "First Name";
            this.dataGridViewExistingDoctor.Columns[2].HeaderText = "Last Name";
            this.dataGridViewExistingDoctor.Columns[3].HeaderText = "Department";
            this.dataGridViewExistingDoctor.Columns[4].HeaderText = "Age";
            this.dataGridViewExistingDoctor.Columns[5].HeaderText = "Sex";
            this.dataGridViewExistingDoctor.Columns[6].HeaderText = "Height (Feet)";
            this.dataGridViewExistingDoctor.Columns[7].HeaderText = "Height (Inch)";
            this.dataGridViewExistingDoctor.Columns[8].HeaderText = "Weight";
            this.dataGridViewExistingDoctor.Columns[9].HeaderText = "Phone";
            this.dataGridViewExistingDoctor.Columns[10].HeaderText = "Email";
            this.dataGridViewExistingDoctor.Columns[11].HeaderText = "Address";
            this.dataGridViewExistingDoctor.Columns[12].HeaderText = "Nationality ID";
            this.dataGridViewExistingDoctor.Columns[13].HeaderText = "Doctor Shift";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void ExistingDoctor_Load(object sender, EventArgs e)
        {
            try
            {
                displayDoctor();
                notSortableDataGridViewExistingDoctor();
                setdatGridViewEixsitngHeaders();
                //this.dataGridViewExistingDoctor.Columns[0].Visible = false;
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
                //sets colour for alternate rowns for dataGridViewExsitingDoctor
                this.dataGridViewExistingDoctor.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
                //Setting comboboxes to -1 index so no item apperas on load
                this.comboBoxDepartment.SelectedIndex = -1;
                this.comboBoxNationality.SelectedIndex = -1;
                this.comboBoxSex.SelectedIndex = -1;
                this.comboBoxDoctorShift.SelectedIndex = -1;
                //datagridview full row select
                this.dataGridViewExistingDoctor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
           

        }

        private void buttonInsert_Click(object sender, EventArgs e)
            {
            string str = "";
            if (this.textBoxFirstName.Text == "")
            {
                str = str + "First Name ";
            }
            if (this.textBoxLastName.Text == "")
            {
                str = str + Environment.NewLine + "Last Name ";
            }
            if (this.comboBoxDepartment.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Department ";
            }
            if (this.textBoxAge.Text == "")
            {
                str = str + Environment.NewLine + "Age ";
            }
            if (this.comboBoxSex.SelectedIndex <0)
            {
                str = str + Environment.NewLine + "Sex ";
            }
            if (this.comboBoxNationality.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Nationality";
            }
            if (this.textBoxHeightFt.Text == "")
            {
                this.textBoxHeightFt.Text = "0";
            }
            if (this.textBoxHeightInch.Text == "")
            {
                this.textBoxHeightInch.Text = "0";
            }
            if (this.textBoxWeight.Text == "")
            {
                this.textBoxWeight.Text = "0";
            }
            if (this.textBoxPhone.Text == "")
            {
                this.textBoxPhone.Text = "0";
            }
            if (this.textBoxEmail.Text == "")
            {
                this.textBoxEmail.Text = null;
            }
            if (this.textBoxAddress.Text == "")
            {
                this.textBoxAddress.Text = null;
            }
            if (this.comboBoxDoctorShift.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Doctor Shift";
            }
            if (str.Length > 0)
            {
                MessageBox.Show(str + Environment.NewLine + "(REQUIRED)");
            }
            else
            {
                Doctor doc = new Doctor();
                try
                {
                    doc.firstName = this.textBoxFirstName.Text;
                    doc.lastName = this.textBoxLastName.Text;
                    doc.department = Int32.Parse(this.comboBoxDepartment.SelectedValue.ToString());
                    doc.age = Convert.ToInt32(this.textBoxAge.Text);
                    doc.sex = this.comboBoxSex.Text;
                    doc.heightFt = Convert.ToInt32(this.textBoxHeightFt.Text);
                    doc.heightInch = Convert.ToInt32(this.textBoxHeightInch.Text);
                    doc.weight = Convert.ToInt32(this.textBoxWeight.Text);
                    doc.phone = Convert.ToInt64(this.textBoxPhone.Text);
                    doc.email = this.textBoxEmail.Text;
                    doc.address = this.textBoxAddress.Text;
                    doc.natioinality = Int32.Parse(this.comboBoxNationality.SelectedValue.ToString());
                    doc.shift = Int32.Parse(this.comboBoxDoctorShift.SelectedValue.ToString());
                    DoctorManager.doctorSave(doc);
                    MessageBox.Show("Success");
                    displayDoctor();
                    clearAllBoxes();
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string str = "";
            if (textBoxFirstName.Text == "")
            {
                str = str + "First Name ";
            }
            if (textBoxLastName.Text == "")
            {
                str = str + Environment.NewLine + "Last Name ";
            }
            if (comboBoxDepartment.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Department ";
            }
            if (textBoxAge.Text == "")
            {
                str = str + Environment.NewLine + "Age ";
            }
            if (comboBoxSex.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Sex ";
            }
            if (comboBoxNationality.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Nationality";
            }
            if (comboBoxDoctorShift.SelectedIndex < 0)
            {
                str = str + Environment.NewLine + "Doctor Shift";
            }
            if (str.Length > 0)
            {
                MessageBox.Show(str + Environment.NewLine + "(REQUIRED)");
            }
            else
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
                    clearAllBoxes();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            try
            {
                doctor.doctorId = Id;
                DoctorManager.doctorDelete(doctor);
                MessageBox.Show("Deleted");
                displayDoctor();
                clearAllBoxes();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            displayDoctor();
        }
        private void dataGridViewExistingDoctor_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dataGridViewExistingDoctor.CurrentRow != null && this.dataGridViewExistingDoctor.CurrentRow.Index != -1)
            {
                try
                {
                    Id = Convert.ToInt32(dataGridViewExistingDoctor.CurrentRow.Cells[0].Value.ToString());
                    textBoxFirstName.Text = dataGridViewExistingDoctor.CurrentRow.Cells[1].Value.ToString();
                    textBoxLastName.Text = dataGridViewExistingDoctor.CurrentRow.Cells[2].Value.ToString();
                    comboBoxDepartment.SelectedValue = Convert.ToInt32(dataGridViewExistingDoctor.CurrentRow.Cells[3].Value.ToString());
                    textBoxAge.Text = dataGridViewExistingDoctor.CurrentRow.Cells[4].Value.ToString();
                    comboBoxSex.Text = dataGridViewExistingDoctor.CurrentRow.Cells[5].Value.ToString();
                    textBoxHeightFt.Text = dataGridViewExistingDoctor.CurrentRow.Cells[6].Value.ToString();
                    textBoxHeightInch.Text = dataGridViewExistingDoctor.CurrentRow.Cells[7].Value.ToString();
                    textBoxWeight.Text = dataGridViewExistingDoctor.CurrentRow.Cells[8].Value.ToString();
                    textBoxPhone.Text = dataGridViewExistingDoctor.CurrentRow.Cells[9].Value.ToString();
                    textBoxEmail.Text = dataGridViewExistingDoctor.CurrentRow.Cells[10].Value.ToString();
                    textBoxAddress.Text = dataGridViewExistingDoctor.CurrentRow.Cells[11].Value.ToString();
                    comboBoxNationality.SelectedValue = Convert.ToInt32(dataGridViewExistingDoctor.CurrentRow.Cells[12].Value.ToString());
                    comboBoxDoctorShift.SelectedValue = Int32.Parse(dataGridViewExistingDoctor.CurrentRow.Cells[13].Value.ToString());
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            if(this.textBoxSearchName.Text.Length > 0 || this.textBoxSearchId.Text.Length >0 || this.textBoxSearchPhone.Text.Length > 0)
            {
                //search by name
                if(this.textBoxSearchName.Text.Length > 0)
                {
                    Doctor doc = new Doctor();
                    doc.firstName = this.textBoxSearchName.Text;
                    DataTable dt = new DataTable();
                    dt = DoctorManager.getDoctorListByName(doc);
                    dataGridViewExistingDoctor.DataSource = dt;
                }
                //search by id
                if(this.textBoxSearchId.Text.Length > 0)
                {
                    Doctor doc = new Doctor();
                    doc.doctorId = Convert.ToInt32(this.textBoxSearchId.Text);
                    DataTable dt = new DataTable();
                    dt = DoctorManager.getDoctorListById(doc);
                    dataGridViewExistingDoctor.DataSource = dt;
                }
                //search by phone
                if(this.textBoxSearchPhone.Text.Length > 0)
                {
                    Doctor doc = new Doctor();
                    doc.phone = Convert.ToInt64(this.textBoxSearchPhone.Text);
                    DataTable dt = new DataTable();
                    dt = DoctorManager.getDoctorListByPhone(doc);
                    dataGridViewExistingDoctor.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please enter details to search");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            displayDoctor();
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

        private void textBoxSearchPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

