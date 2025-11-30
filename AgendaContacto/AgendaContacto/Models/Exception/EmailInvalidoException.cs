using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContacto.Models.Exception
{
    internal class EmailInvalidoException:ApplicationException
    {
        public EmailInvalidoException() { }

        public EmailInvalidoException(string message) : base(message) { }
        public EmailInvalidoException(string message, System.Exception innerException):base(message, innerException) { }
    }
}
