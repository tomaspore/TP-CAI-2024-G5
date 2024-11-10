namespace TemplateTPIntegrador.Forms
{
    partial class FrmDevoluciónVenta
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
            this.btnDevolverVenta = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtIDVenta = new System.Windows.Forms.TextBox();
            this.lblDNIVenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDevolverVenta
            // 
            this.btnDevolverVenta.Location = new System.Drawing.Point(122, 175);
            this.btnDevolverVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDevolverVenta.Name = "btnDevolverVenta";
            this.btnDevolverVenta.Size = new System.Drawing.Size(132, 35);
            this.btnDevolverVenta.TabIndex = 0;
            this.btnDevolverVenta.Text = "Devolver";
            this.btnDevolverVenta.UseVisualStyleBackColor = true;
            this.btnDevolverVenta.Click += new System.EventHandler(this.btnDevolverVenta_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(112, 220);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(160, 35);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver al Menú";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIDVenta
            // 
            this.txtIDVenta.Location = new System.Drawing.Point(47, 101);
            this.txtIDVenta.Name = "txtIDVenta";
            this.txtIDVenta.Size = new System.Drawing.Size(274, 26);
            this.txtIDVenta.TabIndex = 2;
            // 
            // lblDNIVenta
            // 
            this.lblDNIVenta.AutoSize = true;
            this.lblDNIVenta.Location = new System.Drawing.Point(80, 63);
            this.lblDNIVenta.Name = "lblDNIVenta";
            this.lblDNIVenta.Size = new System.Drawing.Size(203, 20);
            this.lblDNIVenta.TabIndex = 3;
            this.lblDNIVenta.Text = "Introduzca el ID de la venta";
            // 
            // FrmDevoluciónVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 280);
            this.Controls.Add(this.lblDNIVenta);
            this.Controls.Add(this.txtIDVenta);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnDevolverVenta);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDevoluciónVenta";
            this.Text = "Devolución de Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDevolverVenta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtIDVenta;
        private System.Windows.Forms.Label lblDNIVenta;
    }
}