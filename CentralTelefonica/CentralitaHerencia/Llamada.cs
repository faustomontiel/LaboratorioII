using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        //atribustos base.
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        //propiedades bases.

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        //constructor base.
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }
        public string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("DURACION: {0}\n", this._duracion);
            mostrar.AppendFormat("Numero DESTINO: {0}\n", this._nroDestino);
            mostrar.AppendFormat("Numero ORIGEN: {0}\n", this._nroOrigen);

            return mostrar.ToString();
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        //retorno los valores para complementarlo luego con el Sort.
        public static int OrdenarPorDuracion(Llamada llamada, Llamada llamada1)
        {
            int retorno = 0;
            if (llamada.Duracion > llamada1.Duracion)
            {
                retorno = 1;
            }
            else if (llamada.Duracion < llamada1.Duracion)
            {
                retorno = -1;
            }
            return retorno;
        }


    }
}
