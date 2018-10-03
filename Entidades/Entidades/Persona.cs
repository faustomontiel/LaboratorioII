using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public abstract class Persona
  {


    private string _apellido;
    private string _nombre;
    private string _documento;


    public Persona(string nombre, string apellido, string documento)
    {
      this._nombre = nombre;
      this._apellido = apellido;

      if (ValidarDocumento(documento))
      {
        this._documento = documento;
      }
    }

    public string Apellido
    {
      get
      {
        return this._apellido;
      }
    }
    public string Nombre
    {
      get
      {
        return this._nombre;
      }
    }
    //documento con validacion
    public string Documento
    {
      get
      {
        return this._documento;
      }
      set
      {
        if(ValidarDocumento(value))
        {
          this._documento = value;
        }
      }
    }

    protected virtual bool ValidarDocumento(string aux)
    {
      if (aux.Length == 9)
      {
        for (int i = 0; i < aux.Length; i++)
        {
          if (i == 2 || i == 7)
          {
            if (aux[i] != '-')
              return false;
          }
          else
          {
            if (!char.IsNumber(aux[i]))
              return false;
          }

        }
        return true;
      }
      return false;

    }



    public virtual string ExponerDatos()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine("NOMBRE: " + this._nombre);
      sb.AppendLine("APELLIDO: " + this._apellido);
      sb.AppendLine("Documentacion: " + this.Documento);

      return sb.ToString();

    }










  }
}
