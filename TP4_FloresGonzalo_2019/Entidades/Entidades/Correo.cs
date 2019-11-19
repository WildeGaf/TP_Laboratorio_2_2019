using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;
     
        public List<Paquete> Paquetes
        {
            get { return paquetes; }
            set { paquetes = value; }
        }

        public Correo() { }

        public void FinEntregas()
        {

        }

        public string MostrarDatos(Mostrar<List<Paquete>> elementos) { }

        public static Correo operator *(Correo c, Paquete p) { }

    }
}
