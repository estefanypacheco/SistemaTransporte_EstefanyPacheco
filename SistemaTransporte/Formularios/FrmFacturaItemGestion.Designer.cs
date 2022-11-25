
namespace SistemaTransporte.Formularios
{
    partial class FrmFacturaItemGestion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturaItemGestion));
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DgvListaItems = new System.Windows.Forms.DataGridView();
            this.CIDServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDistanciaServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDireccionServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioUnitarioServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTipoTerreno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTipoCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadDistancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecioFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboxSumarCantidades = new System.Windows.Forms.CheckBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TrmBuscarItem = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(813, 534);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 52);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(26, 534);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(205, 52);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(227, 24);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(594, 26);
            this.TxtBuscar.TabIndex = 6;
            this.TxtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyDown);
            this.TxtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyUp);
            // 
            // DgvListaItems
            // 
            this.DgvListaItems.AllowUserToAddRows = false;
            this.DgvListaItems.AllowUserToDeleteRows = false;
            this.DgvListaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDServicio,
            this.CDistanciaServicio,
            this.CDireccionServicio,
            this.CPrecioUnitarioServicio,
            this.CTipoTerreno,
            this.CTipoCarga,
            this.CCantidadDistancia});
            this.DgvListaItems.Location = new System.Drawing.Point(13, 65);
            this.DgvListaItems.MultiSelect = false;
            this.DgvListaItems.Name = "DgvListaItems";
            this.DgvListaItems.ReadOnly = true;
            this.DgvListaItems.RowHeadersVisible = false;
            this.DgvListaItems.RowHeadersWidth = 62;
            this.DgvListaItems.RowTemplate.Height = 28;
            this.DgvListaItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaItems.Size = new System.Drawing.Size(1055, 227);
            this.DgvListaItems.TabIndex = 7;
            this.DgvListaItems.VirtualMode = true;
            this.DgvListaItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaItems_CellClick);
            this.DgvListaItems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaItems_DataBindingComplete);
            // 
            // CIDServicio
            // 
            this.CIDServicio.DataPropertyName = "IDServicio";
            this.CIDServicio.HeaderText = "Codigo";
            this.CIDServicio.MinimumWidth = 8;
            this.CIDServicio.Name = "CIDServicio";
            this.CIDServicio.ReadOnly = true;
            this.CIDServicio.Width = 150;
            // 
            // CDistanciaServicio
            // 
            this.CDistanciaServicio.DataPropertyName = "DistanciaServicio";
            this.CDistanciaServicio.HeaderText = "Distancia km";
            this.CDistanciaServicio.MinimumWidth = 8;
            this.CDistanciaServicio.Name = "CDistanciaServicio";
            this.CDistanciaServicio.ReadOnly = true;
            this.CDistanciaServicio.Width = 150;
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
            // CPrecioUnitarioServicio
            // 
            this.CPrecioUnitarioServicio.DataPropertyName = "PrecioUnitarioServicio";
            this.CPrecioUnitarioServicio.HeaderText = "Precio Unitario";
            this.CPrecioUnitarioServicio.MinimumWidth = 8;
            this.CPrecioUnitarioServicio.Name = "CPrecioUnitarioServicio";
            this.CPrecioUnitarioServicio.ReadOnly = true;
            this.CPrecioUnitarioServicio.Width = 150;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecioFinal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CboxSumarCantidades);
            this.groupBox1.Controls.Add(this.txtPrecioUnitario);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 194);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.Location = new System.Drawing.Point(819, 55);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.ReadOnly = true;
            this.txtPrecioFinal.Size = new System.Drawing.Size(102, 26);
            this.txtPrecioFinal.TabIndex = 8;
            this.txtPrecioFinal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(815, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio Final";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(418, 56);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(102, 26);
            this.txtDescuento.TabIndex = 6;
            this.txtDescuento.Text = "0";
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Porcentaje de Descuento";
            // 
            // CboxSumarCantidades
            // 
            this.CboxSumarCantidades.AutoSize = true;
            this.CboxSumarCantidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxSumarCantidades.Location = new System.Drawing.Point(6, 164);
            this.CboxSumarCantidades.Name = "CboxSumarCantidades";
            this.CboxSumarCantidades.Size = new System.Drawing.Size(349, 24);
            this.CboxSumarCantidades.TabIndex = 4;
            this.CboxSumarCantidades.Text = "Sumar Cantidad si Servicio ya está en la lista";
            this.CboxSumarCantidades.UseVisualStyleBackColor = true;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(628, 55);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(102, 26);
            this.txtPrecioUnitario.TabIndex = 3;
            this.txtPrecioUnitario.Text = "0";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(185, 56);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 26);
            this.txtCantidad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(624, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio Unitario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // TrmBuscarItem
            // 
            this.TrmBuscarItem.Interval = 800;
            this.TrmBuscarItem.Tick += new System.EventHandler(this.TrmBuscarItem_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Escriba para buscar..";
            // 
            // FrmFacturaItemGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 650);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvListaItems);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFacturaItemGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Servicio";
            this.Load += new System.EventHandler(this.FrmFacturaItemGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DgvListaItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.CheckBox CboxSumarCantidades;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDistanciaServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDireccionServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioUnitarioServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTipoTerreno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTipoCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadDistancia;
        private System.Windows.Forms.Timer TrmBuscarItem;
        private System.Windows.Forms.TextBox txtPrecioFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}