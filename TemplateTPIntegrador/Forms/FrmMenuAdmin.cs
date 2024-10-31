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
    public partial class FrmMenuAdmin : Form
    {
        public FrmMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            FrmBajaUsuario frmBajaUsuario = new FrmBajaUsuario();
            frmBajaUsuario.Show();
        }

        private void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario frmRegistroUsuario = new FrmRegistroUsuario();
            frmRegistroUsuario.Show();
        }

        private void btnModificacionUsuario_Click(object sender, EventArgs e)
        {
            // Lógica para abrir el formulario de modificación de usuario
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            // Lógica para abrir el formulario de alta de productos
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmConfirmacionCerrarSesion confirmacion = new FrmConfirmacionCerrarSesion();
            if (confirmacion.ShowDialog() == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Close(); // Cierra el formulario actual (por ejemplo, FrmMenuAdmin o FrmMenuSupervisor)
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Lógica para modificar la contraseña
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // Lógica adicional para manejar cuando el usuario entra en el `groupBox2`, si es necesaria
        }
<<<<<<< Updated upstream
=======

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
>>>>>>> Stashed changes
    }
}
