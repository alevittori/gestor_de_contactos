using AgendaContacto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContacto
{
    public partial class FormEditarContacto : Form
    {
        public Contacto ContactoEditado { get; private set; } = null!;
        public FormEditarContacto(Contacto contacto)
        {
            InitializeComponent();
            // Cargar datos en los TextBox
            tbNombre.Text = contacto.Nombre;
            tbApellido.Text = contacto.Apellido;
            tbTel.Text = contacto.Telefono;
            tbMail.Text = contacto.Mail;
            tbDni.Text = contacto.Dni;

            tbDni.ReadOnly = true; // Bloquear edición del DNI
        }

        private void FormEditarContacto_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(tbNombre.Text) || string.IsNullOrWhiteSpace(tbApellido.Text))
            {
                MessageBox.Show("Nombre y Apellido son obligatorios");
                return;
            }

            // Crear contacto editado
            ContactoEditado = new Contacto(tbNombre.Text, tbApellido.Text, tbTel.Text, tbMail.Text, tbDni.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
