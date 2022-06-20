
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trasporte_TP3
{
    internal class cargas
    {
        static int contador;
        private int id;
        private string nombre;
        private double enviob = 5.25;
        private double eFull = 8.95;
        private int tipoA, tipoB, tipoC;
        DateTime hora;
        int peso=1000, pesoEntrada, difpeso; //agregarcion
        double costo;
        bool feriado;
        double porc;
        bool multa = false;
        public cargas(string nom, int id, int tipoA,int tipoB, int tipoC, DateTime tiempo, bool feriado)
        {
            contador++;// variable que cuenta los contenedores
            this.Id = id;
            this.Nombre = nom;
            
            hora = tiempo;
         
            pesoEntrada=(5*tipoA) +(15* tipoB) +(25* tipoC);
            difpeso= peso- pesoEntrada;

            if (difpeso > -100 && difpeso < -10)
            {
                porc = 7;
            }else if (difpeso > -10)
            {
                porc = -5;
            }else if(difpeso >5 && difpeso <= 50)
            {
                porc = 18;
            }else if( difpeso > 50)
            {
                porc = 80;
                multa = true;
            }
            else
            {
                porc = 10;
            }
      
            if(hora.DayOfWeek == DayOfWeek.Sunday || feriado==true)
            {
                //agregar mil al precio
            }
            if (hora.Hour >= 6 && hora.Hour<=20)
            {
                descuento = -5;
            }
            if (!(hora.Hour > 6 && hora.Hour <= 20))
            {
                descuento = +4;
            }

        }
        public double Costo()
        {
            return costo
        }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

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
