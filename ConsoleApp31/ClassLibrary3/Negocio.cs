using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


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
            this.caja = new PuestoAtencion(Puesto.caja1);
        }
        public Negocio(string nombre) : this() // esto es necesario porque cuando instancien este constructor
        {                                     // desde el program ya va estar instanseado con los atributos cargados
                                              //en el constructor privado.
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                 if (this.ClientesPendientes != 0)           
                    return this.clientes.Dequeue();              
                else
                    return null;
            }
            set
            {
                bool var = this + value;
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
                return true;
            }
            return false;
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente AlgunCliente in n.clientes)
            {
                if (AlgunCliente == c)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator ~(Negocio n)
        {
            if (n.ClientesPendientes != 0)
                return n.caja.Atender(n.Cliente);
            else
                return false;

        }


    }
}
