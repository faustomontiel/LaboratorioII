using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Producto
    {
        int identificador;
        string nombre;
        double precio;
        double iva;

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        public Producto(int identificador, string nombre, double precio)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.Precio = precio;
            this.cantidad = 1;
        }

        public int Identificador
        {
            get { return this.identificador; }
            set { this.identificador = value; }
        }

        public double Precio
        {
            set
            {
                this.precio = value;
                this.iva = this.precio * 21 / 100;
            }
        }

        public double Total
        {
            get
            {
                return (this.precio + this.iva) * this.cantidad;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

       
    }
}
