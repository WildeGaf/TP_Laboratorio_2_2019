using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class NacionalidadInvalidException : Exception
    {
        public NacionalidadInvalidException() : this(string.Empty)
        { }

        public NacionalidadInvalidException(string message) : base(message)
        { }
    }
}
