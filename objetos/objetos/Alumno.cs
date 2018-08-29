using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos
{
    class Alumno
    {
        string apellido;
        int legajo;
        string nombre;
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;

        public Alumno(string apellido, int legajo, string nombre)
        {
            this.nombre = nombre;
            this.legajo = legajo;
            this.apellido = apellido;
        }
        public void estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;

            CalcularFinal();

        }
        public void CalcularFinal()
        {
            Random miRamdom = new Random();

            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                this._notaFinal = miRamdom.Next(1, 10);

            }
            else
            {
                this._notaFinal = -1;
                Console.WriteLine("desaprobo");


            }

        }
        public string Mostrar()
        {
        
            StringBuilder sb = new StringBuilder();
            sb.Append("NOMBRE: ");
            sb.AppendLine(this.nombre);
            sb.Append("APELLIDO: ");
            sb.AppendLine(this.nombre);
            sb.Append("Nota 1: ");
            sb.AppendLine(this._nota1.ToString());
            sb.Append("Nota 2: ");
            sb.AppendLine(this._nota2.ToString());
            if (this._notaFinal == -1)
            {
                sb.Append("Nota Final: DESAPROBO");

            }
            else
            {
                sb.Append("Nota Final: ");
                sb.AppendLine(this._notaFinal.ToString());
            }

            return sb.ToString();
           
        }
    }
}
