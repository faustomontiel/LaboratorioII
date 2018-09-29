using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;

        protected Sobreescrito()
        {
            this.miAtributo = "Probar Abstractos";
        }

        public abstract string MiPropiedad
        {
            get;       
        }
        public abstract string MiMetodo();




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
