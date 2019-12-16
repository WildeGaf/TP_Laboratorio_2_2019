using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;
using System.Xml;
using Archivos;

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


        private string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Jornadas: ");
            foreach (Jornada jornada in uni.Jornadas)
            {
                sb.AppendLine(jornada.ToString());
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos(this);
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
            foreach (Profesor profe in u.Instructores)
            {
                if (profe == clase)
                {
                    return profe;
                }
            }
            throw new SinProfesorException();
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
        public static Universidad operator +(Universidad g, Alumno a)
        {
            if (g != a)
            {
                g.Alumnos.Add(a);

            }
            return g;

        }
        public static Universidad operator +(Universidad g, Profesor i)
        {
                if (g != i)
                {
                    g.Instructores.Add(i);
                }
            return g;
        }

        public static Universidad operator +(Universidad u, EClases clase)
        {
            Jornada jornada = new Jornada(clase, u == clase);
            u.Jornadas.Add(jornada);
            foreach (Alumno alumnoAux in u.Alumnos)
            {
                if (alumnoAux == clase)
                {
                    jornada += alumnoAux;
                }
            }
            return u;
        }


        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            bool ret = false;
            string path = String.Format("{0}\\Universidad.xml", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            ret = xml.Guardar(path, uni);
            if (xml.Guardar(path, uni))
            {
                return true;
            }
            return false;
        }

        public Universidad Leer()
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            Universidad g = new Universidad();
            string path = String.Format("{0}\\Universidad.xml", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            xml.Leer(path, out g);
            return g;
        }
    }
}
