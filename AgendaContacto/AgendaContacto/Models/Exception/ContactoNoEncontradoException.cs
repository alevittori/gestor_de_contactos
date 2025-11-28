using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContacto.Models.Exception
{
    internal class ContactoNoEncontradoException:ApplicationException
    {
        public ContactoNoEncontradoException() : base() { }

        public ContactoNoEncontradoException(string? message) : base(message)
        {
        }

        public ContactoNoEncontradoException(string? message, System.Exception? innerException) : base(message, innerException)
        {
        }
    }
}
