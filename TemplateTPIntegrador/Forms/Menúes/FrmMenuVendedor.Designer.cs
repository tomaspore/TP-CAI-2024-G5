namespace TemplateTPIntegrador.Forms
{
    partial class FrmMenuVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuVendedor));
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnReporteVentasXVendedor = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnControlClientes = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.greet_user = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(46, 88);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(230, 35);
            this.btnRegistrarVenta.TabIndex = 0;
            this.btnRegistrarVenta.Text = "Registrar venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnReporteVentasXVendedor
            // 
            this.btnReporteVentasXVendedor.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnReporteVentasXVendedor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteVentasXVendedor.Location = new System.Drawing.Point(46, 166);
            this.btnReporteVentasXVendedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReporteVentasXVendedor.Name = "btnReporteVentasXVendedor";
            this.btnReporteVentasXVendedor.Size = new System.Drawing.Size(230, 35);
            this.btnReporteVentasXVendedor.TabIndex = 1;
            this.btnReporteVentasXVendedor.Text = "Devolución de ventas";
            this.btnReporteVentasXVendedor.UseVisualStyleBackColor = false;
            this.btnReporteVentasXVendedor.Click += new System.EventHandler(this.btnReporteVentasXVendedor_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnControlClientes);
            this.groupBox4.Controls.Add(this.btnReporteVentasXVendedor);
            this.groupBox4.Controls.Add(this.btnRegistrarVenta);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(354, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 337);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operaciones";
            // 
            // btnControlClientes
            // 
            this.btnControlClientes.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnControlClientes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlClientes.Location = new System.Drawing.Point(46, 242);
            this.btnControlClientes.Name = "btnControlClientes";
            this.btnControlClientes.Size = new System.Drawing.Size(230, 35);
            this.btnControlClientes.TabIndex = 2;
            this.btnControlClientes.Text = "Control de Clientes";
            this.btnControlClientes.UseVisualStyleBackColor = false;
            this.btnControlClientes.Click += new System.EventHandler(this.btnControlClientes_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Goldenrod;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(65, 503);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 54);
            this.button4.TabIndex = 10;
            this.button4.Text = "Modificar Contraseña";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(65, 429);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 50);
            this.button3.TabIndex = 17;
            this.button3.Text = "Cerrar Sesión";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 100);
            this.panel2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "ELECTROHOGAR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.greet_user);
            this.panel1.Location = new System.Drawing.Point(2, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 588);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TemplateTPIntegrador.Properties.Resources._31_10_2024_18_31_58;
            this.pictureBox1.Location = new System.Drawing.Point(9, 100);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 305);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // greet_user
            // 
            this.greet_user.AutoSize = true;
            this.greet_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_user.ForeColor = System.Drawing.Color.White;
            this.greet_user.Location = new System.Drawing.Point(62, 29);
            this.greet_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greet_user.Name = "greet_user";
            this.greet_user.Size = new System.Drawing.Size(185, 32);
            this.greet_user.TabIndex = 21;
            this.greet_user.Text = "¡Bienvenido!";
            // 
            // FrmMenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(740, 663);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMenuVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal - Vendedor";
            this.Load += new System.EventHandler(this.FrmMenuVendedor_Load);
            this.groupBox4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnReporteVentasXVendedor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label greet_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnControlClientes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}