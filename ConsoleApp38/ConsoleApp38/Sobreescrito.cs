using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    public class Sobreescrito
    {

        public override string ToString()
        {
            return "¡Este es mi método ToStringsobreescrito!";
        }
        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return 1142510187;
        }

    }
}
