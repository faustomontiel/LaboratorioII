using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecarga
{
    public class Centimetro
    {
        public double valor;
        public Centimetro(double valor)
        {
            this.valor = valor;
        }

        public static bool operator ==(Centimetro centimetro, Centimetro centimetro2)
        {
            return centimetro.valor == centimetro2.valor;

        }

        public static bool operator !=(Centimetro centimetro, Centimetro centimetro2)
        {
            return !(centimetro.valor == centimetro2.valor);
        }


    }
}
