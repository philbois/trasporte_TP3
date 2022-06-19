using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trasporte_TP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 vcarga=new Form2();
            //pruebas tiempo
            DateTime dt = dTPicker.Value;
            //MessageBox.Show("dia" + dt.DayOfWeek+"\n hora"+dt.Hour);
            if(dt.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("un exito");
            }


        }
    }
}
