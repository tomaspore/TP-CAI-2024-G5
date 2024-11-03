using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;
using Negocio.Utils;

namespace TemplateTPIntegrador.Forms
{
    public partial class FrmClientes : Form
{
    private readonly TraerClientes _traerClientes;
    private readonly BorrarCliente _borrarCliente;

    public FrmClientes(TraerClientes traerClientes, BorrarCliente borrarCliente)
    {
        InitializeComponent();

        _traerClientes = traerClientes ?? throw new ArgumentNullException(nameof(traerClientes));
        _borrarCliente = borrarCliente ?? throw new ArgumentNullException(nameof(borrarCliente));

        CargarClientes();
    }

    private async void CargarClientes()
    {
        try
        {
            var clientes = await _traerClientes.ObtenerClientesAsync();
            lstListaClientes.DataSource = clientes;
            lstListaClientes.DisplayMember = "Nombre"; // Ajusta según la propiedad que quieras mostrar
            lstListaClientes.ValueMember = "Id"; // Valor único para identificar al cliente
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocurrió un error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnBajaCliente_Click(object sender, EventArgs e)
    {
        if (lstListaClientes.SelectedItem is ClientesWS clienteSeleccionado)
        {
            try
            {
                bool respuesta = _borrarCliente.BajaClienteNegocio(clienteSeleccionado.Id.ToString());

                if (!respuesta)
                {
                    MessageBox.Show("El cliente no se ha podido dar de baja. Contacte con el Administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El cliente fue exitosamente dado de baja", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes(); // Refresca la lista después de eliminar el cliente
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al dar de baja al cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("No se seleccionó ningún cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    }
}
