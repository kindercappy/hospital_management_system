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
    public partial class ChangePassowrd : Form
    {
        int userId = 0;

        //METHODS
        private void checkUserById()
        {
            try
            {
                Users user = new Users();
                user.userId = Convert.ToInt32(this.textBoxUserID.Text);
                DataTable dt = new DataTable();
                dt =UsersManager.getUserIdByUserId(user);
                if(dt.Rows.Count > 0)
                {
                    //textBoxes
                    this.textBoxNewPassword.Visible = true;
                    this.textBoxConfirmPassword.Visible = true;
                    this.textBoxUserName.Visible = true;
                    this.textBoxUserID.Visible = false;
                    //labels
                    this.labelNewPassword.Visible = true;
                    this.labelConfirmPassword.Visible = true;
                    this.labelUserName.Visible = true;
                    labelUserID.Visible = false;
                    //buttons
                    this.buttonCheckId.Visible = false;
                    this.buttonChangePassword.Visible = true;

                    userId = user.userId;
                    clearUserIdTextbox();
                }
                else
                {
                    MessageBox.Show("User Not found!");
                    clearUserIdTextbox();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearUserIdTextbox()
        {
            this.textBoxUserID.Text = "";
        }



        public ChangePassowrd()
        {
            InitializeComponent();
        }

        private void buttonCheckId_Click(object sender, EventArgs e)
        {
            checkUserById();
        }

        private void ChangePassowrd_Load(object sender, EventArgs e)
        {
            this.textBoxNewPassword.Visible = false;
            this.textBoxConfirmPassword.Visible = false;
            this.textBoxUserName.Visible = false;
            this.labelConfirmPassword.Visible = false;
            this.labelNewPassword.Visible = false;
            this.labelUserName.Visible = false;
            this.buttonChangePassword.Visible = false;
        }

        private void ChangePassowrd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //System.Windows.Forms.Application.Exit();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
 