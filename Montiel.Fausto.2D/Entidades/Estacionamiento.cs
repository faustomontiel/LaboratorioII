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
                    switch(estacionamiento._vehiculos.Count)
                    {
                        case 6:
                            estacionamiento._espacioDisponible = 1;
                            break;
                        case 5:
                            estacionamiento._espacioDisponible = 2;
                            break;
                        case 4:
                            estacionamiento._espacioDisponible = 3;
                            break;
                        case 3:
                            estacionamiento._espacioDisponible = 4;
                            break;
                        case 2:
                            estacionamiento._espacioDisponible = 5;
                            break;
                        case 1:
                            estacionamiento._espacioDisponible = 6;
                            break;
                        default:
                            estacionamiento._espacioDisponible = 6;
                            break;
                    }
                    Console.WriteLine(vehiculo.ImprimirTicket());
                }
                
            }
        
            return (string)estacionamiento;
        }
        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre Estacionamiento: " + e.nombre);
            sb.AppendLine("Espacio Disponible:  "+ e._espacioDisponible);
            
            

            if (!ReferenceEquals(e._vehiculos, null))
            {
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

            if (!ReferenceEquals(estacionamiento._vehiculos, null) && estacionamiento._vehiculos.Contains(vehiculo))
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
