using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string binario = " ";
            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }
                    numero = (int)numero / 2;
                }
            }
            else if (numero == 0)
            {
                binario = "0";
            }
            else
            {
                Console.Write("INGRESO UN NUMERO NEGATIVO");
            }
            return binario;
        }

        public static double BinarioDecimal(string binario)
        {
           double potencia = 1;
           double numero = 0;
           var chars= binario.ToCharArray();

            for (int i= chars.Length - 1; i>=0;i--)
            {
                if(chars[i]=='1')
                {
                    numero = potencia + numero;
                    potencia *= 2;
                }
            }
            return numero;

        }

    }


}

