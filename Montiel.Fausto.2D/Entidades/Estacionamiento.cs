using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int _espacioDisponible;
        private string nombre;
        private List<Vehiculo> _vehiculos;


        public Estacionamiento()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible) : this()
        {
            this.nombre = nombre;
            this._espacioDisponible = espacioDisponible;
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (!ReferenceEquals(estacionamiento._vehiculos, null) && estacionamiento != vehiculo && estacionamiento._espacioDisponible >= estacionamiento._vehiculos.Count)
            {
                estacionamiento._vehiculos.Add(vehiculo);
               
            }
            return estacionamiento;
        }
        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento == vehiculo)
            {
                if (!ReferenceEquals(vehiculo.Patente, null))
                {
                    estacionamiento._vehiculos.Remove(vehiculo);
                   
                    Console.WriteLine("***HASTA LA PROXIMA***"+vehiculo.ImprimirTicket());
                }
                
            }
            else
            {
                Console.WriteLine("No pertenece al ESTABLECIMIENTO");
            }
                 
        
            return (string)estacionamiento;
        }
        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
        
            if (!ReferenceEquals(e._vehiculos, null))
            {
                sb.AppendLine("Nombre Estacionamiento: " + e.nombre);
                foreach (Vehiculo v in e._vehiculos)
                {
                    if (!ReferenceEquals(v.Patente, null))
                        sb.AppendLine(v.ConsultarDatos());
                }


            }
            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool retorno = false;

            if (!ReferenceEquals(estacionamiento._vehiculos, null) && estacionamiento._vehiculos.Contains(vehiculo) )
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }



    }
}
