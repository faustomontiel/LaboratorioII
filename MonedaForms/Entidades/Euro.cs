using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda

{
    public class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;
        //
        private Euro()
        {
            cotizRespectoDolar = 1.16F;
        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }


        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {    

            return Euro.cotizRespectoDolar;

        }

        public static explicit operator Dolar(Euro euro)
        {
            return new Dolar(euro.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Euro euro)
        {
            return new Pesos((euro.GetCantidad() / Euro.GetCotizacion()) * Pesos.GetCotizacion());
        }

        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }

        public static bool operator ==(Euro euro, Dolar dolar)
        {
            bool flag = false;

            if (((Dolar)euro).GetCantidad() == dolar.GetCantidad())
            {
                flag = true;
            }

            return flag;
        }

        public static bool operator ==(Euro euro, Pesos peso)
        {
            bool flag = false;

            if (((Pesos)euro).GetCantidad() == peso.GetCantidad())
            {
                flag = true;
            }

            return flag;
        }

        public static bool operator ==(Euro euro1, Euro euro2)
        {
            bool flag = false;

            if (euro1.GetCantidad() == euro2.GetCantidad())
            {
                flag = true;
            }

            return flag;
        }

        public static bool operator !=(Euro euro1, Euro euro2)
        {
            return !(euro1 == euro2);
        }


        public static bool operator !=(Euro euro, Pesos peso)
        {
            return !(euro == peso);
        }


        public static bool operator !=(Euro euro, Dolar dolar)
        {
            return !(euro == dolar);
        }


        public static Euro operator +(Euro euro, Dolar dolar)
        {
            return new Euro(euro.GetCantidad() + ((Euro)dolar).GetCantidad());

        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.GetCantidad() + ((Euro)p).GetCantidad());

        }

        public static Euro operator -(Euro euro, Dolar dolar)
        {
            return new Euro(euro.GetCantidad() - ((Euro)dolar).GetCantidad());


        }

        public static Euro operator -(Euro euro, Pesos peso)
        {
            return new Euro(euro.GetCantidad() - ((Euro)peso).GetCantidad());


        }
    }
}
