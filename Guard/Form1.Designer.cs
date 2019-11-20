namespace Guard
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rightBorder = new System.Windows.Forms.Panel();
            this.bottomBorder = new System.Windows.Forms.Panel();
            this.leftBorder = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topPanel4 = new System.Windows.Forms.Panel();
            this.closeButtonPrevious = new System.Windows.Forms.Button();
            this.guardText = new System.Windows.Forms.PictureBox();
            this.guardLogo = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guardText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // rightBorder
            // 
            this.rightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.rightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorder.Location = new System.Drawing.Point(652, 0);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(1, 391);
            this.rightBorder.TabIndex = 0;
            // 
            // bottomBorder
            // 
            this.bottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBorder.Location = new System.Drawing.Point(0, 390);
            this.bottomBorder.Name = "bottomBorder";
            this.bottomBorder.Size = new System.Drawing.Size(652, 1);
            this.bottomBorder.TabIndex = 1;
            // 
            // leftBorder
            // 
            this.leftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.leftBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBorder.Location = new System.Drawing.Point(0, 0);
            this.leftBorder.Name = "leftBorder";
            this.leftBorder.Size = new System.Drawing.Size(1, 390);
            this.leftBorder.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 1);
            this.panel1.TabIndex = 3;
            // 
            // topPanel4
            // 
            this.topPanel4.Controls.Add(this.closeButtonPrevious);
            this.topPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel4.Location = new System.Drawing.Point(1, 1);
            this.topPanel4.Name = "topPanel4";
            this.topPanel4.Size = new System.Drawing.Size(651, 38);
            this.topPanel4.TabIndex = 4;
            this.topPanel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel4_MouseDown);
            this.topPanel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel4_MouseMove);
            this.topPanel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel4_MouseUp);
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
            this.closeButtonPrevious.Location = new System.Drawing.Point(610, 3);
            this.closeButtonPrevious.Name = "closeButtonPrevious";
            this.closeButtonPrevious.Size = new System.Drawing.Size(38, 33);
            this.closeButtonPrevious.TabIndex = 6;
            this.closeButtonPrevious.Text = "X";
            this.closeButtonPrevious.UseVisualStyleBackColor = false;
            this.closeButtonPrevious.Click += new System.EventHandler(this.closeButtonPrevious_Click);
            // 
            // guardText
            // 
            this.guardText.BackgroundImage = global::Guard.Properties.Resources.GuardText_copy;
            this.guardText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guardText.Location = new System.Drawing.Point(370, 45);
            this.guardText.Name = "guardText";
            this.guardText.Size = new System.Drawing.Size(222, 93);
            this.guardText.TabIndex = 7;
            this.guardText.TabStop = false;
            // 
            // guardLogo
            // 
            this.guardLogo.BackgroundImage = global::Guard.Properties.Resources.GuardLogo_copy;
            this.guardLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guardLogo.InitialImage = global::Guard.Properties.Resources.GuardLogo_copy;
            this.guardLogo.Location = new System.Drawing.Point(7, 45);
            this.guardLogo.Name = "guardLogo";
            this.guardLogo.Size = new System.Drawing.Size(307, 310);
            this.guardLogo.TabIndex = 5;
            this.guardLogo.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(370, 144);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(222, 210);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(508, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Version 0.9.3.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(653, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.guardText);
            this.Controls.Add(this.guardLogo);
            this.Controls.Add(this.topPanel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftBorder);
            this.Controls.Add(this.bottomBorder);
            this.Controls.Add(this.rightBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guardText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel rightBorder;
        private System.Windows.Forms.Panel bottomBorder;
        private System.Windows.Forms.Panel leftBorder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel topPanel4;
        private System.Windows.Forms.Button closeButtonPrevious;
        private System.Windows.Forms.PictureBox guardLogo;
        private System.Windows.Forms.PictureBox guardText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}