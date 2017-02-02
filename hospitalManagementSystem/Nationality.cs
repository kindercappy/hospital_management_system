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
    public partial class Nationality : Form
    {
        int nationId;
        //METHOD
        private void clearTextBoxes()
        {
            this.textBoxNationalityName.Text = "";
        }
        public Nationality()
        {
            InitializeComponent();
        }
        private void displayNationality()
        {
            DataTable dt = new DataTable();
            dt=NationalityManager.getNationalities();
            dataGridViewNationalities.DataSource = dt;
        }
        private void notSortableDataGridViewNationalities()
        {
            foreach (DataGridViewColumn col in this.dataGridViewNationalities.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void fullRowSelectDataGridViewNationalities()
        {
            this.dataGridViewNationalities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void setDataGridViewNationalitiesHeaders()
        {
            this.dataGridViewNationalities.Columns[0].HeaderText = "Nationality";
            this.dataGridViewNationalities.Columns[1].HeaderText = "Nationality ID";
        }
        private void toUpperCaseLabels()
        {
            labelNationality.Text = labelNationality.Text.ToUpper(); 
        }
        private void Nationality_Load(object sender, EventArgs e)
        {
            displayNationality();
            notSortableDataGridViewNationalities();
            fullRowSelectDataGridViewNationalities();
            setDataGridViewNationalitiesHeaders();
            toUpperCaseLabels();
            this.labelHeader.Width = this.Width;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                NationalityHL nation = new NationalityHL();
                nation.nationalityName = this.textBoxNationalityName.Text;
                nation.nationalityId = nationId;
                NationalityManager.nationalityUpdate(nation);
                MessageBox.Show("Success");
                clearTextBoxes();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridViewNationalities_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewNationalities.CurrentRow != null && this.dataGridViewNationalities.CurrentRow.Index != -1)
            {
                try
                {
                    this.textBoxNationalityName.Text = this.dataGridViewNationalities.CurrentRow.Cells[0].Value.ToString();
                    nationId = Convert.ToInt32(this.dataGridViewNationalities.CurrentRow.Cells[1].Value.ToString());
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NationalityHL nation = new NationalityHL();
            nation.nationalityName = this.textBoxNationalityName.Text;
            NationalityManager.nationalityInsert(nation);
            MessageBox.Show("Success");
            clearTextBoxes();
            displayNationality();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            NationalityHL nation = new NationalityHL();
            nation.nationalityId = nationId;
            NationalityManager.nationalityDelete(nation);
            MessageBox.Show("Success");
            clearTextBoxes();
            displayNationality();
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

        private void Nationality_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
