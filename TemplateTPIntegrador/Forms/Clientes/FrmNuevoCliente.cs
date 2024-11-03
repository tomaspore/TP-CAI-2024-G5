using Datos;
using Negocio.Clientes;
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
    public partial class FrmNuevoCliente : Form
    {
        private readonly AgregarClienteWS _clientesService;

        public FrmNuevoCliente()
        {
            InitializeComponent();
            _clientesService = new AgregarClienteWS();
        }

        private async void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCliente.Text;
            string apellido = txtApellidoCliente.Text;
            DateTime fechanacimiento = dtpFechaNacimiento.Value;
            string email = txtEmailCliente.Text;
            string dnivalidador = txtDNICliente.Text;
            string telefono = txtTeléfonoCliente.Text;
            string domicilio = txtDomicilioCliente.Text;

            if(
                !string.IsNullOrEmpty(nombre) && 
                !string.IsNullOrEmpty(apellido) && 
                fechanacimiento <= DateTime.Today &&
                !string.IsNullOrEmpty(email) && 
                !string.IsNullOrEmpty(dnivalidador) && 
                !string.IsNullOrEmpty(telefono) && 
                !string.IsNullOrEmpty(email))
            {
                if(!int.TryParse(dnivalidador, out int dni ))
                {
                    MessageBox.Show("Debe ingresar un valor númerico en Documento");
                }
                else
                {
                    AgregarClienteWS nuevocliente = new AgregarClienteWS();

                    int response = nuevocliente.AgregarCliente(nombre,apellido,fechanacimiento,dni,telefono,email,domicilio);
                    if (response == 3)
                    {
                        MessageBox.Show("Cliente agregado correctamente.");
                        this.Close();
                    }
                    else if(response == 1)
                    {
                        MessageBox.Show("Error al agregar el cliente.\nVerifique los datos cargados.");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el cliente. Contacte con el Adminisrador");
                    }
                }
            }
            else
            {

                MessageBox.Show("No debe haber campos vacios. \nLa Fecha de Nacimiento no puede ser en el futuro");
            }
            




            
        }
    }
}
