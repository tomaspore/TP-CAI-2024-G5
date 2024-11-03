using Datos;
using Negocio;
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
        public FrmModificarCliente(ClientesWS cliente)
        {
            InitializeComponent();
            _cliente = cliente;

            // Rellenar los campos con los datos del cliente seleccionado
            txtNombreCliente.Text = cliente.Nombre;
            txtDomicilioCliente.Text = cliente.Direccion;
            txtTeléfonoCliente.Text = cliente.Telefono;
            txtEmailCliente.Text = cliente.Email;
        }

        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            _cliente.Direccion = txtDomicilioCliente.Text;
            _cliente.Telefono = txtTeléfonoCliente.Text;
            _cliente.Email = txtEmailCliente.Text;

            this.Close();
        }
    }
}
