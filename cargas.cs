
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trasporte_TP3
{
    internal class cargas
    {
        
        static int sTipoA=0, sTipoB=0, sTipoC=0;//acumulador static
        private int id;
        private string nombre;
        private double costoEnvio;
        private double porc, recarTiempo = 0;
        private double costo = 0;
        private int pesoEntrada=0;
        bool feriado;
        bool tipoEnvio;
        bool multa = false;

        int peso, difPeso, recargo=0;
        DateTime hora;
        public static string cajaMasUsada()
        {
            string caja;
            if (sTipoA > sTipoB)
            {
                if (sTipoA > sTipoC)
                {
                    caja = "Tipo A";
                }
                else
                {
                    caja = "Tipo C";
                }
            }else if(sTipoB > sTipoC)
            {
                caja = "Tipo B";
            }else
            {
                caja = "Tipo C";
            }
            return caja;
        }
        public cargas(string nom, int peso ,int id, int tipoA, int tipoB, int tipoC, DateTime tiempo, bool feriado, bool tEnvio)
        {
            this.peso = peso;
            this.id = id; //guardo id
            this.nombre = nom; 
            hora = tiempo;//guardo hora
            this.feriado = feriado;
            pesoEntrada = (5 * tipoA) + (15 * tipoB) + (25 * tipoC);
            difPeso = PesoEntrada - peso;
            tipoEnvio = tEnvio;
            sTipoA += tipoA;
            sTipoB += tipoB; 
            sTipoC += tipoC;
        }
        private void comparacion()
        {
            if (difPeso <= -100)
            {
                porc = 1.1;
            }
            else if (difPeso > -100 && difPeso <= -10)
            {
                porc = 1.07;
            }
            else if (difPeso > -10 && difPeso <= 5)
            {
                porc = 0.95;

            }
            else if (difPeso > 5 && difPeso <= 50)
            {
                porc = 1.18;
                multa = true;
            }
            else
            {
                porc = 1.8;
                multa = true;
            }
            ///--------
            if (hora.DayOfWeek == DayOfWeek.Sunday || feriado == true)//domingo o feriado
            {
                recargo = 1000;
            }
            if (hora.Hour >= 6 && hora.Hour <= 20) //hora entre las 6 y las 20
            {
                recarTiempo = 0.95;
            }
            if (!(hora.Hour > 6 && hora.Hour <= 20))//hora fuera de las 6 y 20 
            {
                recarTiempo = 1.04;
            }
            if (tipoEnvio)//tipo de envio
            {
                costoEnvio =5.25 ;
            }
            else costoEnvio = 8.95; //tipo de envio(precio)
        }//comparacion de peso
        public double Costo()//costo cobro
        {
            comparacion();
            costo = (((PesoEntrada * costoEnvio) * porc)*recarTiempo) + recargo;
            return costo;
        }

        public string Hora() => hora.ToString("f");
        public int Id { get => id; }
        public bool Multa { get => multa;}
        public string Nombre { get => nombre; }
        public int PesoEntrada { get => pesoEntrada; }

    }
}
