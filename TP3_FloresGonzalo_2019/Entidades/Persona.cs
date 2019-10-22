using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
  public abstract class Persona
  {
    private string apellido;
    private int dni;
    private ENacionalidad nacionalidad;
    private string nombre;

    public enum ENacionalidad
    {
      Argentino,
      Extranjero
    }

    public string Apellido
    {
      get { return apellido; }
      set { apellido = value; }
    }

    public string Nombre
    {
      get { return nombre; }
      set { nombre = value; }
    }

    public ENacionalidad Nacionalidad
    {
      get { return nacionalidad; }
      set { nacionalidad = value; }
    }

    public int Dni
    {
      get { return dni; }
      set { dni = value; }
    }

    public string StringToDni
    {
      set { dni = int.Parse(value); }
    }

    public Persona()
    {
    }

    public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
    {
      Nombre = nombre;
      Apellido = apellido;
      Nacionalidad = nacionalidad;
    }

    public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
    {
      StringToDni = dni;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Apellido: " + Apellido);
      sb.AppendLine("Nombre: " + Nombre);
      sb.AppendLine("Dni: " + Dni.ToString());
      sb.AppendLine("Nacionalidad: " + Nacionalidad.ToString());
      return sb.ToString();
    }

    private int ValidarDni(ENacionalidad nacionalidad, int dato)
    {
      if (nacionalidad is ENacionalidad.Argentino)
      {
        if (dato >= 1 && dato <= 89999999)
          return dato;
      }
      else if (nacionalidad is ENacionalidad.Extranjero)
      {
        if (dato >= 9000000 && dato < 99999999)
          return dato;
      }
      throw new DniInvalidoException("Dni Invalido");
    }

    private int ValidarDni(ENacionalidad nacionalidad, string dato)
    {
      return ValidarDni(nacionalidad, StringToDni = dato);
    }

    private string ValidarNombreApellido(string dato)
    {
      int valida = 0;
      foreach (char valor in dato)
      {
        if (!char.IsLetter(valor))
        {
          valida = 1;
        }
      }
      if (valida == 0)
      {
        return dato;
      }
      else
      {
        return string.Empty;
      }
    }
  }
}
