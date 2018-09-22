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
                return numeroActual ++; 
            }
        }
        public bool Atender(Cliente cliente)
        {
                   
            System.Threading.Thread.Sleep(1000);

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
