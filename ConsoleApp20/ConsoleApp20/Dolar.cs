using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
  public class Dolar
  {
    private double cantidad;
    private static float cotizRespectoDolar;

    private Dolar()
    {
      Dolar.cotizRespectoDolar = 1;
    }
    public Dolar(double cantidad) : this()
    {
      this.cantidad = cantidad;
    }
    public Dolar(double cantidad, float cotizacion) : this(cantidad)
    {

      Dolar.cotizRespectoDolar = cotizacion;
    }

    public double GetCantidad()
    {
      return this.cantidad;
    }
    public static float GetCotizacion()
    {
      return Dolar.cotizRespectoDolar;

    }

    public static explicit operator Euro(Dolar d)
    {
      Euro e;
      e = new Euro(d.GetCantidad() / Euro.GetCotizacion());
      return e;
    }
    public static explicit operator Pesos(Dolar d)
    {
      Pesos peso;

      peso = new Pesos(d.GetCantidad() * Pesos.GetCotizacion());

      return peso;
    }
    public static implicit operator Dolar(double cantidad)
    {
      Dolar d;

      d = new Dolar(cantidad);

      return d;
    }
    public static bool operator ==(Dolar d,Euro e)
    {
      bool retorno = false;
      if(((Euro)d).GetCantidad()== e.GetCantidad())
      {
        retorno = true;
      }
      return retorno;
    }
    public static bool operator ==(Dolar d, Pesos p)
    {
      bool ok = false;

      if (((Pesos)d).GetCantidad() == p.GetCantidad())
      {
        ok = true;
      }

      return ok;
    }

    public static bool operator ==(Dolar d1, Dolar d2)
    {
      bool ok = false;

      if (d1.GetCantidad() == d2.GetCantidad())
      {
        ok = true;
      }

      return ok;
    }

    public static bool operator !=(Dolar d1, Dolar d2)
    {
      return !(d1 == d2);
    }


    public static bool operator !=(Dolar d, Pesos p)
    {
      return !(d == p);
    }


    public static bool operator !=(Dolar d, Euro e)
    {
      return !(d == e);
    }

    public static Dolar operator +(Dolar d, Euro e)
    {
      Dolar dolar = new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());

      return dolar;
    }

    public static Dolar operator +(Dolar d, Pesos p)
    {
      Dolar dolar = new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad());

      return dolar;
    }

    public static Dolar operator -(Dolar d, Euro e)
    {
      Dolar dolar = new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());

      return dolar;
    }

    public static Dolar operator -(Dolar d, Pesos p)
    {
      Dolar dolar = new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());

      return dolar;
    }



  }
}
