using AgendaContacto.Models;
using MySql.Data.MySqlClient;

namespace AgendaContacto
{
    public partial class Form1 : Form
    {
        Agenda miAgenda;
        public Form1()
        {
            InitializeComponent();

            miAgenda = new Agenda();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //validar que los campos no esten vacios, lo debo hacer en el formulario? o en la clase agenda?

                // Validación de UI
                if (string.IsNullOrWhiteSpace(tbNombre.Text) || string.IsNullOrWhiteSpace(tbDni.Text))
                {
                    MessageBox.Show("Nombre y DNI son obligatorios");
                    return;
                }
                if (string.IsNullOrEmpty(tbMail.Text) || string.IsNullOrEmpty(tbTel.Text))
                {
                    MessageBox.Show("Mail y Telefono no pueden estar vacio");
                    return;
                }

                if (string.IsNullOrEmpty(tbApellido.Text))
                {
                    MessageBox.Show("Apellido es Obligatorio");
                    return;
                }

                // Lógica de negocio (Agenda valida duplicados y formatos)

                miAgenda.AgregarContacto(tbNombre.Text, tbApellido.Text, tbDni.Text, tbMail.Text, tbTel.Text);
                miAgenda.ListarContactos(lbxAgenda);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ocurrio un Error"); }
            finally
            {

                miAgenda.LimpiarTextBox(gbContacto);

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Contacto seleccionado = lbxAgenda.SelectedItem as Contacto;
            if (seleccionado == null)
            {
                MessageBox.Show("Debes seleccionar un contacto", "Seleccione un Contacto");
                return;
            }

            using (FormEditarContacto frm = new FormEditarContacto(seleccionado))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Actualizar contacto en la agenda
                    miAgenda.ModificarContacto(frm.ContactoEditado);
                    miAgenda.ListarContactos(lbxAgenda);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Contacto seleccionado = lbxAgenda.SelectedItem as Contacto;
            if (seleccionado == null)
            {
                MessageBox.Show("Debes seleccionar un contacto", "Seleccione un Contacto");
                return;
            }

            miAgenda.QuitarContacto(seleccionado);
            miAgenda.ListarContactos(lbxAgenda);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Contacto aBuscar = new Contacto();
            aBuscar.Dni = tbBuscar.Text;
            lbxAgenda.Items.Clear();
            lbxAgenda.Items.Add(miAgenda.BuscarContacto(aBuscar));

        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            lbxAgenda.Items.Clear();
            foreach (var contacto in miAgenda.FiltrarContactos(tbBuscar.Text))
            {
                lbxAgenda.Items.Add(contacto);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                miAgenda.GuardarAgenda();



            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }
    }
}
