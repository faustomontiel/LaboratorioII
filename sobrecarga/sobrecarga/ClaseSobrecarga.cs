using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecarga
{
    public class Sobrecarga
    {
        public string tipoNumero;

        public Sobrecarga() : this("Metro")
        {
            
        }
        public Sobrecarga(string tipo)
        {
            tipoNumero = tipo; ;
        }

        public Sobrecarga(string tipo, int metro, int metroDos) : this(tipo)
        {
            Sumar(metro,metroDos);
        }

        public float Sumar(int a, int b)
        {
            if (tipoNumero == "Metro")
                return (a + b);
            else
                return (a + b) * 100;
        }
        public float Sumar(float a, float b)
        {
            return (int)(a + b);
        }

        public float Sumar(float numeroUno, int numeroDos)
        {
            return numeroUno + (numeroDos * 100);
        }
        public float Sumar(int metro, float centimetros)
        {
            return Sumar(centimetros, metro);
        }


    }
}
