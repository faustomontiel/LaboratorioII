using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    /// <summary>
    /// Vailida que no se exeda el limite.
    /// </summary>
    public class Validacion
    {

        public static bool Validar(int valor,int maximo,int minimo)
        {
            bool flag=false;

            if(valor < maximo && valor > minimo)
            {
                flag = true;
            }
            return flag;
        }


    }
}
