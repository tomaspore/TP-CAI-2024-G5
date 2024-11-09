namespace TemplateTPIntegrador.Forms
{
    partial class FrmConfirmarVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Desea confirmar la venta?";
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.Location = new System.Drawing.Point(172, 35);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarVenta.TabIndex = 1;
            this.btnConfirmarVenta.Text = "Confirmar";
            this.btnConfirmarVenta.UseVisualStyleBackColor = true;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Location = new System.Drawing.Point(172, 79);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarVenta.TabIndex = 2;
            this.btnCancelarVenta.Text = "Cancelar";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // FrmConfirmarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 234);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.label1);
            this.Name = "FrmConfirmarVenta";
            this.Text = "FrmConfirmarVenta";
            this.Load += new System.EventHandler(this.FrmConfirmarVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Button btnCancelarVenta;
    }
}