using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    public class DirectorTecnico : Persona
    {

        private DateTime fechaDeNacimiento;

        //contructores
        public DirectorTecnico(string nombre)
            : base(nombre)
        {
        }
        public DirectorTecnico(string nombre, DateTime fecha)
            : this(nombre)
        {
            this.fechaDeNacimiento = fecha;
        }
        //metodos
        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendFormat("Fecha de Nacimietno: {0}", this.fechaDeNacimiento);

            return sb.ToString();
        }
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            if (dt1.fechaDeNacimiento == dt2.fechaDeNacimiento && dt1._nombre == dt2._nombre)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1.fechaDeNacimiento == dt2.fechaDeNacimiento && dt1._nombre == dt2._nombre);
        }

    }
}
