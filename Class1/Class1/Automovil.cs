using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    public class Automovil
    {
        //atributos no estaticos
        public Single velocidadActual;

        //atributos estaticos
        public static Byte cantidadRuedas = 4;

        //Metodos estaticos
        public static void MostrarCantidadRuedas()
        {
            Console.Write(Automovil.cantidadRuedas);
        }
        //metodos no estaticos

        public void Acelerar(Single velocidad)
        {
            this.velocidadActual += velocidad;
        }

    }
}
