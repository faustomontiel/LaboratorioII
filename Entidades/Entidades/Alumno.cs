using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Alumno: Persona
  {
    private short _anio;
    private Divisiones _division;

    public Alumno(string nombre,string apellido,string documento,short anio,Divisiones division)
      :base(nombre,apellido,documento)
    {
      this._anio = anio;
      this._division = division;
    }
    public string AnioDivision
    {
      get
      {
        return " " + this._anio + "º" + " " + this._division;
      }
    }
    

    public override string ExponerDatos()
    {
      StringBuilder sb = new StringBuilder();

      
        sb.AppendLine(base.ExponerDatos());
        sb.AppendLine(" " + this.AnioDivision);
      
      return sb.ToString();
    }


  }
}
