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
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearchId = new System.Windows.Forms.Label();
            this.textBoxSearchId = new System.Windows.Forms.TextBox();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.labelShifts = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonBack.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.Navy;
            this.buttonBack.Location = new System.Drawing.Point(654, 269);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(175, 36);
            this.buttonBack.TabIndex = 55;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // labelShiftName
            // 
            this.labelShiftName.AutoSize = true;
            this.labelShiftName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelShiftName.Location = new System.Drawing.Point(465, 126);
            this.labelShiftName.Name = "labelShiftName";
            this.labelShiftName.Size = new System.Drawing.Size(127, 25);
            this.labelShiftName.TabIndex = 58;
            this.labelShiftName.Text = "Shift Name";
            // 
            // textBoxShiftsName
            // 
            this.textBoxShiftsName.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxShiftsName.Location = new System.Drawing.Point(654, 131);
            this.textBoxShiftsName.Name = "textBoxShiftsName";
            this.textBoxShiftsName.Size = new System.Drawing.Size(173, 20);
            this.textBoxShiftsName.TabIndex = 59;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxFrom.Location = new System.Drawing.Point(654, 158);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(173, 20);
            this.textBoxFrom.TabIndex = 60;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelFrom.Location = new System.Drawing.Point(465, 156);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(187, 25);
            this.labelFrom.TabIndex = 61;
            this.labelFrom.Text = "From (00:00:00):";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelTo.Location = new System.Drawing.Point(465, 186);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(161, 25);
            this.labelTo.TabIndex = 62;
            this.labelTo.Text = "To (00:00:00):";
            // 
            // textBoxTo
            // 
            this.textBoxTo.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxTo.Location = new System.Drawing.Point(654, 184);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(173, 20);
            this.textBoxTo.TabIndex = 63;
            // 
            // buttonNewShift
            // 
            this.buttonNewShift.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonNewShift.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonNewShift.ForeColor = System.Drawing.Color.Navy;
            this.buttonNewShift.Location = new System.Drawing.Point(468, 227);
            this.buttonNewShift.Name = "buttonNewShift";
            this.buttonNewShift.Size = new System.Drawing.Size(175, 36);
            this.buttonNewShift.TabIndex = 64;
            this.buttonNewShift.Text = "New Shift";
            this.buttonNewShift.UseVisualStyleBackColor = false;
            this.buttonNewShift.Click += new System.EventHandler(this.buttonNewShift_Click);
            // 
            // dataGridViewShifts
            // 
            this.dataGridViewShifts.AllowUserToAddRows = false;
            this.dataGridViewShifts.AllowUserToDeleteRows = false;
            this.dataGridViewShifts.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridViewShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShifts.Location = new System.Drawing.Point(12, 126);
            this.dataGridViewShifts.Name = "dataGridViewShifts";
            this.dataGridViewShifts.ReadOnly = true;
            this.dataGridViewShifts.Size = new System.Drawing.Size(447, 166);
            this.dataGridViewShifts.TabIndex = 65;
            this.dataGridViewShifts.SelectionChanged += new System.EventHandler(this.dataGridViewShifts_SelectionChanged);
            // 
            // buttonUpdateShift
            // 
            this.buttonUpdateShift.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonUpdateShift.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonUpdateShift.ForeColor = System.Drawing.Color.Navy;
            this.buttonUpdateShift.Location = new System.Drawing.Point(654, 227);
            this.buttonUpdateShift.Name = "buttonUpdateShift";
            this.buttonUpdateShift.Size = new System.Drawing.Size(175, 36);
            this.buttonUpdateShift.TabIndex = 67;
            this.buttonUpdateShift.Text = "Update Shift";
            this.buttonUpdateShift.UseVisualStyleBackColor = false;
            this.buttonUpdateShift.Click += new System.EventHandler(this.buttonUpdateShift_Click);
            // 
            // buttonDeleteShift
            // 
            this.buttonDeleteShift.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonDeleteShift.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteShift.ForeColor = System.Drawing.Color.Navy;
            this.buttonDeleteShift.Location = new System.Drawing.Point(468, 269);
            this.buttonDeleteShift.Name = "buttonDeleteShift";
            this.buttonDeleteShift.Size = new System.Drawing.Size(175, 36);
            this.buttonDeleteShift.TabIndex = 68;
            this.buttonDeleteShift.Text = "Delete Shift";
            this.buttonDeleteShift.UseVisualStyleBackColor = false;
            this.buttonDeleteShift.Click += new System.EventHandler(this.buttonDeleteShift_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonReset.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReset.ForeColor = System.Drawing.Color.Navy;
            this.buttonReset.Location = new System.Drawing.Point(694, 56);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(175, 36);
            this.buttonReset.TabIndex = 96;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.Navy;
            this.buttonSearch.Location = new System.Drawing.Point(513, 56);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(175, 36);
            this.buttonSearch.TabIndex = 94;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearchId
            // 
            this.labelSearchId.AutoSize = true;
            this.labelSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelSearchId.Location = new System.Drawing.Point(279, 60);
            this.labelSearchId.Name = "labelSearchId";
            this.labelSearchId.Size = new System.Drawing.Size(122, 25);
            this.labelSearchId.TabIndex = 92;
            this.labelSearchId.Text = "Search ID:";
            // 
            // textBoxSearchId
            // 
            this.textBoxSearchId.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxSearchId.Location = new System.Drawing.Point(407, 66);
            this.textBoxSearchId.Name = "textBoxSearchId";
            this.textBoxSearchId.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchId.TabIndex = 91;
            this.textBoxSearchId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchId_KeyPress);
            // 
            // labelSearchName
            // 
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelSearchName.Location = new System.Drawing.Point(7, 60);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(160, 25);
            this.labelSearchName.TabIndex = 90;
            this.labelSearchName.Text = "Search Name:";
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxSearchName.Location = new System.Drawing.Point(173, 66);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchName.TabIndex = 89;
            this.textBoxSearchName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchName_KeyPress);
            // 
            // labelShifts
            // 
            this.labelShifts.AutoSize = true;
            this.labelShifts.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShifts.Location = new System.Drawing.Point(12, 91);
            this.labelShifts.Name = "labelShifts";
            this.labelShifts.Size = new System.Drawing.Size(86, 32);
            this.labelShifts.TabIndex = 97;
            this.labelShifts.Text = "Shifts";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(12, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 43);
            this.button1.TabIndex = 144;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeader.BackColor = System.Drawing.Color.DarkGreen;
            this.labelHeader.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeader.Location = new System.Drawing.Point(-1, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(527, 39);
            this.labelHeader.TabIndex = 145;
            this.labelHeader.Text = "New Shifts (Doctor)";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoctorShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1458, 801);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelShifts);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelSearchId);
            this.Controls.Add(this.textBoxSearchId);
            this.Controls.Add(this.labelSearchName);
            this.Controls.Add(this.textBoxSearchName);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.DoctorShifts_Deactivate);
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
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearchId;
        private System.Windows.Forms.TextBox textBoxSearchId;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Label labelShifts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelHeader;
    }
}