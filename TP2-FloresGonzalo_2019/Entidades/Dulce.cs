using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2019
{
    public class Dulce : Producto 
    {

        #region Constructor

        /// <summary>
        /// Constructor de la clase Dulce
        /// </summary>
        /// <param name="marca"> Se le asigna marca, llamando al constructor padre </param>
        /// <param name="CodigoDeBarras">Se le asigna el codigo, llamando al constructor padre</param>
        /// <param name="color">Se le asigna color, llamando al constructor padre</param>
        /// 
        public Dulce(EMarca marca, string codigoDeBarras, ConsoleColor color) : base(marca,codigoDeBarras,color)
        {
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Retorna 80 como cantidad de calorias del tipo Dulce
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Retorna toda la informacion del objeto Dulce
        /// </summary>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("CALORIAS : "+ this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
