using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = this.caja;
        }
        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {

                return this.clientes.Dequeue();
            }
            set
            {
                bool encontro = false;

                foreach (Cliente item in this.clientes)
                {
                    if (item == value)
                    {
                        encontro = true;
                    }
                    if (!encontro)
                    {
                        this.clientes.Enqueue(value);
                    }
                }
            }
        }
        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return false;
            }
            return true;
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            for (int i = 0; n.clientes.Count > 0; i++)
            {
                if (n.clientes.Contains(c))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator ~(Negocio n)
        {
            PuestoAtencion puesto = new PuestoAtencion();
            Cliente cliente;
            
            //verificar esto
            cliente = n.Cliente;
            puesto.Atender();
            

            return true;

        }


    }
}
