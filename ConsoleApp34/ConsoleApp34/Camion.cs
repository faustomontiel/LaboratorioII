using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    public class Camion : VehiculoTerrestre
    {
        private short _cantidadMarchas;
        private int _pesoCarga;

        public Camion(short ruedas,short puertas,Color color,short marchas,int peso) :base(ruedas,puertas,color)
        {
            this._cantidadMarchas = marchas;
            this._pesoCarga = peso;
        }
             
    }
}
