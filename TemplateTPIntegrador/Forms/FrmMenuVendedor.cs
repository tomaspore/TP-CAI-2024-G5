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
    public partial class FrmMenuVendedor : Form
    {
        public FrmMenuVendedor()
        {
            InitializeComponent();
        }

        private void btnModificarContraseña_Click(object sender, EventArgs e)
        {
            FrmCambioContraseña cambiarpassword = new FrmCambioContraseña();
            cambiarpassword.Show();
            this.Hide(); // Esto ocultará el formulario actual
        }

        private void btnReporteVentasXVendedor_Click(object sender, EventArgs e)
        {
            FrmReporteVentas reporteVentas = new FrmReporteVentas();
            reporteVentas.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
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
            FrmConfirmacionCerrarSesion confirmacion = new FrmConfirmacionCerrarSesion();
            if (confirmacion.ShowDialog() == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Close(); // Cierra el formulario actual (por ejemplo, FrmMenuAdmin o FrmMenuSupervisor)
            }

        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {

            FrmRegistrarDatosVenta registrarDatosVenta = new FrmRegistrarDatosVenta();
            registrarDatosVenta.Show();
            this.Hide();

        }

        private void FrmMenuVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
