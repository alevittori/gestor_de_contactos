using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContacto.Models.Exception
{
    internal class DniInvalidoException:ApplicationException
    {
        public DniInvalidoException() { }
        public DniInvalidoException(string message):base(message) { }
        public DniInvalidoException(string? message, System.Exception? innerException) : base(message, innerException)
        {
        }
    }
}
