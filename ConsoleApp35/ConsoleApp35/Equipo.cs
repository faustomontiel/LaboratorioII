using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    public class Equipo
    {
        private short _cantidadDeJugadores;
        private List<Jugador> _Jugadores;
        private string _nombre;

        public Equipo()
        {
            this._Jugadores = new List<Jugador>();
            this._cantidadDeJugadores = 0;
            this._nombre = "";
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this._cantidadDeJugadores = cantidad;
            this._nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if (!(e._Jugadores.Contains(j)) && e._Jugadores.Count < e._cantidadDeJugadores)
            {
                e._Jugadores.Add(j);
                return true;
            }

            return false;
        }
        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("EQUIPO: {0}\n", _nombre);
            datos.Append("***JUGADORES***\n\n");
            foreach (Jugador j in this._Jugadores)
            {

                datos.Append(j.MostrarDatos());
                datos.Append("----------------------\n");
            }

            return datos.ToString();
        }




    }
}
