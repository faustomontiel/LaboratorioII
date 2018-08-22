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
            int a = 0,i, num;
            Console.WriteLine("Ingrese numero");
            num = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < num; j++)
            {

                for ( i = 1; i < (num+1) ; i++)
                {
                    if (num % i == 0)
                    {
                        a++;
                    }
                }

                if (a != 2)
                {
                    Console.WriteLine(" "+j);
                }
                else
                {
                    
                   Console.WriteLine(" "+i );
                }
             }
                Console.ReadLine();
        }
    }

  }



