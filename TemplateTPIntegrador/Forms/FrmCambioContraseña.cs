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
    public partial class FrmCambioContraseña : Form
    {
        public string Usuario { get; set; }
        public FrmCambioContraseña(string usuario)
        {
            InitializeComponent();
            txtUsuario.Text = usuario;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCambioContraseña_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
