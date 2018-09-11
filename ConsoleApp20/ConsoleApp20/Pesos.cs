using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
  public class Pesos
  {
    private double cantidad;
    private static float cotizRespectoDolar;

    private Pesos()
    {
      cotizRespectoDolar = 17.55F;
    }

    public Pesos(double cantidad) : this()
    {
      this.cantidad = cantidad;
    }

    public Pesos(double cantidad, float cotizacion) : this(cantidad)
    {
      cotizRespectoDolar = cotizacion;
    }


    public double GetCantidad()
    {
      double cantidad;

      cantidad = this.cantidad;

      cantidad = Math.Round(cantidad, 4);

      return cantidad;
    }

    public static float GetCotizacion()
    {
      float cotizacion;

      cotizacion = cotizRespectoDolar;

      return cotizacion;
    }

    public static explicit operator Euro(Pesos peso)
    {
      Euro euro = new Euro((peso.GetCantidad() / Pesos.GetCotizacion()) * Euro.GetCotizacion());

      return euro;
    }

    public static explicit operator Dolar(Pesos peso)
    {
      Dolar dolar = new Dolar(peso.GetCantidad() / Pesos.GetCotizacion());

      return dolar;
    }

    public static implicit operator Pesos(double cantidad)
    {
      Pesos peso = new Pesos(cantidad);

      return peso;
    }

    public static bool operator ==(Pesos p, Euro e)
    {
      bool ok = false;

      if (((Euro)p).GetCantidad() == e.GetCantidad())
      {
        ok = true;
      }

      return ok;
    }

    public static bool operator ==(Pesos p, Dolar d)
    {
      bool ok = false;

      if (((Dolar)p).GetCantidad() == d.GetCantidad())
      {
        ok = true;
      }

      return ok;
    }

    public static bool operator ==(Pesos p1, Pesos p2)
    {
      bool ok = false;

      if (p1.GetCantidad() == p2.GetCantidad())
      {
        ok = true;
      }

      return ok;
    }

    public static bool operator !=(Pesos p1, Pesos p2)
    {
      return !(p1 == p2);
    }


    public static bool operator !=(Pesos p, Dolar d)
    {
      return !(p == d);
    }


    public static bool operator !=(Pesos p, Euro e)
    {
      return !(p == e);
    }

    public static Pesos operator +(Pesos p, Euro e)
    {
      Pesos peso = new Pesos(p.GetCantidad() + ((Pesos)e).GetCantidad());

      return peso;
    }

    public static Pesos operator +(Pesos p, Dolar d)
    {
      Pesos peso = new Pesos(p.GetCantidad() + ((Pesos)d).GetCantidad());

      return peso;
    }

    public static Pesos operator -(Pesos p, Euro e)
    {
      Pesos peso = new Pesos(p.GetCantidad() - ((Pesos)e).GetCantidad());

      return peso;
    }

    public static Pesos operator -(Pesos p, Dolar d)
    {
      Pesos peso = new Pesos(p.GetCantidad() - ((Pesos)d).GetCantidad());

      return peso;
    }


  }
}
