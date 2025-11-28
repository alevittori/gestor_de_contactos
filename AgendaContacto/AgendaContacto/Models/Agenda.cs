using AgendaContacto.Models.Exception;
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

        public Contacto AgregarContacto(string nom, string ape, string dni, string mail, string tel)
        {
            var nuevo = new Contacto(nom, ape, tel, mail, dni);

            if (BuscarContacto(nuevo) != null)
                throw new ContactoDuplicadoException("Ya existe un contacto con ese DNI");

            contactos.Add(nuevo);
            return nuevo;
        }
        public void AgregarContacto(Contacto persona)
        {
            if (persona == null) { return; }

            // SI DNI REPEDIDO RETORNO
            if (BuscarContacto(persona) != null)
                throw new ContactoDuplicadoException("Ya existe un contacto con ese DNI");

            //Si todo ok agrego persona
            contactos.Add(persona);
        }
        public bool QuitarContacto(Contacto persona)
        {
            Contacto buscado = BuscarContacto(persona);
            if(buscado == null) { return false; }

            return contactos.Remove(buscado);
        }

        public Contacto ModificarContacto(Contacto persona)
        {
            Contacto existente = BuscarContacto(persona);
            if (existente == null) throw new ContactoNoEncontradoException("No se encontró el contacto");

            existente.Nombre = persona.Nombre;
            existente.Apellido = persona.Apellido;
            existente.Telefono = persona.Telefono;
            existente.Mail = persona.Mail;
            // DNI no debería cambiar

            return existente;

        }

        public Contacto BuscarContacto(Contacto persona)
        {
            Contacto buscado = contactos.Find(c => c.Dni == persona.Dni);
           // if (buscado == null) throw new ContactoNoEncontradoException("No existe un contacto con ese DNI");
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

        public void LimpiarTextBox(Control contenedor)
        {
            foreach (Control ctrl in contenedor.Controls)
            {
                if (ctrl is TextBox tb)
                    tb.Clear();
                else
                    LimpiarTextBox(ctrl); // sigue buscando en sub-contenedores
            }
        }

        public List<Contacto> FiltrarContactos(string texto)
        {
            return contactos
                .Where(c => c.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                            c.Apellido.Contains(texto, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<Contacto> ObtenerContactos()
        {
            return contactos;
        }

    }
}
