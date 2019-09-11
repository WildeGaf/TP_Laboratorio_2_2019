using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public double Operar(Numero num1, Numero num2, string operador)
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

        private static string ValidarOperador(string operador)
        {
            if (!(operador == "+" && operador == "-" && operador == "/" && operador == "*"))
                return "+";
            else
            {
                return operador;
            }
        }
    }
}

