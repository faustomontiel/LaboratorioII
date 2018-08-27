using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, anio, d, m, a;

            Console.Write("CALCULAR EDAD");
            Console.Write("Ingrese dia: ");
            int.TryParse(Console.ReadLine(), out dia);

            Console.Write("Ingrese mes: ");
            int.TryParse(Console.ReadLine(), out mes);

            Console.Write("Ingrese año: ");
            int.TryParse(Console.ReadLine(), out anio);

            a = DateTime.Now.Year - anio;
            m = DateTime.Now.Month - mes;
            d = DateTime.Now.Day - dia;

            Console.WriteLine("Su edad es: " + a + " años, " + m + " meses, " + d + " días");
            Console.ReadKey();
        }
    }
}
