namespace TemplateTPIntegrador.Forms
{
    partial class FrmRegistrarVenta
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
            this.Registrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadAComprar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(101, 455);
            this.Registrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(203, 35);
            this.Registrar.TabIndex = 0;
            this.Registrar.Text = "REGISTRAR";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 598);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Volver al Menú";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNICliente.Location = new System.Drawing.Point(126, 51);
            this.txtDNICliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(178, 26);
            this.txtDNICliente.TabIndex = 2;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(13, 54);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(94, 20);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "DNI Cliente:";
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 20;
            this.lstProductos.Location = new System.Drawing.Point(17, 122);
            this.lstProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(306, 224);
            this.lstProductos.TabIndex = 4;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.lstProductos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccionar producto:";
            // 
            // txtCantidadAComprar
            // 
            this.txtCantidadAComprar.Location = new System.Drawing.Point(126, 387);
            this.txtCantidadAComprar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidadAComprar.Name = "txtCantidadAComprar";
            this.txtCantidadAComprar.Size = new System.Drawing.Size(178, 26);
            this.txtCantidadAComprar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 387);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad:";
            // 
            // FrmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidadAComprar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtDNICliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Registrar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRegistrarVenta";
            this.Text = "Registrar Venta";
            this.Load += new System.EventHandler(this.FrmRegistrarVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadAComprar;
        private System.Windows.Forms.Label label2;
    }
}