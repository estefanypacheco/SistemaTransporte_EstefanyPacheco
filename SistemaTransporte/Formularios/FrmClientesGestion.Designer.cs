
namespace SistemaTransporte.Formularios
{
    partial class FrmClientesGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientesGestion));
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.CbVerActivos = new System.Windows.Forms.CheckBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.GbDetalles = new System.Windows.Forms.GroupBox();
            this.CboxTipoCliente = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvListaClientes = new System.Windows.Forms.DataGridView();
            this.CIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedulaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDireccionCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreClienteTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrmBuscar = new System.Windows.Forms.Timer(this.components);
            this.GbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLimpiar.Location = new System.Drawing.Point(977, 558);
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
            this.BtnEditar.Location = new System.Drawing.Point(195, 558);
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
            this.BtnEliminar.Location = new System.Drawing.Point(368, 558);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(126, 44);
            this.BtnEliminar.TabIndex = 20;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // CbVerActivos
            // 
            this.CbVerActivos.AutoSize = true;
            this.CbVerActivos.Checked = true;
            this.CbVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerActivos.Location = new System.Drawing.Point(927, 20);
            this.CbVerActivos.Name = "CbVerActivos";
            this.CbVerActivos.Size = new System.Drawing.Size(176, 24);
            this.CbVerActivos.TabIndex = 19;
            this.CbVerActivos.Text = "Ver Clientes Activos";
            this.CbVerActivos.UseVisualStyleBackColor = true;
            this.CbVerActivos.CheckedChanged += new System.EventHandler(this.CbVerActivos_CheckedChanged);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(238, 21);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(638, 26);
            this.TxtBuscar.TabIndex = 18;
            this.TxtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyDown);
            this.TxtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAgregar.Location = new System.Drawing.Point(24, 558);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(126, 44);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // GbDetalles
            // 
            this.GbDetalles.Controls.Add(this.CboxTipoCliente);
            this.GbDetalles.Controls.Add(this.label10);
            this.GbDetalles.Controls.Add(this.TxtDireccion);
            this.GbDetalles.Controls.Add(this.label7);
            this.GbDetalles.Controls.Add(this.TxtTelefono);
            this.GbDetalles.Controls.Add(this.label6);
            this.GbDetalles.Controls.Add(this.TxtCedula);
            this.GbDetalles.Controls.Add(this.label5);
            this.GbDetalles.Controls.Add(this.TxtEmail);
            this.GbDetalles.Controls.Add(this.TxtNombre);
            this.GbDetalles.Controls.Add(this.TxtCodigo);
            this.GbDetalles.Controls.Add(this.label4);
            this.GbDetalles.Controls.Add(this.label3);
            this.GbDetalles.Controls.Add(this.label2);
            this.GbDetalles.Location = new System.Drawing.Point(24, 399);
            this.GbDetalles.Name = "GbDetalles";
            this.GbDetalles.Size = new System.Drawing.Size(1114, 153);
            this.GbDetalles.TabIndex = 15;
            this.GbDetalles.TabStop = false;
            this.GbDetalles.Text = "Detalles de Cliente";
            // 
            // CboxTipoCliente
            // 
            this.CboxTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxTipoCliente.FormattingEnabled = true;
            this.CboxTipoCliente.Location = new System.Drawing.Point(974, 26);
            this.CboxTipoCliente.Name = "CboxTipoCliente";
            this.CboxTipoCliente.Size = new System.Drawing.Size(121, 28);
            this.CboxTipoCliente.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(874, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Tipo Cliente";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(617, 90);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(462, 26);
            this.TxtDireccion.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Direccion";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(617, 55);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(209, 26);
            this.TxtTelefono.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Teléfono";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(617, 26);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(209, 26);
            this.TxtCedula.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cédula";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(107, 90);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(416, 26);
            this.TxtEmail.TabIndex = 5;
            this.TxtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(107, 58);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(416, 26);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(107, 23);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(110, 26);
            this.TxtCodigo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
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
            // DgvListaClientes
            // 
            this.DgvListaClientes.AllowUserToAddRows = false;
            this.DgvListaClientes.AllowUserToDeleteRows = false;
            this.DgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDCliente,
            this.CNombreCliente,
            this.CCedulaCliente,
            this.CTelefonoCliente,
            this.CDireccionCliente,
            this.CNombreClienteTipo});
            this.DgvListaClientes.Location = new System.Drawing.Point(24, 68);
            this.DgvListaClientes.MultiSelect = false;
            this.DgvListaClientes.Name = "DgvListaClientes";
            this.DgvListaClientes.ReadOnly = true;
            this.DgvListaClientes.RowHeadersVisible = false;
            this.DgvListaClientes.RowHeadersWidth = 62;
            this.DgvListaClientes.RowTemplate.Height = 28;
            this.DgvListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaClientes.Size = new System.Drawing.Size(1114, 325);
            this.DgvListaClientes.TabIndex = 14;
            this.DgvListaClientes.VirtualMode = true;
            this.DgvListaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaClientes_CellClick);
            this.DgvListaClientes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaClientes_DataBindingComplete);
            // 
            // CIDCliente
            // 
            this.CIDCliente.DataPropertyName = "IDCliente";
            this.CIDCliente.HeaderText = "Código";
            this.CIDCliente.MinimumWidth = 8;
            this.CIDCliente.Name = "CIDCliente";
            this.CIDCliente.ReadOnly = true;
            this.CIDCliente.Width = 150;
            // 
            // CNombreCliente
            // 
            this.CNombreCliente.DataPropertyName = "NombreCliente";
            this.CNombreCliente.HeaderText = "Nombre";
            this.CNombreCliente.MinimumWidth = 8;
            this.CNombreCliente.Name = "CNombreCliente";
            this.CNombreCliente.ReadOnly = true;
            this.CNombreCliente.Width = 150;
            // 
            // CCedulaCliente
            // 
            this.CCedulaCliente.DataPropertyName = "CedulaCliente";
            this.CCedulaCliente.HeaderText = "Cédula";
            this.CCedulaCliente.MinimumWidth = 8;
            this.CCedulaCliente.Name = "CCedulaCliente";
            this.CCedulaCliente.ReadOnly = true;
            this.CCedulaCliente.Width = 150;
            // 
            // CTelefonoCliente
            // 
            this.CTelefonoCliente.DataPropertyName = "TelefonoCliente";
            this.CTelefonoCliente.HeaderText = "Telefono";
            this.CTelefonoCliente.MinimumWidth = 8;
            this.CTelefonoCliente.Name = "CTelefonoCliente";
            this.CTelefonoCliente.ReadOnly = true;
            this.CTelefonoCliente.Width = 150;
            // 
            // CDireccionCliente
            // 
            this.CDireccionCliente.DataPropertyName = "DireccionCliente";
            this.CDireccionCliente.HeaderText = "Direccion";
            this.CDireccionCliente.MinimumWidth = 8;
            this.CDireccionCliente.Name = "CDireccionCliente";
            this.CDireccionCliente.ReadOnly = true;
            this.CDireccionCliente.Width = 150;
            // 
            // CNombreClienteTipo
            // 
            this.CNombreClienteTipo.DataPropertyName = "NombreClienteTipo";
            this.CNombreClienteTipo.HeaderText = "Tipo Cliente";
            this.CNombreClienteTipo.MinimumWidth = 8;
            this.CNombreClienteTipo.Name = "CNombreClienteTipo";
            this.CNombreClienteTipo.ReadOnly = true;
            this.CNombreClienteTipo.Width = 150;
            // 
            // TrmBuscar
            // 
            this.TrmBuscar.Interval = 800;
            this.TrmBuscar.Tick += new System.EventHandler(this.TrmBuscar_Tick);
            // 
            // FrmClientesGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 619);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.CbVerActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.GbDetalles);
            this.Controls.Add(this.DgvListaClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClientesGestion";
            this.Text = "Gestión de Clientes";
            this.Load += new System.EventHandler(this.FrmClientesGestion_Load);
            this.GbDetalles.ResumeLayout(false);
            this.GbDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.CheckBox CbVerActivos;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox GbDetalles;
        private System.Windows.Forms.ComboBox CboxTipoCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvListaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedulaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDireccionCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreClienteTipo;
        private System.Windows.Forms.Timer TrmBuscar;
    }
}