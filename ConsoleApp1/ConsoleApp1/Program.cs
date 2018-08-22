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
            int num = 0;
            int max=0;
            int min=0;
            int i;
            

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                max = num;
                min = num;
                }
                    else if (i != 0)
                    {
                         if (num > max)
                         {
                             max = num;
                         }
                         else if(num < min)
                         {
                             min = max;
                         }
                    }

            }
            
            
            Console.WriteLine("El mayor numero es : "+ max);
            Console.WriteLine("El menor numero es : " + min);
            Console.ReadKey();
        }
    }
}
