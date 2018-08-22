using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num=0,cubo=0,cuadrado=0;
            int potencia = 3;
            int poitenciaCuad = 2;
         
            
               Console.WriteLine("Introduce un número:");
               num = int.Parse(Console.ReadLine());

            if (num > 0)
            {

                cubo = Math.Pow(num, potencia);
                cuadrado = Math.Pow(num, poitenciaCuad);
            }
            else
            {
                Console.WriteLine("ERROR!");
            }
            Console.WriteLine("Su cubo es  " + cubo);
            Console.WriteLine("Su cuadrado es  " + cuadrado);

            Console.ReadKey();

        }
    }
}
