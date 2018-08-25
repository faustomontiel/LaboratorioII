using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultadoCuad,resultadoCub, numero;
            int cuadrado = 2;
            int cubo = 3;

            Console.Write("Ingrese un numero para saber su Cuadrado y su Cubo: ");
            numero = int.Parse(Console.ReadLine());

            resultadoCuad = Math.Pow(numero, cuadrado);
            resultadoCub = Math.Pow(numero, cubo);
            Console.WriteLine("La Cuadrado de " + numero + " es "+ resultadoCuad+" y su cubo es "+resultadoCub);
            Console.ReadKey();


        }
    }
}
