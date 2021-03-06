﻿using System;
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
        public bool UserClosing { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            UserClosing = false;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.textBoxUserName.Text = "kp";
            this.textBoxPassword.Text = "1234";
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Users user = new Users();
                user.userName = this.textBoxUserName.Text;
                user.password = this.textBoxPassword.Text;
                int userId = UsersManager.getUserByIdUserNameAndPassword(user);
                if (userId > 0)
                {
                    UserClosing = true;
                    this.Close();
                }
                else
                {
                    labelLogin.Text = "Wrong username or password";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                switch (e.CloseReason)
                {
                    case CloseReason.ApplicationExitCall:
                        break;
                    case CloseReason.FormOwnerClosing:
                        break;
                    case CloseReason.MdiFormClosing:
                        break;
                    case CloseReason.None:
                        break;
                    case CloseReason.TaskManagerClosing:
                        break;
                    case CloseReason.UserClosing:
                        try {
                        if (UserClosing)
                        {
                            this.Close();
                        }
                        else
                        {
                            Application.Exit();
                        }
                        }
                        catch(System.Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        break;
                    case CloseReason.WindowsShutDown:
                        break;
                    default:
                        break;
                }
                UserClosing = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_Deactivate(object sender, EventArgs e)
        {
            
        }
    }
}
