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
    public partial class FrmBajaUsuario : Form
    {
        private Negocio.LoginNegocio loginNegocio;
        private bool usuarioBloqueado = false; // Para indicar si el usuario ya está bloqueado

        public FrmBajaUsuario()
        {
            InitializeComponent();
            loginNegocio = new Negocio.LoginNegocio();
        }

        // Evento Click para el botón Dar de Baja
        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim(); 

            // Verifica que se haya ingresado un nombre de usuario
            if (string.IsNullOrEmpty(usuario))
            {
                lblResultado.Text = "Por favor, ingrese un nombre de usuario.";
                return;
            }

            // Verificar si el usuario ya está bloqueado
            if (usuarioBloqueado || loginNegocio.estaBloqueado(usuario))
            {
                usuarioBloqueado = true;
                MessageBox.Show("El usuario ya está bloqueado. No se puede dar de baja nuevamente.");
                return;
            }

            // Intentar dar de baja al usuario
            try
            {
                loginNegocio.bloquearUsuario(usuario);
                lblResultado.Text = "Usuario dado de baja exitosamente.";
            }
            catch (Exception ex)
            {
              
                lblResultado.Text = $"Error al dar de baja: {ex.Message}";
            }
        }

        private void FrmBajaUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }
    }///FALTA VERIFICAR SI EL USUARIO EXISTE , Y NO MOSTRAR DADO DE BAJA EXITOSAMENTE
}

