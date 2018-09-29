using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        //Unico atributo especial de la clase.
        protected float _costo;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        //Constructor hereda atributos de llamada y carga el atributo especial.
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this._costo = costo;
        }

        //Ingresa por parametro un objeto con sus atributos ya cargados.
        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        
        public new string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.Append(base.Mostrar());
            mostrar.AppendFormat("COSTO: {0}", this.CostoLlamada);

            return mostrar.ToString();
        }
       
        
        private float CalcularCosto()
        {
            return this._duracion * this._costo;
        }


    }
}
