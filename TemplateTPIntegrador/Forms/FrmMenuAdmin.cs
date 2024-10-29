using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateTPIntegrador.Forms;

namespace TemplateTPIntegrador
{
    public partial class FrmMenuAdmin : Form
    {

        public FrmMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario menuregistrousuario = new FrmRegistroUsuario();

            menuregistrousuario.Show();
            this.Hide();
        }
    }
}
