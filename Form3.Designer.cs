namespace trasporte_TP3
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
            this.listTicket = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listTicket
            // 
            this.listTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.listTicket.FormattingEnabled = true;
            this.listTicket.ItemHeight = 16;
            this.listTicket.Location = new System.Drawing.Point(0, 0);
            this.listTicket.Name = "listTicket";
            this.listTicket.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listTicket.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listTicket.Size = new System.Drawing.Size(487, 404);
            this.listTicket.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(197, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "cobrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listTicket);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox listTicket;
    }
}