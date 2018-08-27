using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1, acum, perfect = 0;
            
            do
            {
                acum = 0;
                //Recorro el numero menos 1 hasta el cero.
                for (int i = numero - 1; i > 0; i--)
                {
                    //si algun numero junto a otro numero es divisible lo sumo.
                    if (numero % i == 0)
                    {
                        acum += i;
                    }
                }
                // si la suma es igual al numero imprimo lo imprimo-
                if (acum == numero) 
                {
                    // contador para asegurar los cuatro que necesito.
                    perfect++;  
                    Console.WriteLine(numero);
                }

                numero++;

            } while (perfect < 4);

            Console.ReadKey();
        }
    }
}
