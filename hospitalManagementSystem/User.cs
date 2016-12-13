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
    public partial class User : Form
    {
        int userId = 0;
        public User()
        {
            InitializeComponent();
        }
        //METHODS
        private void userInsert()
        {
            if (this.textBoxPassword.Text == this.textBoxConfirmPassword.Text)
            {

            Users user = new Users();
            user.userName = this.textBoxNewUserName.Text;
            user.password = this.textBoxPassword.Text;
            UsersManager.userInsert(user);
            MessageBox.Show("User Inserted");
            clearTextBoxes();
            }
            else
            {
                MessageBox.Show("Passwords Dont match!");
            }
        }
        private void userUpdatePassword()
        {
            if (this.textBoxUpdateNewPassword.Text == this.textBoxUpdateConfirmPassword.Text)
            {
                Users user = new Users();
                user.password = this.textBoxUpdateNewPassword.Text;
                user.userId = userId;
                UsersManager.userUpdatePassword(user);
                MessageBox.Show("Password changed");
                clearUpdateTextBoxes();
            }
            else
            {
                MessageBox.Show("Passwords dont match");
            }

        }
        private void userSelect()
        {
            
            DataTable dt = new DataTable();
            dt = UsersManager.userSelect();
            this.dataGridViewUser.DataSource = dt;
        }
        private void clearTextBoxes()
        {
            this.textBoxNewUserName.Text = "";
            this.textBoxPassword.Text = "";
            this.textBoxConfirmPassword.Text = "";
        }
        private void clearUpdateTextBoxes()
        {
            this.textBoxUpdateUserId.Text = "";
            this.textBoxUpdateUserName.Text = "";
            this.textBoxUpdateNewPassword.Text = "";
            this.textBoxConfirmPassword.Text = "";
        }




        private void buttonNewAccount_Click(object sender, EventArgs e)
        {
            userInsert();
        }

        private void User_Load(object sender, EventArgs e)
        {
            this.labelDontMatch.Visible = false;
            userSelect();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(this.textBoxPassword.Text, this.textBoxConfirmPassword.Text, true) != 0)
                this.labelDontMatch.Visible = true;
            else
                labelDontMatch.Visible = false;
        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(this.textBoxPassword.Text, this.textBoxConfirmPassword.Text, true) != 0)
                this.labelDontMatch.Visible = true;
            else
                labelDontMatch.Visible = false;
        }

        private void dataGridViewUser_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewUser.CurrentRow != null && this.dataGridViewUser.CurrentRow.Index != -1)
            {
                try
                {
                    userId = Convert.ToInt32(this.dataGridViewUser.CurrentRow.Cells[0].Value.ToString());
                    this.textBoxUpdateUserId.Text = this.dataGridViewUser.CurrentRow.Cells[0].Value.ToString();
                    this.textBoxUpdateUserName.Text = this.dataGridViewUser.CurrentRow.Cells[1].Value.ToString();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            userUpdatePassword();
        }

        private void textBoxUpdateNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(this.textBoxUpdateNewPassword.Text, this.textBoxUpdateConfirmPassword.Text, true) != 0)
                this.labelDontMatch.Visible = true;
            else
                labelDontMatch.Visible = false;
        }

        private void textBoxUpdateConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(this.textBoxUpdateNewPassword.Text, this.textBoxUpdateConfirmPassword.Text, true) != 0)
                this.labelDontMatch.Visible = true;
            else
                labelDontMatch.Visible = false;
        }
    }
}
