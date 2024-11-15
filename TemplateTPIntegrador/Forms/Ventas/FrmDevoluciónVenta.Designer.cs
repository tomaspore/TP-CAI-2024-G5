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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtIDVenta = new System.Windows.Forms.TextBox();
            this.lblDNIVenta = new System.Windows.Forms.Label();
            this.btnDevolverVenta = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Purple;
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.pictureBoxIcon);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(234, 441);
            this.panelLeft.TabIndex = 0;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::TemplateTPIntegrador.Properties.Resources.eletrohogarok;
            this.pictureBoxIcon.Location = new System.Drawing.Point(36, 111);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(132, 132);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            this.pictureBoxIcon.Click += new System.EventHandler(this.pictureBoxIcon_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelTitle.Location = new System.Drawing.Point(254, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(336, 59);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Devolución de Venta";
            // 
            // txtIDVenta
            // 
            this.txtIDVenta.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtIDVenta.Location = new System.Drawing.Point(261, 151);
            this.txtIDVenta.Name = "txtIDVenta";
            this.txtIDVenta.Size = new System.Drawing.Size(200, 36);
            this.txtIDVenta.TabIndex = 2;
            // 
            // lblDNIVenta
            // 
            this.lblDNIVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIVenta.ForeColor = System.Drawing.Color.White;
            this.lblDNIVenta.Location = new System.Drawing.Point(256, 111);
            this.lblDNIVenta.Name = "lblDNIVenta";
            this.lblDNIVenta.Size = new System.Drawing.Size(200, 25);
            this.lblDNIVenta.TabIndex = 2;
            this.lblDNIVenta.Text = "ID de la Venta";
            // 
            // btnDevolverVenta
            // 
            this.btnDevolverVenta.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDevolverVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolverVenta.ForeColor = System.Drawing.Color.White;
            this.btnDevolverVenta.Location = new System.Drawing.Point(261, 204);
            this.btnDevolverVenta.Name = "btnDevolverVenta";
            this.btnDevolverVenta.Size = new System.Drawing.Size(163, 39);
            this.btnDevolverVenta.TabIndex = 3;
            this.btnDevolverVenta.Text = "Devolver";
            this.btnDevolverVenta.UseVisualStyleBackColor = false;
            this.btnDevolverVenta.Click += new System.EventHandler(this.btnDevolverVenta_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(492, 387);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(177, 42);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver al Menú";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 441);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TemplateTPIntegrador.Properties.Resources.eletrohogarok;
            this.pictureBox1.Location = new System.Drawing.Point(29, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDevoluciónVenta
            // 
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(680, 441);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.lblDNIVenta);
            this.Controls.Add(this.txtIDVenta);
            this.Controls.Add(this.btnDevolverVenta);
            this.Controls.Add(this.btnVolver);
            this.Name = "FrmDevoluciónVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolución de Venta";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion  
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtIDVenta;
        private System.Windows.Forms.Label lblDNIVenta;
        private System.Windows.Forms.Button btnDevolverVenta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
