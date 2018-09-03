using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecarga
{
    public class Metro
    {
        public double valor;
        public Metro(double valor)
        {
            this.valor = valor;
        }

        public static Metro operator +(Metro metro, Centimetro centimetro)
        {
            metro.valor += centimetro.valor / 100;
            return metro;
        }

        public static bool operator ==(Metro metro,Metro metro2)
        {
            return metro.valor==metro2.valor; 

        }

        public static bool operator !=(Metro metro, Metro metro2)
        {
            return !(metro.valor == metro2.valor);
        }

    }
}
