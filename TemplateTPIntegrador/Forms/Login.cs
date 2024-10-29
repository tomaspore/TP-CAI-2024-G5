﻿using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private int intentos; //Temporalmente la variable intentos va a estar acá

        private void button1_Click(object sender, EventArgs e)
        {
            ValidacionesUtils validacionUntil = new ValidacionesUtils();
            string usuario = "";
            string contraseña = "";

            usuario = txtUsuario.Text;
            contraseña = txtContraseña.Text;

            if (validacionUntil.ValidarVacio(usuario, contraseña))
            {
                MessageBox.Show("Debe ingresar un usuario y/o contraseña.");
                intentos++;
            }

            else
            {
                intentos = 0;
            }


            if (intentos == 3)
            {
                MessageBox.Show("El usuario " + usuario + " pasa a estado INACTIVO. El programa se cerrara.");
                intentos = 0;
                this.Close();
            }
            else if (intentos == 0)
            {
                MessageBox.Show("Bienvenido! " + usuario); //Acá en un futuro voy a poner el nombre de la persona y no el user

                FrmMenuAdmin menuadmin = new FrmMenuAdmin();
                //Se debería abrir el menu correspondiente al id usuario

                menuadmin.Show();
                this.Hide(); // una vez que se efectua el Login, cierre el formulario de Login.
            }

            //Usuarios inactivos guardar en memoria FileInfo



            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
