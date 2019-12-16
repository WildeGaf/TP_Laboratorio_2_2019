using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
   public abstract class Universitario : Persona
  {
        private int legajo;


        public Universitario()
        {

        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: "+ this.Nombre);
            sb.AppendLine("Apellido: "+ this.Apellido);
            sb.AppendLine("Nacionalidad: "+ this.Nacionalidad);
            sb.AppendLine("DNI: "+ this.Dni);
            sb.AppendLine("Legajo: "+ this.legajo);
            return sb.ToString();


        }

        public static bool Equals(object obj)
        {
            if (obj is Universitario)
            {
                return true;
            }
            return false;
        }
        protected abstract string ParticiparEnClase();

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if (( Equals(pg1) == Equals(pg2)) && (pg1.Dni == pg2.Dni || pg1.legajo == pg2.legajo))
            {
                throw new AlumnoRepetidoException();
            }
            return false;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        

    }
}
