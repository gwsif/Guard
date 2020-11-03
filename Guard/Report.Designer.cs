namespace Guard
{
    partial class Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.annualDGV = new System.Windows.Forms.DataGridView();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalsLabel = new System.Windows.Forms.Label();
            this.threeMonthLabel = new System.Windows.Forms.Label();
            this.threeMonthAvgLabel = new System.Windows.Forms.Label();
            this.sixMonthLabel = new System.Windows.Forms.Label();
            this.sixMonthAvgLabel = new System.Windows.Forms.Label();
            this.reportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.currTrendLabel = new System.Windows.Forms.Label();
            this.trendOutLabel = new System.Windows.Forms.Label();
            this.adviceTextBox = new System.Windows.Forms.TextBox();
            this.weeklyLabel = new System.Windows.Forms.Label();
            this.fiveWeekAvgLabel = new System.Windows.Forms.Label();
            this.seeAllTopPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.topRight = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.topLeftPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.annualDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).BeginInit();
            this.seeAllTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // annualDGV
            // 
            this.annualDGV.AllowUserToAddRows = false;
            this.annualDGV.AllowUserToDeleteRows = false;
            this.annualDGV.AllowUserToResizeColumns = false;
            this.annualDGV.AllowUserToResizeRows = false;
            this.annualDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.annualDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.annualDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.annualDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.annualDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.annualDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.year,
            this.totals});
            this.annualDGV.EnableHeadersVisualStyles = false;
            this.annualDGV.Location = new System.Drawing.Point(17, 63);
            this.annualDGV.Name = "annualDGV";
            this.annualDGV.ReadOnly = true;
            this.annualDGV.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.annualDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.annualDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.annualDGV.Size = new System.Drawing.Size(199, 179);
            this.annualDGV.TabIndex = 0;
            this.annualDGV.TabStop = false;
            // 
            // year
            // 
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // totals
            // 
            this.totals.DataPropertyName = "totals";
            this.totals.HeaderText = "Totals";
            this.totals.Name = "totals";
            this.totals.ReadOnly = true;
            // 
            // totalsLabel
            // 
            this.totalsLabel.AutoSize = true;
            this.totalsLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsLabel.ForeColor = System.Drawing.Color.White;
            this.totalsLabel.Location = new System.Drawing.Point(55, 35);
            this.totalsLabel.Name = "totalsLabel";
            this.totalsLabel.Size = new System.Drawing.Size(116, 25);
            this.totalsLabel.TabIndex = 16;
            this.totalsLabel.Text = "Annual Totals";
            this.totalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // threeMonthLabel
            // 
            this.threeMonthLabel.AutoSize = true;
            this.threeMonthLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeMonthLabel.ForeColor = System.Drawing.Color.White;
            this.threeMonthLabel.Location = new System.Drawing.Point(233, 35);
            this.threeMonthLabel.Name = "threeMonthLabel";
            this.threeMonthLabel.Size = new System.Drawing.Size(151, 25);
            this.threeMonthLabel.TabIndex = 17;
            this.threeMonthLabel.Text = "3 Month Average";
            this.threeMonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // threeMonthAvgLabel
            // 
            this.threeMonthAvgLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.threeMonthAvgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeMonthAvgLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.threeMonthAvgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.threeMonthAvgLabel.Location = new System.Drawing.Point(232, 63);
            this.threeMonthAvgLabel.Name = "threeMonthAvgLabel";
            this.threeMonthAvgLabel.Size = new System.Drawing.Size(152, 40);
            this.threeMonthAvgLabel.TabIndex = 18;
            this.threeMonthAvgLabel.Text = "label2";
            this.threeMonthAvgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sixMonthLabel
            // 
            this.sixMonthLabel.AutoSize = true;
            this.sixMonthLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixMonthLabel.ForeColor = System.Drawing.Color.White;
            this.sixMonthLabel.Location = new System.Drawing.Point(233, 103);
            this.sixMonthLabel.Name = "sixMonthLabel";
            this.sixMonthLabel.Size = new System.Drawing.Size(151, 25);
            this.sixMonthLabel.TabIndex = 19;
            this.sixMonthLabel.Text = "6 Month Average";
            this.sixMonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sixMonthAvgLabel
            // 
            this.sixMonthAvgLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.sixMonthAvgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixMonthAvgLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.sixMonthAvgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sixMonthAvgLabel.Location = new System.Drawing.Point(232, 130);
            this.sixMonthAvgLabel.Name = "sixMonthAvgLabel";
            this.sixMonthAvgLabel.Size = new System.Drawing.Size(152, 40);
            this.sixMonthAvgLabel.TabIndex = 20;
            this.sixMonthAvgLabel.Text = "label2";
            this.sixMonthAvgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportChart
            // 
            this.reportChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.reportChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Bisque;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            chartArea1.BorderColor = System.Drawing.Color.SlateBlue;
            chartArea1.Name = "ChartArea1";
            this.reportChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            legend1.ForeColor = System.Drawing.Color.LightGray;
            legend1.Name = "Legend1";
            this.reportChart.Legends.Add(legend1);
            this.reportChart.Location = new System.Drawing.Point(17, 253);
            this.reportChart.Name = "reportChart";
            this.reportChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.reportChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.SlateBlue};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelForeColor = System.Drawing.Color.SlateBlue;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.reportChart.Series.Add(series1);
            this.reportChart.Size = new System.Drawing.Size(1014, 383);
            this.reportChart.TabIndex = 21;
            this.reportChart.Text = "chart1";
            // 
            // currTrendLabel
            // 
            this.currTrendLabel.AutoSize = true;
            this.currTrendLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currTrendLabel.ForeColor = System.Drawing.Color.White;
            this.currTrendLabel.Location = new System.Drawing.Point(655, 35);
            this.currTrendLabel.Name = "currTrendLabel";
            this.currTrendLabel.Size = new System.Drawing.Size(124, 25);
            this.currTrendLabel.TabIndex = 22;
            this.currTrendLabel.Text = "Incident Trend";
            this.currTrendLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currTrendLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // trendOutLabel
            // 
            this.trendOutLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.trendOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trendOutLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.trendOutLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trendOutLabel.Location = new System.Drawing.Point(400, 63);
            this.trendOutLabel.Name = "trendOutLabel";
            this.trendOutLabel.Size = new System.Drawing.Size(627, 50);
            this.trendOutLabel.TabIndex = 23;
            this.trendOutLabel.Text = "label2";
            this.trendOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adviceTextBox
            // 
            this.adviceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.adviceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adviceTextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adviceTextBox.ForeColor = System.Drawing.Color.White;
            this.adviceTextBox.Location = new System.Drawing.Point(402, 120);
            this.adviceTextBox.Multiline = true;
            this.adviceTextBox.Name = "adviceTextBox";
            this.adviceTextBox.Size = new System.Drawing.Size(621, 73);
            this.adviceTextBox.TabIndex = 24;
            // 
            // weeklyLabel
            // 
            this.weeklyLabel.AutoSize = true;
            this.weeklyLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyLabel.ForeColor = System.Drawing.Color.White;
            this.weeklyLabel.Location = new System.Drawing.Point(237, 174);
            this.weeklyLabel.Name = "weeklyLabel";
            this.weeklyLabel.Size = new System.Drawing.Size(140, 25);
            this.weeklyLabel.TabIndex = 25;
            this.weeklyLabel.Text = "Weekly Average";
            this.weeklyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fiveWeekAvgLabel
            // 
            this.fiveWeekAvgLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.fiveWeekAvgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveWeekAvgLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.fiveWeekAvgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fiveWeekAvgLabel.Location = new System.Drawing.Point(233, 202);
            this.fiveWeekAvgLabel.Name = "fiveWeekAvgLabel";
            this.fiveWeekAvgLabel.Size = new System.Drawing.Size(152, 40);
            this.fiveWeekAvgLabel.TabIndex = 26;
            this.fiveWeekAvgLabel.Text = "label2";
            this.fiveWeekAvgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seeAllTopPanel
            // 
            this.seeAllTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.seeAllTopPanel.Controls.Add(this.topLeftPanel);
            this.seeAllTopPanel.Controls.Add(this.topPanel);
            this.seeAllTopPanel.Controls.Add(this.topRight);
            this.seeAllTopPanel.Controls.Add(this.closeButton);
            this.seeAllTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.seeAllTopPanel.Location = new System.Drawing.Point(0, 0);
            this.seeAllTopPanel.Name = "seeAllTopPanel";
            this.seeAllTopPanel.Size = new System.Drawing.Size(1046, 33);
            this.seeAllTopPanel.TabIndex = 27;
            this.seeAllTopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.seeAllTopPanel_Paint);
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
            this.closeButton.Location = new System.Drawing.Point(1007, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(38, 33);
            this.closeButton.TabIndex = 4;
            this.closeButton.TabStop = false;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click_1);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1045, 33);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(1, 617);
            this.rightPanel.TabIndex = 28;
            // 
            // topRight
            // 
            this.topRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.topRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.topRight.Location = new System.Drawing.Point(1045, 0);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(1, 33);
            this.topRight.TabIndex = 5;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1045, 1);
            this.topPanel.TabIndex = 6;
            // 
            // topLeftPanel
            // 
            this.topLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.topLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.topLeftPanel.Location = new System.Drawing.Point(0, 1);
            this.topLeftPanel.Name = "topLeftPanel";
            this.topLeftPanel.Size = new System.Drawing.Size(1, 32);
            this.topLeftPanel.TabIndex = 7;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 33);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(1, 617);
            this.leftPanel.TabIndex = 29;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(1, 649);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1044, 1);
            this.bottomPanel.TabIndex = 30;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1046, 650);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.fiveWeekAvgLabel);
            this.Controls.Add(this.weeklyLabel);
            this.Controls.Add(this.adviceTextBox);
            this.Controls.Add(this.trendOutLabel);
            this.Controls.Add(this.currTrendLabel);
            this.Controls.Add(this.reportChart);
            this.Controls.Add(this.sixMonthAvgLabel);
            this.Controls.Add(this.sixMonthLabel);
            this.Controls.Add(this.threeMonthAvgLabel);
            this.Controls.Add(this.threeMonthLabel);
            this.Controls.Add(this.totalsLabel);
            this.Controls.Add(this.annualDGV);
            this.Controls.Add(this.seeAllTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report Card";
            ((System.ComponentModel.ISupportInitialize)(this.annualDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).EndInit();
            this.seeAllTopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView annualDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn totals;
        private System.Windows.Forms.Label totalsLabel;
        private System.Windows.Forms.Label threeMonthLabel;
        private System.Windows.Forms.Label threeMonthAvgLabel;
        private System.Windows.Forms.Label sixMonthLabel;
        private System.Windows.Forms.Label sixMonthAvgLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart reportChart;
        private System.Windows.Forms.Label currTrendLabel;
        private System.Windows.Forms.Label trendOutLabel;
        private System.Windows.Forms.TextBox adviceTextBox;
        private System.Windows.Forms.Label weeklyLabel;
        private System.Windows.Forms.Label fiveWeekAvgLabel;
        private System.Windows.Forms.Panel seeAllTopPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel topRight;
        private System.Windows.Forms.Panel topLeftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel bottomPanel;
    }
}