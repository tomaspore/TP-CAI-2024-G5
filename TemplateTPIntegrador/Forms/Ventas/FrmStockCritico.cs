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

namespace TemplateTPIntegrador.Forms.Ventas
{
    public partial class FrmStockCritico : Form
    {
        private ObtenerProductosWS productosWS;

        public FrmStockCritico()
        {
            InitializeComponent();
            productosWS = new ObtenerProductosWS();
            ConfigurarColumnas();
            CargarStockCritico();
        }

        private void ConfigurarColumnas()
        {
            dgvStockCritico.Columns.Add("Nombre", "Nombre");
            dgvStockCritico.Columns.Add("Categoria", "Categoría");
            dgvStockCritico.Columns.Add("Precio", "Precio");
            dgvStockCritico.Columns.Add("Stock", "Stock");
        }

        private void CargarStockCritico()
        {
            List<ProductoWS> productos = productosWS.ObtenerProductosOrdenadosPorStock();

            if (productos != null)
            {
                // Filtra productos con stock menor al umbral, en este caso 10 (puedes ajustar el valor según necesites)
                var productosBajoStock = productos.FindAll(p => p.Stock < 10);

                dgvStockCritico.Rows.Clear(); // Limpia cualquier fila existente

                foreach (var producto in productosBajoStock)
                {
                    dgvStockCritico.Rows.Add(producto.Nombre, producto.IdCategoria, producto.Precio, producto.Stock);
                }
            }
            else
            {
                MessageBox.Show("Error al cargar los productos.");
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
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
        }
    }
}
