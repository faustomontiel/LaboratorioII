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

    public Accionista(Persona persona,int porcion)
            : this(persona.Nombre, persona.Apellido, porcion)
    {
    }

    public Accionista(string nombre, string apellido, int porcion)
        : base(nombre, apellido)
    {
      this._porcionAcionaria = porcion;
    }
    public override string PosicionSocietaria()
    {
      return "Accionista con el " + this.PorcionAcionaria + " % de la porcion accionaria";
    }

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



    protected override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine("Nombre  : " + base._nombre);
      sb.AppendLine("Apellido: " + base._apellido);
      sb.AppendLine(" " + this.PorcionAcionaria);
      sb.AppendLine("******************");

      return sb.ToString();
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
