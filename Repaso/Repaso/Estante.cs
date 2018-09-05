using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estante
    {
        protected Producto[] productos;
        protected int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        public Estante(int capacidad,int ubicacion): this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        
        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static bool operator ==(Estante est, Producto P)
        {

            for (int i = 0; i < est.productos.Length; i++)
            {
                if(est.productos[i] is Producto)
                {
                    if(est.productos[i]== P)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Estante est, Producto P)
        {
            return !(est == P);
        }
        public static bool operator +(Estante est, Producto P)
        {
            if(est != P)
            {
                for (int i = 0; i < est.productos.Length; i++)
                {
                    if(est.productos[i] is null)
                    {
                        est.productos[i] = P;
                        return true;
                    }
                }
            }
            return false;
        }
       
        public static Estante operator -(Estante est, Producto P )
        {
            if(est == P)
            {
                for (int i = 0; i < est.productos.Length; i++)
                {
                    if(est.productos[i] == P)
                    {
                        est.productos[i] = null;
                        return est;
                    }
                }
            }
            return est;
        }

        public string MostrarEstante(Estante est)
        {
            StringBuilder sb  = new StringBuilder();
            sb.Append("La ubicacion del estante: ");
            sb.AppendLine(this.ubicacionEstante.ToString());
            for (int i = 0; i < est.productos.Length; i++)
            {
                
                if(est.productos[i] is Producto)
                {
                   sb.Append(est.productos[i].MostrarProducto(est.productos[i]));
                }
            }
         

            return sb.ToString();
        }
        



    }
}
