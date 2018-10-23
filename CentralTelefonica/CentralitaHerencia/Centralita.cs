using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;


        private Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        #region Propiedades
        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion 

        // metodo calcula la ganacnia por el tipo de llamada
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                switch (tipo)
                {

                    case Llamada.TipoLlamada.Local:
                        if (llamada is Local)
                        {
                            ganancia += ((Local)llamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            ganancia = ganancia + ((Provincial)llamada).CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLlamada.Todas:
                        if (llamada is Local)
                        {
                            ganancia = ganancia + ((Local)llamada).CostoLlamada;
                        }
                        else if (llamada is Provincial)
                        {
                            ganancia = ganancia + ((Provincial)llamada).CostoLlamada;
                        }

                        break;

                }
            }
            return ganancia;

        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        private string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.Append("*******************\n");
            mostrar.AppendFormat("RAZON SOCIAL: {0}", this.razonSocial);
            mostrar.AppendFormat("\nGanancia TOTAL: {0}", this.GananciasPorTotal);
            mostrar.AppendFormat("\nGanancia LOCAL: {0}", this.GananciasPorLocal);
            mostrar.AppendFormat("\nGanancia PROVINCIAL: {0}", this.GananciasPorProvincial);
            mostrar.Append("\n*******************\n");
            mostrar.Append("\nLLAMADAS: \n");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                mostrar.Append("\n---------------\n");
                mostrar.Append(llamada.ToString());
            }

            return mostrar.ToString();
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            foreach (Llamada l in c.listaDeLlamadas)
            {
                if (l == llamada)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }
            else
            {
                throw new CentralitaException("Llamda ya existente", c.GetType().ToString(), "Sobrecarga +");
            }
            return c;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }






    }
}
