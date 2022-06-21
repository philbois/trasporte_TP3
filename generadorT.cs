using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trasporte_TP3
{
    internal class generadorT
    {
        cargas[] reparto;
        Form2 vcarga=new Form2();
        Form3 ticket=new Form3();
       
        public void Ticket(int xi)
        {
            ticket.listTicket.Items.Add("____________________ticket___________________");
            ticket.listTicket.Items.Add("_____________________RADHA___________________");
            ticket.listTicket.Items.Add("______________(empresa de envio)_____________");
            ticket.listTicket.Items.Add("---------------------------------------------");
            ticket.listTicket.Items.Add("");
            ticket.listTicket.Items.Add("Nombre de la Empresa: " + reparto[xi].Nombre);
            ticket.listTicket.Items.Add("ID: " + reparto[xi].Id);
            ticket.listTicket.Items.Add("Hora de despacho:");
            ticket.listTicket.Items.Add(reparto[xi].Hora());
            ticket.listTicket.Items.Add(" ");
            ticket.listTicket.Items.Add("Total a cobrar: $" + (reparto[xi].Costo()).ToString("0.00"));
            ticket.ShowDialog();
        }

    }
}
