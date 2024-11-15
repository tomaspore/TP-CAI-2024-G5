﻿namespace TemplateTPIntegrador.Forms
{
    partial class FrmControlClientes
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
            this.lstListaClientes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnBajaCliente = new System.Windows.Forms.Button();
            this.btnReactivarCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstListaClientes
            // 
            this.lstListaClientes.FormattingEnabled = true;
            this.lstListaClientes.Location = new System.Drawing.Point(16, 30);
            this.lstListaClientes.Margin = new System.Windows.Forms.Padding(2);
            this.lstListaClientes.Name = "lstListaClientes";
            this.lstListaClientes.Size = new System.Drawing.Size(173, 277);
            this.lstListaClientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Clientes: ";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Location = new System.Drawing.Point(215, 30);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(125, 23);
            this.btnAgregarCliente.TabIndex = 2;
            this.btnAgregarCliente.Text = "Nuevo Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(8, 22);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(131, 27);
            this.btnModificarCliente.TabIndex = 3;
            this.btnModificarCliente.Text = "Modificar Datos";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnBajaCliente
            // 
            this.btnBajaCliente.Location = new System.Drawing.Point(8, 91);
            this.btnBajaCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBajaCliente.Name = "btnBajaCliente";
            this.btnBajaCliente.Size = new System.Drawing.Size(131, 25);
            this.btnBajaCliente.TabIndex = 4;
            this.btnBajaCliente.Text = "Desactivar";
            this.btnBajaCliente.UseVisualStyleBackColor = true;
            this.btnBajaCliente.Click += new System.EventHandler(this.btnBajaCliente_Click);
            // 
            // btnReactivarCliente
            // 
            this.btnReactivarCliente.Location = new System.Drawing.Point(8, 59);
            this.btnReactivarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnReactivarCliente.Name = "btnReactivarCliente";
            this.btnReactivarCliente.Size = new System.Drawing.Size(131, 23);
            this.btnReactivarCliente.TabIndex = 5;
            this.btnReactivarCliente.Text = "Reactivar";
            this.btnReactivarCliente.UseVisualStyleBackColor = true;
            this.btnReactivarCliente.Click += new System.EventHandler(this.btnReactivarCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModificarCliente);
            this.groupBox1.Controls.Add(this.btnReactivarCliente);
            this.groupBox1.Controls.Add(this.btnBajaCliente);
            this.groupBox1.Location = new System.Drawing.Point(203, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(158, 134);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edición";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Volver al Menú";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmControlClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstListaClientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmControlClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Clientes";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstListaClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnBajaCliente;
        private System.Windows.Forms.Button btnReactivarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}