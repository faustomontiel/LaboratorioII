using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{

    public class VehiculoTerrestre
    {
        protected short _cantidadRuedas;
        protected short _cantidadPuertas;
        protected Color _colores;

        public VehiculoTerrestre(short ruedas, short puertas, Color color)
        {
            this._cantidadRuedas = ruedas;
            this._cantidadPuertas = puertas;
            this._colores = color;
        }
        public string Ruedas { get { return this._cantidadRuedas.ToString(); } }
        public string Puertas { get { return this._cantidadPuertas.ToString(); } }
        public string ColorP { get { return this._colores.ToString(); } }

        public enum Color
        {
            Rojo, Blanco, Azul, Gris, Negro
        }

    }
}
