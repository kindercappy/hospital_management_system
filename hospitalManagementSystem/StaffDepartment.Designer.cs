namespace hospitalManagementSystem
{
    partial class StaffDepartment
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonNewDepatment = new System.Windows.Forms.Button();
            this.textBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewStaffDepartment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaffDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.Navy;
            this.buttonClear.Location = new System.Drawing.Point(233, 229);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(122, 20);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonNewDepatment
            // 
            this.buttonNewDepatment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNewDepatment.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonNewDepatment.ForeColor = System.Drawing.Color.Navy;
            this.buttonNewDepatment.Location = new System.Drawing.Point(16, 255);
            this.buttonNewDepatment.Name = "buttonNewDepatment";
            this.buttonNewDepatment.Size = new System.Drawing.Size(211, 30);
            this.buttonNewDepatment.TabIndex = 22;
            this.buttonNewDepatment.Text = "New Department";
            this.buttonNewDepatment.UseVisualStyleBackColor = false;
            this.buttonNewDepatment.Click += new System.EventHandler(this.buttonNewDepatment_Click);
            // 
            // textBoxDepartmentName
            // 
            this.textBoxDepartmentName.Location = new System.Drawing.Point(98, 229);
            this.textBoxDepartmentName.Name = "textBoxDepartmentName";
            this.textBoxDepartmentName.Size = new System.Drawing.Size(129, 20);
            this.textBoxDepartmentName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Department:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.Navy;
            this.buttonDelete.Location = new System.Drawing.Point(168, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 23);
            this.buttonDelete.TabIndex = 19;
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
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridViewStaffDepartment
            // 
            this.dataGridViewStaffDepartment.AllowUserToAddRows = false;
            this.dataGridViewStaffDepartment.AllowUserToDeleteRows = false;
            this.dataGridViewStaffDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaffDepartment.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewStaffDepartment.Name = "dataGridViewStaffDepartment";
            this.dataGridViewStaffDepartment.ReadOnly = true;
            this.dataGridViewStaffDepartment.Size = new System.Drawing.Size(343, 182);
            this.dataGridViewStaffDepartment.TabIndex = 17;
            this.dataGridViewStaffDepartment.SelectionChanged += new System.EventHandler(this.dataGridViewStaffDepartment_SelectionChanged);
            // 
            // StaffDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1442, 801);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonNewDepatment);
            this.Controls.Add(this.textBoxDepartmentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewStaffDepartment);
            this.Name = "StaffDepartment";
            this.Text = "StaffDepartment";
            this.Load += new System.EventHandler(this.StaffDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaffDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonNewDepatment;
        private System.Windows.Forms.TextBox textBoxDepartmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridViewStaffDepartment;
    }
}