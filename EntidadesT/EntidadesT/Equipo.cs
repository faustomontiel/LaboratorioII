using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesT
{
    public abstract class Equipo
    {
        public string _nombre;
        private DateTime _fechaCreacion;

        public Equipo(string nombre,DateTime fecha)
        {
            this._nombre = nombre;
            this._fechaCreacion = fecha;
        }

        public static bool operator ==(Equipo e1,Equipo e2)
        {
            bool salida = false;
            if(e1._nombre == e2._nombre && e1._fechaCreacion == e2._fechaCreacion)
            {
                salida = true;
            }
            return salida;
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0} fundado el {1}",this._nombre,this._fechaCreacion);


            return sb.ToString();
        }


    }
}
