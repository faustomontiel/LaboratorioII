using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int _cilindrada;
        private short _rueda;
        private static int _valorHora;

        static Moto()
        {
            _valorHora = 30;
        }

        public Moto(string patente) : base(patente)
        {
        }

        public Moto(string patente,int cilindrada)
            :this(patente)
        {
            this._cilindrada = cilindrada;
        }
        public Moto(string patente, int cilindrada,short ruedas)
            : this(patente,cilindrada)
        {
            this._rueda = ruedas;
            
        }
        public Moto(string patente, int cilindrada, short ruedas,int valorHora)
            : this(patente, cilindrada,ruedas)
        {
            Moto._valorHora = valorHora;
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
            sb.AppendLine("Cilindrada: "+ this._cilindrada);

            costo = (int)(DateTime.Now - this._ingreso).TotalHours * Moto._valorHora;
            sb.AppendLine("Costo Estadia: "+ costo);

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
