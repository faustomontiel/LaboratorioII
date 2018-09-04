using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Dolar() 
        {
            Dolar.cotizRespectoDolar = (float)17.55;
        }
        public Dolar(double cantidad):this()
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, float cotizacion) 
        {
            this.cantidad = cantidad;
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static float GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;

        }

        public static Dolar operator +(Dolar dolar, Dolar dolar2)
        {
            dolar.cantidad += dolar2.cantidad;
            return dolar;

        }
        public static Dolar operator -(Dolar dolar, Dolar dolar2)
        {
            dolar.cantidad -= dolar2.cantidad;
            return dolar;
        }
        public static bool operator ==(Dolar dolar, Dolar dolar2)
        {
            return dolar.cantidad == dolar2.cantidad;
        }
        public static bool operator !=(Dolar dolar, Dolar dolar2)
        {
            return dolar.cantidad == dolar2.cantidad;
        }


    }
}
