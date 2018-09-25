using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    public class Automovil: VehiculoTerrestre
    {
        private short _cantidadMarchas;
        private int _cantidadPasajeros;

        public Automovil(short ruedas, short puertas, Color color, short marchas,int pasajeros): base(ruedas,puertas,color)
        {
            this._cantidadMarchas = marchas;
            this._cantidadPasajeros = pasajeros;
        }
     

    }
}
