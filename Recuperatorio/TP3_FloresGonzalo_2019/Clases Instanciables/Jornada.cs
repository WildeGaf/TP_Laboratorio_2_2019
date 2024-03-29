﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Archivos;

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

        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.Instructor = instructor;
            this.Clase = clase;
        }

        public static string Leer()
        {
            Texto LeerText = new Texto();
            string datos = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Datos.txt";
            if (LeerText.Leer(datos,out string jornada))
            {
                return jornada;
            }
            return jornada;
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
            if (j != a)
            {
                j.Alumnos.Add(a);
            }
            return j;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Clase :" + this.Clase);
            sb.AppendLine("Profesor:\n" + this.Instructor);
            foreach (Alumno a in this.Alumnos)
            {
                sb.AppendLine(a.ToString());
            }
            return sb.ToString();
        }

        public static bool Guardar(Jornada jornada)
        {
            Texto texto = new Texto();
            string datos = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Datos.txt";
            if (texto.Guardar(datos, jornada.ToString())){
                return true;
            }
            return false;
        }

    }
}
