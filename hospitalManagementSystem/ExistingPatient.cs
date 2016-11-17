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
    public partial class ExistingPatient : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        int Id = 0;

        public ExistingPatient()
        {
            InitializeComponent();

        }


        // METHODS
        //display data in dataGridView
        private void displayPatient()
        {
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Patient_Select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewExistingPatient.DataSource = dt;
        }
        //clear data
        private void clearData()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxAge.Text = "";
            comboBoxSex.SelectedIndex = -1;
            textBoxHeightFt.Text = "";
            textBoxHeightInch.Text = "";
            textBoxPhone.Text = "";
            textBoxWeight.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
            comboBoxNationality.SelectedIndex = -1;
            textBoxFrom.Text = "";
            textBoxTo.Text = "";
            Id = 0;
        }
        private void displayAppointment()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Appointment_Select_By_PatientId";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter iPatientId = new SqlParameter("@patientId", Id);
                iPatientId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iPatientId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAppointmentHistory.DataSource = dt;
            }
        }
        private void notSortableDataGridViewExistingPatient()
        {
            foreach (DataGridViewColumn col in dataGridViewExistingPatient.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void notSortableDataGridViewAppointmentHistory()
        {
            foreach(DataGridViewColumn col in dataGridViewAppointmentHistory.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void setDataGridViewExistingPatientHeaders()
        {
            this.dataGridViewExistingPatient.Columns[0].HeaderText = "Patient ID";
            this.dataGridViewExistingPatient.Columns[1].HeaderText = "First Name";
            this.dataGridViewExistingPatient.Columns[2].HeaderText = "Last Name";
            this.dataGridViewExistingPatient.Columns[3].HeaderText = "Age";
            this.dataGridViewExistingPatient.Columns[4].HeaderText = "Sex";
            this.dataGridViewExistingPatient.Columns[5].HeaderText = "Heaight (Feet)";
            this.dataGridViewExistingPatient.Columns[6].HeaderText = "Height (Inch)";
            this.dataGridViewExistingPatient.Columns[7].HeaderText = "Weight";
            this.dataGridViewExistingPatient.Columns[8].HeaderText = "Phone";
            this.dataGridViewExistingPatient.Columns[9].HeaderText = "Email";
            this.dataGridViewExistingPatient.Columns[10].HeaderText = "Address";
            this.dataGridViewExistingPatient.Columns[11].HeaderText = "Nationality ID";
            this.dataGridViewExistingPatient.Columns[12].HeaderText = "From";
            this.dataGridViewExistingPatient.Columns[13].HeaderText = "To";
        }
        private void setDataGridViewAppointmentHeaders()
        {
            this.dataGridViewAppointmentHistory.Columns[0].HeaderText = "Appointment ID";
            this.dataGridViewAppointmentHistory.Columns[1].HeaderText = "First Name";
            this.dataGridViewAppointmentHistory.Columns[2].HeaderText = "Last Name";
            this.dataGridViewAppointmentHistory.Columns[3].HeaderText = "Department ID";
            this.dataGridViewAppointmentHistory.Columns[4].HeaderText = "Age";
            this.dataGridViewAppointmentHistory.Columns[5].HeaderText = "Doctor ID";
            this.dataGridViewAppointmentHistory.Columns[6].HeaderText = "Phone";
            this.dataGridViewAppointmentHistory.Columns[7].HeaderText = "Patient ID";
            this.dataGridViewAppointmentHistory.Columns[8].HeaderText = "Appointment Time";
            this.dataGridViewAppointmentHistory.Columns[9].HeaderText = "Sex";
        }
       


        // EVENTS
        private void ExistingPatient_Load(object sender, EventArgs e)
        {
            try
            {

                displayPatient();
                notSortableDataGridViewExistingPatient();
                notSortableDataGridViewAppointmentHistory();
                setDataGridViewExistingPatientHeaders();
                setDataGridViewAppointmentHeaders();
                //patientId hide in grid
                this.dataGridViewExistingPatient.Columns[0].Visible = false;
                //ExistingPatient Depertment comboBox
                this.comboBoxDepartment.DataSource = DepartmentDoctorManager.getDepartmentList();
                this.comboBoxDepartment.DisplayMember = "departmentName";
                this.comboBoxDepartment.ValueMember = "departmentId";
                //ExistingPatient Nationality comboBox
                this.comboBoxNationality.DataSource = NationalityManager.getNationalityList();
                this.comboBoxNationality.DisplayMember = "nationalityName";
                this.comboBoxNationality.ValueMember = "nationalityId";
                //sets colour for alternate rowns for dataGridViewExsitingPatient
                this.dataGridViewExistingPatient.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
                //sets color for alternate rows for datagridviewappointmenthistory
                this.dataGridViewAppointmentHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.DodgerBlue;
                //datagridview row select
                this.dataGridViewExistingPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //Setting comboboxes to -1 index so no item apperas on load
                this.comboBoxNationality.SelectedIndex = -1;
                this.comboBoxSex.SelectedIndex = -1;
                this.comboBoxDepartment.SelectedIndex = -1;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewExistingPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            
            string str = "";
            if(textBoxFirstName.Text == "")
            {
                str = str + "First Name ";    
            }
            if (textBoxLastName.Text == "")
            {
                str = str  + Environment.NewLine + "Last Name ";
            }
 
            if (textBoxAge.Text =="")
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
            if (str.Length > 0)
            {
                MessageBox.Show(str + Environment.NewLine + "(REQUIRED)");
            }
            else
            {
                //Insert the patient data here
                Patient patient = new Patient();
                try
                {
                    patient.firstName = this.textBoxFirstName.Text;
                    patient.lastName = this.textBoxLastName.Text;
                    //patient.department = Int32.Parse(this.comboBoxDepartment.SelectedValue.ToString());
                    patient.age = Convert.ToInt32(this.textBoxAge.Text);
                    patient.sex = this.comboBoxSex.Text;
                    patient.heightFt = Convert.ToInt32(this.textBoxHeightFt.Text);
                    patient.heightInch = Convert.ToInt32(this.textBoxHeightInch.Text);
                    patient.weight = Convert.ToInt32(this.textBoxWeight.Text);
                    patient.phone = Convert.ToInt64(this.textBoxPhone.Text);
                    patient.email = this.textBoxEmail.Text;
                    patient.address = this.textBoxAddress.Text;
                    patient.natioinality = Int32.Parse(this.comboBoxNationality.SelectedValue.ToString());
                    patient.from = TimeSpan.Parse(this.textBoxFrom.Text);
                    patient.to = TimeSpan.Parse(this.textBoxTo.Text);
                    PatientManager.patientSave(patient);
                    MessageBox.Show("Success");
                    displayPatient();
                    clearData();
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //updates patient data
            string str = "";
            if (textBoxFirstName.Text == "")
            {
                str = str + "First Name ";
            }
            if (textBoxLastName.Text == "")
            {
                str = str + Environment.NewLine + "Last Name ";
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
            if (str.Length > 0)
            {
                MessageBox.Show(str + Environment.NewLine + "(REQUIRED)");
            }
            else
            {
                Patient patient = new Patient();
                Appointment appointment = new Appointment();
                try
                {
                    //patient
                    patient.patientId = Id;
                    patient.firstName = this.textBoxFirstName.Text;
                    patient.lastName = this.textBoxLastName.Text;
                    //patient.department = Int32.Parse(this.comboBoxDepartment.SelectedValue.ToString());
                    patient.age = Convert.ToInt32(this.textBoxAge.Text);
                    patient.sex = this.comboBoxSex.Text;
                    patient.heightFt = Convert.ToInt32(this.textBoxHeightFt.Text);
                    patient.heightInch = Convert.ToInt32(this.textBoxHeightInch.Text);
                    patient.weight = Convert.ToInt32(this.textBoxWeight.Text);
                    patient.phone = Convert.ToInt64(this.textBoxPhone.Text);
                    patient.email = this.textBoxEmail.Text;
                    patient.address = this.textBoxAddress.Text;
                    patient.natioinality = Int32.Parse(this.comboBoxNationality.SelectedValue.ToString());
                    patient.from = TimeSpan.Parse(this.textBoxFrom.Text);
                    patient.to = TimeSpan.Parse(this.textBoxTo.Text);
                    //appointment
                    appointment.patientId = Id;
                    appointment.firstName = this.textBoxFirstName.Text;
                    appointment.lastName = this.textBoxLastName.Text;
                    appointment.phone = Convert.ToInt64(this.textBoxPhone.Text);
                    PatientManager.patientUpdate(patient);
                    AppointmentManager.AppointmentInfoUpdate(appointment);
                    MessageBox.Show("Success");
                    displayPatient(); 
                    displayAppointment();
                    clearData();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            try
            {
                patient.patientId = Id;
                PatientManager.patientDelete(patient);
                MessageBox.Show("Deleted");
                displayPatient();
                clearData();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length > 0)
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    Doctor doctor = new Doctor();
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    cmd.Connection = Common.getConnection();
                    cmd.CommandText = "Patient_Search";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter sFirstName = new SqlParameter("@firstName", textBoxSearch.Text);
                    sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
                    cmd.Parameters.Add(sFirstName);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dataGridViewExistingPatient.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please enter details");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            displayPatient();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //DataGridView Appointment History CellContentClick
        private void dataGridViewAppointmentHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewExistingPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewAppointmentHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewExistingPatient_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dataGridViewExistingPatient.CurrentRow != null && this.dataGridViewExistingPatient.CurrentRow.Index != -1)
            {
                try
                {
                    //display data in textboxes, comboboxes when record selected in datagridview
                    Id = Convert.ToInt32(dataGridViewExistingPatient.CurrentRow.Cells[0].Value.ToString());
                    textBoxFirstName.Text = dataGridViewExistingPatient.CurrentRow.Cells[1].Value.ToString();
                    textBoxLastName.Text = dataGridViewExistingPatient.CurrentRow.Cells[2].Value.ToString();
                    textBoxAge.Text = dataGridViewExistingPatient.CurrentRow.Cells[3].Value.ToString();
                    comboBoxSex.Text = dataGridViewExistingPatient.CurrentRow.Cells[4].Value.ToString();
                    textBoxHeightFt.Text = dataGridViewExistingPatient.CurrentRow.Cells[5].Value.ToString();
                    textBoxHeightInch.Text = dataGridViewExistingPatient.CurrentRow.Cells[6].Value.ToString();
                    textBoxWeight.Text = dataGridViewExistingPatient.CurrentRow.Cells[7].Value.ToString();
                    textBoxPhone.Text = dataGridViewExistingPatient.CurrentRow.Cells[8].Value.ToString();
                    textBoxEmail.Text = dataGridViewExistingPatient.CurrentRow.Cells[9].Value.ToString();
                    textBoxAddress.Text = dataGridViewExistingPatient.CurrentRow.Cells[10].Value.ToString();
                    comboBoxNationality.SelectedValue = Convert.ToInt32(dataGridViewExistingPatient.CurrentRow.Cells[11].Value.ToString());
                    textBoxFrom.Text = dataGridViewExistingPatient.CurrentRow.Cells[12].Value.ToString();
                    textBoxTo.Text = dataGridViewExistingPatient.CurrentRow.Cells[13].Value.ToString();
                    this.comboBoxDepartment.SelectedIndex = -1;

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                displayAppointment();
            }
        }

        private void dataGridViewAppointmentHistory_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dataGridViewAppointmentHistory.CurrentRow != null && this.dataGridViewAppointmentHistory.CurrentRow.Index != -1)
            {
                try
                {
                    comboBoxDepartment.SelectedValue = Convert.ToInt32(dataGridViewAppointmentHistory.CurrentRow.Cells[3].Value.ToString());
                }
                catch(System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

