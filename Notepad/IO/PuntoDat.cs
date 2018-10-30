using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
  public class PuntoDat:Archivo
  {
    private string _contenido;
    public string Contenido
    {
      get
      {
        return this._contenido;
      }
      set
      {
        this._contenido = value;
      }
    }



  }
}
