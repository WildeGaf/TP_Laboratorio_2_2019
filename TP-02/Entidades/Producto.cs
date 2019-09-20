using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2019
{
  /// <summary>
  /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
  /// </summary>
  public abstract class Producto
  {
    public enum EMarca
    {
      Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
    }
    private EMarca marca;
    private string codigoDeBarras;
    private ConsoleColor colorPrimarioEmpaque;


    public Producto (EMarca marca,string codigo, ConsoleColor color)
    {
      this.marca = marca;
      this.codigoDeBarras = codigo;
      this.colorPrimarioEmpaque = color;
    }

    /// <summary>
    /// ReadOnly: Retornará la cantidad de calorias del Producto
    /// </summary>
    protected virtual short CantidadCalorias { get; }

    /// <summary>
    /// Publica todos los datos del Producto.
    /// </summary>
    /// <returns></returns>
    public virtual string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(this.marca.ToString());
      sb.AppendLine(this.codigoDeBarras);
      sb.AppendLine(this.colorPrimarioEmpaque.ToString());
      return sb.ToString();
    }

    public static explicit operator string(Producto p)
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine("CODIGO DE BARRAS: \r\n" + p.codigoDeBarras);
      sb.AppendLine("MARCA          :  \r\n" + p.marca.ToString());
      sb.AppendLine("COLOR EMPAQUE  :  \r\n" + p.colorPrimarioEmpaque.ToString());
      sb.AppendLine("---------------------");

      return sb.ToString();
    }

    /// <summary>
    /// Dos productos son iguales si comparten el mismo código de barras
    /// </summary>
    /// <param name="v1"></param>
    /// <param name="v2"></param>
    /// <returns></returns>
    public static bool operator ==(Producto v1, Producto v2)
    {
      return (v1.codigoDeBarras == v2.codigoDeBarras);
    }
    /// <summary>
    /// Dos productos son distintos si su código de barras es distinto
    /// </summary>
    /// <param name="v1"></param>
    /// <param name="v2"></param>
    /// <returns></returns>
    public static bool operator !=(Producto v1, Producto v2)
    {
      return !(v1.codigoDeBarras == v2.codigoDeBarras);
    }
  }
}
