using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clases_Instanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        public List<Alumno> Alumnos
        {
            get { return alumnos; }
            set { alumnos = value; }
        }

        public Universidad.EClases Clase
        {
            get { return clase; }
            set { clase = value; }
        }

        public Profesor Instructor
        {
            get { return instructor; }
            set { instructor = value; }
        }

        private Jornada()
        {
            alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor)
        {
            this.Instructor = instructor;
            this.Clase = clase;
        }

        public string Leer()
        {
            StreamReader sr = new StreamReader("C:\\prueba.txt");
            return sr.ReadToEnd();
            sr.Close();
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Alumno alumnoAux in j.Alumnos)
            {
                if (alumnoAux == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j == a)
            {
                j.Alumnos.Add(a);
            }
            return j;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Clase :" + this.Clase);
            sb.AppendLine("Profesor :" + this.Instructor);
            sb.AppendLine("Alumnos :");
            foreach (Alumno a in this.Alumnos)
            {
                sb.AppendLine(a.Apellido);
                sb.AppendLine(a.Nombre);
                sb.AppendLine(a.Dni.ToString());
                sb.AppendLine(a.Nacionalidad.ToString());
            }
            return sb.ToString();
        }

        public bool Guardar(Jornada jornada)
        {
            StreamWriter sw = new StreamWriter("C:\\prueba.txt");
            sw.Write(this.ToString());
            sw.Close();
            return true;

        }

    }
}
