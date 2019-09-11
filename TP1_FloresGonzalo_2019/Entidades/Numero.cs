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

        public Numero()
        {
            numero = 0;
        }

        public Numero(double num) : this()
        {
            numero = num;
        }

        public Numero(string num)
        {
            SetNumero(num);
        }

        #endregion

        #region Propiedades

        public void SetNumero(string num)
        {
            this.numero = this.ValidarNumero(num);
        }

        #endregion

        #region Metodos

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
            if (numero > 0)
            {
                while (division >= 2)
                {
                    resto = division % 2;
                    division = division / 2;

                    auxString = resto.ToString();
                    resultado = auxString + resultado;
                }
                resultado = "1" + resultado;
            }
            else
            {
                resultado = "0";
            }
            return resultado;
        }

        #endregion

        #region Sobre carga de Operadores

        public static double operator +(Numero n1, Numero n2)
        {
            double resp;
            resp = n1.numero + n2.numero;
            return resp;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double resp;
            if (n2.numero != 0)
                resp = n1.numero / n2.numero;
            else
                resp = double.MinValue;
            return resp;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            double resp;
            resp = n1.numero - n2.numero;
            return resp;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            double resp;
            resp = n1.numero * n2.numero;
            return resp;
        }

        #endregion

        

    }
}
