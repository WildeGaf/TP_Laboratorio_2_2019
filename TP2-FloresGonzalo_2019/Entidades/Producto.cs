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
        #region Enumerador
        public enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }
        #endregion

        #region Atributos
        private EMarca marca;
        private string codigoDeBarras;
        private ConsoleColor colorPrimarioEmpaque;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de la clase Producto
        /// </summary>
        /// <param name="marca"> Se le asigna marca</param>
        /// <param name="Codigo">Se le asigna el codigo</param>
        /// <param name="color">Se le asigna color</param>
        public Producto(EMarca marca, string codigo, ConsoleColor color)
        {
            this.marca = marca;
            this.codigoDeBarras = codigo;
            this.colorPrimarioEmpaque = color;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// ReadOnly: Retornará la cantidad de calorias del Producto
        /// </summary>
        /// 
        protected abstract short CantidadCalorias { get; }

        #endregion

        #region Metodos

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns>Retorna un string con la informacion</returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.marca.ToString());
            sb.AppendLine(this.codigoDeBarras);
            sb.AppendLine(this.colorPrimarioEmpaque.ToString());
            return sb.ToString();
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Sobrecarga el operador String, para mostrar la informacion del objeto
        /// </summary>
        /// <param name="p"> Producto a Mostrar</param>
        /// <returns>Retorna un string con la informacion</returns>

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
        /// <param name="v1">Primer objeto a comparar</param>
        /// <param name="v2">Segundo objeto a comparar</param>
        /// <returns>Retorna un bool, true para "="</returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            return (v1.codigoDeBarras == v2.codigoDeBarras);
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1">Primer objeto a comparar</param>
        /// <param name="v2">Segundo objeto a comparar</param>
        /// <returns>Retorna un bool, true para "!="</returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return !(v1 == v2);
        }

        #endregion
    }
}

