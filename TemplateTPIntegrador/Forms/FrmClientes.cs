using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Negocio.Utils;

namespace TemplateTPIntegrador.Forms
{
    public partial class FrmClientes : Form
    {
        private readonly TraerClientes _traerclientes;
        public FrmClientes()
        {
            InitializeComponent();

            _traerclientes = new TraerClientes();
            CargarClientes();
        }

        private async void CargarClientes()
        {
            try
            {
                var clientes = await _traerclientes.ObtenerClientesAsync();
                lstListaClientes.DataSource = clientes;
                lstListaClientes.DisplayMember = "Nombre"; // Ajusta según la propiedad que quieras mostrar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnReactivarCliente_Click(object sender, EventArgs e)
        {

        }

        private async void btnBajaCliente_Click(object sender, EventArgs e)
        {
            string clienteSeleccionado = lstListaClientes.SelectedItem.ToString();

            var clientes = await _traerclientes.ObtenerClientesAsync();

            var clienteEncontrado = clientes.Find(c => c.Nombre == clienteSeleccionado).Id;

            



        }
    }
}
