namespace Guard
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.rightBorder = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.datesTextBox = new System.Windows.Forms.TextBox();
            this.achTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.seeDatesButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.seeAchButton = new System.Windows.Forms.Button();
            this.addNowButton = new System.Windows.Forms.Button();
            this.addPrevButton = new System.Windows.Forms.Button();
            this.achLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nextGoalPanel = new System.Windows.Forms.Panel();
            this.titleNextGoalLabel = new System.Windows.Forms.Label();
            this.nextGoalLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timeLeftTitleLabel = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timeSinceTitleLabel = new System.Windows.Forms.Label();
            this.timeSinceLabel = new System.Windows.Forms.Label();
            this.currentTimeTitleLabel = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.timersLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.nextGoalPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightBorder
            // 
            this.rightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.rightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorder.Location = new System.Drawing.Point(932, 0);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(1, 450);
            this.rightBorder.TabIndex = 1;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 449);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(932, 1);
            this.bottomPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 449);
            this.panel1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // datesTextBox
            // 
            this.datesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.datesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datesTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.datesTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.datesTextBox.Location = new System.Drawing.Point(6, 7);
            this.datesTextBox.Multiline = true;
            this.datesTextBox.Name = "datesTextBox";
            this.datesTextBox.ReadOnly = true;
            this.datesTextBox.Size = new System.Drawing.Size(161, 226);
            this.datesTextBox.TabIndex = 4;
            this.datesTextBox.TabStop = false;
            // 
            // achTextBox
            // 
            this.achTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.achTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.achTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.achTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.achTextBox.Location = new System.Drawing.Point(5, 7);
            this.achTextBox.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.achTextBox.Multiline = true;
            this.achTextBox.Name = "achTextBox";
            this.achTextBox.ReadOnly = true;
            this.achTextBox.Size = new System.Drawing.Size(327, 226);
            this.achTextBox.TabIndex = 5;
            this.achTextBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.seeDatesButton);
            this.panel2.Controls.Add(this.datesTextBox);
            this.panel2.Location = new System.Drawing.Point(743, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 265);
            this.panel2.TabIndex = 6;
            // 
            // seeDatesButton
            // 
            this.seeDatesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.seeDatesButton.FlatAppearance.BorderSize = 0;
            this.seeDatesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.seeDatesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.seeDatesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seeDatesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeDatesButton.ForeColor = System.Drawing.Color.White;
            this.seeDatesButton.Location = new System.Drawing.Point(0, 234);
            this.seeDatesButton.Name = "seeDatesButton";
            this.seeDatesButton.Size = new System.Drawing.Size(171, 31);
            this.seeDatesButton.TabIndex = 7;
            this.seeDatesButton.TabStop = false;
            this.seeDatesButton.Text = "Show All Dates";
            this.seeDatesButton.UseVisualStyleBackColor = false;
            this.seeDatesButton.Click += new System.EventHandler(this.seeDatesButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.seeAchButton);
            this.panel3.Controls.Add(this.achTextBox);
            this.panel3.Location = new System.Drawing.Point(389, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 265);
            this.panel3.TabIndex = 7;
            // 
            // seeAchButton
            // 
            this.seeAchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.seeAchButton.FlatAppearance.BorderSize = 0;
            this.seeAchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.seeAchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.seeAchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seeAchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeAchButton.ForeColor = System.Drawing.Color.White;
            this.seeAchButton.Location = new System.Drawing.Point(0, 234);
            this.seeAchButton.Name = "seeAchButton";
            this.seeAchButton.Size = new System.Drawing.Size(356, 31);
            this.seeAchButton.TabIndex = 7;
            this.seeAchButton.TabStop = false;
            this.seeAchButton.Text = "Show All Achievements";
            this.seeAchButton.UseVisualStyleBackColor = false;
            // 
            // addNowButton
            // 
            this.addNowButton.BackColor = System.Drawing.Color.Green;
            this.addNowButton.FlatAppearance.BorderSize = 0;
            this.addNowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addNowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.addNowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNowButton.ForeColor = System.Drawing.Color.White;
            this.addNowButton.Location = new System.Drawing.Point(743, 338);
            this.addNowButton.Name = "addNowButton";
            this.addNowButton.Size = new System.Drawing.Size(171, 25);
            this.addNowButton.TabIndex = 8;
            this.addNowButton.TabStop = false;
            this.addNowButton.Text = "Add Now";
            this.addNowButton.UseVisualStyleBackColor = false;
            this.addNowButton.Click += new System.EventHandler(this.addNowButton_Click);
            // 
            // addPrevButton
            // 
            this.addPrevButton.BackColor = System.Drawing.Color.SlateBlue;
            this.addPrevButton.FlatAppearance.BorderSize = 0;
            this.addPrevButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.addPrevButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.addPrevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPrevButton.ForeColor = System.Drawing.Color.White;
            this.addPrevButton.Location = new System.Drawing.Point(743, 363);
            this.addPrevButton.Name = "addPrevButton";
            this.addPrevButton.Size = new System.Drawing.Size(171, 25);
            this.addPrevButton.TabIndex = 9;
            this.addPrevButton.TabStop = false;
            this.addPrevButton.Text = "Add Previous";
            this.addPrevButton.UseVisualStyleBackColor = false;
            this.addPrevButton.Click += new System.EventHandler(this.addPrevButton_Click);
            // 
            // achLabel
            // 
            this.achLabel.AutoSize = true;
            this.achLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achLabel.ForeColor = System.Drawing.Color.White;
            this.achLabel.Location = new System.Drawing.Point(516, 44);
            this.achLabel.Name = "achLabel";
            this.achLabel.Size = new System.Drawing.Size(97, 25);
            this.achLabel.TabIndex = 10;
            this.achLabel.Text = "Best Times";
            this.achLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(800, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dates";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextGoalPanel
            // 
            this.nextGoalPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nextGoalPanel.Controls.Add(this.titleNextGoalLabel);
            this.nextGoalPanel.Controls.Add(this.nextGoalLabel);
            this.nextGoalPanel.Location = new System.Drawing.Point(19, 72);
            this.nextGoalPanel.Name = "nextGoalPanel";
            this.nextGoalPanel.Size = new System.Drawing.Size(353, 80);
            this.nextGoalPanel.TabIndex = 12;
            // 
            // titleNextGoalLabel
            // 
            this.titleNextGoalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleNextGoalLabel.ForeColor = System.Drawing.Color.White;
            this.titleNextGoalLabel.Location = new System.Drawing.Point(0, 0);
            this.titleNextGoalLabel.Name = "titleNextGoalLabel";
            this.titleNextGoalLabel.Size = new System.Drawing.Size(353, 31);
            this.titleNextGoalLabel.TabIndex = 0;
            this.titleNextGoalLabel.Text = "Next Goal";
            this.titleNextGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextGoalLabel
            // 
            this.nextGoalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextGoalLabel.ForeColor = System.Drawing.Color.White;
            this.nextGoalLabel.Location = new System.Drawing.Point(0, 19);
            this.nextGoalLabel.Name = "nextGoalLabel";
            this.nextGoalLabel.Size = new System.Drawing.Size(353, 61);
            this.nextGoalLabel.TabIndex = 1;
            this.nextGoalLabel.Text = "0 Years 0 Months 0 Days 0 Hours 0 Minutes";
            this.nextGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextGoalLabel.Click += new System.EventHandler(this.nextGoalLabel_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Controls.Add(this.timeLeftTitleLabel);
            this.panel4.Controls.Add(this.timeLeftLabel);
            this.panel4.Location = new System.Drawing.Point(19, 164);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(353, 80);
            this.panel4.TabIndex = 13;
            // 
            // timeLeftTitleLabel
            // 
            this.timeLeftTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftTitleLabel.ForeColor = System.Drawing.Color.White;
            this.timeLeftTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.timeLeftTitleLabel.Name = "timeLeftTitleLabel";
            this.timeLeftTitleLabel.Size = new System.Drawing.Size(353, 31);
            this.timeLeftTitleLabel.TabIndex = 0;
            this.timeLeftTitleLabel.Text = "Time Left";
            this.timeLeftTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLabel.ForeColor = System.Drawing.Color.White;
            this.timeLeftLabel.Location = new System.Drawing.Point(0, 19);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(353, 61);
            this.timeLeftLabel.TabIndex = 1;
            this.timeLeftLabel.Text = "0 Years 0 Months 0 Days 0 Hours 0 Minutes";
            this.timeLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Controls.Add(this.timeSinceTitleLabel);
            this.panel5.Controls.Add(this.timeSinceLabel);
            this.panel5.Location = new System.Drawing.Point(19, 257);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(353, 80);
            this.panel5.TabIndex = 14;
            // 
            // timeSinceTitleLabel
            // 
            this.timeSinceTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSinceTitleLabel.ForeColor = System.Drawing.Color.White;
            this.timeSinceTitleLabel.Location = new System.Drawing.Point(1, 1);
            this.timeSinceTitleLabel.Name = "timeSinceTitleLabel";
            this.timeSinceTitleLabel.Size = new System.Drawing.Size(353, 31);
            this.timeSinceTitleLabel.TabIndex = 2;
            this.timeSinceTitleLabel.Text = "Time Since";
            this.timeSinceTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeSinceLabel
            // 
            this.timeSinceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSinceLabel.ForeColor = System.Drawing.Color.White;
            this.timeSinceLabel.Location = new System.Drawing.Point(0, 19);
            this.timeSinceLabel.Name = "timeSinceLabel";
            this.timeSinceLabel.Size = new System.Drawing.Size(353, 61);
            this.timeSinceLabel.TabIndex = 2;
            this.timeSinceLabel.Text = "0 Years 0 Months 0 Days 0 Hours 0 Minutes";
            this.timeSinceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTimeTitleLabel
            // 
            this.currentTimeTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeTitleLabel.ForeColor = System.Drawing.Color.White;
            this.currentTimeTitleLabel.Location = new System.Drawing.Point(771, 398);
            this.currentTimeTitleLabel.Name = "currentTimeTitleLabel";
            this.currentTimeTitleLabel.Size = new System.Drawing.Size(113, 22);
            this.currentTimeTitleLabel.TabIndex = 0;
            this.currentTimeTitleLabel.Text = "System Time";
            this.currentTimeTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currentTimeTitleLabel.Click += new System.EventHandler(this.currentTimeTitleLabel_Click);
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLabel.ForeColor = System.Drawing.Color.White;
            this.currentTimeLabel.Location = new System.Drawing.Point(743, 418);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(171, 23);
            this.currentTimeLabel.TabIndex = 1;
            this.currentTimeLabel.Text = "01/01/1970 00:00:00 AM";
            this.currentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currentTimeLabel.Click += new System.EventHandler(this.currentTimeLabel_Click);
            // 
            // timersLabel
            // 
            this.timersLabel.AutoSize = true;
            this.timersLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timersLabel.ForeColor = System.Drawing.Color.White;
            this.timersLabel.Location = new System.Drawing.Point(165, 44);
            this.timersLabel.Name = "timersLabel";
            this.timersLabel.Size = new System.Drawing.Size(59, 25);
            this.timersLabel.TabIndex = 15;
            this.timersLabel.Text = "Status";
            this.timersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.topPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topPanel.BackgroundImage")));
            this.topPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Location = new System.Drawing.Point(1, 1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(933, 33);
            this.topPanel.TabIndex = 0;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
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
            this.closeButton.Location = new System.Drawing.Point(895, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(38, 33);
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Gray;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(19, 413);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(110, 25);
            this.settingsButton.TabIndex = 17;
            this.settingsButton.TabStop = false;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.timersLabel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.nextGoalPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.achLabel);
            this.Controls.Add(this.addPrevButton);
            this.Controls.Add(this.addNowButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.rightBorder);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.currentTimeTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.nextGoalPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel rightBorder;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox datesTextBox;
        private System.Windows.Forms.TextBox achTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button seeDatesButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button seeAchButton;
        private System.Windows.Forms.Button addNowButton;
        private System.Windows.Forms.Button addPrevButton;
        private System.Windows.Forms.Label achLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel nextGoalPanel;
        private System.Windows.Forms.Label titleNextGoalLabel;
        private System.Windows.Forms.Label nextGoalLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label timeLeftTitleLabel;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label currentTimeTitleLabel;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label timersLabel;
        private System.Windows.Forms.Label timeSinceTitleLabel;
        private System.Windows.Forms.Label timeSinceLabel;
        private System.Windows.Forms.Button settingsButton;
    }
}

