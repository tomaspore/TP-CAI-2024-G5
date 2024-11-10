using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace TemplateTPIntegrador.Forms
{
    public partial class FrmRegistroUsuario : Form
    {
        private static int UserId = 1; // Inicializa el Id una sola vez

        public FrmRegistroUsuario()
        {
            InitializeComponent();
            LlenarcmbHost(); // Para poner los posibles valores a elegir en cmbHost
            MostrarIDUsuarioActual();
        }

        private void MostrarIDUsuarioActual()
        {
            txtIdUsuario.Text = UserId.ToString(); // Muestra el Id actual
            txtIdUsuario.ReadOnly = true; // Hace que no se pueda editar el campo manualmente
        }

        private void LlenarcmbHost()
        {
            // Se llena el comboBox Host con sus diferentes opciones
            cmbHost.Items.Add("Administrador (3)");
            cmbHost.Items.Add("Supervisor (2)");
            cmbHost.Items.Add("Vendedor (1)");
        }

        private async void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioService usuarioService = new UsuarioService();

                bool registrado = await usuarioService.RegistrarUsuario(
                    Guid.NewGuid(),
                    txtNombre.Text,
                    txtApellido.Text,
                    int.Parse(txtDNI.Text),
                    txtUsuario.Text,
                    cmbHost.SelectedIndex + 1,
                    txtDireccion.Text,
                    txtTelefono.Text,
                    txtEmail.Text,
                    dtpFechaNacimiento.Value,
                    dtpFechaAlta.Value,
                    txtContraseña.Text
                );

                if (registrado)
                {
                    MessageBox.Show("Usuario registrado exitosamente en el sistema.");
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario. Intente nuevamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //VOLVER AL MENU INICIAL
            this.Close();  // Cierra el formulario actual (Registrar Usuario)
            FrmMenuAdmin menu = new FrmMenuAdmin(); // Crea una instancia del menú administrador
            menu.Show();  // Muestra el formulario del menú administrador
        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {
            //ID USUARIO
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //fecha nacimiento
        }

        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDNI_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
