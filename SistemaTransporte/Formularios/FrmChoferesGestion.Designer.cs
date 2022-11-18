
namespace SistemaTransporte.Formularios
{
    partial class FrmChoferesGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChoferesGestion));
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.GbDetalles = new System.Windows.Forms.GroupBox();
            this.CboxLicenciaChofer = new System.Windows.Forms.ComboBox();
            this.CboxLicencia = new System.Windows.Forms.Label();
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
            this.DgvListaChoferes = new System.Windows.Forms.DataGridView();
            this.CIDChofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreChofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedulaChofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefonoChofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDireccionChofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTipoLicencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbVerActivos = new System.Windows.Forms.CheckBox();
            this.GbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaChoferes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLimpiar.Location = new System.Drawing.Point(954, 540);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 44);
            this.BtnLimpiar.TabIndex = 22;
            this.BtnLimpiar.Text = "Limpiar ";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEditar.Location = new System.Drawing.Point(186, 540);
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
            this.BtnEliminar.Location = new System.Drawing.Point(359, 540);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(126, 44);
            this.BtnEliminar.TabIndex = 20;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(229, 15);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(638, 26);
            this.TxtBuscar.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAgregar.Location = new System.Drawing.Point(15, 540);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(126, 44);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // GbDetalles
            // 
            this.GbDetalles.Controls.Add(this.CboxLicenciaChofer);
            this.GbDetalles.Controls.Add(this.CboxLicencia);
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
            this.GbDetalles.Location = new System.Drawing.Point(15, 381);
            this.GbDetalles.Name = "GbDetalles";
            this.GbDetalles.Size = new System.Drawing.Size(1114, 133);
            this.GbDetalles.TabIndex = 15;
            this.GbDetalles.TabStop = false;
            this.GbDetalles.Text = "Detalles de Choferes";
            // 
            // CboxLicenciaChofer
            // 
            this.CboxLicenciaChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxLicenciaChofer.FormattingEnabled = true;
            this.CboxLicenciaChofer.Location = new System.Drawing.Point(958, 21);
            this.CboxLicenciaChofer.Name = "CboxLicenciaChofer";
            this.CboxLicenciaChofer.Size = new System.Drawing.Size(150, 28);
            this.CboxLicenciaChofer.TabIndex = 14;
            // 
            // CboxLicencia
            // 
            this.CboxLicencia.AutoSize = true;
            this.CboxLicencia.Location = new System.Drawing.Point(885, 26);
            this.CboxLicencia.Name = "CboxLicencia";
            this.CboxLicencia.Size = new System.Drawing.Size(67, 20);
            this.CboxLicencia.TabIndex = 12;
            this.CboxLicencia.Text = "Licencia";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(670, 90);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(412, 26);
            this.TxtDireccion.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(589, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dirección";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(670, 55);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(209, 26);
            this.TxtTelefono.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Teléfono";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(670, 23);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(209, 26);
            this.TxtCedula.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cédula";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(107, 90);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(459, 26);
            this.TxtEmail.TabIndex = 5;
            this.TxtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(107, 58);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(459, 26);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(107, 23);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(101, 26);
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
            // DgvListaChoferes
            // 
            this.DgvListaChoferes.AllowUserToAddRows = false;
            this.DgvListaChoferes.AllowUserToDeleteRows = false;
            this.DgvListaChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaChoferes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDChofer,
            this.CNombreChofer,
            this.CCedulaChofer,
            this.CTelefonoChofer,
            this.CDireccionChofer,
            this.CTipoLicencia});
            this.DgvListaChoferes.Location = new System.Drawing.Point(15, 50);
            this.DgvListaChoferes.MultiSelect = false;
            this.DgvListaChoferes.Name = "DgvListaChoferes";
            this.DgvListaChoferes.ReadOnly = true;
            this.DgvListaChoferes.RowHeadersVisible = false;
            this.DgvListaChoferes.RowHeadersWidth = 62;
            this.DgvListaChoferes.RowTemplate.Height = 28;
            this.DgvListaChoferes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaChoferes.Size = new System.Drawing.Size(1114, 325);
            this.DgvListaChoferes.TabIndex = 14;
            this.DgvListaChoferes.VirtualMode = true;
            this.DgvListaChoferes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaChoferes_CellClick);
            this.DgvListaChoferes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaChoferes_DataBindingComplete);
            // 
            // CIDChofer
            // 
            this.CIDChofer.DataPropertyName = "IDChofer";
            this.CIDChofer.HeaderText = "Código";
            this.CIDChofer.MinimumWidth = 8;
            this.CIDChofer.Name = "CIDChofer";
            this.CIDChofer.ReadOnly = true;
            this.CIDChofer.Width = 150;
            // 
            // CNombreChofer
            // 
            this.CNombreChofer.DataPropertyName = "NombreChofer";
            this.CNombreChofer.HeaderText = "Nombre";
            this.CNombreChofer.MinimumWidth = 8;
            this.CNombreChofer.Name = "CNombreChofer";
            this.CNombreChofer.ReadOnly = true;
            this.CNombreChofer.Width = 150;
            // 
            // CCedulaChofer
            // 
            this.CCedulaChofer.DataPropertyName = "CedulaChofer";
            this.CCedulaChofer.HeaderText = "Cédula";
            this.CCedulaChofer.MinimumWidth = 8;
            this.CCedulaChofer.Name = "CCedulaChofer";
            this.CCedulaChofer.ReadOnly = true;
            this.CCedulaChofer.Width = 150;
            // 
            // CTelefonoChofer
            // 
            this.CTelefonoChofer.DataPropertyName = "TelefonoChofer";
            this.CTelefonoChofer.HeaderText = "Teléfono";
            this.CTelefonoChofer.MinimumWidth = 8;
            this.CTelefonoChofer.Name = "CTelefonoChofer";
            this.CTelefonoChofer.ReadOnly = true;
            this.CTelefonoChofer.Width = 150;
            // 
            // CDireccionChofer
            // 
            this.CDireccionChofer.DataPropertyName = "DireccionChofer";
            this.CDireccionChofer.HeaderText = "Dirección";
            this.CDireccionChofer.MinimumWidth = 8;
            this.CDireccionChofer.Name = "CDireccionChofer";
            this.CDireccionChofer.ReadOnly = true;
            this.CDireccionChofer.Width = 150;
            // 
            // CTipoLicencia
            // 
            this.CTipoLicencia.DataPropertyName = "TipoLicencia";
            this.CTipoLicencia.HeaderText = "Tipo Licencia";
            this.CTipoLicencia.MinimumWidth = 8;
            this.CTipoLicencia.Name = "CTipoLicencia";
            this.CTipoLicencia.ReadOnly = true;
            this.CTipoLicencia.Width = 150;
            // 
            // CbVerActivos
            // 
            this.CbVerActivos.AutoSize = true;
            this.CbVerActivos.Checked = true;
            this.CbVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerActivos.Location = new System.Drawing.Point(904, 15);
            this.CbVerActivos.Name = "CbVerActivos";
            this.CbVerActivos.Size = new System.Drawing.Size(176, 24);
            this.CbVerActivos.TabIndex = 24;
            this.CbVerActivos.Text = "Ver Choferes Ativos";
            this.CbVerActivos.UseVisualStyleBackColor = true;
            this.CbVerActivos.CheckedChanged += new System.EventHandler(this.CbVerActivos_CheckedChanged);
            // 
            // FrmChoferesGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 601);
            this.Controls.Add(this.CbVerActivos);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.GbDetalles);
            this.Controls.Add(this.DgvListaChoferes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChoferesGestion";
            this.Text = "Gestión de Choferes";
            this.Load += new System.EventHandler(this.FrmChoferesGestion_Load);
            this.GbDetalles.ResumeLayout(false);
            this.GbDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaChoferes)).EndInit();
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
        private System.Windows.Forms.ComboBox CboxLicenciaChofer;
        private System.Windows.Forms.Label CboxLicencia;
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
        private System.Windows.Forms.DataGridView DgvListaChoferes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDChofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreChofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedulaChofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefonoChofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDireccionChofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTipoLicencia;
        private System.Windows.Forms.CheckBox CbVerActivos;
    }
}