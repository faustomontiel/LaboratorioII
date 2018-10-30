using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public abstract class Robot
  {

    private static int _capacidadDeEnergia;
    private static int _contador;
    private int _codigo;
    protected int _energia;
    protected string _origen;

    static Robot()
    {
      _capacidadDeEnergia = 50;
      _contador = 0;
    }
    protected Robot()
    {
      this._origen = "Coreano";
      this._energia = 10;
      this._codigo = Robot._contador++;
    }
    public Robot(int energia, string origen) : this()
    {
      this._energia = energia;
      this._origen = origen;
    }


    public static int CapacidadEnergia
    {
      get
      {
        return _capacidadDeEnergia;
      }
    }
    public int Codigo
    {
      get
      {
        return this._codigo;
      }
    }
    public int Energia
    {
      get
      {
        return this._energia;
      }
    }

    public virtual bool CargarEnergia(int energia)
    {
      bool salida = false;
      if (energia > 0 && _capacidadDeEnergia > energia)
      {
        this._energia = energia;
        salida = true;
      }
      return salida;
    }
    public abstract string ServirHumanidad();

    public static bool operator ==(Robot r1, Robot r2)
    {
      return (r1._codigo == r2._codigo);
    }
    public static bool operator !=(Robot r1, Robot r2)
    {
      return !(r1 == r2);
    }
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine("Energia: "+this._energia);
      sb.AppendLine("Codigo: "+this._codigo);
      sb.AppendLine("Origen: " + this._origen);

      return sb.ToString();
    }

  }

}

