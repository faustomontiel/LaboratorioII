using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Factura
    {
        int numero;
        DateTime fecha;
        int moneda;
        List<Producto> productos;
        int tipo;



        public Producto this[int i]
        {
            get
            {
                Producto salida = null;
                foreach (Producto item in this.productos)
                {
                    if (item.Identificador == i)
                        salida = item;
                }
                return salida;
            }
            set
            {

                bool encontro = false;
                foreach (Producto item in this.productos)
                {
                    if (item.Identificador ==  i)
                    {
                        item.Cantidad += value.Cantidad;
                        encontro = true;
                    }
                }
                if (!encontro)
                {
                    this.productos.Add(value);
                }
            }
        }

        public int Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }


        public int Moneda
        {
            get { return this.moneda; }
            set { this.moneda = value; }
        }

        public Factura()
        {
            this.productos = new List<Producto>();
        }

        public double Total
        {
            get
            {
                double total = 0;
                foreach (Producto item in this.productos)
                {
                    total += item.Total;
                }

                return total;
            }
        }

    }
}
