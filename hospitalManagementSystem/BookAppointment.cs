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
    public partial class BookAppointment : Form
    {
        //SqlCommand cmd = new SqlCommand();
        //SqlDataAdapter da = new SqlDataAdapter();
        //DataTable dt = new DataTable();
        int patId = 0;
        int docId = 0;
        //int docNewId = 0;
        public BookAppointment()
        {
            InitializeComponent();
        }
        // METHODS
        //display data in dataGridView
        private void displayPatient()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Patient_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewPatient.DataSource = dt;
            }
        }
        //clears data from boxes
        private void clearData()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxAge.Text = "";
            textBoxDoctor.Text = "";
            textBoxAppTime.Text = "";
            comboBoxSex.SelectedIndex = -1;
            comboBoxDepartment.SelectedIndex = -1;
        }
        // clear textBoxSearch Id, Name, Phone
        private void clearSearchBoxes()
        {
            textBoxSearchName.Text = "";
            textBoxSearchId.Text = "";
            textBoxSearchPhone.Text = "";
        }
        private void setDatagridViewPatientHeaders()
        {
            this.dataGridViewPatient.Columns[0].HeaderText = "Patient ID";
            this.dataGridViewPatient.Columns[1].HeaderText = "First Name";
            this.dataGridViewPatient.Columns[2].HeaderText = "Last Name";
            this.dataGridViewPatient.Columns[3].HeaderText = "Age";
            this.dataGridViewPatient.Columns[4].HeaderText = "Sex";
            this.dataGridViewPatient.Columns[5].HeaderText = "Height (Feet)";
            this.dataGridViewPatient.Columns[6].HeaderText = "Heignt (Inch)";
            this.dataGridViewPatient.Columns[7].HeaderText = "Weight";
            this.dataGridViewPatient.Columns[8].HeaderText = "Phone";
            this.dataGridViewPatient.Columns[9].HeaderText = "Email";
            this.dataGridViewPatient.Columns[10].HeaderText = "Address";
            this.dataGridViewPatient.Columns[11].HeaderText = "Nationality ID";
        }
        private void setDataGridViewDoctorHeaders()
        {
            this.dataGridViewDoctor.Columns[0].HeaderText = "Doctor ID";
            this.dataGridViewDoctor.Columns[1].HeaderText = "First Name";
            this.dataGridViewDoctor.Columns[2].HeaderText = "Last Name";
        }
        private void notSortableDataGirdViewPatient()
        {
            foreach(DataGridViewColumn col in dataGridViewPatient.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void notSortableDataGridViewDoctor()
        {
            foreach(DataGridViewColumn col in this.dataGridViewDoctor.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void fullRowSelectDataGridViewPatient()
        {
            this.dataGridViewPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void fullRowSelectDataGridViewDoctor()
        {
            this.dataGridViewDoctor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void toUpperCaseLabels()
        {
            labelBookAppointment.Text = labelBookAppointment.Text.ToUpper();
            labelDoctor.Text = labelDoctor.Text.ToUpper();
            labelPatient.Text = labelPatient.Text.ToUpper();
        }
      
        private void BookAppointment_Load(object sender, EventArgs e)
        {

            dateTimePickerAppointmentTime.Format = DateTimePickerFormat.Time;
            //dateTimePickerAppointmentTime.CustomFormat = "MM/ dd/ yyyy | hh:mm:ss";
            //displaying Patient list in dataGridViewPatient
            displayPatient();
            setDatagridViewPatientHeaders();
            notSortableDataGirdViewPatient();
            fullRowSelectDataGridViewPatient();
            toUpperCaseLabels();
            //Department ComboBox
            this.comboBoxDepartment.DisplayMember = "departmentName";
            this.comboBoxDepartment.ValueMember = "departmentId";
            this.comboBoxDepartment.DataSource = DepartmentDoctorManager.getDepartmentList();
            //ExistingDoctor Nationality comboBox
            this.comboBoxNewNationality.DisplayMember = "nationalityName";
            this.comboBoxNewNationality.ValueMember = "nationalityId";
            this.comboBoxNewNationality.DataSource = NationalityManager.getNationalityList();
            //dataGridViewDoctor alternateRow colorChanged
            this.dataGridViewDoctor.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
            //dataGridViewPatient alternateRow colorChanged
            this.dataGridViewPatient.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
            //comboBox
            this.comboBoxDepartment.SelectedIndex = -1;
            this.comboBoxNewNationality.SelectedIndex = -1;
            //textBoxTime scrollBars
            textBoxAppTime.ScrollBars = ScrollBars.Vertical;
            //dataGridViewDoctor is Visible = False
            this.dataGridViewDoctor.Visible = false;

        }

        //button Search onClick event
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBoxSearchName.Text.Length > 0 || this.textBoxSearchId.Text.Length > 0 || this.textBoxSearchPhone.Text.Length > 0)
                {
                    //Search by Name
                    if (this.textBoxSearchName.Text.Length > 0)
                    {
                        Patient pat = new Patient();
                        pat.firstName = this.textBoxSearchName.Text;
                        DataTable dt = new DataTable();
                        dt = PatientManager.getPatientListBYName(pat);
                        dataGridViewPatient.DataSource = dt;
                        clearSearchBoxes();

                    }
                    //Search by Id
                    if (this.textBoxSearchId.Text.Length > 0)
                    {
                        Patient pat = new Patient();
                        pat.patientId = Convert.ToInt32(this.textBoxSearchId.Text);
                        DataTable dt = new DataTable();
                        dt = PatientManager.getPatientListById(pat);
                        dataGridViewPatient.DataSource = dt;
                        clearSearchBoxes();

                    }
                    //Search by Phone
                    if (textBoxSearchPhone.Text.Length > 0)
                    {
                        Patient pat = new Patient();
                        pat.phone = Convert.ToInt64(this.textBoxSearchPhone.Text);
                        DataTable dt = new DataTable();
                        dt = PatientManager.getPatientListByPhone(pat);
                        dataGridViewPatient.DataSource = dt;
                        clearSearchBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a value to search!");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //button Refresh onClick event
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            displayPatient();
        }

        //Submit button onClock event
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                Appointment app = new Appointment();
                app.firstName = this.textBoxFirstName.Text;
                app.lastName = this.textBoxLastName.Text;
                app.departmentId = Int32.Parse(this.comboBoxDepartment.SelectedValue.ToString());
                app.age = Convert.ToInt32(this.textBoxAge.Text);
                app.doctorId = docId;
                app.sex = this.comboBoxSex.Text;
                app.phone = Convert.ToInt64(this.textBoxPhone.Text);
                app.appTime = DateTime.Parse(this.dateTimePickerAppointmentTime.Value.ToString());
                app.patientId = patId;
                AppointmentManager.appointmentSave(app);
                MessageBox.Show("Success");
                displayPatient();
                clearSearchBoxes();
                clearData();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //comboBocDepartment SelectedIndexChanged
        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBoxDepartment.SelectedIndex >= 0)
                {

                    this.dataGridViewDoctor.Visible = true;
                    
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = Common.getConnection();
                        cmd.CommandText = "Doctor_Select_By_Department";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlParameter iDepartment = new SqlParameter("@department", this.comboBoxDepartment.SelectedValue);
                        iDepartment.SqlDbType = System.Data.SqlDbType.Int;
                        cmd.Parameters.Add(iDepartment);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewDoctor.DataSource = dt;
                    }
                    setDataGridViewDoctorHeaders();
                    fullRowSelectDataGridViewDoctor();
                    notSortableDataGridViewDoctor();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            try
            {
                patient.firstName = this.textBoxNewFirstName.Text;
                patient.lastName = this.textBoxNewLastName.Text;
                patient.age = Convert.ToInt32(this.textBoxNewAge.Text);
                patient.sex = this.comboBoxNewSex.Text;
                patient.heightFt = Convert.ToInt32("0");
                patient.heightInch = Convert.ToInt32("0");
                patient.weight = Convert.ToInt32("0");
                patient.phone = Convert.ToInt64("0");
                patient.email = null;
                patient.address = null;
                //patient.entryTime = DateTime.Parse(null);
                patient.natioinality = Int32.Parse(this.comboBoxNewNationality.SelectedValue.ToString());
                

                PatientManager.patientSave(patient);
                MessageBox.Show("Success");
                displayPatient();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void textBoxSearchPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void dataGridViewPatient_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dataGridViewPatient.CurrentRow != null && this.dataGridViewPatient.CurrentRow.Index != -1)
            {
                try
                {
                    patId = Convert.ToInt32(dataGridViewPatient.CurrentRow.Cells[0].Value.ToString());
                    textBoxFirstName.Text = dataGridViewPatient.CurrentRow.Cells[1].Value.ToString();
                    textBoxLastName.Text = dataGridViewPatient.CurrentRow.Cells[2].Value.ToString();
                    textBoxAge.Text = dataGridViewPatient.CurrentRow.Cells[3].Value.ToString();
                    textBoxPhone.Text = dataGridViewPatient.CurrentRow.Cells[8].Value.ToString();
                    comboBoxSex.Text = dataGridViewPatient.CurrentRow.Cells[4].Value.ToString();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridViewDoctor_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dataGridViewDoctor.CurrentRow !=  null
                && this.dataGridViewDoctor.CurrentRow.Index != -1)
            {
                try
                {
                    docId = Convert.ToInt32(dataGridViewDoctor.CurrentRow.Cells[0].Value.ToString());
                    textBoxDoctor.Text = dataGridViewDoctor.CurrentRow.Cells[1].Value.ToString();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxNewAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            { 
                e.Handled = true;
            }
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
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

        private void BookAppointment_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
