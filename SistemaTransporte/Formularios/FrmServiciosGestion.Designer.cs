
namespace SistemaTransporte.Formularios
{
    partial class FrmServiciosGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServiciosGestion));
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.GbDetalles = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CboxDistanciaExtra = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CboxTipoCarga = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CboxTipoTerreno = new System.Windows.Forms.ComboBox();
            this.CboxLicencia = new System.Windows.Forms.Label();
            this.TxtPrecioU = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDirección = new System.Windows.Forms.TextBox();
            this.TxtDistancia = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvListaServicios = new System.Windows.Forms.DataGridView();
            this.CIDServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDistanciaServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioUnitarioServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDireccionServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTipoTerreno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTipoCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadDistancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbVerActivos = new System.Windows.Forms.CheckBox();
            this.GbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLimpiar.Location = new System.Drawing.Point(973, 554);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 44);
            this.BtnLimpiar.TabIndex = 31;
            this.BtnLimpiar.Text = "Limpiar ";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEditar.Location = new System.Drawing.Point(183, 554);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(126, 44);
            this.BtnEditar.TabIndex = 30;
            this.BtnEditar.Text = "Modificar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEliminar.Location = new System.Drawing.Point(356, 554);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(126, 44);
            this.BtnEliminar.TabIndex = 29;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(226, 23);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(638, 26);
            this.TxtBuscar.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Buscar:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAgregar.Location = new System.Drawing.Point(12, 554);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(126, 44);
            this.BtnAgregar.TabIndex = 26;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // GbDetalles
            // 
            this.GbDetalles.Controls.Add(this.label8);
            this.GbDetalles.Controls.Add(this.CboxDistanciaExtra);
            this.GbDetalles.Controls.Add(this.label6);
            this.GbDetalles.Controls.Add(this.CboxTipoCarga);
            this.GbDetalles.Controls.Add(this.label5);
            this.GbDetalles.Controls.Add(this.CboxTipoTerreno);
            this.GbDetalles.Controls.Add(this.CboxLicencia);
            this.GbDetalles.Controls.Add(this.TxtPrecioU);
            this.GbDetalles.Controls.Add(this.label7);
            this.GbDetalles.Controls.Add(this.TxtDirección);
            this.GbDetalles.Controls.Add(this.TxtDistancia);
            this.GbDetalles.Controls.Add(this.TxtCodigo);
            this.GbDetalles.Controls.Add(this.label4);
            this.GbDetalles.Controls.Add(this.label3);
            this.GbDetalles.Controls.Add(this.label2);
            this.GbDetalles.Location = new System.Drawing.Point(12, 395);
            this.GbDetalles.Name = "GbDetalles";
            this.GbDetalles.Size = new System.Drawing.Size(1114, 133);
            this.GbDetalles.TabIndex = 25;
            this.GbDetalles.TabStop = false;
            this.GbDetalles.Text = "Detalles de Servicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1065, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "km*";
            // 
            // CboxDistanciaExtra
            // 
            this.CboxDistanciaExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxDistanciaExtra.FormattingEnabled = true;
            this.CboxDistanciaExtra.Location = new System.Drawing.Point(909, 93);
            this.CboxDistanciaExtra.Name = "CboxDistanciaExtra";
            this.CboxDistanciaExtra.Size = new System.Drawing.Size(150, 28);
            this.CboxDistanciaExtra.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(789, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Distancia Extra";
            // 
            // CboxTipoCarga
            // 
            this.CboxTipoCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxTipoCarga.FormattingEnabled = true;
            this.CboxTipoCarga.Location = new System.Drawing.Point(909, 55);
            this.CboxTipoCarga.Name = "CboxTipoCarga";
            this.CboxTipoCarga.Size = new System.Drawing.Size(150, 28);
            this.CboxTipoCarga.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(817, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tipo Carga";
            // 
            // CboxTipoTerreno
            // 
            this.CboxTipoTerreno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxTipoTerreno.FormattingEnabled = true;
            this.CboxTipoTerreno.Location = new System.Drawing.Point(909, 19);
            this.CboxTipoTerreno.Name = "CboxTipoTerreno";
            this.CboxTipoTerreno.Size = new System.Drawing.Size(150, 28);
            this.CboxTipoTerreno.TabIndex = 14;
            // 
            // CboxLicencia
            // 
            this.CboxLicencia.AutoSize = true;
            this.CboxLicencia.Location = new System.Drawing.Point(805, 27);
            this.CboxLicencia.Name = "CboxLicencia";
            this.CboxLicencia.Size = new System.Drawing.Size(98, 20);
            this.CboxLicencia.TabIndex = 12;
            this.CboxLicencia.Text = "Tipo Terreno";
            // 
            // TxtPrecioU
            // 
            this.TxtPrecioU.Location = new System.Drawing.Point(593, 55);
            this.TxtPrecioU.Name = "TxtPrecioU";
            this.TxtPrecioU.Size = new System.Drawing.Size(161, 26);
            this.TxtPrecioU.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dirección";
            // 
            // TxtDirección
            // 
            this.TxtDirección.Location = new System.Drawing.Point(117, 90);
            this.TxtDirección.Name = "TxtDirección";
            this.TxtDirección.Size = new System.Drawing.Size(637, 26);
            this.TxtDirección.TabIndex = 5;
            // 
            // TxtDistancia
            // 
            this.TxtDistancia.Location = new System.Drawing.Point(117, 58);
            this.TxtDistancia.Name = "TxtDistancia";
            this.TxtDistancia.Size = new System.Drawing.Size(242, 26);
            this.TxtDistancia.TabIndex = 4;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(117, 29);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(101, 26);
            this.TxtCodigo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Precio ₡";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Distancia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // DgvListaServicios
            // 
            this.DgvListaServicios.AllowUserToAddRows = false;
            this.DgvListaServicios.AllowUserToDeleteRows = false;
            this.DgvListaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDServicio,
            this.CDistanciaServicio,
            this.CPrecioUnitarioServicio,
            this.CDireccionServicio,
            this.CTipoTerreno,
            this.CTipoCarga,
            this.CCantidadDistancia});
            this.DgvListaServicios.Location = new System.Drawing.Point(12, 64);
            this.DgvListaServicios.MultiSelect = false;
            this.DgvListaServicios.Name = "DgvListaServicios";
            this.DgvListaServicios.ReadOnly = true;
            this.DgvListaServicios.RowHeadersVisible = false;
            this.DgvListaServicios.RowHeadersWidth = 62;
            this.DgvListaServicios.RowTemplate.Height = 28;
            this.DgvListaServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaServicios.Size = new System.Drawing.Size(1114, 325);
            this.DgvListaServicios.TabIndex = 24;
            this.DgvListaServicios.VirtualMode = true;
            this.DgvListaServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaServicios_CellClick);
            // 
            // CIDServicio
            // 
            this.CIDServicio.DataPropertyName = "IDServicio";
            this.CIDServicio.HeaderText = "Código";
            this.CIDServicio.MinimumWidth = 8;
            this.CIDServicio.Name = "CIDServicio";
            this.CIDServicio.ReadOnly = true;
            this.CIDServicio.Width = 150;
            // 
            // CDistanciaServicio
            // 
            this.CDistanciaServicio.DataPropertyName = "DistanciaServicio";
            this.CDistanciaServicio.HeaderText = "Distancia";
            this.CDistanciaServicio.MinimumWidth = 8;
            this.CDistanciaServicio.Name = "CDistanciaServicio";
            this.CDistanciaServicio.ReadOnly = true;
            this.CDistanciaServicio.Width = 150;
            // 
            // CPrecioUnitarioServicio
            // 
            this.CPrecioUnitarioServicio.DataPropertyName = "PrecioUnitarioServicio";
            this.CPrecioUnitarioServicio.HeaderText = "Precio Unitario";
            this.CPrecioUnitarioServicio.MinimumWidth = 8;
            this.CPrecioUnitarioServicio.Name = "CPrecioUnitarioServicio";
            this.CPrecioUnitarioServicio.ReadOnly = true;
            this.CPrecioUnitarioServicio.Width = 150;
            // 
            // CDireccionServicio
            // 
            this.CDireccionServicio.DataPropertyName = "DireccionServicio";
            this.CDireccionServicio.HeaderText = "Direccion";
            this.CDireccionServicio.MinimumWidth = 8;
            this.CDireccionServicio.Name = "CDireccionServicio";
            this.CDireccionServicio.ReadOnly = true;
            this.CDireccionServicio.Width = 150;
            // 
            // CTipoTerreno
            // 
            this.CTipoTerreno.DataPropertyName = "TipoTerreno";
            this.CTipoTerreno.HeaderText = "Terreno";
            this.CTipoTerreno.MinimumWidth = 8;
            this.CTipoTerreno.Name = "CTipoTerreno";
            this.CTipoTerreno.ReadOnly = true;
            this.CTipoTerreno.Width = 150;
            // 
            // CTipoCarga
            // 
            this.CTipoCarga.DataPropertyName = "TipoCarga";
            this.CTipoCarga.HeaderText = "Carga";
            this.CTipoCarga.MinimumWidth = 8;
            this.CTipoCarga.Name = "CTipoCarga";
            this.CTipoCarga.ReadOnly = true;
            this.CTipoCarga.Width = 150;
            // 
            // CCantidadDistancia
            // 
            this.CCantidadDistancia.DataPropertyName = "CantidadDistancia";
            this.CCantidadDistancia.HeaderText = "Distancia Extra";
            this.CCantidadDistancia.MinimumWidth = 8;
            this.CCantidadDistancia.Name = "CCantidadDistancia";
            this.CCantidadDistancia.ReadOnly = true;
            this.CCantidadDistancia.Width = 150;
            // 
            // CbVerActivos
            // 
            this.CbVerActivos.AutoSize = true;
            this.CbVerActivos.Checked = true;
            this.CbVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerActivos.Location = new System.Drawing.Point(899, 23);
            this.CbVerActivos.Name = "CbVerActivos";
            this.CbVerActivos.Size = new System.Drawing.Size(182, 24);
            this.CbVerActivos.TabIndex = 33;
            this.CbVerActivos.Text = "Ver Servicios Activos";
            this.CbVerActivos.UseVisualStyleBackColor = true;
            this.CbVerActivos.CheckedChanged += new System.EventHandler(this.CbVerActivos_CheckedChanged);
            // 
            // FrmServiciosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 617);
            this.Controls.Add(this.CbVerActivos);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.GbDetalles);
            this.Controls.Add(this.DgvListaServicios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmServiciosGestion";
            this.Text = "Gestión de Servicios";
            this.Load += new System.EventHandler(this.FrmServiciosGestion_Load);
            this.GbDetalles.ResumeLayout(false);
            this.GbDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox GbDetalles;
        private System.Windows.Forms.ComboBox CboxTipoTerreno;
        private System.Windows.Forms.Label CboxLicencia;
        private System.Windows.Forms.TextBox TxtPrecioU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDirección;
        private System.Windows.Forms.TextBox TxtDistancia;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvListaServicios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboxDistanciaExtra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboxTipoCarga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDistanciaServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioUnitarioServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDireccionServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTipoTerreno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTipoCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadDistancia;
        private System.Windows.Forms.CheckBox CbVerActivos;
    }
}