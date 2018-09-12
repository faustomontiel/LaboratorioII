using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Pesos()
        {
            cotizRespectoDolar = 17.55F;
        }

        public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }


        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            float cotizacion;

            return cotizacion = cotizRespectoDolar;
        }

        public static explicit operator Euro(Pesos peso)
        {
            return new Euro((peso.GetCantidad() / Pesos.GetCotizacion()) * Euro.GetCotizacion());
        }

        public static explicit operator Dolar(Pesos peso)
        {
            return new Dolar(peso.GetCantidad() / Pesos.GetCotizacion());

        }

        public static implicit operator Pesos(double cantidad)
        {
            return new Pesos(cantidad);

        }

        public static bool operator ==(Pesos peso, Euro euro)
        {
            bool flag = false;

            if (((Euro)peso).GetCantidad() == euro.GetCantidad())
            {
                flag = true;
            }

            return flag;
        }

        public static bool operator ==(Pesos peso, Dolar dolar)
        {
            bool flag = false;

            if (((Dolar)peso).GetCantidad() == dolar.GetCantidad())
            {
                flag = true;
            }

            return flag;
        }

        public static bool operator ==(Pesos peso1, Pesos peso2)
        {
            bool flag = false;

            if (peso1.GetCantidad() == peso2.GetCantidad())
            {
                flag = true;
            }

            return flag;
        }

        public static bool operator !=(Pesos peso1, Pesos peso2)
        {
            return !(peso1 == peso2);
        }


        public static bool operator !=(Pesos peso, Dolar dolar)
        {
            return !(peso == dolar);
        }


        public static bool operator !=(Pesos peso, Euro euro)
        {
            return !(peso == euro);
        }

        public static Pesos operator +(Pesos peso, Euro euro)
        {
            return new Pesos(peso.GetCantidad() + ((Pesos)euro).GetCantidad());

        }

        public static Pesos operator +(Pesos peso, Dolar dolar)
        {
            return new Pesos(peso.GetCantidad() + ((Pesos)dolar).GetCantidad());

        }

        public static Pesos operator -(Pesos peso, Euro euro)
        {
            return new Pesos(peso.GetCantidad() - ((Pesos)euro).GetCantidad());

        }

        public static Pesos operator -(Pesos peso, Dolar dolar)
        {
            return new Pesos(peso.GetCantidad() - ((Pesos)dolar).GetCantidad());

        }


    }
}
