using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace _20181030_RPP_Boullon
{
    class Program
    {
        static void Main(string[] args)
        {
            Arena arena = new Arena("Lucha de robots", 50);
            RobotDeCombate robotA = new RobotDeCombate(10, "China", 20);
            RobotDeCombate robotB = new RobotDeCombate(0, "EEUU", 20);
            RobotDeCombate robotC = new RobotDeCombate(10, "Argentina", 20);
            arena += robotA;
            arena += robotB;
            arena += robotC;
            arena += robotC;
            Console.WriteLine(arena.Combate(new RobotDeCombate(20, "Yankee", 250)));
            if (!robotB.CargarEnergia(80))
                Console.WriteLine("\nIngresar una cantidad de energía menor a {0}\n", Robot.CapacidadEnergia);
            robotB.CargarEnergia(40);
            
            Console.WriteLine(arena.Combate(null));

            Robot robotD = new RobotSirviente(0, "China");
            Robot robotE = new RobotSirviente(3, "Corea");
            Robot robotF = new RobotSirviente(3, "Yankee");

            arena += robotD;
            arena += robotE;
            arena += robotF;

            ConsoleColor colorActual = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(arena);
            Console.ForegroundColor = colorActual;

            Console.WriteLine(arena.ServirEspectadores());
            Console.WriteLine(arena.ServirEspectadores());
            Console.WriteLine(arena.ServirEspectadores());
            Console.WriteLine(arena.ServirEspectadores());

            arena -= robotA;
            arena -= robotB;
            arena -= robotA;
            arena -= robotC;
            arena -= robotD;
            arena -= robotE;

            colorActual = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(arena);
            Console.ForegroundColor = colorActual;

            Console.ReadKey();
            
        }
    }
}
