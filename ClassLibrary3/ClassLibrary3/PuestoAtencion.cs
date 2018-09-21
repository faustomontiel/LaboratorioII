using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public enum Puesto
    {
        caja1,
        caja2
    }

    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                return PuestoAtencion.numeroActual + 1;
            }
        }
        public bool Atender(Cliente cliente)
        {
            Random r = new Random();
           
            System.Threading.Thread.Sleep(r.Next(1000, 3000));

            return true;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }


    }
}
