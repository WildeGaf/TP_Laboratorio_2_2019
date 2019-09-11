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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOperar_Click(object sender, EventArgs e)
        {
            //Numero num1 = new Numero num1(textBox1.Text);
        }

        private void Limpiar()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            this.comboBox1.SelectedIndex = 0;
            this.lblResultado.Text = string.Empty;
            this.lblResp.Text = string.Empty;
        }

        private double Operar(string num1, string num2,string operador)
        {

        }

        public LaCalculadora()
        {

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
