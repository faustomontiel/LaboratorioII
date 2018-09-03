using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine(ClaseSobrecarga.Sumar(1, 2) + ClaseSobrecarga.Sumar(1, 2, 3));
            //Sobrecarga sobrecarga = new Sobrecarga();
            //sobrecarga.Sumar(500, 500);
           
            Console.WriteLine((new Metro(5)+ new Centimetro(800)).valor);
            Console.ReadKey();
        }
    }
}
