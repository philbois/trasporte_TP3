
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trasporte_TP3
{
    internal class cargas
    {
       
        private int id;
        private string nombre;
        /*private double enviob = 5.25;
        private double eFull = 8.95;*/
        private double envio;
        private int tipoA, tipoB, tipoC;
        private double costo;
        private double peso;
        private double difPeso;
        private double recargo;
        DateTime hora;
        public cargas(string nom, int id, int tipoA,int tipoB, int tipoC, DateTime tiempo)
        {
            this.Id = id;
            this.Nombre = nom;
            this.TipoA=tipoA*5;
            this.TipoB=tipoB*15;
            this.TipoC=tipoC*25;
            hora = tiempo;
            this.peso = TipoA + TipoB + TipoC;
            this.difPeso = peso - 1000;
            if (this.difPeso < -99)
            {
                recargo = 0.10;
            }
            else if (this.difPeso > -100 && < -10)
            {
                recargo = 0.07;
            }
            else if (this.difPeso > -10 && < 5)
            {
                recargo = 0.95;
            }
            else if (this.difPeso > 5 && < 50)
            {
                recargo = 0.18;
            }
            else if (this.difPeso > 50)
            {
                recargo = 0.80 + multa
            }

            } 
            

        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int TipoA { get => tipoA; set => tipoA = value; }
        public int TipoB { get => tipoB; set => tipoB = value; }
        public int TipoC { get => tipoC; set => tipoC = value; }
        public int Hora()
        {
            int h = Convert.ToInt32(hora.Hour);
            return h;
        }
        public string dia()
        {
            string semana=hora.DayOfWeek.ToString();
            return semana;
        }
    }
}
