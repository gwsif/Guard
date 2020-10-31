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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.annualDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).BeginInit();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.annualDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.annualDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.year,
            this.totals});
            this.annualDGV.EnableHeadersVisualStyles = false;
            this.annualDGV.Location = new System.Drawing.Point(17, 37);
            this.annualDGV.Name = "annualDGV";
            this.annualDGV.ReadOnly = true;
            this.annualDGV.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.annualDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            this.totalsLabel.Location = new System.Drawing.Point(55, 9);
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
            this.threeMonthLabel.Location = new System.Drawing.Point(233, 9);
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
            this.threeMonthAvgLabel.Location = new System.Drawing.Point(232, 37);
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
            this.sixMonthLabel.Location = new System.Drawing.Point(233, 77);
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
            this.sixMonthAvgLabel.Location = new System.Drawing.Point(232, 104);
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
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Bisque;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            chartArea2.BorderColor = System.Drawing.Color.SlateBlue;
            chartArea2.Name = "ChartArea1";
            this.reportChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            legend2.ForeColor = System.Drawing.Color.LightGray;
            legend2.Name = "Legend1";
            this.reportChart.Legends.Add(legend2);
            this.reportChart.Location = new System.Drawing.Point(17, 222);
            this.reportChart.Name = "reportChart";
            this.reportChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.reportChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.SlateBlue};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelForeColor = System.Drawing.Color.SlateBlue;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.reportChart.Series.Add(series2);
            this.reportChart.Size = new System.Drawing.Size(1014, 383);
            this.reportChart.TabIndex = 21;
            this.reportChart.Text = "chart1";
            // 
            // currTrendLabel
            // 
            this.currTrendLabel.AutoSize = true;
            this.currTrendLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currTrendLabel.ForeColor = System.Drawing.Color.White;
            this.currTrendLabel.Location = new System.Drawing.Point(655, 9);
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
            this.trendOutLabel.Location = new System.Drawing.Point(400, 37);
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
            this.adviceTextBox.Location = new System.Drawing.Point(402, 94);
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
            this.weeklyLabel.Location = new System.Drawing.Point(237, 148);
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
            this.fiveWeekAvgLabel.Location = new System.Drawing.Point(233, 176);
            this.fiveWeekAvgLabel.Name = "fiveWeekAvgLabel";
            this.fiveWeekAvgLabel.Size = new System.Drawing.Size(152, 40);
            this.fiveWeekAvgLabel.TabIndex = 26;
            this.fiveWeekAvgLabel.Text = "label2";
            this.fiveWeekAvgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1045, 613);
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
            this.Name = "Report";
            this.Text = "Report Card";
            ((System.ComponentModel.ISupportInitialize)(this.annualDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).EndInit();
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
    }
}