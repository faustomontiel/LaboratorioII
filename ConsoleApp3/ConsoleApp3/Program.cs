using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int maximo;
   
            Console.WriteLine("Ingrese un número hasta el cual se calcularan todos los números primos: ");
            while (!int.TryParse(Console.ReadLine(), out maximo))
            {
                Console.WriteLine("Error. Ingrese un valor entero y numérico.");
            }

            bool esPrimo;
            // Un número primo es un número natural mayor que 1, por eso arranco el contador desde 2 hasta el número ingresado
            for (int i = 2; i <= maximo; i++)
            {
                esPrimo = true;
                // Busco divisores entre 2 y el número actual, dando por hecho que el número se dividirá por 1 y por si mismo,
                // ya que un número primo tiene únicamente dos divisores distintos: él mismo y el 1.
                for (int divisor = 2; divisor < i; divisor++)
                {
                    if ((i % divisor) == 0)
                    {
                        // Si encuentro otro divisor, marco como no primo y rompo la iteración del FOR
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                    Console.WriteLine("El número {0} es un número primo menor a {1}", i, maximo);
            }
            Console.ReadKey();
        }
    }
}
