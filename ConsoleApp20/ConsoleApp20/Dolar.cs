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
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, float cotizacion) : this(cantidad)
        {

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

        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro(dolar.GetCantidad() / Euro.GetCotizacion());
        }
        public static explicit operator Pesos(Dolar dolar)
        {

            return new Pesos(dolar.GetCantidad() * Pesos.GetCotizacion());

        }
        public static implicit operator Dolar(double cantidad)
        {
 
            return new Dolar(cantidad);

        }
        public static bool operator ==(Dolar dolar, Euro euro)
        {
            bool retorno = false;
            if (((Euro)dolar).GetCantidad() == euro.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ==(Dolar dolar, Pesos peso)
        {
            bool flag = false;

            if (((Pesos)dolar).GetCantidad() == peso.GetCantidad())
            {
                flag = true;
            }

            return flag;
        }

        public static bool operator ==(Dolar dolar1, Dolar dolar2)
        {
            bool flag = false;

            if (dolar1.GetCantidad() == dolar2.GetCantidad())
            {
                flag = true;
            }

            return flag;
        }

        public static bool operator !=(Dolar dolar1, Dolar dolar2)
        {
            return !(dolar1 == dolar2);
        }


        public static bool operator !=(Dolar dolar, Pesos peso)
        {
            return !(dolar == peso);
        }


        public static bool operator !=(Dolar dolar, Euro euro)
        {
            return !(dolar == euro);
        }

        public static Dolar operator +(Dolar dolar, Euro euro)
        {
            return new Dolar(dolar.GetCantidad() + ((Dolar)euro).GetCantidad());

        }

        public static Dolar operator +(Dolar dolar, Pesos peso)
        {
            return new Dolar(dolar.GetCantidad() + ((Dolar)peso).GetCantidad());

        }

        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            return new Dolar(dolar.GetCantidad() - ((Dolar)euro).GetCantidad());

        }

        public static Dolar operator -(Dolar dolar, Pesos peso)
        {
            return new Dolar(dolar.GetCantidad() - ((Dolar)peso).GetCantidad());

        }



    }
}
