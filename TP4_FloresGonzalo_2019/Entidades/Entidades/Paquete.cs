using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    class Paquete
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public delegate void DelegadoEstado();
        public event DelegadoEstado InformaEstado;

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }

        public string DireccionEntrega
        {
            get { return direccionEntrega; }
            set { direccionEntrega = value; }
        }

        public EEstado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string TrackingID
        {
            get { return trackingID; }
            set { trackingID = value; }
        }


        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
        }

        public void MockCicloDeVida()
        {

        }

        public string MostrarDatos(Mostrar<Paquete> elemento) { }

        public static bool operator ==(Paquete p1, Paquete p2) { }

        public static bool operator !=(Paquete p1, Paquete p2) { }



        public override string ToString()
        {
            return MostrarDatos.(this).ToString();
        }

    }
}
