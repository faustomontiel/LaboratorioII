using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor _color;
        private static int _valorHora;

        static Automovil()
        {
            Automovil._valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color)
            : base(patente)
        {
            this._color = color;

        }
        public Automovil(string patente, ConsoleColor color, int valorHora)
            : this(patente, color)
        {
            Automovil._valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            return this.ImprimirTicket();
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            int costo;

            sb.Append(base.ImprimirTicket());
            sb.AppendFormat("Color:{0}", this._color);

            costo = (int)(DateTime.Now - this._ingreso).TotalHours * Automovil._valorHora;
            sb.AppendLine("Costo Estadia: " + costo);

            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (this == obj)
            {
                retorno = true;
            }
            return retorno;
        }


    }
}
