namespace Guard
{
    partial class AddPrevious
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
            this.rightPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.topPanelPrevious = new System.Windows.Forms.Panel();
            this.closeButtonPrevious = new System.Windows.Forms.Button();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.timeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addPreviousLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.yearPicker = new System.Windows.Forms.DateTimePicker();
            this.topPanelPrevious.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(349, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(1, 258);
            this.rightPanel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 257);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(349, 1);
            this.bottomPanel.TabIndex = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(1, 257);
            this.leftPanel.TabIndex = 2;
            // 
            // topPanelPrevious
            // 
            this.topPanelPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.topPanelPrevious.Controls.Add(this.panel1);
            this.topPanelPrevious.Controls.Add(this.closeButtonPrevious);
            this.topPanelPrevious.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanelPrevious.Location = new System.Drawing.Point(1, 0);
            this.topPanelPrevious.Name = "topPanelPrevious";
            this.topPanelPrevious.Size = new System.Drawing.Size(348, 41);
            this.topPanelPrevious.TabIndex = 3;
            this.topPanelPrevious.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanelPrevious_MouseDown);
            this.topPanelPrevious.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanelPrevious.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // closeButtonPrevious
            // 
            this.closeButtonPrevious.BackColor = System.Drawing.Color.Transparent;
            this.closeButtonPrevious.FlatAppearance.BorderSize = 0;
            this.closeButtonPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.closeButtonPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.closeButtonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButtonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButtonPrevious.ForeColor = System.Drawing.Color.White;
            this.closeButtonPrevious.Location = new System.Drawing.Point(308, 2);
            this.closeButtonPrevious.Name = "closeButtonPrevious";
            this.closeButtonPrevious.Size = new System.Drawing.Size(38, 33);
            this.closeButtonPrevious.TabIndex = 4;
            this.closeButtonPrevious.Text = "X";
            this.closeButtonPrevious.UseVisualStyleBackColor = false;
            this.closeButtonPrevious.Click += new System.EventHandler(this.closeButtonPrevious_Click);
            // 
            // monthComboBox
            // 
            this.monthComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthComboBox.ForeColor = System.Drawing.Color.White;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthComboBox.Location = new System.Drawing.Point(15, 64);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 21);
            this.monthComboBox.TabIndex = 4;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.BackColor = System.Drawing.Color.Transparent;
            this.monthLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.ForeColor = System.Drawing.Color.White;
            this.monthLabel.Location = new System.Drawing.Point(12, 44);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(46, 17);
            this.monthLabel.TabIndex = 5;
            this.monthLabel.Text = "Month";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.BackColor = System.Drawing.Color.Transparent;
            this.dayLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.ForeColor = System.Drawing.Color.White;
            this.dayLabel.Location = new System.Drawing.Point(12, 97);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(30, 17);
            this.dayLabel.TabIndex = 7;
            this.dayLabel.Text = "Day";
            // 
            // dayComboBox
            // 
            this.dayComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.dayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayComboBox.ForeColor = System.Drawing.Color.White;
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayComboBox.Location = new System.Drawing.Point(15, 117);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(121, 21);
            this.dayComboBox.TabIndex = 6;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.ForeColor = System.Drawing.Color.White;
            this.yearLabel.Location = new System.Drawing.Point(12, 150);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(33, 17);
            this.yearLabel.TabIndex = 9;
            this.yearLabel.Text = "Year";
            // 
            // timePicker
            // 
            this.timePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.timePicker.CustomFormat = "hh:mm:ss tt";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(15, 223);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(122, 20);
            this.timePicker.TabIndex = 23;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(12, 203);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(36, 17);
            this.timeLabel.TabIndex = 24;
            this.timeLabel.Text = "Time";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(-1, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 10);
            this.panel1.TabIndex = 25;
            // 
            // addPreviousLabel
            // 
            this.addPreviousLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPreviousLabel.ForeColor = System.Drawing.Color.White;
            this.addPreviousLabel.Location = new System.Drawing.Point(197, 45);
            this.addPreviousLabel.Name = "addPreviousLabel";
            this.addPreviousLabel.Size = new System.Drawing.Size(123, 16);
            this.addPreviousLabel.TabIndex = 26;
            this.addPreviousLabel.Text = "Add A Custom Date";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BackgroundImage = global::Guard.Properties.Resources.GuardLogo_copy;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.addButton.Location = new System.Drawing.Point(197, 77);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(123, 126);
            this.addButton.TabIndex = 27;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // yearPicker
            // 
            this.yearPicker.CustomFormat = "yyyy";
            this.yearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearPicker.Location = new System.Drawing.Point(14, 170);
            this.yearPicker.Name = "yearPicker";
            this.yearPicker.ShowUpDown = true;
            this.yearPicker.Size = new System.Drawing.Size(122, 20);
            this.yearPicker.TabIndex = 28;
            // 
            // AddPrevious
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(350, 258);
            this.Controls.Add(this.yearPicker);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addPreviousLabel);
            this.Controls.Add(this.topPanelPrevious);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.rightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPrevious";
            this.Text = "AddPrevious";
            this.topPanelPrevious.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanelPrevious;
        private System.Windows.Forms.Button closeButtonPrevious;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label addPreviousLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker yearPicker;
    }
}