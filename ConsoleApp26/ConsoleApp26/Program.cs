using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random NumRandom = new Random();
            for(int i=0;i<20; i++)
            {
                numeros.Add(NumRandom.Next(-50,50));
            }
            foreach(var Num in numeros)
            {
                Console.WriteLine(Num);
            }
            

            Console.WriteLine("////////////////////////");

            numeros.Sort();
            foreach(var Num in numeros)
            {
                Console.WriteLine(Num);
            }
            Console.ReadKey();
        }
    }
}
