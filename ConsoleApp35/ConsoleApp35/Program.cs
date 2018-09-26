using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo miEquipo = new Equipo(5, "Club Atletico Tristan Suarez");
            Jugador j1 = new Jugador(34707508, "Pulga Rodriguez", 7, 15);
            Jugador j2 = new Jugador(37058801, "Polaco Bastia", 5, 8);

            

            if (miEquipo + j1 && miEquipo + j2)
            {
                Console.WriteLine(miEquipo.Mostrar());
            }
            else
            {
                Console.WriteLine("error al cargar los jugadores por exeso de jugadores");
            }

            Console.ReadKey();


        }
    }
}
