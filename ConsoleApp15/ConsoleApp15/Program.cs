using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            double res;
            res=Calculadora.Calcular(5, 2, "+");
            Console.WriteLine(" " + res);
            Console.ReadKey();
            
        }
    }
}
