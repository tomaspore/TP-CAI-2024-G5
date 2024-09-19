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
            this.btnAltaProducto = new System.Windows.Forms.Button();
            this.btnModificacionProductos = new System.Windows.Forms.Button();
            this.btnBajaProductos = new System.Windows.Forms.Button();
            this.btnDevolucionVenta = new System.Windows.Forms.Button();
            this.btnReporteStockCritico = new System.Windows.Forms.Button();
            this.btnRepProdMasVendidoXCategoria = new System.Windows.Forms.Button();
            this.btnReporteVentasXVendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.Location = new System.Drawing.Point(40, 33);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(285, 23);
            this.btnAltaProducto.TabIndex = 0;
            this.btnAltaProducto.Text = "Alta de Productos";
            this.btnAltaProducto.UseVisualStyleBackColor = true;
            // 
            // btnModificacionProductos
            // 
            this.btnModificacionProductos.Location = new System.Drawing.Point(40, 71);
            this.btnModificacionProductos.Name = "btnModificacionProductos";
            this.btnModificacionProductos.Size = new System.Drawing.Size(285, 23);
            this.btnModificacionProductos.TabIndex = 1;
            this.btnModificacionProductos.Text = "Modificacion de Productos";
            this.btnModificacionProductos.UseVisualStyleBackColor = true;
            // 
            // btnBajaProductos
            // 
            this.btnBajaProductos.Location = new System.Drawing.Point(40, 112);
            this.btnBajaProductos.Name = "btnBajaProductos";
            this.btnBajaProductos.Size = new System.Drawing.Size(285, 23);
            this.btnBajaProductos.TabIndex = 2;
            this.btnBajaProductos.Text = "Baja de Productos";
            this.btnBajaProductos.UseVisualStyleBackColor = true;
            // 
            // btnDevolucionVenta
            // 
            this.btnDevolucionVenta.Location = new System.Drawing.Point(40, 152);
            this.btnDevolucionVenta.Name = "btnDevolucionVenta";
            this.btnDevolucionVenta.Size = new System.Drawing.Size(285, 23);
            this.btnDevolucionVenta.TabIndex = 3;
            this.btnDevolucionVenta.Text = "Devolucion de venta";
            this.btnDevolucionVenta.UseVisualStyleBackColor = true;
            // 
            // btnReporteStockCritico
            // 
            this.btnReporteStockCritico.Location = new System.Drawing.Point(40, 192);
            this.btnReporteStockCritico.Name = "btnReporteStockCritico";
            this.btnReporteStockCritico.Size = new System.Drawing.Size(285, 23);
            this.btnReporteStockCritico.TabIndex = 4;
            this.btnReporteStockCritico.Text = "Reporte de stock critico";
            this.btnReporteStockCritico.UseVisualStyleBackColor = true;
            // 
            // btnRepProdMasVendidoXCategoria
            // 
            this.btnRepProdMasVendidoXCategoria.Location = new System.Drawing.Point(40, 276);
            this.btnRepProdMasVendidoXCategoria.Name = "btnRepProdMasVendidoXCategoria";
            this.btnRepProdMasVendidoXCategoria.Size = new System.Drawing.Size(285, 23);
            this.btnRepProdMasVendidoXCategoria.TabIndex = 5;
            this.btnRepProdMasVendidoXCategoria.Text = "Reporte de productos más vendido por categoría";
            this.btnRepProdMasVendidoXCategoria.UseVisualStyleBackColor = true;
            // 
            // btnReporteVentasXVendedor
            // 
            this.btnReporteVentasXVendedor.Location = new System.Drawing.Point(40, 232);
            this.btnReporteVentasXVendedor.Name = "btnReporteVentasXVendedor";
            this.btnReporteVentasXVendedor.Size = new System.Drawing.Size(285, 23);
            this.btnReporteVentasXVendedor.TabIndex = 6;
            this.btnReporteVentasXVendedor.Text = "Reporte de ventas por vendedor";
            this.btnReporteVentasXVendedor.UseVisualStyleBackColor = true;
            // 
            // FrmMenuSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 343);
            this.Controls.Add(this.btnReporteVentasXVendedor);
            this.Controls.Add(this.btnRepProdMasVendidoXCategoria);
            this.Controls.Add(this.btnReporteStockCritico);
            this.Controls.Add(this.btnDevolucionVenta);
            this.Controls.Add(this.btnBajaProductos);
            this.Controls.Add(this.btnModificacionProductos);
            this.Controls.Add(this.btnAltaProducto);
            this.Name = "FrmMenuSupervisor";
            this.Text = "FrmMenuSupervisor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaProducto;
        private System.Windows.Forms.Button btnModificacionProductos;
        private System.Windows.Forms.Button btnBajaProductos;
        private System.Windows.Forms.Button btnDevolucionVenta;
        private System.Windows.Forms.Button btnReporteStockCritico;
        private System.Windows.Forms.Button btnRepProdMasVendidoXCategoria;
        private System.Windows.Forms.Button btnReporteVentasXVendedor;
    }
}