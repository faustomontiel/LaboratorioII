using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class RobotSirviente : Robot
  {
    public override bool CargarEnergia(int energia)
    {
      bool salida = false;
      if (this._energia == 0)

      {
        this._energia = energia;
        salida = true;
      }
      return salida;

    }
    public RobotSirviente() : base()
    {
    }
    public RobotSirviente(int energia,string origen):base(energia,origen)
    {

    }
    public override string ServirHumanidad()
    {
      StringBuilder sb = new StringBuilder();

      if (this._energia != 0)
      {
        sb.AppendLine("Haciendo masajes...");
        this._energia--;
      }
      else
      {
        sb.AppendLine("Sin Energia");
      }
      return sb.ToString();
    }

  }
}
