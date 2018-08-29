using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero,num;
            string binario,bin;
            

            Console.WriteLine("Ingrese numero decimal a convertir: ");
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Error. Ingrese un numero valido.");
            }

            Console.WriteLine("Ingrese numero binario a convertir: ");
            bin=Console.ReadLine();
           


            binario = Conversor.DecimalBinario(numero);

            num = Conversor.BinarioDecimal(bin);

            Console.WriteLine("  "+binario);
            Console.WriteLine("  " + num);


            Console.ReadKey();

        }
    }
}
