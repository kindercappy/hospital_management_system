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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Users user = new Users();
                user.userName = this.textBoxUserName.Text;
                user.password = this.textBoxPassword.Text;
                int userId = UsersManager.getUserByIdUserNameAndPassword(user);
            if(userId > 0)
            {
                    this.labelLogin.Text = string.Format("You are userId : {0}", userId);
                    
            }
            else
            {
                labelLogin.Text = "Wrong username or password";

            }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNewAccount_Click(object sender, EventArgs e)
        {
            
            CommonFormOperation.ShowDialogSubForm(CommonFormOperation.createNewAccount, this.MdiParent);
            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            CommonFormOperation.ShowDialogSubForm(CommonFormOperation.changePassword, this.MdiParent);
        }
    }
}
