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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModificarContraseña = new System.Windows.Forms.Button();
            this.chkMostrarContraseñaActual = new System.Windows.Forms.CheckBox();
            this.chkMostrarContraseñaNueva = new System.Windows.Forms.CheckBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Purple;
            this.panelLeft.Controls.Add(this.pictureBoxIcon);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(333, 521);
            this.panelLeft.TabIndex = 0;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::TemplateTPIntegrador.Properties.Resources.eletrohogarok;
            this.pictureBoxIcon.Location = new System.Drawing.Point(81, 142);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(158, 146);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(442, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(415, 50);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Cambio de Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtUsuario.Location = new System.Drawing.Point(449, 119);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(220, 27);
            this.txtUsuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(444, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Usuario:";
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtContraseñaActual.Location = new System.Drawing.Point(449, 203);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.Size = new System.Drawing.Size(220, 27);
            this.txtContraseñaActual.TabIndex = 5;
            this.txtContraseñaActual.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(444, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña Actual:";
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtContraseñaNueva.Location = new System.Drawing.Point(449, 320);
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.Size = new System.Drawing.Size(220, 27);
            this.txtContraseñaNueva.TabIndex = 8;
            this.txtContraseñaNueva.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(444, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nueva Contraseña:";
            // 
            // txtModificarContraseña
            // 
            this.txtModificarContraseña.BackColor = System.Drawing.Color.Purple;
            this.txtModificarContraseña.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtModificarContraseña.ForeColor = System.Drawing.Color.White;
            this.txtModificarContraseña.Location = new System.Drawing.Point(449, 408);
            this.txtModificarContraseña.Name = "txtModificarContraseña";
            this.txtModificarContraseña.Size = new System.Drawing.Size(200, 40);
            this.txtModificarContraseña.TabIndex = 10;
            this.txtModificarContraseña.Text = "Modificar";
            this.txtModificarContraseña.UseVisualStyleBackColor = false;
            // 
            // chkMostrarContraseñaActual
            // 
            this.chkMostrarContraseñaActual.Font = new System.Drawing.Font("Arial", 9F);
            this.chkMostrarContraseñaActual.Location = new System.Drawing.Point(449, 245);
            this.chkMostrarContraseñaActual.Name = "chkMostrarContraseñaActual";
            this.chkMostrarContraseñaActual.Size = new System.Drawing.Size(200, 24);
            this.chkMostrarContraseñaActual.TabIndex = 6;
            this.chkMostrarContraseñaActual.Text = "Mostrar Contraseña Actual";
            this.chkMostrarContraseñaActual.CheckedChanged += new System.EventHandler(this.ChkMostrarContraseñaActual_CheckedChanged);
            // 
            // chkMostrarContraseñaNueva
            // 
            this.chkMostrarContraseñaNueva.Font = new System.Drawing.Font("Arial", 9F);
            this.chkMostrarContraseñaNueva.Location = new System.Drawing.Point(449, 362);
            this.chkMostrarContraseñaNueva.Name = "chkMostrarContraseñaNueva";
            this.chkMostrarContraseñaNueva.Size = new System.Drawing.Size(187, 24);
            this.chkMostrarContraseñaNueva.TabIndex = 9;
            this.chkMostrarContraseñaNueva.Text = "Mostrar Contraseña Nueva";
            this.chkMostrarContraseñaNueva.CheckedChanged += new System.EventHandler(this.ChkMostrarContraseñaNueva_CheckedChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gray;
            this.buttonBack.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(449, 458);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(200, 40);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Volver al Menú";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FrmCambioContraseña
            // 
            this.ClientSize = new System.Drawing.Size(846, 521);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseñaActual);
            this.Controls.Add(this.chkMostrarContraseñaActual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContraseñaNueva);
            this.Controls.Add(this.chkMostrarContraseñaNueva);
            this.Controls.Add(this.txtModificarContraseña);
            this.Controls.Add(this.buttonBack);
            this.Name = "FrmCambioContraseña";
            this.Text = "Cambio de Contraseña";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.CheckBox chkMostrarContraseñaActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.CheckBox chkMostrarContraseñaNueva;
        private System.Windows.Forms.Button txtModificarContraseña;
        private System.Windows.Forms.Button buttonBack;

    }
}
