using Datos;
using Negocio.Ventas;
using Persistencia.Productos;
using Persistencia.UsuariosData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TemplateTPIntegrador.Forms
{
    public partial class FrmRegistrarVenta : Form
    {
        public FrmRegistrarVenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConfirmarAcción confirmar = new FrmConfirmarAcción();

            if(confirmar.ShowDialog() == DialogResult.OK)
            {
                OperaciónVenta();
                txtCantidad.Clear();
                lstProductos.SelectedIndex = -1;
            }
            else
            {

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //VOLVER AL MENU DEL VENDEDOR
            this.Close();  // Cierra el formulario actual (Registrar Usuario)
            FrmMenuVendedor menu = new FrmMenuVendedor(); // Crea una instancia del menú Vendedor
            menu.Show();  // Muestra el formulario del menú Vendedor

        }

        private void OperaciónVenta()
        {
            AgregarVentaNegocio AgregarN = new AgregarVentaNegocio();

            // Obtener el DNI del cliente ingresado en el formulario
            string ingresoCliente = txtDNICliente.Text;
            int dniCliente;
            if (!int.TryParse(ingresoCliente, out dniCliente))
            {
                MessageBox.Show("Por favor ingrese un DNI válido.");
                return;
            }

            // Buscar el ID del cliente usando el DNI
            Guid idCliente = AgregarN.BuscarClientePorDNI(dniCliente);

            if (idCliente == Guid.Empty)
            {
                MessageBox.Show("Cliente no encontrado.");
                return;
            }

            // Obtener el producto seleccionado en el ListBox
            if (lstProductos.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un producto.");
                return;
            }

            ListItem productoSeleccionado = (ListItem)lstProductos.SelectedItem;
            string idProducto = productoSeleccionado.Value;

            // Obtener la cantidad del formulario
            string cantidadAComprar = txtCantidad.Text;
            string idUsuario = "25e430a1-2da0-4f63-a98e-9c2f29bedbab"; // Ejemplo de ID de usuario, puedes actualizarlo según sea necesario

            int cantidad;
            if (!int.TryParse(cantidadAComprar, out cantidad))
            {
                MessageBox.Show("Por favor ingrese una cantidad válida.");
                return;
            }

            // Agregar la venta utilizando el ID del cliente y el ID del producto
            bool response = AgregarN.AgregarVenta(idCliente.ToString(), idUsuario, idProducto, cantidad);

            // Mostrar mensaje de éxito o error
            if (!response)
            {
                MessageBox.Show("Ha ocurrido un error con la carga. Verifique los datos cargados.");
            }
            else
            {
                MessageBox.Show("Venta cargada exitosamente");
            }
        }


        private void FrmRegistrarVenta_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            ObtenerProductosWS obtenerProductos = new ObtenerProductosWS();
            List<ProductoWS> productos = obtenerProductos.buscarDatosProductos();

            if (productos != null)
            {
                foreach (var producto in productos)
                {
                    // Añadir el producto al ListBox, mostrando el nombre pero guardando el IDProducto
                    lstProductos.Items.Add(new ListItem(producto.Nombre, producto.Id.ToString()));
                }
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los productos.");
            }
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmMenuVendedor menu = new FrmMenuVendedor();

            menu.Show();
            this.Close();
        }
    }

    public class ListItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public ListItem(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }


    internal class FrmregistrarDatosVenta
    {
    }
}
