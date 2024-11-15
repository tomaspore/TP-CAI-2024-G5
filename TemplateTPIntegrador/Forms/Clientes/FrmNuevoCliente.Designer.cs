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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(223, 35);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(173, 26);
            this.txtNombreCliente.TabIndex = 0;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(137, 37);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(180, 26);
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
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 234);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Básicos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Location = new System.Drawing.Point(20, 188);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(106, 20);
            this.lblDNICliente.TabIndex = 7;
            this.lblDNICliente.Text = "Documento:";
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(223, 185);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(173, 26);
            this.txtDNICliente.TabIndex = 6;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(223, 135);
            this.dtpFechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(173, 26);
            this.dtpFechaNacimiento.TabIndex = 5;
            this.dtpFechaNacimiento.Value = new System.DateTime(2024, 11, 3, 15, 41, 14, 0);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(223, 83);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(173, 26);
            this.txtApellidoCliente.TabIndex = 4;
            // 
            // lblFechaNacimientoCliente
            // 
            this.lblFechaNacimientoCliente.AutoSize = true;
            this.lblFechaNacimientoCliente.Location = new System.Drawing.Point(20, 138);
            this.lblFechaNacimientoCliente.Name = "lblFechaNacimientoCliente";
            this.lblFechaNacimientoCliente.Size = new System.Drawing.Size(183, 20);
            this.lblFechaNacimientoCliente.TabIndex = 3;
            this.lblFechaNacimientoCliente.Text = "Fecha de Nacimiento:";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Location = new System.Drawing.Point(20, 89);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(78, 20);
            this.lblApellidoCliente.TabIndex = 2;
            this.lblApellidoCliente.Text = "Apellido:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(20, 40);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(76, 20);
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
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(475, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 234);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Contacto";
            // 
            // txtDomicilioCliente
            // 
            this.txtDomicilioCliente.Location = new System.Drawing.Point(137, 135);
            this.txtDomicilioCliente.Name = "txtDomicilioCliente";
            this.txtDomicilioCliente.Size = new System.Drawing.Size(180, 26);
            this.txtDomicilioCliente.TabIndex = 6;
            // 
            // txtTeléfonoCliente
            // 
            this.txtTeléfonoCliente.Location = new System.Drawing.Point(137, 86);
            this.txtTeléfonoCliente.Name = "txtTeléfonoCliente";
            this.txtTeléfonoCliente.Size = new System.Drawing.Size(180, 26);
            this.txtTeléfonoCliente.TabIndex = 5;
            // 
            // lblDomicilioCliente
            // 
            this.lblDomicilioCliente.AutoSize = true;
            this.lblDomicilioCliente.Location = new System.Drawing.Point(18, 141);
            this.lblDomicilioCliente.Name = "lblDomicilioCliente";
            this.lblDomicilioCliente.Size = new System.Drawing.Size(86, 20);
            this.lblDomicilioCliente.TabIndex = 2;
            this.lblDomicilioCliente.Text = "Domicilio:";
            // 
            // lblTeléfonoCliente
            // 
            this.lblTeléfonoCliente.AutoSize = true;
            this.lblTeléfonoCliente.Location = new System.Drawing.Point(18, 89);
            this.lblTeléfonoCliente.Name = "lblTeléfonoCliente";
            this.lblTeléfonoCliente.Size = new System.Drawing.Size(84, 20);
            this.lblTeléfonoCliente.TabIndex = 1;
            this.lblTeléfonoCliente.Text = "Teléfono:";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(18, 38);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(58, 20);
            this.lblEmailCliente.TabIndex = 0;
            this.lblEmailCliente.Text = "Email:";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAgregarCliente.Location = new System.Drawing.Point(756, 324);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(134, 38);
            this.btnAgregarCliente.TabIndex = 10;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Indigo;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(16, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nuevo Cliente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(956, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmNuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label3;
    }
}