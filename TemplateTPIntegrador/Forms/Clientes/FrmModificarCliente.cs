using Datos;
using Negocio;
using Negocio.Utils;
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
    public partial class FrmModificarCliente : Form
    {
        private ClientesWS _cliente;
        private readonly ModificarCliente _clientesService;

        public FrmModificarCliente(ClientesWS cliente)
        {
            InitializeComponent();
            _cliente = cliente;
            _clientesService = new ModificarCliente();

            // Rellenar los campos con los datos del cliente seleccionado
            txtNombreCliente.Text = cliente.Nombre;
            txtDomicilioCliente.Text = cliente.Direccion;
            txtTeléfonoCliente.Text = cliente.Telefono;
            txtEmailCliente.Text = cliente.Email;
        }

        private async void btnModificarDatos_Click(object sender, EventArgs e)
        {
            FrmConfirmarAcción confirmar = new FrmConfirmarAcción();
            if (confirmar.ShowDialog() == DialogResult.OK)
            {
                _cliente.Direccion = txtDomicilioCliente.Text;
                _cliente.Telefono = txtTeléfonoCliente.Text;
                _cliente.Email = txtEmailCliente.Text;

                bool resultado = await _clientesService.ActualizarCliente(_cliente);

                if (resultado)
                {
                    MessageBox.Show("Datos actualizados correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al actualizar los datos.");
                }

                this.Close();
            }
        }
    }
}
