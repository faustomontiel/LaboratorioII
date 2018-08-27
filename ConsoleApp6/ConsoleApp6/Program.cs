using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio;
            Console.WriteLine("Ingrese año: ");
            while (!int.TryParse(Console.ReadLine(), out anio))
            {
                Console.WriteLine("Error. Ingrese un año valido.");
            }
            if (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0))
            {
                Console.WriteLine("El año " + anio + " Si es bisiesto ");
            }
            else
            {
                Console.WriteLine("El año " + anio + " No es bisiesto ");
            }
            Console.ReadLine();
        }
    }
}
