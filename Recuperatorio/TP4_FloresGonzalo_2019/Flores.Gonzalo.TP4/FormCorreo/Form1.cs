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

namespace FormCorreo
{
    public partial class Form1 : Form
    {
        private Entidades.Correo correo;
        public Form1()
        {
            InitializeComponent();
            correo = new Entidades.Correo();
        }
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)ListEntregado.SelectedItem);
        }

        /// <summary>
        /// actualiza los listbox mostrando los paquetes q contiene cada uno
        /// </summary>
        private void ActualizarEstados()
        {
            ListEntregado.Items.Clear();
            ListEnViaje.Items.Clear();
            ListIngresado.Items.Clear();
            foreach (Paquete paquete in correo.Paquetes)
            {
                switch (paquete.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        ListIngresado.Items.Add(paquete);
                        break;
                    case Paquete.EEstado.EnViaje:
                        ListEnViaje.Items.Add(paquete);
                        break;
                    case Paquete.EEstado.Entregado:
                        ListEntregado.Items.Add(paquete);
                        break;
                }

            }
        }
        /// <summary>
        /// muestra la informacion de todos los paquetes y los guarda en un archivo
        /// muestra un mensaje si no puede guardarse
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (elemento != null)
            {
                RtbResult.Text = elemento.MostrarDatos(elemento);
                try
                {
                    RtbResult.Text.Guardar("salida.txt");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error al guardar en archivo");
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(this.paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                ActualizarEstados();
            }
        }
        /// <summary>
        /// el cerrar el formulario cierra todos los hilos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPal_FormClosing(object sender, FormClosingEventArgs e)
        {
            correo.finEntregas();
        }

        /// <summary>
        /// agrega un nuevo paquete a la instancia correo 
        /// muestra un msj si no pudo agregarse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Paquete p = new Paquete(txtDireccion.Text, MskTracking.Text);
            try
            {
                correo += p;
                p.InformaEstado += new Paquete.DelegadoEstado(paq_InformaEstado);
            }
            catch (TrackingIdRepetidoException exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        /// <summary>
        /// muestra todos los paquetes generados en el rich del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Gonzalo.Flores.2D";
            this.cmsListas.Visible = true;
        }

        private void mostrarToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)ListEntregado.SelectedItem);
        }

    }
}
