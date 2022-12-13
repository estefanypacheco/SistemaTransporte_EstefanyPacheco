namespace SistemaTransporte.Formularios
{
    partial class FrmEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresa));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.CNombreEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedulaEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEmailEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDireccionEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefonoEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Información de la Empresa";
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNombreEmpresa,
            this.CCedulaEmpresa,
            this.CEmailEmpresa,
            this.CDireccionEmpresa,
            this.CTelefonoEmpresa});
            this.dgvEmpresa.Location = new System.Drawing.Point(25, 70);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.RowHeadersWidth = 62;
            this.dgvEmpresa.RowTemplate.Height = 28;
            this.dgvEmpresa.Size = new System.Drawing.Size(1086, 106);
            this.dgvEmpresa.TabIndex = 12;
            // 
            // CNombreEmpresa
            // 
            this.CNombreEmpresa.DataPropertyName = "NombreEmpresa";
            this.CNombreEmpresa.HeaderText = "Nombre Empresa";
            this.CNombreEmpresa.MinimumWidth = 8;
            this.CNombreEmpresa.Name = "CNombreEmpresa";
            this.CNombreEmpresa.Width = 150;
            // 
            // CCedulaEmpresa
            // 
            this.CCedulaEmpresa.DataPropertyName = "CedulaEmpresa";
            this.CCedulaEmpresa.HeaderText = "Cédula Jurídica";
            this.CCedulaEmpresa.MinimumWidth = 8;
            this.CCedulaEmpresa.Name = "CCedulaEmpresa";
            this.CCedulaEmpresa.Width = 150;
            // 
            // CEmailEmpresa
            // 
            this.CEmailEmpresa.DataPropertyName = "EmailEmpresa";
            this.CEmailEmpresa.HeaderText = "Email Empresa";
            this.CEmailEmpresa.MinimumWidth = 8;
            this.CEmailEmpresa.Name = "CEmailEmpresa";
            this.CEmailEmpresa.Width = 150;
            // 
            // CDireccionEmpresa
            // 
            this.CDireccionEmpresa.DataPropertyName = "DireccionEmpresa";
            this.CDireccionEmpresa.HeaderText = "Ubicación de Negocio";
            this.CDireccionEmpresa.MinimumWidth = 8;
            this.CDireccionEmpresa.Name = "CDireccionEmpresa";
            this.CDireccionEmpresa.Width = 355;
            // 
            // CTelefonoEmpresa
            // 
            this.CTelefonoEmpresa.DataPropertyName = "TelefonoEmpresa";
            this.CTelefonoEmpresa.HeaderText = "Contacto Telefónico";
            this.CTelefonoEmpresa.MinimumWidth = 8;
            this.CTelefonoEmpresa.Name = "CTelefonoEmpresa";
            this.CTelefonoEmpresa.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(449, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 163);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 367);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvEmpresa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEmpresa";
            this.Text = "Información de Empresa";
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedulaEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEmailEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDireccionEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefonoEmpresa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}