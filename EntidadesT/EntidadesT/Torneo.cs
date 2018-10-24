using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesT
{
    public class Torneo<T> where T : Equipo
    {

        private List<T> _equipos;
        private string _nombre;

        public Torneo()
        {
            this._equipos = new List<T>();
        }
        public Torneo(string nombre) : this()
        {
            this._nombre = nombre;
        }

        public string JugarPartido
        {
           
            get
            {
                Random equipoRandom = new Random();
                string salida;
                T e1,e2;
                e1 = CalcularRandom();
                e2 = CalcularRandom();                
                salida = CalcularPartido(e1,e2);
                return salida;
            }
        }

        public static bool operator ==(Torneo<T> equipos, T e)
        {
            bool salida = false;
            if (equipos._equipos.Contains(e))
            {
                salida = true;
            }
            return salida;
        }
        public static bool operator !=(Torneo<T> equipos, T e)
        {
            return !(equipos == e);
        }

        public static Torneo<T> operator +(Torneo<T> equipos, T e)
        {
            if (equipos != e)
            {
                equipos._equipos.Add(e);
            }
            return equipos;
        }
        private T CalcularRandom()
        {
            Random eRndom = new Random();
            T equipo = this._equipos.ElementAt(eRndom.Next(this._equipos.Count));
            return equipo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre del torneo: "+ this._nombre);

            foreach (T e in this._equipos)
            {
                sb.AppendLine(e.Ficha());
            }

            return sb.ToString();
        }
        private string CalcularPartido(T e1,T e2)
        {

            StringBuilder sb = new StringBuilder();
            Random goles = new Random();

            if(e1 is Equipo && e2 is Equipo)
            {
                if(e1 is EquipoFutbol || e2 is EquipoFutbol)
                {
                    sb.AppendFormat("{0} {1}-{2} {3}", e1._nombre, goles.Next(5), goles.Next(5), e2._nombre);
                }
                else if(e1 is EquipoBasquet || e2 is EquipoBasquet)
                {
                    sb.AppendFormat("{0} {1}-{2} {3}", e1._nombre, goles.Next(50,120), goles.Next(50,120), e2._nombre);
                }
               
            }

            return sb.ToString();
        }


    }
}
