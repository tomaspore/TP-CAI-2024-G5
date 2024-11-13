namespace TemplateTPIntegrador.Forms
{
    partial class FrmModificarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTeléfono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDomicilioCliente = new System.Windows.Forms.TextBox();
            this.txtTeléfonoCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.btnModificarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(97, 22);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(96, 20);
            this.txtNombreCliente.TabIndex = 0;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(31, 24);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(42, 13);
            this.lblNombreCliente.TabIndex = 1;
            this.lblNombreCliente.Text = "Cliente:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(27, 55);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Domicilio:";
            // 
            // lblTeléfono
            // 
            this.lblTeléfono.AutoSize = true;
            this.lblTeléfono.Location = new System.Drawing.Point(28, 84);
            this.lblTeléfono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeléfono.Name = "lblTeléfono";
            this.lblTeléfono.Size = new System.Drawing.Size(52, 13);
            this.lblTeléfono.TabIndex = 3;
            this.lblTeléfono.Text = "Teléfono:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(33, 112);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDomicilioCliente
            // 
            this.txtDomicilioCliente.Location = new System.Drawing.Point(97, 55);
            this.txtDomicilioCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDomicilioCliente.Name = "txtDomicilioCliente";
            this.txtDomicilioCliente.Size = new System.Drawing.Size(96, 20);
            this.txtDomicilioCliente.TabIndex = 5;
            // 
            // txtTeléfonoCliente
            // 
            this.txtTeléfonoCliente.Location = new System.Drawing.Point(97, 84);
            this.txtTeléfonoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTeléfonoCliente.Name = "txtTeléfonoCliente";
            this.txtTeléfonoCliente.Size = new System.Drawing.Size(96, 20);
            this.txtTeléfonoCliente.TabIndex = 6;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(97, 112);
            this.txtEmailCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(96, 20);
            this.txtEmailCliente.TabIndex = 7;
            // 
            // btnModificarDatos
            // 
            this.btnModificarDatos.Location = new System.Drawing.Point(70, 150);
            this.btnModificarDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarDatos.Name = "btnModificarDatos";
            this.btnModificarDatos.Size = new System.Drawing.Size(95, 22);
            this.btnModificarDatos.TabIndex = 8;
            this.btnModificarDatos.Text = "Modificar";
            this.btnModificarDatos.UseVisualStyleBackColor = true;
            this.btnModificarDatos.Click += new System.EventHandler(this.btnModificarDatos_Click);
            // 
            // FrmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 187);
            this.Controls.Add(this.btnModificarDatos);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.txtTeléfonoCliente);
            this.Controls.Add(this.txtDomicilioCliente);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTeléfono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTeléfono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDomicilioCliente;
        private System.Windows.Forms.TextBox txtTeléfonoCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Button btnModificarDatos;
    }
}