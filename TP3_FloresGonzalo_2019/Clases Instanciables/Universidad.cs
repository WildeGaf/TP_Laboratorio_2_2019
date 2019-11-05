using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }


        public List<Alumno> Alumnos
        {
            get { return alumnos; }
            set { alumnos = value; }
        }

        public List<Jornada> Jornadas
        {
            get { return jornada; }
            set { jornada = value; }
        }

        public List<Profesor> Instructores
        {
            get { return profesores; }
            set { profesores = value; }
        }

        public Jornada this[int i]
        {
            get { return this.Jornadas[i]; }
            set { this.Jornadas[i] = value; }
        }

        public Universidad()
        {
            Alumnos = new List<Alumno>();
            Instructores = new List<Profesor>();
            Jornadas = new List<Jornada>();
        }


        private string MostrarDatos(Universidad uni) { }

        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno aux in g.Alumnos)
            {
                if (aux == a)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor aux in g.Instructores)
            {
                if (aux == i)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            int i = 0;
            foreach (Profesor profe in u.Instructores)
            {
                if (profe == clase)
                {
                    break;
                }
                i++;
            }
            return u.Instructores[i];
        }
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            int i = 0;
            foreach (Profesor profe in u.Instructores)
            {
                if (profe != clase)
                {
                    break;
                }
                i++;
            }
            return u.Instructores[i];
        }
        public static bool operator +(Universidad g, Alumno a)
        {
            foreach (Alumno aux in g.Alumnos)
            {
                if (aux == a)
                {
                    return false;
                }
            }
            g.Alumnos.Add(a);
            return true;
        }
        public static bool operator +(Universidad g, Profesor i)
        {
            foreach (Profesor aux in g.Instructores)
            {
                if (aux == i)
                {
                    return false;
                }
            }
            g.Instructores.Add(i);
            return true;
        }

        public static bool operator +(Universidad u, EClases clase)
        {
            bool resp = false;
            Profesor profe = (u == clase);
            Jornada jor = new Jornada(clase, profe);
            foreach (Alumno aux in u.Alumnos)
            {
                if (aux == clase)
                {
                    jor.Alumnos.Add(aux);
                    resp = true;
                }
            }
            return resp;
        }


        public bool Guardar(Universidad uni)
        {


        }

        public Universidad Leer() { }

    }
}
