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
    public partial class CreateNewAccount : Form
    {
        public CreateNewAccount()
        {
            InitializeComponent();
        }
        //METHODS
        private void userInsert()
        {
            Users user = new Users();
            user.userName = this.textBoxUserName.Text;
            user.password = this.textBoxPassword.Text;
            UsersManager.userInsert(user);
            MessageBox.Show("User Inserted");
            clearTextBoxes();
        }
        private void clearTextBoxes()
        {
            this.textBoxUserName.Text = "";
            this.textBoxPassword.Text = "";
        }


        private void buttonNewAccount_Click(object sender, EventArgs e)
        {
            userInsert();
        }
    }
}
