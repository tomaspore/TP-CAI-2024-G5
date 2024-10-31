namespace TemplateTPIntegrador.Forms
{
    partial class FrmMenuSupervisor
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
            this.btnDevolucionVenta = new System.Windows.Forms.Button();
            this.btnReporteStockCritico = new System.Windows.Forms.Button();
            this.btnRepProdMasVendidoXCategoria = new System.Windows.Forms.Button();
            this.btnReporteVentasXVendedor = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnModificarContraseña = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAltaProducto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnModificacionProductos = new System.Windows.Forms.Button();
            this.btnBajaProductos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.greet_user = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDevolucionVenta
            // 
            this.btnDevolucionVenta.Location = new System.Drawing.Point(13, 148);
            this.btnDevolucionVenta.Name = "btnDevolucionVenta";
            this.btnDevolucionVenta.Size = new System.Drawing.Size(144, 23);
            this.btnDevolucionVenta.TabIndex = 3;
            this.btnDevolucionVenta.Text = "Devolucion de venta";
            this.btnDevolucionVenta.UseVisualStyleBackColor = true;
            this.btnDevolucionVenta.Click += new System.EventHandler(this.btnDevolucionVenta_Click);
            // 
            // btnReporteStockCritico
            // 
            this.btnReporteStockCritico.Location = new System.Drawing.Point(15, 33);
            this.btnReporteStockCritico.Name = "btnReporteStockCritico";
            this.btnReporteStockCritico.Size = new System.Drawing.Size(153, 23);
            this.btnReporteStockCritico.TabIndex = 4;
            this.btnReporteStockCritico.Text = "Stock critico";
            this.btnReporteStockCritico.UseVisualStyleBackColor = true;
            // 
            // btnRepProdMasVendidoXCategoria
            // 
            this.btnRepProdMasVendidoXCategoria.Location = new System.Drawing.Point(15, 110);
            this.btnRepProdMasVendidoXCategoria.Name = "btnRepProdMasVendidoXCategoria";
            this.btnRepProdMasVendidoXCategoria.Size = new System.Drawing.Size(153, 23);
            this.btnRepProdMasVendidoXCategoria.TabIndex = 5;
            this.btnRepProdMasVendidoXCategoria.Text = "Productos más vendidos";
            this.btnRepProdMasVendidoXCategoria.UseVisualStyleBackColor = true;
            // 
            // btnReporteVentasXVendedor
            // 
            this.btnReporteVentasXVendedor.Location = new System.Drawing.Point(15, 72);
            this.btnReporteVentasXVendedor.Name = "btnReporteVentasXVendedor";
            this.btnReporteVentasXVendedor.Size = new System.Drawing.Size(153, 23);
            this.btnReporteVentasXVendedor.TabIndex = 6;
            this.btnReporteVentasXVendedor.Text = "Ventas por vendedor";
            this.btnReporteVentasXVendedor.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnModificarContraseña);
            this.groupBox4.Location = new System.Drawing.Point(356, 304);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(181, 110);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opciones Personales";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(28, 450);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 37);
            this.button5.TabIndex = 17;
            this.button5.Text = "Cerrar Sesión";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnModificarContraseña
            // 
            this.btnModificarContraseña.Location = new System.Drawing.Point(5, 43);
            this.btnModificarContraseña.Name = "btnModificarContraseña";
            this.btnModificarContraseña.Size = new System.Drawing.Size(153, 25);
            this.btnModificarContraseña.TabIndex = 10;
            this.btnModificarContraseña.Text = "Modificar Contraseña";
            this.btnModificarContraseña.UseVisualStyleBackColor = true;
            this.btnModificarContraseña.Click += new System.EventHandler(this.btnModificarContraseña_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReporteVentasXVendedor);
            this.groupBox1.Controls.Add(this.btnRepProdMasVendidoXCategoria);
            this.groupBox1.Controls.Add(this.btnReporteStockCritico);
            this.groupBox1.Location = new System.Drawing.Point(455, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 151);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.Location = new System.Drawing.Point(16, 33);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(141, 23);
            this.btnAltaProducto.TabIndex = 3;
            this.btnAltaProducto.Text = "Alta de Productos";
            this.btnAltaProducto.UseVisualStyleBackColor = true;
            this.btnAltaProducto.Click += new System.EventHandler(this.btnAltaProducto_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAltaProducto);
            this.groupBox3.Controls.Add(this.btnModificacionProductos);
            this.groupBox3.Controls.Add(this.btnBajaProductos);
            this.groupBox3.Controls.Add(this.btnDevolucionVenta);
            this.groupBox3.Location = new System.Drawing.Point(256, 69);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(177, 185);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control de Inventario";
            // 
            // btnModificacionProductos
            // 
            this.btnModificacionProductos.Location = new System.Drawing.Point(16, 71);
            this.btnModificacionProductos.Name = "btnModificacionProductos";
            this.btnModificacionProductos.Size = new System.Drawing.Size(141, 23);
            this.btnModificacionProductos.TabIndex = 4;
            this.btnModificacionProductos.Text = "Modificacion de Productos";
            this.btnModificacionProductos.UseVisualStyleBackColor = true;
            // 
            // btnBajaProductos
            // 
            this.btnBajaProductos.Location = new System.Drawing.Point(16, 108);
            this.btnBajaProductos.Name = "btnBajaProductos";
            this.btnBajaProductos.Size = new System.Drawing.Size(141, 23);
            this.btnBajaProductos.TabIndex = 5;
            this.btnBajaProductos.Text = "Baja de Productos";
            this.btnBajaProductos.UseVisualStyleBackColor = true;
            this.btnBajaProductos.Click += new System.EventHandler(this.btnBajaProductos_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 44);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(49, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "ELECTROHOGAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.greet_user);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(1, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 499);
            this.panel2.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TemplateTPIntegrador.Properties.Resources.eletrohogarx2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 228);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // greet_user
            // 
            this.greet_user.AutoSize = true;
            this.greet_user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_user.ForeColor = System.Drawing.Color.White;
            this.greet_user.Location = new System.Drawing.Point(69, 28);
            this.greet_user.Name = "greet_user";
            this.greet_user.Size = new System.Drawing.Size(94, 19);
            this.greet_user.TabIndex = 21;
            this.greet_user.Text = "¡Bienvenido!";
            this.greet_user.Click += new System.EventHandler(this.greet_user_Click);
            // 
            // FrmMenuSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "FrmMenuSupervisor";
            this.Text = "Menu Principal - Supervisor";
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDevolucionVenta;
        private System.Windows.Forms.Button btnReporteStockCritico;
        private System.Windows.Forms.Button btnRepProdMasVendidoXCategoria;
        private System.Windows.Forms.Button btnReporteVentasXVendedor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnModificarContraseña;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAltaProducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnModificacionProductos;
        private System.Windows.Forms.Button btnBajaProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label greet_user;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}