namespace hospitalManagementSystem
{
    partial class DoctorDepartment
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
            this.dataGridViewDoctorDepartment = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonNewDepartment = new System.Windows.Forms.Button();
            this.textBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDoctorDepartment = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoctorDepartment
            // 
            this.dataGridViewDoctorDepartment.AllowUserToAddRows = false;
            this.dataGridViewDoctorDepartment.AllowUserToDeleteRows = false;
            this.dataGridViewDoctorDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctorDepartment.Location = new System.Drawing.Point(13, 70);
            this.dataGridViewDoctorDepartment.Name = "dataGridViewDoctorDepartment";
            this.dataGridViewDoctorDepartment.ReadOnly = true;
            this.dataGridViewDoctorDepartment.Size = new System.Drawing.Size(306, 150);
            this.dataGridViewDoctorDepartment.TabIndex = 0;
            this.dataGridViewDoctorDepartment.SelectionChanged += new System.EventHandler(this.dataGridViewDoctorDepartment_SelectionChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.Navy;
            this.buttonDelete.Location = new System.Drawing.Point(168, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.Navy;
            this.buttonUpdate.Location = new System.Drawing.Point(12, 12);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(150, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.Navy;
            this.buttonClear.Location = new System.Drawing.Point(230, 226);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(122, 20);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonNewDepartment
            // 
            this.buttonNewDepartment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNewDepartment.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonNewDepartment.ForeColor = System.Drawing.Color.Navy;
            this.buttonNewDepartment.Location = new System.Drawing.Point(13, 252);
            this.buttonNewDepartment.Name = "buttonNewDepartment";
            this.buttonNewDepartment.Size = new System.Drawing.Size(211, 30);
            this.buttonNewDepartment.TabIndex = 15;
            this.buttonNewDepartment.Text = "New Department";
            this.buttonNewDepartment.UseVisualStyleBackColor = false;
            this.buttonNewDepartment.Click += new System.EventHandler(this.buttonNewDepartment_Click);
            // 
            // textBoxDepartmentName
            // 
            this.textBoxDepartmentName.Location = new System.Drawing.Point(95, 226);
            this.textBoxDepartmentName.Name = "textBoxDepartmentName";
            this.textBoxDepartmentName.Size = new System.Drawing.Size(129, 20);
            this.textBoxDepartmentName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Department:";
            // 
            // labelDoctorDepartment
            // 
            this.labelDoctorDepartment.AutoSize = true;
            this.labelDoctorDepartment.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDoctorDepartment.Location = new System.Drawing.Point(9, 44);
            this.labelDoctorDepartment.Name = "labelDoctorDepartment";
            this.labelDoctorDepartment.Size = new System.Drawing.Size(169, 22);
            this.labelDoctorDepartment.TabIndex = 17;
            this.labelDoctorDepartment.Text = "Doctor Department";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBack.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.Navy;
            this.buttonBack.Location = new System.Drawing.Point(12, 528);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(209, 43);
            this.buttonBack.TabIndex = 144;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // DoctorDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1414, 793);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelDoctorDepartment);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonNewDepartment);
            this.Controls.Add(this.textBoxDepartmentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewDoctorDepartment);
            this.Name = "DoctorDepartment";
            this.Text = "DoctorDepartment";
            this.Deactivate += new System.EventHandler(this.DoctorDepartment_Deactivate);
            this.Load += new System.EventHandler(this.DoctorDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoctorDepartment;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonNewDepartment;
        private System.Windows.Forms.TextBox textBoxDepartmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDoctorDepartment;
        private System.Windows.Forms.Button buttonBack;
    }
}