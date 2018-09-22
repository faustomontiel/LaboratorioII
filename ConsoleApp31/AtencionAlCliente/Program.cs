using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AtencionAlCliente
{
    class Program
    {
        static void Main(string[] args)
        {

            Negocio negocio = new Negocio("Clinica");
            Cliente c1 = new Cliente(1, "Jose");
            Cliente c2 = new Cliente(2, "Franco");
            Cliente c3 = new Cliente(3, "Juan");
            Cliente c4 = new Cliente(4, "Analia");
            negocio.Cliente = c1;
            negocio.Cliente = c2;
            negocio.Cliente = c3;
            negocio.Cliente = c4;

            while (~negocio)
            {
                Console.WriteLine("Faltan {0} cliente/s por atender", negocio.ClientesPendientes+1);
                Console.WriteLine("Cliente Atendido");
            }
            Console.WriteLine("Sin Clientes");
            Console.ReadKey();




        }
    }
}
