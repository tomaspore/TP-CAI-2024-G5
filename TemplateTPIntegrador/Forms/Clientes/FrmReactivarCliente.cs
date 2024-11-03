using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Clientes;

namespace TemplateTPIntegrador.Forms.Clientes
{
    public partial class FrmReactivarCliente : Form
    {
        public FrmReactivarCliente()
        {
            InitializeComponent();
        }

        private void btnReactivaciónCliente_Click(object sender, EventArgs e)
        {
            string id = txtidCliente.Text;
            
            if(!string.IsNullOrEmpty(id))
            {
                ReactivarCliente reactivacion = new ReactivarCliente();

                int response = reactivacion.ValidarReactivación(id);

                if(response == 2)
                {
                    MessageBox.Show("No se ha podido reactivar el ID. \nConsejos:\n-El ID ya se encuentra activo.\n-El ID no existe.");
                }
            }
            else
            {
                MessageBox.Show("Introduzca un ID.");
            }

            

        }

        private void FrmReactivarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
