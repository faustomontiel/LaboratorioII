using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        //propiedades
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
            set
            {
                this.totalGoles = value;
            }
        }
        public float PromedioDeGoles
        {
            get
            {
                return   (float)this.partidosJugados / this.totalGoles;
            }
        }

        // metodos y constructores
        public Jugador(int dni, string nombre) 
            : base(dni, nombre)
        {

        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendFormat("Partidos Jugados: {0}\n", this.partidosJugados);
            sb.AppendFormat("Goles: {0}\n", this.totalGoles);
            sb.AppendFormat("Promedio de Gol: {0}\n", this.PromedioDeGoles);

            return sb.ToString();
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1._dni == j2._dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1._dni == j2._dni);
        }

    }
}
