using AgendaContacto.Models;

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
                Agenda.contactoActual = new Contacto(tbNombre.Text, tbApellido.Text, tbTel.Text, tbMail.Text, tbDni.Text);

                miAgenda.AgregarContacto();
                lbxAgenda.Items.Add(Agenda.contactoActual);
            }
            catch (Exception ex){ MessageBox.Show(ex.Message, "Ocurrio un Error"); }
            finally
            {

                tbNombre.Clear();
                tbApellido.Clear();
                tbTel.Clear();
                tbMail.Clear();
                tbDni.Clear();

            }
        }
    }
}
