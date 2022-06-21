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
        cargas [] reparto = new cargas[100];
        Form2 vcarga;
        generadorT recibo=new generadorT();
        public int xi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vcarga=new Form2();
        
            int tA = 0, tB=0, tC=0;
            bool fer = false;
            bool tEnvio=false;
            fer = cFeriado.Checked;
            DateTime dt = dTPicker.Value;
            // DateTime tiempo = DateTime.Now; 
            string empre = tNombre.Text;
            int ID = Convert.ToInt32(tID.Text);
            if(vcarga.ShowDialog() == DialogResult.OK)
            {
                tA = Convert.ToInt32(vcarga.textA.Text);
                tB = Convert.ToInt32(vcarga.textB.Text);
                tC = Convert.ToInt32(vcarga.textC.Text);
                tEnvio = vcarga.rdEnvio.Checked;
                reparto[xi] = new cargas(empre, ID, tA, tB, tC, dt, fer, tEnvio);
                //MessageBox.Show(Convert.ToString(reparto[i].Costo()));
                recibo.Ticket(xi);
            }
                xi++;
            vcarga.Dispose();
            

        }
        /*private void Ticket()
        {
            ticket.listTicket.Items.Add("____________________ticket___________________");
            ticket.listTicket.Items.Add("_____________________RADHA___________________");
            ticket.listTicket.Items.Add("______________(empresa de envio)_____________");
            ticket.listTicket.Items.Add("---------------------------------------------");
            ticket.listTicket.Items.Add("");
            ticket.listTicket.Items.Add("Nombre de la Empresa: " + reparto[i].Nombre);
            ticket.listTicket.Items.Add("ID: " + reparto[i].Id);
            ticket.listTicket.Items.Add("Hora de despacho:");
            ticket.listTicket.Items.Add(reparto[i].Hora());
            ticket.listTicket.Items.Add(" ");
            ticket.listTicket.Items.Add("Total a cobrar: $" + (reparto[i].Costo()).ToString("0.00"));
            ticket.ShowDialog();
        }*/

        private void button4_Click(object sender, EventArgs e)
        {
            int aux=-1;
            for (int j=0; j<reparto.Length; j++)
            {
                if(reparto[j].Id==Convert.ToInt32(tID.Text))
                {
                    aux = j;
                }
            }
            if (aux > -1)
            {
                recibo.Ticket(xi);
            }
        }
    }
}
