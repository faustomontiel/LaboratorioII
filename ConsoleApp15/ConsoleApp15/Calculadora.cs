using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Calculadora
    {
        public static double Calcular(double primero, double segundo, string signo)
        {
            double resultado=0;

            switch (signo)
            {
                case "+":
                    resultado= primero +segundo;
                    break;
                case "-":
                    resultado = primero - segundo;
                    break;

                case "*":
                    resultado = primero * segundo;
                    break;
                case "/":
                    resultado = primero / segundo;
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }
            return resultado;
        }
    }
}
