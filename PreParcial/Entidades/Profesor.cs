using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime _fechaIngreso;

        public Profesor(string nombre, string apellido, string documento)
          : base(nombre, apellido, documento)
        {

        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso)
          : this(nombre, apellido, documento)
        {
            this._fechaIngreso = fechaIngreso;

        }


        public int Antiguedad
        {
            get
            {
                return (int)(DateTime.Now - this._fechaIngreso).TotalDays;
            }
        }




        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ExponerDatos());

            sb.AppendLine("Antiguedad: " + this.Antiguedad);



            return sb.ToString();
        }

        protected override bool ValidarDocumento(string doc)
        {
            return (doc.Trim().Length == 8);

        }




    }
}
