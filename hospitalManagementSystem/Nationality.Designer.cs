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
            this.labelNationality = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNationalities)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNationalities
            // 
            this.dataGridViewNationalities.AllowUserToAddRows = false;
            this.dataGridViewNationalities.AllowUserToDeleteRows = false;
            this.dataGridViewNationalities.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridViewNationalities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNationalities.Location = new System.Drawing.Point(18, 133);
            this.dataGridViewNationalities.Name = "dataGridViewNationalities";
            this.dataGridViewNationalities.ReadOnly = true;
            this.dataGridViewNationalities.Size = new System.Drawing.Size(333, 211);
            this.dataGridViewNationalities.TabIndex = 0;
            this.dataGridViewNationalities.SelectionChanged += new System.EventHandler(this.dataGridViewNationalities_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nationality:";
            // 
            // textBoxNationalityName
            // 
            this.textBoxNationalityName.BackColor = System.Drawing.Color.PowderBlue;
            this.textBoxNationalityName.Location = new System.Drawing.Point(154, 359);
            this.textBoxNationalityName.Name = "textBoxNationalityName";
            this.textBoxNationalityName.Size = new System.Drawing.Size(129, 20);
            this.textBoxNationalityName.TabIndex = 2;
            // 
            // buttonNewNationality
            // 
            this.buttonNewNationality.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonNewNationality.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonNewNationality.ForeColor = System.Drawing.Color.Navy;
            this.buttonNewNationality.Location = new System.Drawing.Point(22, 385);
            this.buttonNewNationality.Name = "buttonNewNationality";
            this.buttonNewNationality.Size = new System.Drawing.Size(261, 39);
            this.buttonNewNationality.TabIndex = 3;
            this.buttonNewNationality.Text = "New Nationality";
            this.buttonNewNationality.UseVisualStyleBackColor = false;
            this.buttonNewNationality.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonUpdate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.Navy;
            this.buttonUpdate.Location = new System.Drawing.Point(12, 59);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(175, 36);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.Navy;
            this.buttonDelete.Location = new System.Drawing.Point(193, 59);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(175, 36);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonClear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.Navy;
            this.buttonClear.Location = new System.Drawing.Point(289, 349);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(175, 36);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNationality.Location = new System.Drawing.Point(12, 98);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(152, 32);
            this.labelNationality.TabIndex = 12;
            this.labelNationality.Text = "Nationality";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonBack.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.Navy;
            this.buttonBack.Location = new System.Drawing.Point(16, 577);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(209, 43);
            this.buttonBack.TabIndex = 144;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelHeader.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(497, 39);
            this.labelHeader.TabIndex = 145;
            this.labelHeader.Text = "Nationality";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nationality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1398, 745);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelNationality);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonNewNationality);
            this.Controls.Add(this.textBoxNationalityName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNationalities);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Nationality";
            this.Text = "Nationality";
            this.Deactivate += new System.EventHandler(this.Nationality_Deactivate);
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
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelHeader;
    }
}