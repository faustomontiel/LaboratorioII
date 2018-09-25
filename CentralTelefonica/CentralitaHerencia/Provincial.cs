using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        //Unico atributo especial de la clase.
        protected Franja _franjaHoraria;

        //propiedad donde retorno el metodo CalcularCosto
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        //constructor hereda atributos de Llamada.
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this._franjaHoraria = miFranja;
        }

        //constructor ingresa por parametro un objeto de tipo llamada con sus atributos ya cargados.
        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        private float CalcularCosto()
        {
            float CostoTotal;
            float costo = 0;
            switch (_franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = 0.99F;
                    break;
                case Franja.Franja_2:
                    costo = 1.25F;
                    break;
                case Franja.Franja_3:
                    costo = 0.66F;
                    break;
            }
            CostoTotal = this._duracion * costo;
            return CostoTotal;

        }

        public new string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("DURACION: {0}", this._duracion);
            mostrar.AppendFormat("Numero DESTINO: {0}", this._nroDestino);
            mostrar.AppendFormat("Numero ORIGEN: {0}", this._nroOrigen);
            mostrar.AppendFormat("COSTO: {0}", this.CostoLlamada);
            mostrar.AppendFormat("FRANJA: {0}", this._franjaHoraria);

            return mostrar.ToString();
        }
    }
}
