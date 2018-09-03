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
            Metro metro = new Metro(5);
            Centimetro centimetro = new Centimetro(800);
            Metro resultado = metro + centimetro;


            Console.WriteLine(resultado.valor);
            Console.ReadKey();
        }
    }
}
