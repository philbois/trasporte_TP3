﻿namespace trasporte_TP3
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.listTicket = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listTicket
            // 
            this.listTicket.BackColor = System.Drawing.SystemColors.MenuText;
            this.listTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTicket.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTicket.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listTicket.FormattingEnabled = true;
            this.listTicket.ItemHeight = 20;
            this.listTicket.Location = new System.Drawing.Point(0, 0);
            this.listTicket.Name = "listTicket";
            this.listTicket.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listTicket.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listTicket.Size = new System.Drawing.Size(453, 568);
            this.listTicket.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(348, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listTicket);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radha";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox listTicket;
    }
}