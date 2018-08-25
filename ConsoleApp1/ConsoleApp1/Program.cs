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
            int num;
            int max = 0;
            int min= 0;
            int i;
            bool flag = false;


            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (num < min || flag == false)
                {
                    min = num;
                    flag = true;
                }

                if (num > max || flag == false)
                {
                    max = num;
                    flag = true;
                }
            }
            Console.WriteLine("El menor numero es : " + min);
            Console.WriteLine("El mayor numero es : " + max);
            
            Console.ReadKey();
        }
    }
}
