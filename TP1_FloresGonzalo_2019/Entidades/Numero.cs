using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {

        #region Atributos

        private double numero;

        #endregion

        #region Constructores

        /// <summary>
        /// Contructor de la clase, inicializa en 0.
        /// </summary>
        public Numero() : this(0)
        {
        }

        /// <summary>
        /// Contructor de la clase, inicializa por parametro double.
        /// </summary>
        /// <param name="num">numero a asignar </param>
        public Numero(double num) : this(num.ToString())
        {
        }

        /// <summary>
        /// Contructor de la clase, inicializa por parametro string.
        /// </summary>
        /// <param name="num">numero a asignar</param>
        public Numero(string num)
        {
            SetNumero = num;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Asigna el valor al atributo
        /// </summary>
        /// <param name="numeroAux">Numero a asignar</param>
        public string SetNumero
        {
            set { this.numero = ValidarNumero(value); }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Contructor de la clase, inicializa por parametro string.
        /// </summary>
        /// <param name="num">numero a asignar</param>
        private double ValidarNumero(string strNum)
        {
            double resp;
            if (double.TryParse(strNum, out resp) == true)
            {
                return resp;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Convierte un numero binario en decimal.
        /// </summary>
        /// <param name="binarioAux">Numero que se desea convertir</param>
        /// <returns>Retorna el numero en decimal</returns>
        public static string BinarioDecimal(string binarioAux)
        {
            int binario, cantidad, i, exponente = 0;
            string resultado;
            double suma = 0;
            cantidad = binarioAux.Length;
            int.TryParse(binarioAux, out binario);
            for (i = cantidad - 1; i >= 0; i--)
            {

                if (binarioAux[i] == '1')
                {
                    suma += Math.Pow(2, exponente);
                }
                exponente++;
            }
            resultado = suma.ToString();
            return resultado;
        }

        /// <summary>
        /// Convierte un numero decimal en binario.
        /// </summary>
        /// <param name="numero">Numero que se desea convertir</param>
        /// <returns>Retorna el numero en binario</returns>
        public static string DecimalBinario(double numero)
        {
            double resto;
            string auxString, resultado = "";
            int division = (int)numero;
                while (division >= 2)
                {
                    resto = division % 2;
                    division = division / 2;

                    auxString = resto.ToString();
                    resultado = auxString + resultado;
                }
                resultado = "1" + resultado;
            return resultado;
        }

        /// <summary>
        /// Convierte un numero decimal en binario.
        /// </summary>
        /// <param name="numeroAux">Numero que se desea convertir</param>
        /// <returns>Retorna el numero en binario</returns>
        public static string DecimalBinario(string numeroAux)
        {
            double numero;
            string resultado = "Valor invalido";
            if (double.TryParse(numeroAux, out numero)&& (numero > 0))
            {
                resultado = DecimalBinario(numero);
            }
            return resultado;
        }

        #endregion

        #region Sobre carga de Operadores

        /// <summary>
        /// Sobrecarga el operador "+" (atributo numero)
        /// </summary>
        /// <param name="numeroUno">Primer objeto a sumar</param>
        /// <param name="numeroDos">Segundo objeto a sumar</param>
        /// <returns>Retorna la suma entre dos objetos</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            double resp;
            resp = n1.numero + n2.numero;
            return resp;
        }

        /// <summary>
        /// Sobrecarga el operador "/" (atributo numero)
        /// </summary>
        /// <param name="numeroUno">Primer objeto a dividir</param>
        /// <param name="numeroDos">Segundo objeto, como divisor</param>
        /// <returns>Retorna la division los objetos, o double.MinValue si no es valido </returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double resp;
            if (n2.numero != 0)
                resp = n1.numero / n2.numero;
            else
                resp = double.MinValue;
            return resp;
        }

        /// <summary>
        /// Sobrecarga el operador "-" (atributo numero)
        /// </summary> 
        /// <param name="numeroUno">Primer objeto a restar</param>
        /// <param name="numeroDos">Segundo objeto a restar</param>
        /// <returns></returns>
        public static double operator -(Numero n1, Numero n2)
        {
            double resp;
            resp = n1.numero - n2.numero;
            return resp;
        }

        /// <summary>
        /// Sobrecarga el operador "*" (atributo numero)
        /// </summary>
        /// <param name="numeroUno">Primer objeto a multiplicar</param>
        /// <param name="numeroDos">Segundo objeto a multiplicar</param>
        /// <returns>Retorna el resultado de la multiplicacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            double resp;
            resp = n1.numero * n2.numero;
            return resp;
        }

        #endregion

    }
}
