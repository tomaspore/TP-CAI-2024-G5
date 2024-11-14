namespace TemplateTPIntegrador.Forms
{
    partial class FrmConfirmarAcción
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
            this.lblCartel = new System.Windows.Forms.Label();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCartel
            // 
            this.lblCartel.AutoSize = true;
            this.lblCartel.Location = new System.Drawing.Point(98, 54);
            this.lblCartel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCartel.Name = "lblCartel";
            this.lblCartel.Size = new System.Drawing.Size(210, 20);
            this.lblCartel.TabIndex = 0;
            this.lblCartel.Text = "¿Desea confirmar la acción?";
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmarVenta.Location = new System.Drawing.Point(69, 122);
            this.btnConfirmarVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(112, 35);
            this.btnConfirmarVenta.TabIndex = 1;
            this.btnConfirmarVenta.Text = "Confirmar";
            this.btnConfirmarVenta.UseVisualStyleBackColor = true;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarVenta.Location = new System.Drawing.Point(223, 122);
            this.btnCancelarVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(112, 35);
            this.btnCancelarVenta.TabIndex = 2;
            this.btnCancelarVenta.Text = "Cancelar";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // FrmConfirmarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 190);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.lblCartel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmConfirmarVenta";
            this.Text = "Confirmación";
            this.Load += new System.EventHandler(this.FrmConfirmarVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCartel;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Button btnCancelarVenta;
    }
}