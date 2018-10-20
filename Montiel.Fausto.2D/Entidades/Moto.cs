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
        private int _valorHora;

        private Moto() : base("")
        { 

        }


        public Moto(string patente,int cilindrada)
            :base(patente)
        {
            this._cilindrada = cilindrada;
            this._valorHora = 30;
        }
        public Moto(string patente, int cilindrada,short ruedas)
            : this(patente,cilindrada)
        {
            this._rueda = ruedas;
            this._valorHora = 30;
        }
        public Moto(string patente, int cilindrada, short ruedas,int valorHora)
            : this(patente, cilindrada,ruedas)
        {
            this._valorHora = valorHora;
        }

        public Moto(string patente) : base(patente)
        {
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

            costo = (int)(DateTime.Now - this._ingreso).TotalHours * this._valorHora;
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
