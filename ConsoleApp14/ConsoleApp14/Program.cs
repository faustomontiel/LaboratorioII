using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado,base_,h,radio;
            double cuadrado, triangulo, circulo;
           
            
            Console.WriteLine("Ingrese lado de un cuadrado: ");
            while (!double.TryParse(Console.ReadLine(), out lado))
            {
                Console.WriteLine("Error. Ingrese un año valido.");
            }

            Console.WriteLine("Ingrese Altura de un triangulo: ");
            while (!double.TryParse(Console.ReadLine(), out h))
            {
                Console.WriteLine("Error. Ingrese un año valido.");
            }


            Console.WriteLine("Ingrese base de un base: ");
            while (!double.TryParse(Console.ReadLine(), out base_))
            {
                Console.WriteLine("Error. Ingrese un año valido.");
            }

            Console.WriteLine("Ingrese radio de un circulo: ");
            while (!double.TryParse(Console.ReadLine(), out radio))
            {
                Console.WriteLine("Error. Ingrese un año valido.");
            }

            cuadrado = CalculoDeArea.CalcularCuadrado(lado);
            triangulo = CalculoDeArea.CalcularTriangulo(h,base_);
            circulo = CalculoDeArea.CalcularCirculo(radio);

            Console.WriteLine("El area de un cuadrado es " + cuadrado);
            Console.WriteLine("El area de un triangulo es " + triangulo);
            Console.WriteLine("El area de un circulo es " + circulo);

            Console.ReadKey();



        }
    }
}
