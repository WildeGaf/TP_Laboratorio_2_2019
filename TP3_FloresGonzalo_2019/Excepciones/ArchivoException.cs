using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class ArchivoException : Exception
    {
        public ArchivoException(Exception innerException) : base(string.Empty,innerException)
        {

        }
    }
}
