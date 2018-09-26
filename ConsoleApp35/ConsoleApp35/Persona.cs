using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    public class Persona
    {
        protected long _dni;
        protected string _nombre;

        //propiedades
        public long Dni
        {
            get
            {
                return this._dni;
            }
            set
            {
                this._dni = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }
        //metodos y contructores
        public Persona(string nombre)
        {
            this._nombre = nombre;
        }
        public Persona(long dni, string nombre) : this(nombre)
        {
            this._dni = dni;
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0}", this._dni);
            sb.AppendFormat("Dni: {0}", this._nombre);

            return sb.ToString();

        }

    }
}
