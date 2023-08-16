
namespace Калькулятор
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLinkCalculator = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(71, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро \r\nпожаловать!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLinkCalculator
            // 
            this.lblLinkCalculator.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblLinkCalculator.AutoSize = true;
            this.lblLinkCalculator.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLinkCalculator.LinkColor = System.Drawing.Color.Gray;
            this.lblLinkCalculator.Location = new System.Drawing.Point(52, 283);
            this.lblLinkCalculator.Name = "lblLinkCalculator";
            this.lblLinkCalculator.Size = new System.Drawing.Size(270, 41);
            this.lblLinkCalculator.TabIndex = 1;
            this.lblLinkCalculator.TabStop = true;
            this.lblLinkCalculator.Text = "Калькулятор";
            this.lblLinkCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLinkCalculator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkCalculator_LinkClicked);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.lblLinkCalculator);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblLinkCalculator;
    }
}