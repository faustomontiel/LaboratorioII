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

        protected abstract bool ValidarDocumento(string aux);
    

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
