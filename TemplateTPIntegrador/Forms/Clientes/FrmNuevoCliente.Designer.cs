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
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.lblFechaNacimientoCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
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
            this.txtNombreCliente.Location = new System.Drawing.Point(201, 35);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(155, 26);
            this.txtNombreCliente.TabIndex = 0;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(123, 35);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(161, 26);
            this.txtEmailCliente.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox1.Controls.Add(this.txtApellidoCliente);
            this.groupBox1.Controls.Add(this.lblFechaNacimientoCliente);
            this.groupBox1.Controls.Add(this.lblApellidoCliente);
            this.groupBox1.Controls.Add(this.lblNombreCliente);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 185);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Básicos";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(201, 136);
            this.dtpFechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(155, 26);
            this.dtpFechaNacimiento.TabIndex = 5;
            this.dtpFechaNacimiento.Value = new System.DateTime(2024, 11, 3, 15, 41, 14, 0);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(201, 83);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(155, 26);
            this.txtApellidoCliente.TabIndex = 4;
            // 
            // lblFechaNacimientoCliente
            // 
            this.lblFechaNacimientoCliente.AutoSize = true;
            this.lblFechaNacimientoCliente.Location = new System.Drawing.Point(18, 139);
            this.lblFechaNacimientoCliente.Name = "lblFechaNacimientoCliente";
            this.lblFechaNacimientoCliente.Size = new System.Drawing.Size(163, 20);
            this.lblFechaNacimientoCliente.TabIndex = 3;
            this.lblFechaNacimientoCliente.Text = "Fecha de Nacimiento:";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Location = new System.Drawing.Point(18, 89);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(69, 20);
            this.lblApellidoCliente.TabIndex = 2;
            this.lblApellidoCliente.Text = "Apellido:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(18, 37);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(69, 20);
            this.lblNombreCliente.TabIndex = 1;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.lblDomicilioCliente);
            this.groupBox2.Controls.Add(this.lblTeléfonoCliente);
            this.groupBox2.Controls.Add(this.lblEmailCliente);
            this.groupBox2.Controls.Add(this.txtEmailCliente);
            this.groupBox2.Location = new System.Drawing.Point(444, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 185);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Contacto";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(123, 136);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(161, 26);
            this.textBox10.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(123, 86);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(161, 26);
            this.textBox9.TabIndex = 5;
            // 
            // lblDomicilioCliente
            // 
            this.lblDomicilioCliente.AutoSize = true;
            this.lblDomicilioCliente.Location = new System.Drawing.Point(17, 140);
            this.lblDomicilioCliente.Name = "lblDomicilioCliente";
            this.lblDomicilioCliente.Size = new System.Drawing.Size(76, 20);
            this.lblDomicilioCliente.TabIndex = 2;
            this.lblDomicilioCliente.Text = "Domicilio:";
            // 
            // lblTeléfonoCliente
            // 
            this.lblTeléfonoCliente.AutoSize = true;
            this.lblTeléfonoCliente.Location = new System.Drawing.Point(17, 89);
            this.lblTeléfonoCliente.Name = "lblTeléfonoCliente";
            this.lblTeléfonoCliente.Size = new System.Drawing.Size(75, 20);
            this.lblTeléfonoCliente.TabIndex = 1;
            this.lblTeléfonoCliente.Text = "Teléfono:";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(17, 38);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(52, 20);
            this.lblEmailCliente.TabIndex = 0;
            this.lblEmailCliente.Text = "Email:";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(371, 236);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(114, 39);
            this.btnAgregarCliente.TabIndex = 10;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // FrmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 287);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNuevoCliente";
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
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button btnAgregarCliente;
    }
}