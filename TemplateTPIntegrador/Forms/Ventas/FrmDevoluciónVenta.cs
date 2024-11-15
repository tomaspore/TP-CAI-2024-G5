using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Ventas;

namespace TemplateTPIntegrador.Forms
{
    public partial class FrmDevoluciónVenta : Form
    {
        public FrmDevoluciónVenta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //VOLVER AL MENU
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
            else if (ConfiguracionUsuario.PerfilUsuario == "Vendedor")
            {
                FrmMenuVendedor menuVendedor = new FrmMenuVendedor();
                menuVendedor.Show();
            }
        }

        private void btnDevolverVenta_Click(object sender, EventArgs e)
        {
            FrmConfirmarAcción confirmar = new FrmConfirmarAcción();

            if (confirmar.ShowDialog() == DialogResult.OK)
            {
                DevolverVentaNegocio devolver = new DevolverVentaNegocio();

                string idventa = txtIDVenta.Text;

                bool response = devolver.DevolverVenta(idventa);

                if (!response)
                {
                    MessageBox.Show("Ha ocurrido un error. Verifique el ID.");
                }
                else
                {
                    MessageBox.Show("La devolución se realizo con éxito.");
                }
            }
            
               

        }
    }
}
