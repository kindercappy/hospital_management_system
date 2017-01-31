namespace hospitalManagementSystem
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNewUserName = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonNewAccount = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelChangePassword = new System.Windows.Forms.Label();
            this.textBoxUpdateUserId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDontMatch = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUpdateUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUpdateNewPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUpdateConfirmPassword = new System.Windows.Forms.TextBox();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.labelUpdateDontMatch = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDeleteUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDeleteUserId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelCreateNewUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNewUserName
            // 
            this.textBoxNewUserName.Location = new System.Drawing.Point(131, 31);
            this.textBoxNewUserName.Name = "textBoxNewUserName";
            this.textBoxNewUserName.Size = new System.Drawing.Size(168, 20);
            this.textBoxNewUserName.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label.Location = new System.Drawing.Point(14, 34);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Create New User:";
            // 
            // buttonNewAccount
            // 
            this.buttonNewAccount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewAccount.ForeColor = System.Drawing.Color.Navy;
            this.buttonNewAccount.Location = new System.Drawing.Point(17, 119);
            this.buttonNewAccount.Name = "buttonNewAccount";
            this.buttonNewAccount.Size = new System.Drawing.Size(282, 30);
            this.buttonNewAccount.TabIndex = 6;
            this.buttonNewAccount.Text = "Create User";
            this.buttonNewAccount.UseVisualStyleBackColor = false;
            this.buttonNewAccount.Click += new System.EventHandler(this.buttonNewAccount_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(131, 57);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(168, 20);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password:";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(131, 83);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '•';
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(168, 20);
            this.textBoxConfirmPassword.TabIndex = 10;
            this.textBoxConfirmPassword.TextChanged += new System.EventHandler(this.textBoxConfirmPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Confirm Password:";
            // 
            // labelChangePassword
            // 
            this.labelChangePassword.AutoSize = true;
            this.labelChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangePassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelChangePassword.Location = new System.Drawing.Point(17, 293);
            this.labelChangePassword.Name = "labelChangePassword";
            this.labelChangePassword.Size = new System.Drawing.Size(108, 13);
            this.labelChangePassword.TabIndex = 11;
            this.labelChangePassword.Text = "Change Password";
            // 
            // textBoxUpdateUserId
            // 
            this.textBoxUpdateUserId.Location = new System.Drawing.Point(134, 312);
            this.textBoxUpdateUserId.Name = "textBoxUpdateUserId";
            this.textBoxUpdateUserId.Size = new System.Drawing.Size(168, 20);
            this.textBoxUpdateUserId.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(17, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "User ID:";
            // 
            // labelDontMatch
            // 
            this.labelDontMatch.AutoSize = true;
            this.labelDontMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDontMatch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelDontMatch.Location = new System.Drawing.Point(305, 83);
            this.labelDontMatch.Name = "labelDontMatch";
            this.labelDontMatch.Size = new System.Drawing.Size(73, 13);
            this.labelDontMatch.TabIndex = 14;
            this.labelDontMatch.Text = "Dont Match";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(386, 35);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.Size = new System.Drawing.Size(245, 233);
            this.dataGridViewUser.TabIndex = 15;
            this.dataGridViewUser.SelectionChanged += new System.EventHandler(this.dataGridViewUser_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(17, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "User Name:";
            // 
            // textBoxUpdateUserName
            // 
            this.textBoxUpdateUserName.Location = new System.Drawing.Point(134, 338);
            this.textBoxUpdateUserName.Name = "textBoxUpdateUserName";
            this.textBoxUpdateUserName.Size = new System.Drawing.Size(168, 20);
            this.textBoxUpdateUserName.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(17, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "New Password:";
            // 
            // textBoxUpdateNewPassword
            // 
            this.textBoxUpdateNewPassword.Location = new System.Drawing.Point(134, 364);
            this.textBoxUpdateNewPassword.Name = "textBoxUpdateNewPassword";
            this.textBoxUpdateNewPassword.PasswordChar = '•';
            this.textBoxUpdateNewPassword.Size = new System.Drawing.Size(168, 20);
            this.textBoxUpdateNewPassword.TabIndex = 18;
            this.textBoxUpdateNewPassword.TextChanged += new System.EventHandler(this.textBoxUpdateNewPassword_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(17, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Confirm Password:";
            // 
            // textBoxUpdateConfirmPassword
            // 
            this.textBoxUpdateConfirmPassword.Location = new System.Drawing.Point(134, 390);
            this.textBoxUpdateConfirmPassword.Name = "textBoxUpdateConfirmPassword";
            this.textBoxUpdateConfirmPassword.PasswordChar = '•';
            this.textBoxUpdateConfirmPassword.Size = new System.Drawing.Size(168, 20);
            this.textBoxUpdateConfirmPassword.TabIndex = 20;
            this.textBoxUpdateConfirmPassword.TextChanged += new System.EventHandler(this.textBoxUpdateConfirmPassword_TextChanged);
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateUser.ForeColor = System.Drawing.Color.Navy;
            this.buttonUpdateUser.Location = new System.Drawing.Point(20, 416);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(282, 30);
            this.buttonUpdateUser.TabIndex = 22;
            this.buttonUpdateUser.Text = "Update";
            this.buttonUpdateUser.UseVisualStyleBackColor = false;
            this.buttonUpdateUser.Click += new System.EventHandler(this.buttonUpdateUser_Click);
            // 
            // labelUpdateDontMatch
            // 
            this.labelUpdateDontMatch.AutoSize = true;
            this.labelUpdateDontMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateDontMatch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelUpdateDontMatch.Location = new System.Drawing.Point(308, 393);
            this.labelUpdateDontMatch.Name = "labelUpdateDontMatch";
            this.labelUpdateDontMatch.Size = new System.Drawing.Size(73, 13);
            this.labelUpdateDontMatch.TabIndex = 23;
            this.labelUpdateDontMatch.Text = "Dont Match";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(637, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "User Name:";
            // 
            // textBoxDeleteUserName
            // 
            this.textBoxDeleteUserName.Location = new System.Drawing.Point(754, 80);
            this.textBoxDeleteUserName.Name = "textBoxDeleteUserName";
            this.textBoxDeleteUserName.Size = new System.Drawing.Size(168, 20);
            this.textBoxDeleteUserName.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(637, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "User ID:";
            // 
            // textBoxDeleteUserId
            // 
            this.textBoxDeleteUserId.Location = new System.Drawing.Point(754, 54);
            this.textBoxDeleteUserId.Name = "textBoxDeleteUserId";
            this.textBoxDeleteUserId.Size = new System.Drawing.Size(168, 20);
            this.textBoxDeleteUserId.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(637, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Delete User";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Navy;
            this.buttonDelete.Location = new System.Drawing.Point(640, 106);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(282, 30);
            this.buttonDelete.TabIndex = 29;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelUser.Location = new System.Drawing.Point(382, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(48, 22);
            this.labelUser.TabIndex = 25;
            this.labelUser.Text = "User";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBack.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.Navy;
            this.buttonBack.Location = new System.Drawing.Point(18, 528);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(209, 43);
            this.buttonBack.TabIndex = 144;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelCreateNewUser
            // 
            this.labelCreateNewUser.AutoSize = true;
            this.labelCreateNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateNewUser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelCreateNewUser.Location = new System.Drawing.Point(15, 9);
            this.labelCreateNewUser.Name = "labelCreateNewUser";
            this.labelCreateNewUser.Size = new System.Drawing.Size(103, 13);
            this.labelCreateNewUser.TabIndex = 145;
            this.labelCreateNewUser.Text = "Create New User";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1271, 741);
            this.Controls.Add(this.labelCreateNewUser);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDeleteUserName);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxDeleteUserId);
            this.Controls.Add(this.labelUpdateDontMatch);
            this.Controls.Add(this.buttonUpdateUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxUpdateConfirmPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxUpdateNewPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUpdateUserName);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.labelDontMatch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUpdateUserId);
            this.Controls.Add(this.labelChangePassword);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNewAccount);
            this.Controls.Add(this.textBoxNewUserName);
            this.Controls.Add(this.label);
            this.Name = "User";
            this.Text = " ";
            this.Deactivate += new System.EventHandler(this.User_Deactivate);
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewUserName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonNewAccount;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelChangePassword;
        private System.Windows.Forms.TextBox textBoxUpdateUserId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDontMatch;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUpdateUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUpdateNewPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUpdateConfirmPassword;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.Label labelUpdateDontMatch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDeleteUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDeleteUserId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelCreateNewUser;
    }
}