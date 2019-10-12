using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2019
{
    public class Leche : Producto
    {
        #region Enumerador
        public enum ETipo { Entera, Descremada }
        ETipo tipo;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de la clase Leche, por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>

        public Leche(EMarca marca, string codigo, ConsoleColor color)
            : this(marca, codigo, color, ETipo.Entera) {}

        /// <summary>
        /// Constructor de la clase Leche
        /// </summary>
        /// <param name="marca"> Se le asigna marca, llamando al constructor padre </param>
        /// <param name="Codigo">Se le asigna el codigo, llamando al constructor padre</param>
        /// <param name="color">Se le asigna color, llamando al constructor padre</param>
        /// <param name="Leche">Se le asigna leche, recibido por parametro </param>
        public Leche(EMarca marca, string codigo, ConsoleColor color, ETipo leche) : base(marca, codigo, color)
        {
            tipo = leche;
        }

        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna 20 como cantidad de calorias de la clase Leche
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Retorna toda la informacion del objeto Leche
        /// </summary>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("CALORIAS : " + this.CantidadCalorias);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}