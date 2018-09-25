using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil auto = new Automovil(4, 5, VehiculoTerrestre.Color.Negro, 5,5);
            Moto motocicleta = new Moto(2, 0, VehiculoTerrestre.Color.Azul, 150);
            Camion camion = new Camion(8, 3, VehiculoTerrestre.Color.Rojo, 5, 2500);

            Console.WriteLine("AUTO");
            Console.WriteLine("Ruedas: {0}",auto.Ruedas);
            Console.WriteLine("Puertas: {0}", auto.Puertas);
            Console.WriteLine("Color: {0}",auto.ColorP);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("CAMION");
            Console.WriteLine("Ruedas: {0}", camion.Ruedas);
            Console.WriteLine("Puertas: {0}", camion.Puertas);
            Console.WriteLine("Color: {0}", camion.ColorP);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("MOTO");
            Console.WriteLine("Ruedas: {0}", motocicleta.Ruedas);
            Console.WriteLine("Puertas: {0}", motocicleta.Puertas);
            Console.WriteLine("Color: {0}", motocicleta.ColorP);

            Console.ReadKey();
        }
    }
}
