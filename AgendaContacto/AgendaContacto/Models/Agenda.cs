using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContacto.Models
{
    internal class Agenda
    {
        List<Contacto> contactos;

        public Agenda() {
            contactos = new List<Contacto>();

        }

        public void AgregarContacto()
        {

        }
        public bool QuitarContacto(Contacto persona)
        {
            Contacto buscado = BuscarContacto(persona);
            return contactos.Remove(buscado);
        }

        public Contacto BuscarContacto(Contacto persona)
        {
            Contacto buscado = contactos.Find(contacto => contacto.Dni == persona.Dni);
            if (buscado == null) { return null; }
            return buscado;
        }
        public void ListarContactos(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach(Contacto c in contactos)
            {
                listBox.Items.Add(c);
            }
        }
    }
}
