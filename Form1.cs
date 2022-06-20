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
        cargas reparto;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt = dTPicker.Value;
            DateTime tiempo = DateTime.Now;
            Form2 vcarga=new Form2();
            reparto = new cargas("boruchovas", 252312, 25, 26, 23, tiempo);
            //pruebas tiempo
            listBox1.Items.Add(reparto.Nombre);
            listBox1.Items.Add(reparto.Id.ToString());
            listBox1.Items.Add(reparto.TipoA.ToString());
            listBox1.Items.Add(reparto.TipoB.ToString());
            listBox1.Items.Add(reparto.TipoC.ToString());
            listBox1.Items.Add(reparto.Hora().ToString());
            listBox1.Items.Add(reparto.dia().ToString());
            listBox1.Items.Add(dt.Hour);
            //MessageBox.Show("dia" + dt.DayOfWeek+"\n hora"+dt.Hour);
            if (dt.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("un exito");
            }


        }

        private void dTPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
