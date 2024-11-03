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


            if (lstListaClientes.SelectedItem != null)
            {
                string clienteSeleccionado = lstListaClientes.SelectedItem.ToString();
                // Continua con la lógica, como la búsqueda del cliente

                var clientes = await _traerclientes.ObtenerClientesAsync();

                //string clienteEncontrado = clientes.Find(c => c.Nombre == clienteSeleccionado).Id;

                BorrarCliente borrar = new BorrarCliente();

                bool respuesta = borrar.BajaClienteNegocio("ff7d3565-1eef-48df-bfb4-0e25c4524623");

                if (!respuesta)
                {
                    MessageBox.Show("El cliente no se ha podido dar de baja. Contacte con el Administrador. ");
                }
                else
                {
                    MessageBox.Show("El cliente fue exitosamente dado de baja");
                }
            }
            else
            {
                MessageBox.Show("No se seleccionó ningún cliente.");
            }
            

           


        }
    }
}
