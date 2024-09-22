using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador.Forms
{
    public partial class FrmRegistroUsuario : Form
    {
        public FrmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = "";
            string apellido = "";
            string direccion = "";
            string telefono = "";
            string email = "";
            string usuario = "";
            string dni = "";
            string contraseña = "";
            string host = "";

            // Se toman los valores que se van ingresando en el formulario de registro en los TextBox
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            direccion = txtDireccion.Text;
            telefono = txtTelefono.Text;
            email = txtEmail.Text;
            usuario = txtUsuario.Text;
            dni = txtDNI.Text;
            contraseña = txtContraseña.Text;

            // Se toma el valor que se ingresa en el comboBox
            // host = cmbHost.SelectedItem.ToString();

            // Usuario registrado con exito
            MessageBox.Show("Usuario se ha registrado con exito.");

        }
    }
}
