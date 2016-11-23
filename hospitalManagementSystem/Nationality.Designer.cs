namespace hospitalManagementSystem
{
    partial class Nationality
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
            this.dataGridViewNationalities = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNationalityName = new System.Windows.Forms.TextBox();
            this.buttonNewNationality = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNationalities)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNationalities
            // 
            this.dataGridViewNationalities.AllowUserToAddRows = false;
            this.dataGridViewNationalities.AllowUserToDeleteRows = false;
            this.dataGridViewNationalities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNationalities.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewNationalities.Name = "dataGridViewNationalities";
            this.dataGridViewNationalities.ReadOnly = true;
            this.dataGridViewNationalities.Size = new System.Drawing.Size(333, 211);
            this.dataGridViewNationalities.TabIndex = 0;
            this.dataGridViewNationalities.SelectionChanged += new System.EventHandler(this.dataGridViewNationalities_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nationality:";
            // 
            // textBoxNationalityName
            // 
            this.textBoxNationalityName.Location = new System.Drawing.Point(88, 258);
            this.textBoxNationalityName.Name = "textBoxNationalityName";
            this.textBoxNationalityName.Size = new System.Drawing.Size(129, 20);
            this.textBoxNationalityName.TabIndex = 2;
            // 
            // buttonNewNationality
            // 
            this.buttonNewNationality.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNewNationality.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonNewNationality.ForeColor = System.Drawing.Color.Navy;
            this.buttonNewNationality.Location = new System.Drawing.Point(14, 284);
            this.buttonNewNationality.Name = "buttonNewNationality";
            this.buttonNewNationality.Size = new System.Drawing.Size(203, 30);
            this.buttonNewNationality.TabIndex = 3;
            this.buttonNewNationality.Text = "New Nationality";
            this.buttonNewNationality.UseVisualStyleBackColor = false;
            this.buttonNewNationality.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.Navy;
            this.buttonUpdate.Location = new System.Drawing.Point(12, 12);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(150, 23);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.Navy;
            this.buttonDelete.Location = new System.Drawing.Point(168, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.Navy;
            this.buttonClear.Location = new System.Drawing.Point(223, 258);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(122, 20);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Nationality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1398, 745);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonNewNationality);
            this.Controls.Add(this.textBoxNationalityName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNationalities);
            this.Name = "Nationality";
            this.Text = "Nationality";
            this.Load += new System.EventHandler(this.Nationality_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNationalities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNationalities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNationalityName;
        private System.Windows.Forms.Button buttonNewNationality;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
    }
}