using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace TemplateTPIntegrador.Forms
{
    public partial class FrmRegistroUsuario : Form
    {
        private static int UserId; // metodo necesario para poder autoincrementar el Id por cada registro

        public FrmRegistroUsuario()
        {
            InitializeComponent();
            LlenarcmbHost(); // para poner los posibles valores a elegir en cmbHost
            AutoincrementarIDUsuario();
        }

        private void AutoincrementarIDUsuario()
        {
            UserId++;
            txtIdUsuario.Text = UserId.ToString();
            txtIdUsuario.ReadOnly = true; // se logra que no se edite de forma manual el Id de usuario.

        }

        private void LlenarcmbHost()
        {
            // Se llena el comboBox Host con sus diferentes opciones:
            cmbHost.Items.Add("Administrador (3)");
            cmbHost.Items.Add("Supervisor (2)");
            cmbHost.Items.Add("Vendedor (1)");
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
            host = cmbHost.SelectedItem?.ToString();


            // Llamamos a Validaciones de negocio
            ValidacionesNegocio validacionesRegistro = new ValidacionesNegocio();
            
            // Creamos un campo tipo string para ver si devuelve error las validaciones de negocio
            string error;

            if(!validacionesRegistro.ValidarNombreRegistroUsuario(usuario, nombre, apellido, out error))
            {
                MessageBox.Show(error);
                return; // con el return nos aseguramos que si devuelve false, nos siga pidiendo que ingresemos correctamente lo que pide hasta que la validacion se cumpla correctamente.
            }



            ValidacionesUtils validacionUntilRegistro = new ValidacionesUtils();
            
            if(validacionUntilRegistro.ValidarVacioRegistroUsuario(nombre, apellido, direccion, telefono, email, usuario, dni, contraseña, host))
            {
                MessageBox.Show("Le esta faltando ingresar datos.");
            }
            else
            {
                // Usuario registrado con exito
                MessageBox.Show("Usuario se ha registrado con exito.");

                // Volver al formulario de FrmMenuAdmin
                FrmMenuAdmin menuadmin = new FrmMenuAdmin();

                // Abrir el menu FrmMenuAdmin
                menuadmin.Show();

                // Cerrar el formulario de registro de usuario.
                this.Hide();
            }

            

            

        }
    }
}
