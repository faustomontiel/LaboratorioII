using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Producto
    {
        protected string codigoDeBarra;
        protected string marca;
        protected float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public string MostrarProducto(Producto prod)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("MARCA:  ");
            sb.AppendLine(prod.marca);
            sb.Append("PRECIO: ");
            sb.AppendLine(prod.precio.ToString());
            sb.Append("CODIGO: ");
            sb.AppendLine(prod.codigoDeBarra);

            return sb.ToString();
        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            if (productoUno.codigoDeBarra == productoDos.codigoDeBarra && productoUno.marca == productoDos.marca)
                return true;
            else
                return false;
        }
        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return !(productoUno == productoDos);
        }

        public static bool operator ==(Producto productoUno, string marca)
        {
            if (productoUno.marca == marca)
                return true;
            else
                return false;
        }
        public static bool operator !=(Producto productoUno, string marca)
        {
            return !(productoUno == marca);
        }






    }
}
