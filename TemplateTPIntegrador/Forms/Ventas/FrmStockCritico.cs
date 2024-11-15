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

        private void FrmStockCritico_Load(object sender, EventArgs e)
        {
            //load
            // Llama al método que obtiene los productos
            List<ProductoWS> productos = productosWS.ObtenerProductosOrdenadosPorStock();

            // Verificar si hay productos con stock crítico (stock == 0)
            bool tieneStockCritico = productos.Any(p => p.Stock == 0);

            // Si hay productos con stock crítico, mostrar el MessageBox y el mensaje en el Label
            if (tieneStockCritico)
            {
                MessageBox.Show("¡Atención! Hay productos con stock crítico. Favor de revisar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblAdvertencia.Text = "¡Atención! Hay productos con stock crítico. Favor de revisar.";
                lblAdvertencia.Visible = true;
            }
            else
            {
                lblAdvertencia.Visible = false; // Oculta el label si no hay productos con stock crítico
            }

            // Configuración del DataGridView
            dgvStockCritico.AutoGenerateColumns = false;
            dgvStockCritico.Columns.Clear();

            // Añadir columnas manualmente
            dgvStockCritico.Columns.Add("Nombre", "Nombre");
            dgvStockCritico.Columns["Nombre"].DataPropertyName = "Nombre";

            dgvStockCritico.Columns.Add("Categoria", "Categoría");
            dgvStockCritico.Columns["Categoria"].DataPropertyName = "IdCategoria";

            dgvStockCritico.Columns.Add("Precio", "Precio");
            dgvStockCritico.Columns["Precio"].DataPropertyName = "Precio";

            dgvStockCritico.Columns.Add("Stock", "Stock");
            dgvStockCritico.Columns["Stock"].DataPropertyName = "Stock";

            // Asigna el DataSource después de configurar las columnas
            dgvStockCritico.DataSource = productos;
        }
    }
}
