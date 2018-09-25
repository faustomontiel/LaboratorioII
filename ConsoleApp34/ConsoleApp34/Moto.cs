using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    public class Moto : VehiculoTerrestre
    {
        private short _cilindrada;

        public Moto(short ruedas, short puertas, Color color,short cilindrada):base(ruedas,puertas,color)
        {
            this._cilindrada = cilindrada;
        }
       
    }

}
