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
        public FrmNuevoCliente()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCliente.Text;
            string apellido = txtApellidoCliente.Text;
            DateTime fechanacimiento = dtpFechaNacimiento.Value;
            string email = txtEmailCliente.Text;



        }
    }
}
