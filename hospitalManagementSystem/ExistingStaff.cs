using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HospitalLibrary;

namespace hospitalManagementSystem
{
    public partial class ExistingStaff : Form
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        int Id = 0;

        public ExistingStaff()
        {
            InitializeComponent();
            displayData();
            //this.dataGridViewExistingStaff.Columns[0].Visible = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            HospitalMain hospitalMain = new HospitalMain();
            hospitalMain.ShowDialog();
            this.Close();
        }

        private void ExistingStaff_Load(object sender, EventArgs e)
        {
            this.comboBoxDepartment.DataSource = DepartmentDoctorManager.getDepartmentList();
            this.comboBoxDepartment.DisplayMember = "departmentName";
            this.comboBoxDepartment.ValueMember = "departmentId";

        }

        //display data in dataGridView
        private void displayData()
        {
            //cmd.Connection = Common.getConnection();
            //cmd.CommandText = "StaffSample_Select";
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //da = new SqlDataAdapter(cmd);
            //dt = new DataTable();
            //da.Fill(dt);
            //dataGridViewExistingStaff.DataSource = dt;
            con = Common.getConnection();
            dt = new DataTable();
            da = new SqlDataAdapter("SELECT * FROM StaffSample", con);
            da.Fill(dt);
            dataGridViewExistingStaff.DataSource = dt;
        }



        //clear data
        private void clearData()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            Id = 0;
        }
        //dataGridView cellContentClick
        private void dataGridViewExistingStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridViewExistingStaff.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxFirstName.Text = dataGridViewExistingStaff.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridViewExistingStaff.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxDepartment.SelectedValue = Convert.ToInt32(dataGridViewExistingStaff.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if(textBoxFirstName.Text != "" && textBoxLastName.Text != "")
            {
                cmd = new SqlCommand();
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "StaffSample_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter sFirstName = new SqlParameter("@firstName", textBoxFirstName.Text);
                sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sFirstName);
                SqlParameter sLastName = new SqlParameter("@lastName", textBoxLastName.Text);
                sLastName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sLastName);
                SqlParameter iDepartment = new SqlParameter("@department", comboBoxDepartment.SelectedValue);
                iDepartment.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iDepartment);
                cmd.ExecuteNonQuery();
                //cmd.Parameters.Clear();
                MessageBox.Show("Data Inserted");
                displayData();
                clearData();
                //cmd = new SqlCommand("INSERT INTO StaffSample(firstName,lastName,department) VALUES(@firstName,@lastName,@department)", con);
                //con = Common.getConnection();
                //cmd.Parameters.AddWithValue("@firstName", textBoxFirstName.Text);
                //cmd.Parameters.AddWithValue("@lastName", textBoxLastName.Text);
                //cmd.Parameters.AddWithValue("@department", comboBoxDepartment.SelectedValue);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Done");
                //displayData();
                //clearData();
            }
            else {
                MessageBox.Show("Please enter valid details!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE StaffSample set firstName=@firstName,lastName=@lastName WHERE Id=@id", con);
            cmd.Connection = Common.getConnection();
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@firstName", textBoxFirstName.Text);
            cmd.Parameters.AddWithValue("@lastName", textBoxLastName.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated");
            displayData();
            clearData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE StaffSample WHERE Id=@Id", con);
            cmd.Connection = Common.getConnection();
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            displayData();
            clearData();
        }
    }
}
