namespace trasporte_TP3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dTPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cFeriado = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textPeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tID
            // 
            this.tID.Location = new System.Drawing.Point(38, 180);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(223, 22);
            this.tID.TabIndex = 4;
            this.tID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tID_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Parcial";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "Nuevo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id del contenedor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(38, 108);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(223, 22);
            this.tNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre de la Empresa";
            // 
            // dTPicker
            // 
            this.dTPicker.CustomFormat = " dd/MM/yyyy hh:mm:ss tt";
            this.dTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPicker.Location = new System.Drawing.Point(38, 40);
            this.dTPicker.Name = "dTPicker";
            this.dTPicker.Size = new System.Drawing.Size(223, 22);
            this.dTPicker.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha y hora de ingreso";
            // 
            // cFeriado
            // 
            this.cFeriado.AutoSize = true;
            this.cFeriado.Location = new System.Drawing.Point(289, 44);
            this.cFeriado.Name = "cFeriado";
            this.cFeriado.Size = new System.Drawing.Size(88, 20);
            this.cFeriado.TabIndex = 2;
            this.cFeriado.Text = "FERIADO";
            this.cFeriado.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Z (Cerrar)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Image = global::trasporte_TP3.Properties.Resources._3;
            this.button4.Location = new System.Drawing.Point(359, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 34);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // textPeso
            // 
            this.textPeso.Location = new System.Drawing.Point(38, 253);
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(219, 22);
            this.textPeso.TabIndex = 17;
            this.textPeso.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Pesos Contratado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(411, 378);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPeso);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cFeriado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dTPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cFeriado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textPeso;
        private System.Windows.Forms.Label label4;
    }
}

