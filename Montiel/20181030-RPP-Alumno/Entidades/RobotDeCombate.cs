using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class RobotDeCombate : Robot
  {
    private bool _lucho;
    private int _caballosDeFuerza;


    public bool Lucho
    {
      get
      {
      return  this._lucho;
      }
    }
    public int CaballosDeFuerza
    {
      get
      {
        return this._caballosDeFuerza;
      }
    }

    public RobotDeCombate():base()
    {
      this._lucho = false;
    }
    public RobotDeCombate(int energia,string origen)
      :base(energia,origen)
    {
      this._caballosDeFuerza = 10;
      this._lucho = false;
    }
    public RobotDeCombate(int energia,string origen, int caballos)
      :this(energia,origen)
    {
      this._caballosDeFuerza = caballos;
    }


    public override string ServirHumanidad()
    {
      StringBuilder sb = new StringBuilder();

      if(this._energia != 0)
      {
        sb.AppendFormat("Robot de Combate {0} - Disparando misiles...",this.Codigo);
        this._energia--;
      }
      else
      {
        sb.AppendFormat("Robot de Combate {0} - Sin Energia", this.Codigo);
      }

      return sb.ToString();
    }

  



  }
}
