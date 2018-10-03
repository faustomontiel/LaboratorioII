using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short _anio;
        private Divisiones _division;


        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
          : base(nombre, apellido, documento)
        {
            this._anio = anio;
            this._division = division;
        }


        public string AnioDivision
        {
            get
            {
                return " " + this._anio + "º" + " " + this._division;
            }
        }



        protected override bool ValidarDocumento(string aux)
        {
            if (aux.Length == 9)
            {
                for (int i = 0; i < aux.Length; i++)
                {
                    if (i == 2 || i == 7)
                    {
                        if (aux[i] != '-')
                            return false;
                    }
                    else
                    {
                        if (!char.IsNumber(aux[i]))
                            return false;
                    }

                }
                return true;
            }
            return false;

        }




        public override string ExponerDatos()
        {

            StringBuilder sb = new StringBuilder();


            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine(" " + this.AnioDivision);

            return sb.ToString();
        }


    }
}