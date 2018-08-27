using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("hello world");
            MiClase objeto = new MiClase();
            objeto.valor = 2;
            Console.WriteLine(objeto.valor);
            MiClase objeto2 = new MiClase();
            objeto2.valor = 3;
            Console.WriteLine(objeto2.valor);
            MiClase.valorEstatico = 1;*/

            Automovil velocidad = new Automovil();
            velocidad.velocidadActual = 80; 

            velocidad.Acelerar(20);

            Console.WriteLine(velocidad.velocidadActual);


             Automovil.MostrarCantidadRuedas();


            Console.ReadKey();

        }
        
    }
}
