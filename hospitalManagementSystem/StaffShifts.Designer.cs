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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearchId = new System.Windows.Forms.Label();
            this.textBoxSearchId = new System.Windows.Forms.TextBox();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.labelStaffShifts = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteShift
            // 
            this.buttonDeleteShift.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonDeleteShift.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteShift.ForeColor = System.Drawing.Color.Navy;
            this.buttonDeleteShift.Location = new System.Drawing.Point(471, 421);
            this.buttonDeleteShift.Name = "buttonDeleteShift";
            this.buttonDeleteShift.Size = new System.Drawing.Size(175, 36);
            this.buttonDeleteShift.TabIndex = 79;
            this.buttonDeleteShift.Text = "Delete Shift";
            this.buttonDeleteShift.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateShift
            // 
            this.buttonUpdateShift.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonUpdateShift.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonUpdateShift.ForeColor = System.Drawing.Color.Navy;
            this.buttonUpdateShift.Location = new System.Drawing.Point(651, 379);
            this.buttonUpdateShift.Name = "buttonUpdateShift";
            this.buttonUpdateShift.Size = new System.Drawing.Size(175, 36);
            this.buttonUpdateShift.TabIndex = 78;
            this.buttonUpdateShift.Text = "Update Shift";
            this.buttonUpdateShift.UseVisualStyleBackColor = false;
            // 
            // dataGridViewShifts
            // 
            this.dataGridViewShifts.AllowUserToAddRows = false;
            this.dataGridViewShifts.AllowUserToDeleteRows = false;
            this.dataGridViewShifts.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridViewShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShifts.Location = new System.Drawing.Point(15, 140);
            this.dataGridViewShifts.Name = "dataGridViewShifts";
            this.dataGridViewShifts.ReadOnly = true;
            this.dataGridViewShifts.Size = new System.Drawing.Size(449, 332);
            this.dataGridViewShifts.TabIndex = 77;
            this.dataGridViewShifts.SelectionChanged += new System.EventHandler(this.dataGridViewShifts_SelectionChanged);
            // 
            // buttonNewShift
            // 
            this.buttonNewShift.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonNewShift.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonNewShift.ForeColor = System.Drawing.Color.Navy;
            this.buttonNewShift.Location = new System.Drawing.Point(470, 379);
            this.buttonNewShift.Name = "buttonNewShift";
            this.buttonNewShift.Size = new System.Drawing.Size(175, 36);
            this.buttonNewShift.TabIndex = 76;
            this.buttonNewShift.Text = "New Shift";
            this.buttonNewShift.UseVisualStyleBackColor = false;
            this.buttonNewShift.Click += new System.EventHandler(this.buttonNewShift_Click);
            // 
            // textBoxTo
            // 
            this.textBoxTo.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxTo.Location = new System.Drawing.Point(636, 326);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(173, 20);
            this.textBoxTo.TabIndex = 75;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(467, 325);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(139, 24);
            this.labelTo.TabIndex = 74;
            this.labelTo.Text = "To (00:00:00):";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(467, 295);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(163, 24);
            this.labelFrom.TabIndex = 73;
            this.labelFrom.Text = "From (00:00:00):";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxFrom.Location = new System.Drawing.Point(636, 300);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(173, 20);
            this.textBoxFrom.TabIndex = 72;
            // 
            // textBoxShiftName
            // 
            this.textBoxShiftName.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxShiftName.Location = new System.Drawing.Point(636, 273);
            this.textBoxShiftName.Name = "textBoxShiftName";
            this.textBoxShiftName.Size = new System.Drawing.Size(173, 20);
            this.textBoxShiftName.TabIndex = 71;
            // 
            // labelShiftName
            // 
            this.labelShiftName.AutoSize = true;
            this.labelShiftName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShiftName.Location = new System.Drawing.Point(467, 265);
            this.labelShiftName.Name = "labelShiftName";
            this.labelShiftName.Size = new System.Drawing.Size(111, 24);
            this.labelShiftName.TabIndex = 70;
            this.labelShiftName.Text = "Shift Name";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonBack.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.Navy;
            this.buttonBack.Location = new System.Drawing.Point(652, 421);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(175, 36);
            this.buttonBack.TabIndex = 69;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonClearTextboxes
            // 
            this.buttonClearTextboxes.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonClearTextboxes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearTextboxes.ForeColor = System.Drawing.Color.Navy;
            this.buttonClearTextboxes.Location = new System.Drawing.Point(815, 286);
            this.buttonClearTextboxes.Name = "buttonClearTextboxes";
            this.buttonClearTextboxes.Size = new System.Drawing.Size(123, 47);
            this.buttonClearTextboxes.TabIndex = 80;
            this.buttonClearTextboxes.Text = "Clear";
            this.buttonClearTextboxes.UseVisualStyleBackColor = false;
            this.buttonClearTextboxes.Click += new System.EventHandler(this.buttonClearTextboxes_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonRefresh.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRefresh.ForeColor = System.Drawing.Color.Navy;
            this.buttonRefresh.Location = new System.Drawing.Point(667, 60);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(175, 36);
            this.buttonRefresh.TabIndex = 90;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.Navy;
            this.buttonSearch.Location = new System.Drawing.Point(486, 61);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(175, 36);
            this.buttonSearch.TabIndex = 88;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearchId
            // 
            this.labelSearchId.AutoSize = true;
            this.labelSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchId.Location = new System.Drawing.Point(267, 66);
            this.labelSearchId.Name = "labelSearchId";
            this.labelSearchId.Size = new System.Drawing.Size(107, 24);
            this.labelSearchId.TabIndex = 86;
            this.labelSearchId.Text = "Search ID:";
            // 
            // textBoxSearchId
            // 
            this.textBoxSearchId.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxSearchId.Location = new System.Drawing.Point(380, 70);
            this.textBoxSearchId.Name = "textBoxSearchId";
            this.textBoxSearchId.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchId.TabIndex = 85;
            this.textBoxSearchId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchId_KeyPress);
            // 
            // labelSearchName
            // 
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchName.Location = new System.Drawing.Point(12, 66);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(143, 24);
            this.labelSearchName.TabIndex = 84;
            this.labelSearchName.Text = "Search Name:";
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxSearchName.Location = new System.Drawing.Point(161, 70);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchName.TabIndex = 83;
            this.textBoxSearchName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchName_KeyPress);
            // 
            // labelStaffShifts
            // 
            this.labelStaffShifts.AutoSize = true;
            this.labelStaffShifts.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffShifts.Location = new System.Drawing.Point(12, 101);
            this.labelStaffShifts.Name = "labelStaffShifts";
            this.labelStaffShifts.Size = new System.Drawing.Size(172, 36);
            this.labelStaffShifts.TabIndex = 91;
            this.labelStaffShifts.Text = "Staff Shifts";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(16, 681);
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
            this.labelHeader.BackColor = System.Drawing.Color.BurlyWood;
            this.labelHeader.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(521, 39);
            this.labelHeader.TabIndex = 145;
            this.labelHeader.Text = "New Shifts (Staff)";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaffShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1342, 739);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelStaffShifts);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelSearchId);
            this.Controls.Add(this.textBoxSearchId);
            this.Controls.Add(this.labelSearchName);
            this.Controls.Add(this.textBoxSearchName);
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
            this.Deactivate += new System.EventHandler(this.StaffShifts_Deactivate);
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
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearchId;
        private System.Windows.Forms.TextBox textBoxSearchId;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Label labelStaffShifts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelHeader;
    }
}