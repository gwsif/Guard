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
            this.seeAllTopPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.rightBorder = new System.Windows.Forms.Panel();
            this.bottomBorder = new System.Windows.Forms.Panel();
            this.leftBorder = new System.Windows.Forms.Panel();
            this.allDatesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numEntriesLabel = new System.Windows.Forms.Label();
            this.exportRAWButton = new System.Windows.Forms.Button();
            this.exportFriendlyButton = new System.Windows.Forms.Button();
            this.seeAllTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // seeAllTopPanel
            // 
            this.seeAllTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.seeAllTopPanel.Controls.Add(this.closeButton);
            this.seeAllTopPanel.Location = new System.Drawing.Point(1, 1);
            this.seeAllTopPanel.Name = "seeAllTopPanel";
            this.seeAllTopPanel.Size = new System.Drawing.Size(577, 33);
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
            this.closeButton.Location = new System.Drawing.Point(539, 0);
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
            this.rightBorder.Location = new System.Drawing.Point(578, 0);
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
            this.bottomBorder.Size = new System.Drawing.Size(578, 1);
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
            // allDatesTextBox
            // 
            this.allDatesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.allDatesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allDatesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allDatesTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.allDatesTextBox.Location = new System.Drawing.Point(302, 40);
            this.allDatesTextBox.Multiline = true;
            this.allDatesTextBox.Name = "allDatesTextBox";
            this.allDatesTextBox.ReadOnly = true;
            this.allDatesTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.allDatesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.allDatesTextBox.Size = new System.Drawing.Size(265, 398);
            this.allDatesTextBox.TabIndex = 14;
            this.allDatesTextBox.TabStop = false;
            this.allDatesTextBox.Text = "ThisIsATest";
            this.allDatesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // SeeAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.seeAllTopPanel);
            this.Controls.Add(this.exportFriendlyButton);
            this.Controls.Add(this.exportRAWButton);
            this.Controls.Add(this.numEntriesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allDatesTextBox);
            this.Controls.Add(this.leftBorder);
            this.Controls.Add(this.bottomBorder);
            this.Controls.Add(this.rightBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeeAll";
            this.Text = "Form2";
            this.seeAllTopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel seeAllTopPanel;
        private System.Windows.Forms.Panel rightBorder;
        private System.Windows.Forms.Panel bottomBorder;
        private System.Windows.Forms.Panel leftBorder;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox allDatesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numEntriesLabel;
        private System.Windows.Forms.Button exportRAWButton;
        private System.Windows.Forms.Button exportFriendlyButton;
    }
}