using Datos;
using Persistencia.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador.Forms.Productos
{
    public partial class FrmBajaProducto : Form
    {
        private ObtenerProductosWS productosWS;
       

        public FrmBajaProducto()
        {
            InitializeComponent();
            productosWS = new ObtenerProductosWS(); // Inicializa la instancia de ObtenerProductosWS
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            FrmConfirmarAcción confirmar = new FrmConfirmarAcción();
            if (confirmar.ShowDialog() == DialogResult.OK)
            {
                OperacionBajaProducto();
            }
        }

        // Método para realizar la baja del producto
        private void OperacionBajaProducto()
        {
            string idProducto = txtIdProducto.Text.Trim();

            // Verifica que se haya ingresado un ID de producto
            if (string.IsNullOrEmpty(idProducto))
            {
                lblResultado.Text = "Por favor, ingrese el ID del producto.";
                return;
            }

           

            // Intentar dar de baja el producto
            try
            {
                bool resultado = productosWS.EliminarProducto(idProducto);
                if (resultado)
                {
                    lblResultado.Text = "Producto dado de baja exitosamente.";
                }
                else
                {
                    lblResultado.Text = "Error al dar de baja el producto. Verifique el ID.";
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = $"Error al dar de baja: {ex.Message}";
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //VOLVER AL MENU
            this.Close(); // Cierra el formulario actual

            if (ConfiguracionUsuario.PerfilUsuario == "Administrador")
            {
                FrmMenuAdmin menuAdmin = new FrmMenuAdmin();
                menuAdmin.Show();
            }
            else if (ConfiguracionUsuario.PerfilUsuario == "Supervisor")
            {
                FrmMenuSupervisor menuSupervisor = new FrmMenuSupervisor();
                menuSupervisor.Show();
            }
            else if (ConfiguracionUsuario.PerfilUsuario == "Vendedor")
            {
                FrmMenuVendedor menuVendedor = new FrmMenuVendedor();
                menuVendedor.Show();
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            //lblresultado
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
