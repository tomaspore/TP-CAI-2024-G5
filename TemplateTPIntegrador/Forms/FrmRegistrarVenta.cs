using Datos;
using Negocio.Ventas;
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
            AgregarVentaNegocio AgregarN = new AgregarVentaNegocio();

            string ingresoCliente = txtDNICliente.Text;
            string productos = "e038c3d9-7ae4-4447-9646-000e16877537";  /*lstProductos.SelectedItem.ToString();*/
            string cantidadAComprar = txtCantidadAComprar.Text; // va a haber que transformarlo a numero mediante un validador
            string idUsuario = "25e430a1-2da0-4f63-a98e-9c2f29bedbab";

            int cantidad = Convert.ToInt32(cantidadAComprar);

            bool response = AgregarN.AgregarVenta(ingresoCliente, idUsuario, productos, cantidad);

            if (!response)
            {
                MessageBox.Show("Ha ocurrido un error con la carga");
            }
            else
            {
                MessageBox.Show("Datos cargados exitosamente");
            }
            

            //FrmConfirmarVenta confirmar = new FrmConfirmarVenta();
            //confirmar.Show();            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //VOLVER AL MENU DEL VENDEDOR
            this.Close();  // Cierra el formulario actual (Registrar Usuario)
            FrmMenuVendedor menu = new FrmMenuVendedor(); // Crea una instancia del menú Vendedor
            menu.Show();  // Muestra el formulario del menú Vendedor

        }

        private void FrmRegistrarVenta_Load(object sender, EventArgs e)
        {
           
        }
    }

    internal class FrmregistrarDatosVenta
    {
    }
}
