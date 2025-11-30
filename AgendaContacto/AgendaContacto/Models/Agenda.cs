using AgendaContacto.Models.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AgendaContacto.Models
{
    internal class Agenda
    {
        List<Contacto> contactos;

        string connectionString = "Server=localhost;Database=agendadb;Uid=root;Pwd=1310Alevitt-;";


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

        public void GuardarAgenda()
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        foreach (var c in contactos)
                        {
                            // Validaciones básicas
                            if (string.IsNullOrWhiteSpace(c.Nombre) || string.IsNullOrWhiteSpace(c.Dni))
                                throw new ArgumentException("Nombre y DNI son obligatorios");

                            if (!long.TryParse(c.Dni, out _))
                                throw new DniInvalidoException("El DNI debe ser numérico");

                            if (string.IsNullOrWhiteSpace(c.Mail) || !c.Mail.Contains("@"))
                                throw new EmailInvalidoException("El email no tiene un formato válido");

                            // Validación de duplicado en la base
                            string checkQuery = "SELECT COUNT(*) FROM Contactos WHERE Dni = @Dni";
                            using (var checkCmd = new MySqlCommand(checkQuery, conn, transaction))
                            {
                                checkCmd.Parameters.AddWithValue("@Dni", c.Dni);
                                long count = (long)checkCmd.ExecuteScalar();

                                if (count > 0)
                                {
                                    // Podés elegir: lanzar excepción o simplemente saltar este contacto
                                    throw new ContactoDuplicadoException($"El contacto con DNI {c.Dni} ya existe en la base de datos");
                                }
                            }

                            // Insertar contacto
                            string insertQuery = @"INSERT INTO Contactos (Nombre, Apellido, Telefono, Mail, Dni) 
                                           VALUES (@Nombre, @Apellido, @Telefono, @Mail, @Dni)";
                            using (var insertCmd = new MySqlCommand(insertQuery, conn, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@Nombre", c.Nombre);
                                insertCmd.Parameters.AddWithValue("@Apellido", c.Apellido);
                                insertCmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                                insertCmd.Parameters.AddWithValue("@Mail", c.Mail);
                                insertCmd.Parameters.AddWithValue("@Dni", c.Dni);

                                insertCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit(); // confirma todos los inserts
                    }
                    catch
                    {
                        transaction.Rollback(); // si algo falla, no se guarda nada
                        throw;
                    }
                }
            }
        }
        public void GuardarContactoEnDB(Contacto c)
        {
            // Validación básica en C#: nombre y DNI no vacíos
            if (string.IsNullOrWhiteSpace(c.Nombre) || string.IsNullOrWhiteSpace(c.Dni))
                throw new ArgumentException("Nombre y DNI son obligatorios");

            // Validación de formato de DNI (aunque sea VARCHAR en la DB, lo tratamos como numérico)
            if (!long.TryParse(c.Dni, out _))
                throw new DniInvalidoException("El DNI debe ser numérico");

            // Validación de email simple
            if (string.IsNullOrWhiteSpace(c.Mail) || !c.Mail.Contains("@"))
                throw new EmailInvalidoException("El email no tiene un formato válido");

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Primero verificamos si ya existe el contacto por DNI
                string checkQuery = "SELECT COUNT(*) FROM Contactos WHERE Dni = @Dni";
                using (var checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Dni", c.Dni);
                    long count = (long)checkCmd.ExecuteScalar();

                    if (count > 0)
                        throw new ContactoDuplicadoException("Ya existe un contacto con ese DNI en la base de datos");
                }

                // Si no existe, lo insertamos
                string insertQuery = @"INSERT INTO Contactos (Nombre, Apellido, Telefono, Mail, Dni) 
                               VALUES (@Nombre, @Apellido, @Telefono, @Mail, @Dni)";
                using (var insertCmd = new MySqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@Nombre", c.Nombre);
                    insertCmd.Parameters.AddWithValue("@Apellido", c.Apellido);
                    insertCmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                    insertCmd.Parameters.AddWithValue("@Mail", c.Mail);
                    insertCmd.Parameters.AddWithValue("@Dni", c.Dni);

                    try
                    {
                        insertCmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex) when (ex.Number == 1062) // error de clave duplicada
                    {
                        throw new ContactoDuplicadoException("El DNI ya existe en la base de datos");
                    }
                }
            }
        }
    }
}
