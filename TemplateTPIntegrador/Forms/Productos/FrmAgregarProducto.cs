using Negocio.Utils;
using Persistencia;
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
    public partial class FrmAgregarProducto : Form
    {
        private readonly TraerProveedor _traerProveedor;

        public FrmAgregarProducto()
        {
            InitializeComponent();
            _traerProveedor = new TraerProveedor();

            cmbCategoria.Items.Add("Audio");

            cmbCategoria.Items.Add("Celulares");

            cmbCategoria.Items.Add("Electro Hogar");

            cmbCategoria.Items.Add("Informática");

            cmbCategoria.Items.Add("Smart TV");

            // Mover la llamada al método CargarProveedores aquí
            CargarProveedores(); // Llama al método para cargar proveedores al iniciar el formulario
        }

        private async void CargarProveedores()
        {
            try
            {
                var proveedores = await _traerProveedor.ObtenerProveedoresAsync();
                lstProveedores.DataSource = proveedores;
                lstProveedores.DisplayMember = "Nombre"; // Ajusta según la propiedad que quieras mostrar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Acá voy a tener que agregar la lista de proveedores
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            FrmConfirmarAcción confirmar = new FrmConfirmarAcción();

            if (confirmar.ShowDialog() == DialogResult.OK)
            {
                OperaciónAgregarProducto();
            }
        }

        private void lstProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OperaciónAgregarProducto()
        {
            string nombre = txtNombreProducto.Text;
            string proveedor = lstProveedores.SelectedItem?.ToString();
            string categoria = cmbCategoria.SelectedItem?.ToString();
            string preciovalidador = txtPrecio.Text;
            string stockvalidador = txtStock.Text;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombre) ||/* string.IsNullOrWhiteSpace(proveedor) ||*/
                string.IsNullOrWhiteSpace(categoria) || string.IsNullOrWhiteSpace(preciovalidador) ||
                string.IsNullOrWhiteSpace(stockvalidador))
            {
                MessageBox.Show("Todos los campos deben estar completos.");
                return;
            }

            // Validar y convertir los valores de precio y stock
            if (!double.TryParse(preciovalidador, out double precio))
            {
                MessageBox.Show("El precio debe ser un valor numérico.");
                return;
            }

            if (!int.TryParse(stockvalidador, out int stock))
            {
                MessageBox.Show("El stock debe ser un valor numérico.");
                return;
            }

            int idcategoria;
            //idcategoria

            if (categoria == "Audio")
            {
                idcategoria = 1;
            }
            else if (categoria == "Celulares")
            {
                idcategoria = 2;
            }
            else if (categoria == "Electro Hogar")
            {
                idcategoria = 3;
            }
            else if (categoria == "Informática")
            {
                idcategoria = 4;
            }
            else idcategoria = 5;


            // Obtener el idProveedor seleccionado del ListBox
            if (lstProveedores.SelectedItem is Proveedor proveedorSeleccionado)
            {
                string idProveedor = proveedorSeleccionado.Id; // Ajusta según la propiedad de tu clase Proveedor
                string idUsuario = "1653c7ec-870d-468a-b581-9800961d53d2";

                // Instanciar o inyectar el servicio de negocio
                ProductosNegocio productoService = new ProductosNegocio();

                // Llamar al servicio de negocio para agregar el producto
                string resultado = productoService.AgregarProductoConValidaciones(idcategoria, idUsuario, idProveedor, nombre, precio, stock);

                // Verificar el resultado
                if (resultado == "Error")
                {
                    MessageBox.Show("Ocurrió un error al agregar el producto.");
                }
                else
                {
                    MessageBox.Show("Producto agregado exitosamente.");
                    txtNombreProducto.Clear();
                    lstProveedores.SelectedIndex = -1;
                    cmbCategoria.SelectedIndex = -1;
                    txtPrecio.Clear();
                    txtStock.Clear();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un proveedor.");
            }



        }

        private void button1_Click(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
