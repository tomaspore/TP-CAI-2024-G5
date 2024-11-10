namespace TemplateTPIntegrador.Forms
{
    partial class FrmModificarProducto
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
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtNuevoPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtNuevoStockProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblNuevoPrecio = new System.Windows.Forms.Label();
            this.lblNuevoStock = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(177, 63);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(180, 26);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // txtNuevoPrecioProducto
            // 
            this.txtNuevoPrecioProducto.Location = new System.Drawing.Point(177, 123);
            this.txtNuevoPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNuevoPrecioProducto.Name = "txtNuevoPrecioProducto";
            this.txtNuevoPrecioProducto.Size = new System.Drawing.Size(180, 26);
            this.txtNuevoPrecioProducto.TabIndex = 1;
            // 
            // txtNuevoStockProducto
            // 
            this.txtNuevoStockProducto.Location = new System.Drawing.Point(177, 191);
            this.txtNuevoStockProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNuevoStockProducto.Name = "txtNuevoStockProducto";
            this.txtNuevoStockProducto.Size = new System.Drawing.Size(180, 26);
            this.txtNuevoStockProducto.TabIndex = 2;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(34, 66);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(132, 20);
            this.lblNombreProducto.TabIndex = 3;
            this.lblNombreProducto.Text = "Nombre producto";
            // 
            // lblNuevoPrecio
            // 
            this.lblNuevoPrecio.AutoSize = true;
            this.lblNuevoPrecio.Location = new System.Drawing.Point(34, 128);
            this.lblNuevoPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoPrecio.Name = "lblNuevoPrecio";
            this.lblNuevoPrecio.Size = new System.Drawing.Size(101, 20);
            this.lblNuevoPrecio.TabIndex = 4;
            this.lblNuevoPrecio.Text = "Nuevo precio";
            // 
            // lblNuevoStock
            // 
            this.lblNuevoStock.AutoSize = true;
            this.lblNuevoStock.Location = new System.Drawing.Point(34, 195);
            this.lblNuevoStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoStock.Name = "lblNuevoStock";
            this.lblNuevoStock.Size = new System.Drawing.Size(96, 20);
            this.lblNuevoStock.TabIndex = 5;
            this.lblNuevoStock.Text = "Nuevo stock";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Volver al Menú";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 252);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 351);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNuevoStock);
            this.Controls.Add(this.lblNuevoPrecio);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.txtNuevoStockProducto);
            this.Controls.Add(this.txtNuevoPrecioProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmModificarProducto";
            this.Text = "Modificar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtNuevoPrecioProducto;
        private System.Windows.Forms.TextBox txtNuevoStockProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblNuevoPrecio;
        private System.Windows.Forms.Label lblNuevoStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}