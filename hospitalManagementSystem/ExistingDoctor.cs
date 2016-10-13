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
        SqlDataAdapter da;
        public ExistingDoctor()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            HospitalMain hospitalMain = new HospitalMain();
            hospitalMain.ShowDialog();
            this.Close();
        }

        private void ExistingDoctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalManagementSystemDataSet1.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hospitalManagementSystemDataSet1.Doctor);
            // TODO: This line of code loads data into the 'hospitalManagementSystemDataSet.Doctor' table. You can move, or remove it, as needed.
            //this.doctorTableAdapter.Fill(this.hospitalManagementSystemDataSet.Doctor);
            this.dataGridViewExistingDocotor.Sort(dataGridViewExistingDocotor.Columns[1],ListSortDirection.Ascending);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT firstName,lastName FROM Doctor WHERE firstName ='" + textBoxSearch.Text + "'" ,Common.getConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewExistingDocotor.DataSource = dt;
            //displayData();
        }
    }
}
