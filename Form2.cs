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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textA.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textB.Enabled = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textC.Enabled = checkBox3.Checked;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)|| e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)|| e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)|| e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
