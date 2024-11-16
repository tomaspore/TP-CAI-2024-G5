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
using TemplateTPIntegrador.Forms.Productos;
using TemplateTPIntegrador.Forms.Ventas;

namespace TemplateTPIntegrador
{
    public partial class FrmMenuAdmin : Form
    {

        public FrmMenuAdmin()
        {
            InitializeComponent();
           
        }

        private void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario menuregistrousuario = new FrmRegistroUsuario();

            menuregistrousuario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin logindatos = new FrmLogin();
            
            FrmCambioContraseña cambiarpassword = new FrmCambioContraseña();

            cambiarpassword.Show();
            this.Hide();


        }

        private void btnRegistroUsuario__Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario menuregistrousuario = new FrmRegistroUsuario();

            menuregistrousuario.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmLogin logindatos = new FrmLogin();

            FrmCambioContraseña cambiarpassword = new FrmCambioContraseña();

            cambiarpassword.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfirmacionCerrarSesion confirmacion = new FrmConfirmacionCerrarSesion();
            if (confirmacion.ShowDialog() == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Close(); // Cierra el formulario actual (por ejemplo, FrmMenuAdmin o FrmMenuSupervisor)
            }


        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto altaproducto = new FrmAgregarProducto();

            altaproducto.Show();
            this.Hide();

        }

        private void btnModificacionUsuario_Click(object sender, EventArgs e)
        {
            FrmReactivarUsuario modificarUsuarioForm = new FrmReactivarUsuario();
            modificarUsuarioForm.Show();
            this.Hide();
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            FrmBajaUsuario frmBajaUsuario = new FrmBajaUsuario();
            frmBajaUsuario.Show();
            this.Hide();
        }

        private void btnRegistroUsuari0_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario frmRegistroUsuario = new FrmRegistroUsuario();
            frmRegistroUsuario.Show();
            this.Hide();
        }

        private void btnModificacionUsuari0_Click(object sender, EventArgs e)
        {
            FrmReactivarUsuario frmModificarUsuario = new FrmReactivarUsuario();
            frmModificarUsuario.Show();
            this.Hide();
        }

        private void btnAltaProduct0_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto altaproducto = new FrmAgregarProducto();

            altaproducto.Show();
            this.Hide();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            FrmConfirmacionCerrarSesion confirmacion = new FrmConfirmacionCerrarSesion();
            if (confirmacion.ShowDialog() == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Close(); // Cierra el formulario actual (por ejemplo, FrmMenuAdmin o FrmMenuSupervisor)
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            // Lógica para modificar la contraseña
        }

        private void groupBox22_Enter(object sender, EventArgs e)
        {
            // Lógica adicional para manejar cuando el usuario entra en el `groupBox2`, si es necesaria
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReporteStockCritico_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FrmStockCritico
            FrmStockCritico frmStockCritico = new FrmStockCritico();

            // Mostrar el formulario de Stock Crítico
            frmStockCritico.Show();

            // Cerrar el formulario actual
            this.Close();
        }

        private void btnModificacionProductos_Click(object sender, EventArgs e)
        {
            FrmModificarProducto modificarProducto = new FrmModificarProducto();

            modificarProducto.Show();
            this.Hide();
        }

        private void btnBajaProductos_Click(object sender, EventArgs e)
        {
            // Crear y mostrar el formulario de baja de productos
            FrmBajaProducto frmBajaProducto = new FrmBajaProducto();
            frmBajaProducto.Show();

            // Cerrar el formulario actual (Menú Principal)
            this.Close();
        }

        private void btnReporteVentasXVendedor_Click(object sender, EventArgs e)
        {
            FrmListadoVentas listadoVentasForm = new FrmListadoVentas();
            listadoVentasForm.Show();
        }
    }
}
