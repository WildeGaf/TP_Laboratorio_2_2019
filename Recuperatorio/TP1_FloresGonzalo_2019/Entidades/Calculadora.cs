using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {

        #region Metodos
        /// <summary>
        /// Hace una operacion entre el atributo numero de dos objetos
        /// </summary>
        /// <param name="num1">El primero objeto a operar </param>
        /// <param name="num2">El segundo objeto a operar </param>
        /// <param name="operador">La operacion que se quiere realizar</param>
        /// <returns>Retorna el resultado de la operacion </returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno;
            operador = ValidarOperador(operador);
            switch (operador)
            {
                case "-":
                    retorno = num1 - num2;
                    break;

                case "/":
                    retorno = num1 / num2;
                    break;

                case "*":
                    retorno = num1 * num2;
                    break;

                default:
                    retorno = num1 + num2;
                    break;
            }
            return retorno;
        }

        /// <summary>
        /// Valida que el operador sea valido.
        /// </summary>
        /// <param name="operador"> Recibe una operador como string </param>
        /// <returns>Retorna el operador ingresado, en caso de no ser valido retorna el operador suma </returns>
        private static string ValidarOperador(string operador)
        {
            if (!(operador == "+" || operador == "-" || operador == "/" || operador == "*"))
                return "+";
            else
            {
                return operador;
            }
        }
        #endregion

    }
}

