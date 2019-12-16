using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2019
{
    public class Snacks : Producto
    {
        #region Constructores

        /// <summary>
        /// Constructor de la clase Snacks
        /// </summary>
        /// <param name="marca"> Se le asigna marca, llamando al constructor padre </param>
        /// <param name="CodigoDeBarras">Se le asigna el codigo, llamando al constructor padre</param>
        /// <param name="color">Se le asigna color, llamando al constructor padre</param>
        /// 
        public Snacks(EMarca marca, string codigo, ConsoleColor color)
            : base(marca, codigo, color)
        {
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Retorna 104 correspondiente a las calorías de los Snacks
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Retorna toda la informacion del objeto Snacks
        /// </summary>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("CALORIAS : "+ this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
