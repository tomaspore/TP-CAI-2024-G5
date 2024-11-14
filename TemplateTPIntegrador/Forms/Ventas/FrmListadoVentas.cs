using Datos;
using Persistencia.Venta;
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
    public partial class FrmListadoVentas : Form
    {
        private ObtenerVentasWS ventasWS;

        public FrmListadoVentas()
        {
            InitializeComponent();
            ventasWS = new ObtenerVentasWS();
        }

        private void CargarVentasPorCliente(Guid idCliente)
        {
            List<Venta> ventas = ventasWS.ObtenerVentasPorCliente(idCliente);

            if (ventas != null && ventas.Count > 0)
            {
                dgvVentas.DataSource = ventas; // Asigna la lista de ventas al DataGridView
            }
            else
            {
                MessageBox.Show("No se encontraron ventas para el cliente especificado o hubo un error al cargar las ventas.");
            }
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dvgVentas
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Guid.TryParse(txtIdCliente.Text, out Guid idCliente))
            {
                CargarVentasPorCliente(idCliente);
            }
            else
            {
                MessageBox.Show("Ingrese un ID de cliente válido.");
            }
        }
    }
}
