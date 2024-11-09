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
using Negocio.Ventas;

namespace TemplateTPIntegrador.Forms
{
    public partial class FrmConfirmarAcción : Form
    {
        public FrmConfirmarAcción()
        {
            InitializeComponent();
        }

        private void FrmConfirmarVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            //AgregarVentaNegocio AgregarN = new AgregarVentaNegocio();

            //string ingresoCliente = txt

            //bool response = AgregarN.AgregarVenta(cliente, usuario, producto, cantidad);


            //FrmRegistrarVenta RegistroVenta = new FrmRegistrarVenta();
            //RegistroVenta.

        }
    }
}
