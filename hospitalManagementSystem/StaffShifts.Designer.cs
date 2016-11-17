namespace hospitalManagementSystem
{
    partial class StaffShifts
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
            this.buttonDeleteShift = new System.Windows.Forms.Button();
            this.buttonUpdateShift = new System.Windows.Forms.Button();
            this.dataGridViewShifts = new System.Windows.Forms.DataGridView();
            this.buttonNewShift = new System.Windows.Forms.Button();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxShiftName = new System.Windows.Forms.TextBox();
            this.labelShiftName = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonClearTextboxes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteShift
            // 
            this.buttonDeleteShift.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDeleteShift.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteShift.ForeColor = System.Drawing.Color.Navy;
            this.buttonDeleteShift.Location = new System.Drawing.Point(470, 155);
            this.buttonDeleteShift.Name = "buttonDeleteShift";
            this.buttonDeleteShift.Size = new System.Drawing.Size(123, 23);
            this.buttonDeleteShift.TabIndex = 79;
            this.buttonDeleteShift.Text = "Delete Shift";
            this.buttonDeleteShift.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateShift
            // 
            this.buttonUpdateShift.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonUpdateShift.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonUpdateShift.ForeColor = System.Drawing.Color.Navy;
            this.buttonUpdateShift.Location = new System.Drawing.Point(607, 126);
            this.buttonUpdateShift.Name = "buttonUpdateShift";
            this.buttonUpdateShift.Size = new System.Drawing.Size(123, 23);
            this.buttonUpdateShift.TabIndex = 78;
            this.buttonUpdateShift.Text = "Update Shift";
            this.buttonUpdateShift.UseVisualStyleBackColor = false;
            // 
            // dataGridViewShifts
            // 
            this.dataGridViewShifts.AllowUserToAddRows = false;
            this.dataGridViewShifts.AllowUserToDeleteRows = false;
            this.dataGridViewShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShifts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewShifts.Name = "dataGridViewShifts";
            this.dataGridViewShifts.ReadOnly = true;
            this.dataGridViewShifts.Size = new System.Drawing.Size(449, 166);
            this.dataGridViewShifts.TabIndex = 77;
            this.dataGridViewShifts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShifts_CellClick);
            this.dataGridViewShifts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShifts_CellContentClick);
            this.dataGridViewShifts.SelectionChanged += new System.EventHandler(this.dataGridViewShifts_SelectionChanged);
            this.dataGridViewShifts.Click += new System.EventHandler(this.dataGridViewShifts_Click);
            // 
            // buttonNewShift
            // 
            this.buttonNewShift.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNewShift.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonNewShift.ForeColor = System.Drawing.Color.Navy;
            this.buttonNewShift.Location = new System.Drawing.Point(470, 126);
            this.buttonNewShift.Name = "buttonNewShift";
            this.buttonNewShift.Size = new System.Drawing.Size(123, 23);
            this.buttonNewShift.TabIndex = 76;
            this.buttonNewShift.Text = "New Shift";
            this.buttonNewShift.UseVisualStyleBackColor = false;
            this.buttonNewShift.Click += new System.EventHandler(this.buttonNewShift_Click);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(573, 65);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(173, 20);
            this.textBoxTo.TabIndex = 75;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(467, 72);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(88, 13);
            this.labelTo.TabIndex = 74;
            this.labelTo.Text = "To (00:00:00):";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(467, 42);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(100, 13);
            this.labelFrom.TabIndex = 73;
            this.labelFrom.Text = "From (00:00:00):";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(573, 39);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(173, 20);
            this.textBoxFrom.TabIndex = 72;
            // 
            // textBoxShiftName
            // 
            this.textBoxShiftName.Location = new System.Drawing.Point(573, 12);
            this.textBoxShiftName.Name = "textBoxShiftName";
            this.textBoxShiftName.Size = new System.Drawing.Size(173, 20);
            this.textBoxShiftName.TabIndex = 71;
            // 
            // labelShiftName
            // 
            this.labelShiftName.AutoSize = true;
            this.labelShiftName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShiftName.Location = new System.Drawing.Point(467, 12);
            this.labelShiftName.Name = "labelShiftName";
            this.labelShiftName.Size = new System.Drawing.Size(69, 13);
            this.labelShiftName.TabIndex = 70;
            this.labelShiftName.Text = "Shift Name";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBack.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.Navy;
            this.buttonBack.Location = new System.Drawing.Point(607, 155);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(123, 23);
            this.buttonBack.TabIndex = 69;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonClearTextboxes
            // 
            this.buttonClearTextboxes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClearTextboxes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonClearTextboxes.ForeColor = System.Drawing.Color.Navy;
            this.buttonClearTextboxes.Location = new System.Drawing.Point(752, 12);
            this.buttonClearTextboxes.Name = "buttonClearTextboxes";
            this.buttonClearTextboxes.Size = new System.Drawing.Size(123, 47);
            this.buttonClearTextboxes.TabIndex = 80;
            this.buttonClearTextboxes.Text = "Clear";
            this.buttonClearTextboxes.UseVisualStyleBackColor = false;
            this.buttonClearTextboxes.Click += new System.EventHandler(this.buttonClearTextboxes_Click);
            // 
            // StaffShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1342, 739);
            this.Controls.Add(this.buttonClearTextboxes);
            this.Controls.Add(this.buttonDeleteShift);
            this.Controls.Add(this.buttonUpdateShift);
            this.Controls.Add(this.dataGridViewShifts);
            this.Controls.Add(this.buttonNewShift);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.textBoxShiftName);
            this.Controls.Add(this.labelShiftName);
            this.Controls.Add(this.buttonBack);
            this.Name = "StaffShifts";
            this.Text = "StaffShifts";
            this.Load += new System.EventHandler(this.StaffShifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteShift;
        private System.Windows.Forms.Button buttonUpdateShift;
        private System.Windows.Forms.DataGridView dataGridViewShifts;
        private System.Windows.Forms.Button buttonNewShift;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxShiftName;
        private System.Windows.Forms.Label labelShiftName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonClearTextboxes;
    }
}