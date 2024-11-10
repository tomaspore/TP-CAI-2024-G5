using Datos;
using Negocio;
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
    public partial class FrmReactivarUsuario : Form
    {
        public FrmReactivarUsuario()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            UsuarioService _usuarioservice = new UsuarioService();
            string id = textBox9.Text;

            if (!string.IsNullOrEmpty(id))
            {
                bool response = _usuarioservice.ReactivarUsuario(id);

                if (!response)
                {
                    MessageBox.Show("Error. No se ha podido reactivar el usuario, verifique el ID.");
                }
                else
                {
                    MessageBox.Show("Usuario reactivado exitosamente.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();  // Cierra el formulario actual (Registrar Usuario)
            FrmMenuAdmin menu = new FrmMenuAdmin(); // Crea una instancia del menú administrador
            menu.Show();  // Muestra el formulario del menú administrador

        }

        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}