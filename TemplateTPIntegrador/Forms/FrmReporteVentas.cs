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
    public partial class FrmReporteVentas : Form
    {
        public FrmReporteVentas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //VOLVER AL MENU DEL VENDEDOR
            this.Close();  // Cierra el formulario actual (Registrar Usuario)
            FrmMenuVendedor menu = new FrmMenuVendedor(); // Crea una instancia del menú Vendedor
            menu.Show();  // Muestra el formulario del menú Vendedor
        }
    }
}
