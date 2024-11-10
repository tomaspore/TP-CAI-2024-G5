namespace TemplateTPIntegrador.Forms
{
    partial class FrmReactivarUsuario
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
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.btnReactivar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(217, 88);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(120, 20);
            this.textBox9.TabIndex = 11;
            // 
            // btnReactivar
            // 
            this.btnReactivar.Location = new System.Drawing.Point(141, 171);
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Size = new System.Drawing.Size(129, 23);
            this.btnReactivar.TabIndex = 25;
            this.btnReactivar.Text = "Reactivar";
            this.btnReactivar.UseVisualStyleBackColor = true;
            this.btnReactivar.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Id del Usuario a Reactivar";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(154, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 23);
            this.button4.TabIndex = 42;
            this.button4.Text = "Volver al Menú";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmReactivarUsuario
            // 
            this.ClientSize = new System.Drawing.Size(437, 270);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnReactivar);
            this.Controls.Add(this.textBox9);
            this.Name = "FrmReactivarUsuario";
            this.Text = "Reactivar Usuario";
            this.Load += new System.EventHandler(this.FrmModificarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
       
       
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button btnReactivar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
    }
}