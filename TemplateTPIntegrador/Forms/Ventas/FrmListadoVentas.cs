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
            CargarVentasFicticias(); 
        }

        private void CargarVentasFicticias()
        {
            List<Venta> ventas = ventasWS.ObtenerVentasFicticias();

            if (ventas != null && ventas.Count > 0)
            {
                dgvVentas.DataSource = ventas; 
            }
            else
            {
                MessageBox.Show("No se encontraron ventas ficticias.");
            }
        }


        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dvgVentas
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
