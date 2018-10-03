using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {

        private List<Alumno> _alumnos;
        private short _anio;
        private Divisiones _divisiones;
        private Profesor _profesor;

        private Curso()
        {
            this._alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor) : this()
        {
            this._anio = anio;
            this._divisiones = division;
            this._profesor = profesor;
        }

        public string AnioDivision
        {
            get
            {
                return " " + this._anio + "º" + " " + this._divisiones;
            }
        }



        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine("Año y Division: " + c.AnioDivision);
            sb.AppendLine("Profesor: " + c._profesor.ExponerDatos());


            foreach (Alumno a in c._alumnos)
            { 
                sb.AppendLine(a.ExponerDatos());
            }

            return sb.ToString();

        }

        public static bool operator ==(Curso c, Alumno a)
        {
            return (c.AnioDivision == a.AnioDivision);
        }
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }


        public static Curso operator +(Curso c, Alumno a)
        {
            if (c == a)
            {
                if(!(a.Documento is null))
                c._alumnos.Add(a);

            }

            return c;
        }





    }
}
