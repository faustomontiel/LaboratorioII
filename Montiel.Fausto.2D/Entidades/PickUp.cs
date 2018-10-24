using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string _modelo;
        private static int _valorHora;


        static PickUp()
        {
           PickUp._valorHora = 70;
        }


        public PickUp(string patente, string modelo)
            : base(patente)
        {
            this._modelo = modelo;
            
        }
        public PickUp(string patente, string modelo, int valorHora)
            : this(patente, modelo)
        {
            PickUp._valorHora = valorHora;
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
            sb.AppendLine("Modelo: "+this._modelo);

            costo = (int)(DateTime.Now - this._ingreso).TotalHours * PickUp._valorHora;
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
