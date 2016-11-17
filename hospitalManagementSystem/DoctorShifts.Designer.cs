namespace hospitalManagementSystem
{
    partial class DoctorShifts
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelShiftName = new System.Windows.Forms.Label();
            this.textBoxShiftsName = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.buttonNewShift = new System.Windows.Forms.Button();
            this.dataGridViewShifts = new System.Windows.Forms.DataGridView();
            this.buttonUpdateShift = new System.Windows.Forms.Button();
            this.buttonDeleteShift = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBack.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.Navy;
            this.buttonBack.Location = new System.Drawing.Point(505, 155);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(123, 23);
            this.buttonBack.TabIndex = 55;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // labelShiftName
            // 
            this.labelShiftName.AutoSize = true;
            this.labelShiftName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShiftName.Location = new System.Drawing.Point(365, 12);
            this.labelShiftName.Name = "labelShiftName";
            this.labelShiftName.Size = new System.Drawing.Size(69, 13);
            this.labelShiftName.TabIndex = 58;
            this.labelShiftName.Text = "Shift Name";
            // 
            // textBoxShiftsName
            // 
            this.textBoxShiftsName.Location = new System.Drawing.Point(471, 12);
            this.textBoxShiftsName.Name = "textBoxShiftsName";
            this.textBoxShiftsName.Size = new System.Drawing.Size(173, 20);
            this.textBoxShiftsName.TabIndex = 59;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(471, 39);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(173, 20);
            this.textBoxFrom.TabIndex = 60;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(365, 42);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(100, 13);
            this.labelFrom.TabIndex = 61;
            this.labelFrom.Text = "From (00:00:00):";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(365, 72);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(88, 13);
            this.labelTo.TabIndex = 62;
            this.labelTo.Text = "To (00:00:00):";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(471, 65);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(173, 20);
            this.textBoxTo.TabIndex = 63;
            // 
            // buttonNewShift
            // 
            this.buttonNewShift.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNewShift.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonNewShift.ForeColor = System.Drawing.Color.Navy;
            this.buttonNewShift.Location = new System.Drawing.Point(368, 126);
            this.buttonNewShift.Name = "buttonNewShift";
            this.buttonNewShift.Size = new System.Drawing.Size(123, 23);
            this.buttonNewShift.TabIndex = 64;
            this.buttonNewShift.Text = "New Shift";
            this.buttonNewShift.UseVisualStyleBackColor = false;
            this.buttonNewShift.Click += new System.EventHandler(this.buttonNewShift_Click);
            // 
            // dataGridViewShifts
            // 
            this.dataGridViewShifts.AllowUserToAddRows = false;
            this.dataGridViewShifts.AllowUserToDeleteRows = false;
            this.dataGridViewShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShifts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewShifts.Name = "dataGridViewShifts";
            this.dataGridViewShifts.ReadOnly = true;
            this.dataGridViewShifts.Size = new System.Drawing.Size(347, 166);
            this.dataGridViewShifts.TabIndex = 65;
            this.dataGridViewShifts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShifts_CellClick);
            this.dataGridViewShifts.SelectionChanged += new System.EventHandler(this.dataGridViewShifts_SelectionChanged);
            // 
            // buttonUpdateShift
            // 
            this.buttonUpdateShift.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonUpdateShift.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonUpdateShift.ForeColor = System.Drawing.Color.Navy;
            this.buttonUpdateShift.Location = new System.Drawing.Point(505, 126);
            this.buttonUpdateShift.Name = "buttonUpdateShift";
            this.buttonUpdateShift.Size = new System.Drawing.Size(123, 23);
            this.buttonUpdateShift.TabIndex = 67;
            this.buttonUpdateShift.Text = "Update Shift";
            this.buttonUpdateShift.UseVisualStyleBackColor = false;
            this.buttonUpdateShift.Click += new System.EventHandler(this.buttonUpdateShift_Click);
            // 
            // buttonDeleteShift
            // 
            this.buttonDeleteShift.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDeleteShift.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteShift.ForeColor = System.Drawing.Color.Navy;
            this.buttonDeleteShift.Location = new System.Drawing.Point(368, 155);
            this.buttonDeleteShift.Name = "buttonDeleteShift";
            this.buttonDeleteShift.Size = new System.Drawing.Size(123, 23);
            this.buttonDeleteShift.TabIndex = 68;
            this.buttonDeleteShift.Text = "Delete Shift";
            this.buttonDeleteShift.UseVisualStyleBackColor = false;
            this.buttonDeleteShift.Click += new System.EventHandler(this.buttonDeleteShift_Click);
            // 
            // DoctorShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1458, 801);
            this.Controls.Add(this.buttonDeleteShift);
            this.Controls.Add(this.buttonUpdateShift);
            this.Controls.Add(this.dataGridViewShifts);
            this.Controls.Add(this.buttonNewShift);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.textBoxShiftsName);
            this.Controls.Add(this.labelShiftName);
            this.Controls.Add(this.buttonBack);
            this.Name = "DoctorShifts";
            this.Text = "DoctorShifts";
            this.Load += new System.EventHandler(this.DoctorShifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelShiftName;
        private System.Windows.Forms.TextBox textBoxShiftsName;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Button buttonNewShift;
        private System.Windows.Forms.DataGridView dataGridViewShifts;
        private System.Windows.Forms.Button buttonUpdateShift;
        private System.Windows.Forms.Button buttonDeleteShift;
    }
}