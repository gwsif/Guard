namespace Guard
{
    partial class SeeAll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.seeAllTopPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.rightBorder = new System.Windows.Forms.Panel();
            this.bottomBorder = new System.Windows.Forms.Panel();
            this.leftBorder = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numEntriesLabel = new System.Windows.Forms.Label();
            this.exportRAWButton = new System.Windows.Forms.Button();
            this.exportFriendlyButton = new System.Windows.Forms.Button();
            this.guardDatesDGV = new System.Windows.Forms.DataGridView();
            this.DayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportButton = new System.Windows.Forms.Button();
            this.seeAllTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guardDatesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // seeAllTopPanel
            // 
            this.seeAllTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.seeAllTopPanel.Controls.Add(this.closeButton);
            this.seeAllTopPanel.Location = new System.Drawing.Point(1, 1);
            this.seeAllTopPanel.Name = "seeAllTopPanel";
            this.seeAllTopPanel.Size = new System.Drawing.Size(836, 33);
            this.seeAllTopPanel.TabIndex = 0;
            this.seeAllTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.seeAllTopPanel_MouseDown);
            this.seeAllTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.seeAllTopPanel_MouseMove);
            this.seeAllTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.seeAllTopPanel_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(799, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(38, 33);
            this.closeButton.TabIndex = 4;
            this.closeButton.TabStop = false;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // rightBorder
            // 
            this.rightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.rightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorder.Location = new System.Drawing.Point(837, 0);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(1, 450);
            this.rightBorder.TabIndex = 1;
            // 
            // bottomBorder
            // 
            this.bottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBorder.Location = new System.Drawing.Point(0, 449);
            this.bottomBorder.Name = "bottomBorder";
            this.bottomBorder.Size = new System.Drawing.Size(837, 1);
            this.bottomBorder.TabIndex = 2;
            // 
            // leftBorder
            // 
            this.leftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.leftBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBorder.Location = new System.Drawing.Point(0, 0);
            this.leftBorder.Name = "leftBorder";
            this.leftBorder.Size = new System.Drawing.Size(1, 449);
            this.leftBorder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 43);
            this.label1.TabIndex = 15;
            this.label1.Text = "Entries";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numEntriesLabel
            // 
            this.numEntriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEntriesLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.numEntriesLabel.Location = new System.Drawing.Point(12, 105);
            this.numEntriesLabel.Name = "numEntriesLabel";
            this.numEntriesLabel.Size = new System.Drawing.Size(280, 75);
            this.numEntriesLabel.TabIndex = 16;
            this.numEntriesLabel.Text = "label2";
            this.numEntriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exportRAWButton
            // 
            this.exportRAWButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.exportRAWButton.FlatAppearance.BorderSize = 0;
            this.exportRAWButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.exportRAWButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.exportRAWButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportRAWButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportRAWButton.ForeColor = System.Drawing.Color.White;
            this.exportRAWButton.Location = new System.Drawing.Point(12, 370);
            this.exportRAWButton.Name = "exportRAWButton";
            this.exportRAWButton.Size = new System.Drawing.Size(280, 31);
            this.exportRAWButton.TabIndex = 17;
            this.exportRAWButton.Text = "Export RAW Data To CSV";
            this.exportRAWButton.UseVisualStyleBackColor = false;
            // 
            // exportFriendlyButton
            // 
            this.exportFriendlyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.exportFriendlyButton.FlatAppearance.BorderSize = 0;
            this.exportFriendlyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.exportFriendlyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.exportFriendlyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportFriendlyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportFriendlyButton.ForeColor = System.Drawing.Color.White;
            this.exportFriendlyButton.Location = new System.Drawing.Point(12, 407);
            this.exportFriendlyButton.Name = "exportFriendlyButton";
            this.exportFriendlyButton.Size = new System.Drawing.Size(280, 31);
            this.exportFriendlyButton.TabIndex = 18;
            this.exportFriendlyButton.Text = "Export Readable Data To CSV";
            this.exportFriendlyButton.UseVisualStyleBackColor = false;
            this.exportFriendlyButton.Click += new System.EventHandler(this.exportFriendlyButton_Click);
            // 
            // guardDatesDGV
            // 
            this.guardDatesDGV.AllowUserToAddRows = false;
            this.guardDatesDGV.AllowUserToDeleteRows = false;
            this.guardDatesDGV.AllowUserToResizeColumns = false;
            this.guardDatesDGV.AllowUserToResizeRows = false;
            this.guardDatesDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.guardDatesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guardDatesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.guardDatesDGV.ColumnHeadersHeight = 25;
            this.guardDatesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guardDatesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DayOfWeek,
            this.MonthName,
            this.Day,
            this.Year,
            this.Time});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guardDatesDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.guardDatesDGV.EnableHeadersVisualStyles = false;
            this.guardDatesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guardDatesDGV.Location = new System.Drawing.Point(298, 40);
            this.guardDatesDGV.Name = "guardDatesDGV";
            this.guardDatesDGV.ReadOnly = true;
            this.guardDatesDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guardDatesDGV.RowHeadersVisible = false;
            this.guardDatesDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.guardDatesDGV.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.guardDatesDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.guardDatesDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.guardDatesDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardDatesDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.guardDatesDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.guardDatesDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guardDatesDGV.Size = new System.Drawing.Size(528, 398);
            this.guardDatesDGV.TabIndex = 19;
            this.guardDatesDGV.TabStop = false;
            this.guardDatesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guardDatesDGV_CellContentClick);
            // 
            // DayOfWeek
            // 
            this.DayOfWeek.DataPropertyName = "day_of_week";
            this.DayOfWeek.HeaderText = "Day Of Week";
            this.DayOfWeek.Name = "DayOfWeek";
            this.DayOfWeek.ReadOnly = true;
            // 
            // MonthName
            // 
            this.MonthName.DataPropertyName = "month";
            this.MonthName.HeaderText = "Month";
            this.MonthName.Name = "MonthName";
            this.MonthName.ReadOnly = true;
            // 
            // Day
            // 
            this.Day.DataPropertyName = "day";
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "year";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Year.DefaultCellStyle = dataGridViewCellStyle7;
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "timestamp";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Time.DefaultCellStyle = dataGridViewCellStyle8;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.Color.Green;
            this.reportButton.FlatAppearance.BorderSize = 0;
            this.reportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.reportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.ForeColor = System.Drawing.Color.White;
            this.reportButton.Location = new System.Drawing.Point(92, 288);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(113, 31);
            this.reportButton.TabIndex = 20;
            this.reportButton.Text = "Report Card";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // SeeAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.guardDatesDGV);
            this.Controls.Add(this.seeAllTopPanel);
            this.Controls.Add(this.exportFriendlyButton);
            this.Controls.Add(this.exportRAWButton);
            this.Controls.Add(this.numEntriesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leftBorder);
            this.Controls.Add(this.bottomBorder);
            this.Controls.Add(this.rightBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeeAll";
            this.Text = "Form2";
            this.seeAllTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guardDatesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel seeAllTopPanel;
        private System.Windows.Forms.Panel rightBorder;
        private System.Windows.Forms.Panel bottomBorder;
        private System.Windows.Forms.Panel leftBorder;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numEntriesLabel;
        private System.Windows.Forms.Button exportRAWButton;
        private System.Windows.Forms.Button exportFriendlyButton;
        private System.Windows.Forms.DataGridView guardDatesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayOfWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Button reportButton;
    }
}