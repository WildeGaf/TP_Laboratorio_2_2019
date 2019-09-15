using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Valida, realiza una operacion y muestra el resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOperar_Click(object sender, EventArgs e)
        {
            double retorno;
            bool validacion;
            validacion = validar();
            if (validacion != true)
            {
                retorno = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
                lblResultado.Text = retorno.ToString();
                btnConvertirABinario.Enabled = true;
                btnConvertirADecimal.Enabled = false;
            }
            else
            {
                MessageBox.Show("No paso las validaciones, No se ingreso un numero, o se ingresaron letras");
                Limpiar();
            }

        }

        /// <summary>
        /// Borra los valores del form.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = string.Empty;
        }

        /// <summary>
        /// Ejecuta la operacion entre los valores ingresados.
        /// </summary>
        /// <param name="numeroUno">Primer numero a operar</param>
        /// <param name="numeroDos">Segundo numero a operar</param>
        /// <param name="Operador">Operacion que se desea realizar</param>
        /// <returns>Retorna el resultado</returns>
        private static double Operar(string num1, string num2, string operador)
        {
            double retorno;
            Numero numero1 = new Numero(num1);
            Numero numero2 = new Numero(num2);
            retorno = Calculadora.Operar(numero1, numero2, operador);
            return retorno;
        }

        /// <summary>
        /// Valida que los textbox sean numeros y no esten vacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool validar()
        {
            int auxVerificacion, auxVerificacionDos;
            return (this.txtNumero1.Text == string.Empty || this.txtNumero2.Text == string.Empty) ||
                (!int.TryParse(txtNumero1.Text, out auxVerificacion) || !int.TryParse(txtNumero2.Text, out auxVerificacionDos));
        }

        /// <summary>
        /// Limpia los campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        /// <summary>
        /// Carga items en el combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("*");
            cmbOperador.Items.Add("/");
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }


        /// <summary>
        /// Convierte un valor en binario y lo muestra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;

        }


        /// <summary>
        /// Convierte un valor en decimal y lo muestra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            int aux;
            if (int.TryParse(lblResultado.Text, out aux))
            {
                lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
                btnConvertirABinario.Enabled = true;
                btnConvertirADecimal.Enabled = false;
            }
        }


        /// <summary>
        /// Cierra el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
