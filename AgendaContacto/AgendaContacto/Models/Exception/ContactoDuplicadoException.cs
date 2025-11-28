using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContacto.Models.Exception
{
    internal class ContactoDuplicadoException:ApplicationException
    {
        public ContactoDuplicadoException() { }
        public ContactoDuplicadoException(string message) : base(message) { }
        public ContactoDuplicadoException(string? message, System.Exception? innerException) : base(message, innerException)
        {
        }
    }
}
