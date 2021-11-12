
namespace KurgasovLabs.Lab4
{
    partial class CaseGreeting
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTextBoxLabel = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lstCountryBox = new System.Windows.Forms.ListBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(11, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Интернациональная программа\r\nприветствий";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextBoxLabel
            // 
            this.lblTextBoxLabel.AutoSize = true;
            this.lblTextBoxLabel.Location = new System.Drawing.Point(52, 61);
            this.lblTextBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextBoxLabel.Name = "lblTextBoxLabel";
            this.lblTextBoxLabel.Size = new System.Drawing.Size(94, 13);
            this.lblTextBoxLabel.TabIndex = 1;
            this.lblTextBoxLabel.Text = "Выберите страну";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountry.Location = new System.Drawing.Point(52, 173);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(0, 17);
            this.lblCountry.TabIndex = 2;
            // 
            // lblGreeting
            // 
            this.lblGreeting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGreeting.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGreeting.Location = new System.Drawing.Point(49, 194);
            this.lblGreeting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(162, 17);
            this.lblGreeting.TabIndex = 3;
            // 
            // lstCountryBox
            // 
            this.lstCountryBox.FormattingEnabled = true;
            this.lstCountryBox.Location = new System.Drawing.Point(49, 76);
            this.lstCountryBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCountryBox.Name = "lstCountryBox";
            this.lstCountryBox.Size = new System.Drawing.Size(162, 95);
            this.lstCountryBox.TabIndex = 4;
            this.lstCountryBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lstCountryBox.MouseHover += new System.EventHandler(this.lstCountryBox_MouseHover);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(102, 215);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(57, 21);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Выход";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // CaseGreeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 244);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lstCountryBox);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblTextBoxLabel);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CaseGreeting";
            this.Text = "Приветствие";
            this.Load += new System.EventHandler(this.CaseGreeting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTextBoxLabel;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.ListBox lstCountryBox;
        private System.Windows.Forms.Button btnQuit;
    }
}