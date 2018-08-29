using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double numero)
        {
            return numero * numero;

        }
        public static double CalcularTriangulo(double h,double base_)
        {
            return base_ * h ;

        }
        public static double CalcularCirculo( double radio)
        {
            return Math.Pow(radio, 2) * 3.14159;

        }


    }
}
