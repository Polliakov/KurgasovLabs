
namespace KurgasovLabs.Lab6
{
    partial class ClockMenuStrip
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.деньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(235, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DateToolStripMenuItem
            // 
            this.DateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.деньToolStripMenuItem,
            this.TimeToolStripMenuItem});
            this.DateToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.DateToolStripMenuItem.Name = "DateToolStripMenuItem";
            this.DateToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.DateToolStripMenuItem.Text = "&Дата";
            this.DateToolStripMenuItem.Click += new System.EventHandler(this.DateToolStripMenuItem_Click);
            // 
            // деньToolStripMenuItem
            // 
            this.деньToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.деньToolStripMenuItem.Name = "деньToolStripMenuItem";
            this.деньToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.деньToolStripMenuItem.Text = "&Число";
            this.деньToolStripMenuItem.Click += new System.EventHandler(this.DayToolStripMenuItem_Click);
            // 
            // TimeToolStripMenuItem
            // 
            this.TimeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem";
            this.TimeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TimeToolStripMenuItem.Text = "&Время";
            this.TimeToolStripMenuItem.Click += new System.EventHandler(this.TimeToolStripMenuItem_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label1.Location = new System.Drawing.Point(51, 39);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(132, 26);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "                    ";
            // 
            // ClockMenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 90);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClockMenuStrip";
            this.Text = "ClockMenuStrip";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem деньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimeToolStripMenuItem;
        private System.Windows.Forms.Label Label1;
    }
}