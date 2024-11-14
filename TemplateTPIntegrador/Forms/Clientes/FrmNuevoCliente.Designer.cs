namespace TemplateTPIntegrador.Forms
{
    partial class FrmNuevoCliente
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
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.lblFechaNacimientoCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDomicilioCliente = new System.Windows.Forms.TextBox();
            this.txtTeléfonoCliente = new System.Windows.Forms.TextBox();
            this.lblDomicilioCliente = new System.Windows.Forms.Label();
            this.lblTeléfonoCliente = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(134, 23);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(105, 20);
            this.txtNombreCliente.TabIndex = 0;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(82, 23);
            this.txtEmailCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(109, 20);
            this.txtEmailCliente.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDNICliente);
            this.groupBox1.Controls.Add(this.txtDNICliente);
            this.groupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox1.Controls.Add(this.txtApellidoCliente);
            this.groupBox1.Controls.Add(this.lblFechaNacimientoCliente);
            this.groupBox1.Controls.Add(this.lblApellidoCliente);
            this.groupBox1.Controls.Add(this.lblNombreCliente);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(271, 152);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Básicos";
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Location = new System.Drawing.Point(12, 122);
            this.lblDNICliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(65, 13);
            this.lblDNICliente.TabIndex = 7;
            this.lblDNICliente.Text = "Documento:";
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(134, 120);
            this.txtDNICliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(105, 20);
            this.txtDNICliente.TabIndex = 6;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(134, 88);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(105, 20);
            this.dtpFechaNacimiento.TabIndex = 5;
            this.dtpFechaNacimiento.Value = new System.DateTime(2024, 11, 3, 15, 41, 14, 0);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(134, 54);
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(105, 20);
            this.txtApellidoCliente.TabIndex = 4;
            // 
            // lblFechaNacimientoCliente
            // 
            this.lblFechaNacimientoCliente.AutoSize = true;
            this.lblFechaNacimientoCliente.Location = new System.Drawing.Point(12, 90);
            this.lblFechaNacimientoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNacimientoCliente.Name = "lblFechaNacimientoCliente";
            this.lblFechaNacimientoCliente.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimientoCliente.TabIndex = 3;
            this.lblFechaNacimientoCliente.Text = "Fecha de Nacimiento:";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Location = new System.Drawing.Point(12, 58);
            this.lblApellidoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoCliente.TabIndex = 2;
            this.lblApellidoCliente.Text = "Apellido:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(12, 26);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(47, 13);
            this.lblNombreCliente.TabIndex = 1;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDomicilioCliente);
            this.groupBox2.Controls.Add(this.txtTeléfonoCliente);
            this.groupBox2.Controls.Add(this.lblDomicilioCliente);
            this.groupBox2.Controls.Add(this.lblTeléfonoCliente);
            this.groupBox2.Controls.Add(this.lblEmailCliente);
            this.groupBox2.Controls.Add(this.txtEmailCliente);
            this.groupBox2.Location = new System.Drawing.Point(296, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(238, 120);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Contacto";
            // 
            // txtDomicilioCliente
            // 
            this.txtDomicilioCliente.Location = new System.Drawing.Point(82, 88);
            this.txtDomicilioCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDomicilioCliente.Name = "txtDomicilioCliente";
            this.txtDomicilioCliente.Size = new System.Drawing.Size(109, 20);
            this.txtDomicilioCliente.TabIndex = 6;
            // 
            // txtTeléfonoCliente
            // 
            this.txtTeléfonoCliente.Location = new System.Drawing.Point(82, 56);
            this.txtTeléfonoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTeléfonoCliente.Name = "txtTeléfonoCliente";
            this.txtTeléfonoCliente.Size = new System.Drawing.Size(109, 20);
            this.txtTeléfonoCliente.TabIndex = 5;
            // 
            // lblDomicilioCliente
            // 
            this.lblDomicilioCliente.AutoSize = true;
            this.lblDomicilioCliente.Location = new System.Drawing.Point(11, 91);
            this.lblDomicilioCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDomicilioCliente.Name = "lblDomicilioCliente";
            this.lblDomicilioCliente.Size = new System.Drawing.Size(52, 13);
            this.lblDomicilioCliente.TabIndex = 2;
            this.lblDomicilioCliente.Text = "Domicilio:";
            // 
            // lblTeléfonoCliente
            // 
            this.lblTeléfonoCliente.AutoSize = true;
            this.lblTeléfonoCliente.Location = new System.Drawing.Point(11, 58);
            this.lblTeléfonoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeléfonoCliente.Name = "lblTeléfonoCliente";
            this.lblTeléfonoCliente.Size = new System.Drawing.Size(52, 13);
            this.lblTeléfonoCliente.TabIndex = 1;
            this.lblTeléfonoCliente.Text = "Teléfono:";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(11, 25);
            this.lblEmailCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCliente.TabIndex = 0;
            this.lblEmailCliente.Text = "Email:";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(236, 179);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(99, 25);
            this.btnAgregarCliente.TabIndex = 10;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // FrmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 212);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmNuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDomicilioCliente;
        private System.Windows.Forms.Label lblTeléfonoCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Label lblFechaNacimientoCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtDomicilioCliente;
        private System.Windows.Forms.TextBox txtTeléfonoCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.TextBox txtDNICliente;
    }
}