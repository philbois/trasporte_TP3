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
        cargas [] contenedor = new cargas[100];
        Form2 vcarga;
       // generadorT recibo=new generadorT();
        Form3 ticket = new Form3();
        public int xi = 0;
       

        public void recibo(int x )
        {
            ticket.listTicket.Items.Clear();
            ticket.listTicket.Items.Add("______________________ticket___________________");
            ticket.listTicket.Items.Add("_____________________RADHA___________________");
            ticket.listTicket.Items.Add("_______________empresa de envio______________");
            ticket.listTicket.Items.Add("---------------------------------------------");
            ticket.listTicket.Items.Add("");
            ticket.listTicket.Items.Add("Nombre de la Empresa: " + contenedor[x].Nombre);
            ticket.listTicket.Items.Add("ID: " + contenedor[x].Id);
            ticket.listTicket.Items.Add("Hora de despacho:");
            ticket.listTicket.Items.Add(contenedor[x].Hora());
            ticket.listTicket.Items.Add(" ");
            ticket.listTicket.Items.Add("Total a cobrar: $" + (contenedor[x].Costo()).ToString("0.00"));
            ticket.ShowDialog();
        }

        public double Total()
        {
            double total = 0;
            for (int j = 0; j < xi - 1; j++)
            {
                total += contenedor[j].Costo();
            }return total;
        }
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
            bool exiteID = true;
        
            int tA = 0, tB=0, tC=0;
            bool fer = false;
            bool tEnvio=false;
            fer = cFeriado.Checked;
            DateTime dt = dTPicker.Value;
            // DateTime tiempo = DateTime.Now; 
            string empre = tNombre.Text;
            int ID = Convert.ToInt32(tID.Text);
            for (int j = 0; j < xi ; j++)
            {
                if (contenedor[j].Id == Convert.ToInt32(tID.Text))
                {
                    exiteID = false;
                    MessageBox.Show("EL ID DEL CONTENEDOR YA FUE INGRESADO");
                }
            }
            if (exiteID)
            {
                if (vcarga.ShowDialog() == DialogResult.OK)
                {
                    tA = Convert.ToInt32(vcarga.textA.Text);
                    tB = Convert.ToInt32(vcarga.textB.Text);
                    tC = Convert.ToInt32(vcarga.textC.Text);
                    tEnvio = vcarga.rdEnvio.Checked;
                    contenedor[xi] = new cargas(empre, ID, tA, tB, tC, dt, fer, tEnvio);
                    //MessageBox.Show(Convert.ToString(reparto[i].Costo()));
                    recibo(xi);
                    xi++;
                }
                
                vcarga.Dispose(); 
                tNombre.Clear();
            }
            tID.Clear();
            

        }
      


        private void button1_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void button4_Click_1(object sender, EventArgs e)//buscar id
        {
            int aux = -1;
            for (int j = 0; j < xi-1; j++)
            {
                if (contenedor[j].Id == Convert.ToInt32(tID.Text))
                {
                    aux = j;
                    MessageBox.Show("un exito - LO ENCONTRE");
                }
            }

            if (aux > -1)
            {
                recibo(aux);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           // recibo
           
        }
    }
}
