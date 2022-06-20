
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
        private double enviob = 5.25;
        private double eFull = 8.95;
        private int tipoA, tipoB, tipoC;
        DateTime hora;
        double costo;
        bool feriado;
        public cargas(string nom, int id, int tipoA,int tipoB, int tipoC, DateTime tiempo, bool feriado)
        {
            this.Id = id;
            this.Nombre = nom;
            this.TipoA=tipoA*5;
            this.TipoB=tipoB*15;
            this.TipoC=tipoC*25;
            hora = tiempo;
            this.feriado=feriado;

            if()
            if(hora.DayOfWeek == DayOfWeek.Sunday)
            {
                
            }

        }
        public double Costo()
        {
            return costo
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
