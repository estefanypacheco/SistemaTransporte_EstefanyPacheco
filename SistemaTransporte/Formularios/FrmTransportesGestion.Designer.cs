
namespace SistemaTransporte.Formularios
{
    partial class FrmTransportesGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransportesGestion));
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.GbDetalles = new System.Windows.Forms.GroupBox();
            this.CboxTipoTransporte = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvListaTransportes = new System.Windows.Forms.DataGridView();
            this.CIDTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPlacaTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcionTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDTransporteTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbVerActivos = new System.Windows.Forms.CheckBox();
            this.GbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaTransportes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLimpiar.Location = new System.Drawing.Point(869, 554);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 44);
            this.BtnLimpiar.TabIndex = 22;
            this.BtnLimpiar.Text = "Limpiar ";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click_1);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEditar.Location = new System.Drawing.Point(183, 554);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(126, 44);
            this.BtnEditar.TabIndex = 21;
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
            this.BtnEliminar.TabIndex = 20;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(183, 17);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(638, 26);
            this.TxtBuscar.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAgregar.Location = new System.Drawing.Point(12, 554);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(126, 44);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // GbDetalles
            // 
            this.GbDetalles.Controls.Add(this.CboxTipoTransporte);
            this.GbDetalles.Controls.Add(this.label10);
            this.GbDetalles.Controls.Add(this.label6);
            this.GbDetalles.Controls.Add(this.TxtDescripcion);
            this.GbDetalles.Controls.Add(this.label5);
            this.GbDetalles.Controls.Add(this.TxtPlaca);
            this.GbDetalles.Controls.Add(this.TxtNombre);
            this.GbDetalles.Controls.Add(this.TxtCodigo);
            this.GbDetalles.Controls.Add(this.label4);
            this.GbDetalles.Controls.Add(this.label3);
            this.GbDetalles.Controls.Add(this.label2);
            this.GbDetalles.Location = new System.Drawing.Point(12, 395);
            this.GbDetalles.Name = "GbDetalles";
            this.GbDetalles.Size = new System.Drawing.Size(1000, 133);
            this.GbDetalles.TabIndex = 15;
            this.GbDetalles.TabStop = false;
            this.GbDetalles.Text = "Detalles de Medio de Transporte";
            // 
            // CboxTipoTransporte
            // 
            this.CboxTipoTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxTipoTransporte.FormattingEnabled = true;
            this.CboxTipoTransporte.Location = new System.Drawing.Point(549, 61);
            this.CboxTipoTransporte.Name = "CboxTipoTransporte";
            this.CboxTipoTransporte.Size = new System.Drawing.Size(208, 28);
            this.CboxTipoTransporte.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Tipo Transporte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 8;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(549, 20);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(434, 26);
            this.TxtDescripcion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descripción";
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Location = new System.Drawing.Point(107, 90);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(300, 26);
            this.TxtPlaca.TabIndex = 5;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(107, 58);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(300, 26);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(107, 23);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(96, 26);
            this.TxtCodigo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // DgvListaTransportes
            // 
            this.DgvListaTransportes.AllowUserToAddRows = false;
            this.DgvListaTransportes.AllowUserToDeleteRows = false;
            this.DgvListaTransportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaTransportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDTransporte,
            this.CNombreTransporte,
            this.CPlacaTransporte,
            this.CDescripcionTransporte,
            this.CIDTransporteTipo});
            this.DgvListaTransportes.Location = new System.Drawing.Point(12, 64);
            this.DgvListaTransportes.MultiSelect = false;
            this.DgvListaTransportes.Name = "DgvListaTransportes";
            this.DgvListaTransportes.ReadOnly = true;
            this.DgvListaTransportes.RowHeadersVisible = false;
            this.DgvListaTransportes.RowHeadersWidth = 62;
            this.DgvListaTransportes.RowTemplate.Height = 28;
            this.DgvListaTransportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaTransportes.Size = new System.Drawing.Size(1000, 325);
            this.DgvListaTransportes.TabIndex = 14;
            this.DgvListaTransportes.VirtualMode = true;
            this.DgvListaTransportes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaTransportes_CellClick);
            this.DgvListaTransportes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaTransportes_DataBindingComplete);
            // 
            // CIDTransporte
            // 
            this.CIDTransporte.DataPropertyName = "IDTransporte";
            this.CIDTransporte.HeaderText = "Código";
            this.CIDTransporte.MinimumWidth = 8;
            this.CIDTransporte.Name = "CIDTransporte";
            this.CIDTransporte.ReadOnly = true;
            this.CIDTransporte.Width = 150;
            // 
            // CNombreTransporte
            // 
            this.CNombreTransporte.DataPropertyName = "NombreTransporte";
            this.CNombreTransporte.HeaderText = "Nombre";
            this.CNombreTransporte.MinimumWidth = 8;
            this.CNombreTransporte.Name = "CNombreTransporte";
            this.CNombreTransporte.ReadOnly = true;
            this.CNombreTransporte.Width = 150;
            // 
            // CPlacaTransporte
            // 
            this.CPlacaTransporte.DataPropertyName = "Placa";
            this.CPlacaTransporte.HeaderText = "Placa";
            this.CPlacaTransporte.MinimumWidth = 8;
            this.CPlacaTransporte.Name = "CPlacaTransporte";
            this.CPlacaTransporte.ReadOnly = true;
            this.CPlacaTransporte.Width = 150;
            // 
            // CDescripcionTransporte
            // 
            this.CDescripcionTransporte.DataPropertyName = "DescripcionTransporte";
            this.CDescripcionTransporte.HeaderText = "Descripción";
            this.CDescripcionTransporte.MinimumWidth = 8;
            this.CDescripcionTransporte.Name = "CDescripcionTransporte";
            this.CDescripcionTransporte.ReadOnly = true;
            this.CDescripcionTransporte.Width = 150;
            // 
            // CIDTransporteTipo
            // 
            this.CIDTransporteTipo.DataPropertyName = "TipoTransporte";
            this.CIDTransporteTipo.HeaderText = "Tipo Transporte";
            this.CIDTransporteTipo.MinimumWidth = 8;
            this.CIDTransporteTipo.Name = "CIDTransporteTipo";
            this.CIDTransporteTipo.ReadOnly = true;
            this.CIDTransporteTipo.Width = 150;
            // 
            // CbVerActivos
            // 
            this.CbVerActivos.AutoSize = true;
            this.CbVerActivos.Checked = true;
            this.CbVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerActivos.Location = new System.Drawing.Point(836, 19);
            this.CbVerActivos.Name = "CbVerActivos";
            this.CbVerActivos.Size = new System.Drawing.Size(204, 24);
            this.CbVerActivos.TabIndex = 24;
            this.CbVerActivos.Text = "Ver Transportes Activos";
            this.CbVerActivos.UseVisualStyleBackColor = true;
            this.CbVerActivos.CheckedChanged += new System.EventHandler(this.CbVerActivos_CheckedChanged);
            // 
            // FrmTransportesGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 630);
            this.Controls.Add(this.CbVerActivos);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.GbDetalles);
            this.Controls.Add(this.DgvListaTransportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTransportesGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Transportes";
            this.Load += new System.EventHandler(this.FrmTransportesGestion_Load);
            this.GbDetalles.ResumeLayout(false);
            this.GbDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaTransportes)).EndInit();
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
        private System.Windows.Forms.ComboBox CboxTipoTransporte;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvListaTransportes;
        private System.Windows.Forms.CheckBox CbVerActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPlacaTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcionTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDTransporteTipo;
    }
}