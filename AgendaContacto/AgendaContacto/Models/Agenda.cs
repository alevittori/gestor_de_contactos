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

        static Contacto contactoActual;

        public Agenda() {
            contactos = new List<Contacto>();

        }

        public void AgregarContacto(Contacto persona)
        {
            if(persona == null) { return; }

            // SI DNI REPEDIDO RETORNO
            if(BuscarContacto(persona) != null) { return; } // aca va validacion por dni repetido

            //Si todo ok agrego persona
            contactos.Add(persona);
        }
        public bool QuitarContacto(Contacto persona)
        {
            Contacto buscado = BuscarContacto(persona);
            if(buscado == null) { return false; }

            return contactos.Remove(buscado);
        }

        public Contacto BuscarContacto(Contacto persona)
        {
            Contacto buscado = contactos.Find(contacto => contacto.Dni == persona.Dni);
            if (buscado == null) { return null; } //Lanzar excepcion ContactoNoEncontradoException
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
