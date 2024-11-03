namespace TemplateTPIntegrador.Forms.Clientes
{
    partial class FrmReactivarCliente
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
            this.btnReactivaciónCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReactivaciónCliente
            // 
            this.btnReactivaciónCliente.Location = new System.Drawing.Point(162, 159);
            this.btnReactivaciónCliente.Name = "btnReactivaciónCliente";
            this.btnReactivaciónCliente.Size = new System.Drawing.Size(118, 31);
            this.btnReactivaciónCliente.TabIndex = 0;
            this.btnReactivaciónCliente.Text = "Reactivar";
            this.btnReactivaciónCliente.UseVisualStyleBackColor = true;
            this.btnReactivaciónCliente.Click += new System.EventHandler(this.btnReactivaciónCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduzca el ID del Cliente";
            // 
            // txtidCliente
            // 
            this.txtidCliente.Location = new System.Drawing.Point(92, 70);
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(265, 26);
            this.txtidCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consulte con el Administrador el ID de Cliente";
            // 
            // FrmReactivarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 224);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReactivaciónCliente);
            this.Name = "FrmReactivarCliente";
            this.Text = "Reactivar Cliente";
            this.Load += new System.EventHandler(this.FrmReactivarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReactivaciónCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidCliente;
        private System.Windows.Forms.Label label2;
    }
}