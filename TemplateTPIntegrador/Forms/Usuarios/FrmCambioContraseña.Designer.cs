namespace TemplateTPIntegrador.Forms
{
    partial class FrmCambioContraseña
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
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.txtModificarContraseña = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.chkMostrarContraseñaNueva = new System.Windows.Forms.CheckBox();
            this.chkMostrarContraseñaActual = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaActual.Location = new System.Drawing.Point(88, 143);
            this.txtContraseñaActual.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.Size = new System.Drawing.Size(220, 27);
            this.txtContraseñaActual.TabIndex = 0;
            this.txtContraseñaActual.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña Actual:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva Contraseña:";
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaNueva.Location = new System.Drawing.Point(86, 241);
            this.txtContraseñaNueva.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.Size = new System.Drawing.Size(220, 27);
            this.txtContraseñaNueva.TabIndex = 3;
            this.txtContraseñaNueva.UseSystemPasswordChar = true;
            // 
            // txtModificarContraseña
            // 
            this.txtModificarContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.txtModificarContraseña.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtModificarContraseña.Location = new System.Drawing.Point(86, 313);
            this.txtModificarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtModificarContraseña.Name = "txtModificarContraseña";
            this.txtModificarContraseña.Size = new System.Drawing.Size(94, 31);
            this.txtModificarContraseña.TabIndex = 4;
            this.txtModificarContraseña.Text = "Modificar";
            this.txtModificarContraseña.UseVisualStyleBackColor = false;
            this.txtModificarContraseña.Click += new System.EventHandler(this.txtModificarContraseña_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(88, 69);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(220, 27);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged_1);
            // 
            // chkMostrarContraseñaNueva
            // 
            this.chkMostrarContraseñaNueva.AutoSize = true;
            this.chkMostrarContraseñaNueva.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarContraseñaNueva.Location = new System.Drawing.Point(88, 272);
            this.chkMostrarContraseñaNueva.Margin = new System.Windows.Forms.Padding(2);
            this.chkMostrarContraseñaNueva.Name = "chkMostrarContraseñaNueva";
            this.chkMostrarContraseñaNueva.Size = new System.Drawing.Size(169, 18);
            this.chkMostrarContraseñaNueva.TabIndex = 8;
            this.chkMostrarContraseñaNueva.Text = "Mostrar Contraseña Nueva";
            this.chkMostrarContraseñaNueva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMostrarContraseñaNueva.UseVisualStyleBackColor = true;
            this.chkMostrarContraseñaNueva.CheckedChanged += new System.EventHandler(this.ChkMostrarContraseñaNueva_CheckedChanged);
            this.chkMostrarContraseñaNueva.Click += new System.EventHandler(this.ChkMostrarContraseñaNueva_CheckedChanged);
            // 
            // chkMostrarContraseñaActual
            // 
            this.chkMostrarContraseñaActual.AutoSize = true;
            this.chkMostrarContraseñaActual.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarContraseñaActual.Location = new System.Drawing.Point(88, 174);
            this.chkMostrarContraseñaActual.Margin = new System.Windows.Forms.Padding(2);
            this.chkMostrarContraseñaActual.Name = "chkMostrarContraseñaActual";
            this.chkMostrarContraseñaActual.Size = new System.Drawing.Size(169, 18);
            this.chkMostrarContraseñaActual.TabIndex = 9;
            this.chkMostrarContraseñaActual.Text = "Mostrar Contraseña Actual";
            this.chkMostrarContraseñaActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMostrarContraseñaActual.UseVisualStyleBackColor = true;
            this.chkMostrarContraseñaActual.CheckedChanged += new System.EventHandler(this.ChkMostrarContraseñaActual_CheckedChanged);
            this.chkMostrarContraseñaActual.Click += new System.EventHandler(this.ChkMostrarContraseñaActual_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TemplateTPIntegrador.Properties.Resources.eletrohogarok;
            this.pictureBox2.Location = new System.Drawing.Point(364, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 388);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TemplateTPIntegrador.Properties.Resources.eletrohogarok;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 388);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCambioContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(404, 386);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkMostrarContraseñaActual);
            this.Controls.Add(this.chkMostrarContraseñaNueva);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModificarContraseña);
            this.Controls.Add(this.txtContraseñaNueva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseñaActual);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCambioContraseña";
            this.Text = "FrmCambioContraseña";
            this.Load += new System.EventHandler(this.FrmCambioContraseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.Button txtModificarContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.CheckBox chkMostrarContraseñaNueva;
        private System.Windows.Forms.CheckBox chkMostrarContraseñaActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}