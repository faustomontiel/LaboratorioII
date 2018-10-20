using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime _ingreso;
        private string _patente;

        public Vehiculo(string patente)
        {
           
            this.Patente = patente;
            this._ingreso = DateTime.Now.AddHours(-3);
        }

        public string Patente
        {
            get
            {
                return this._patente;
            }
            set
            {
                if (value.Length == 6)
                {
                    this._patente = value;
                }
                else
                {
                    this._patente = null;
                }
            }
        }

        public abstract string ConsultarDatos();

        public override string ToString()
        {
            
            return string.Format("Patente: {0} ", this.Patente);
            

        }

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(this.ToString());
            sb.AppendFormat("Fecha de Ingreso: {0} ", this._ingreso);

            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;
            if(v1._patente==v2._patente) 
            {
                retorno = true;
            }
            return retorno;
            
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
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
