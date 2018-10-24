using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesT;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Mundial");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("NBA");

            EquipoBasquet b1 = new EquipoBasquet("BasquetA",DateTime.Now);
            EquipoBasquet b2 = new EquipoBasquet("BasquetB", DateTime.Now);
            EquipoBasquet b3 = new EquipoBasquet("BasquetC", DateTime.Now);

            EquipoFutbol f1 = new EquipoFutbol("FutbolA", DateTime.Now);
            EquipoFutbol f2 = new EquipoFutbol("FutbolB", DateTime.Now);
            EquipoFutbol f3 = new EquipoFutbol("FutbolC", DateTime.Now);

            string partido;

            torneoBasquet += b1;
            torneoBasquet += b2;
            torneoBasquet += b3;
            torneoBasquet += b3;

            Console.WriteLine(torneoBasquet.Mostrar());

            Console.WriteLine("----------------------");
            torneoFutbol += f1;
            torneoFutbol += f2;
            torneoFutbol += f3;
            torneoFutbol += f3;
            Console.WriteLine(torneoFutbol.Mostrar());

           partido=torneoFutbol.JugarPartido;

            Console.WriteLine(partido);

            partido = torneoBasquet.JugarPartido;

            Console.WriteLine(partido);



            Console.ReadKey();



        }
    }
}
