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

        //Propiedades
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
        public string Mostrar()
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
                mostrar.Append("---------------\n");
                mostrar.Append(llamada.Mostrar());
            }

            return mostrar.ToString();
        }
    }
}
