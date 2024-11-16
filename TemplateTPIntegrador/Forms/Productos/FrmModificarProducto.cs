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
    public partial class FrmModificarProducto : Form
    {
        public FrmModificarProducto()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            FrmConfirmarAcción confirmar = new FrmConfirmarAcción();

            if(confirmar.ShowDialog() == DialogResult.OK)
            {
                OperaciónModificarProducto();
            }
        }

        private void OperaciónModificarProducto()
        {
        }
    }
}
