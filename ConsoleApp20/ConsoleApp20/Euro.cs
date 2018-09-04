using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes

{
    class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Euro()
        {

        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            Euro.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static float GetCotizacion()
        {
            return Euro.cotizRespectoDolar;

        }

    }
}
