using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno("monitel",  120, "fausto");
            Alumno alumno2 = new Alumno("perez",  150, "juan");
            Alumno alumno3 = new Alumno("gomez", 200, "pedro");

            alumno.estudiar(7,8);
            alumno2.estudiar(6, 7);
            alumno3.estudiar(7, 5);

            alumno.Mostrar();
            alumno2.Mostrar();
            alumno3.Mostrar();

            Console.ReadKey();



        }
    }
}
