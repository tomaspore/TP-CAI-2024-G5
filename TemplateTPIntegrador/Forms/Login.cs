using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateTPIntegrador.Forms;

namespace TemplateTPIntegrador
{
    public partial class FrmLogin : Form
    {
        private int intentos = 0; // Acá manejamos el número de intentos fallidos
        private bool usuarioBloqueado = false; // para bloquear al usuario

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuarioBloqueado)
            {
                MessageBox.Show("El usuario está bloqueado. Contacte con el Administrador.");
                return;
            }

            ValidacionesUtils validacionUntil = new ValidacionesUtils();
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (validacionUntil.ValidarVacio(usuario, contraseña))
            {
                MessageBox.Show("Debe ingresar usuario y/o contraseña.");
            }
            else
            {
                try
                {
                    // Crear instancia de la clase de negocio
                    LoginNegocio negocio = new LoginNegocio();
                    string perfil = negocio.login(usuario, contraseña);

                    if (perfil.StartsWith("Administrador"))
                    {
                        MessageBox.Show("Bienvenido! " + usuario);
                        FrmMenuAdmin admin = new FrmMenuAdmin();
                        admin.Show();
                        this.Hide();
                    }
                    else if (perfil.StartsWith("Supervisor"))
                    {
                        MessageBox.Show("Bienvenido! " + usuario);
                        FrmMenuSupervisor supervisor = new FrmMenuSupervisor();
                        supervisor.Show();
                    }
                    else if (perfil.StartsWith("Vendedor"))
                    {
                        MessageBox.Show("Bienvenido! " + usuario);
                        FrmMenuVendedor vendedor = new FrmMenuVendedor();
                        vendedor.Show();
                        this.Hide();
                    }
                    else if (perfil == "Error")
                    {
                        intentos++; // Aumentar el contador de intentos fallidos

                        if (intentos == 3)
                        {
                            usuarioBloqueado = true; // Marcar al usuario como bloqueado
                            MessageBox.Show("El usuario " + usuario + " pasa a estado INACTIVO.\nContacte con el Administrador.");
                        }
                        else
                        {
                            MessageBox.Show("Contraseña y/o usuario incorrecto. Vuelta a intentarlo.");
                        }
                    }
                    else if (perfil == "Cuenta bloqueada por intentos fallidos")
                    {
                        MessageBox.Show("El usuario " + usuario + " pasa a estado INACTIVO.\nContacte con el Administrador.");
                    }
                    else if (perfil == "Usuario no activo")
                    {
                        MessageBox.Show("El usuario está inactivo. Contacte con el administrador.");
                    }
                }
                catch (Exception ex)
                {
                    // Captura de cualquier excepción lanzada desde la capa de negocio
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Hola esto es una prueba
        }
    }
}
