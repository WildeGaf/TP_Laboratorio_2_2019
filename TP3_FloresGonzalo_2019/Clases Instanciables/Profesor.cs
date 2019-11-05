﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> claseDelDia;
        private static Random random;

        private Profesor()
        {

        }

        static Profesor()
        {
            random = new Random();
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            claseDelDia = new Queue<Universidad.EClases>();
            _randomClases();

        }


        private void _randomClases()
        {
            int randNum;
            for (int i = 0; i < 2; i++)
            {
                randNum = random.Next(0, 3);
                this.claseDelDia.Enqueue((Universidad.EClases)randNum);
            }
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.Append(this.ParticiparEnClase());
            return sb.ToString();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Clases del dia" + claseDelDia.ToArray());
            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos();
        }

        public static bool operator == (Profesor i, Universidad.EClases clase)
        {
            foreach(Universidad.EClases clas in i.claseDelDia)
            {
                if (clas == clase)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

    }
}
