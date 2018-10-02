using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8_Library
{
  public class Accionista : Persona
  {
    private int _porcionAcionaria;

    public int PorcionAcionaria
    {
      get {

        int porcion = 0;
        if(this._porcionAcionaria > 0 && this._porcionAcionaria<100)
        {
          porcion = this._porcionAcionaria;
        }
        return porcion;

      }
      set
      {
        this._porcionAcionaria = value;
      }
    }

    public string PorcionSocietaria()
    {
      return "Accionista con el "+this.PorcionAcionaria+" % de la porcion accionaria";
    }

    public static bool operator ==(Accionista a1,Accionista a2)
    {
      return (a1._apellido == a2._apellido && a1._nombre == a2._nombre);    
    }
    public static bool operator !=(Accionista a1, Accionista a2)
    {
      return !(a1 == a2);
    }



  }
}
