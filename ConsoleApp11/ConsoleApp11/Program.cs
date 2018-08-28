using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int max = 0;
            int min = 0;
            bool flag = false;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100");
                int.TryParse(Console.ReadLine(), out numero);

                if (!(Validacion.Validar(numero, 100, -100)))
                {
                    Console.WriteLine("Se exedio el limite");

                }
                else
                {
                    if (numero < min || flag == false)
                    {
                        min = numero;
                        flag = true;
                    }

                    if (numero > max || flag == false)
                    {
                        max = numero;
                        flag = true;
                    }
                }

            }

            Console.WriteLine("El menor numero es : " + min);
            Console.WriteLine("El mayor numero es : " + max);

            Console.ReadKey();

        }
    }
}
