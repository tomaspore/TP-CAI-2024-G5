using Negocio.Utils;
using Negocio;
using Persistencia.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateTPIntegrador.Forms.Productos;

namespace TemplateTPIntegrador.Forms
{
    public partial class FrmMenuSupervisor : Form
    {
        public FrmMenuSupervisor()
        {
            InitializeComponent();
        }

        private void btnBajaProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarContraseña_Click(object sender, EventArgs e)
        {
            FrmLogin logindatos = new FrmLogin();

            FrmCambioContraseña cambiarpassword = new FrmCambioContraseña();

            cambiarpassword.Show();
            this.Hide();
        }

        private void btnModificacionProductos_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ALTA PRODUCTOS
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmConfirmacionCerrarSesion confirmacion = new FrmConfirmacionCerrarSesion();
            if (confirmacion.ShowDialog() == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Close(); // Cierra el formulario actual (por ejemplo, FrmMenuAdmin o FrmMenuSupervisor)
            }

        }

        private void btnDevolucionVenta_Click(object sender, EventArgs e)
        {
            FrmDevoluciónVenta devolucionmenu = new FrmDevoluciónVenta();

            devolucionmenu.Show();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto altaproducto = new FrmAgregarProducto();

            altaproducto.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBajaProductos_Click_1(object sender, EventArgs e)
        {
            // Crear y mostrar el formulario de baja de productos
            FrmBajaProducto frmBajaProducto = new FrmBajaProducto();
            frmBajaProducto.Show();

            // Cerrar el formulario actual (Menú Principal)
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void greet_user_Click(object sender, EventArgs e)
        {

        }

        private void btnControlClientes_Click(object sender, EventArgs e)
        {
            // Crea instancias de las clases de Negocio
            TraerClientes traerClientes = new TraerClientes(new ClientesData());
            BorrarCliente borrarCliente = new BorrarCliente(new DeleteCliente());

            // Pasa estas instancias al constructor de FrmClientes
            FrmControlClientes clientes = new FrmControlClientes(traerClientes, borrarCliente);

            clientes.Show();

            this.Hide();
        }

        private void btnModificacionProductos_Click_1(object sender, EventArgs e)
        {
            FrmModificarProducto modificar = new FrmModificarProducto();

            modificar.Show();
            this.Close();
        }
    }
}
