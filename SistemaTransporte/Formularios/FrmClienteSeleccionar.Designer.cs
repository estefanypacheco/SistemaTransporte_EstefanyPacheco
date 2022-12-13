
namespace SistemaTransporte.Formularios
{
    partial class FrmClienteSeleccionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteSeleccionar));
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.CIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedulaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEmailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDireccionCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TmrBuscarCliente = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(220, 21);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(594, 26);
            this.TxtBuscar.TabIndex = 0;
            this.TxtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyDown);
            this.TxtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyUp);
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDCliente,
            this.CNombreCliente,
            this.CCedulaCliente,
            this.CTelefonoCliente,
            this.CEmailCliente,
            this.CDireccionCliente});
            this.DgvLista.Location = new System.Drawing.Point(12, 70);
            this.DgvLista.MultiSelect = false;
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 62;
            this.DgvLista.RowTemplate.Height = 28;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(1014, 351);
            this.DgvLista.TabIndex = 1;
            this.DgvLista.VirtualMode = true;
            this.DgvLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvLista_DataBindingComplete);
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
            this.CCedulaCliente.HeaderText = "Cedula";
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
            // CEmailCliente
            // 
            this.CEmailCliente.DataPropertyName = "EmailCliente";
            this.CEmailCliente.HeaderText = "Email";
            this.CEmailCliente.MinimumWidth = 8;
            this.CEmailCliente.Name = "CEmailCliente";
            this.CEmailCliente.ReadOnly = true;
            this.CEmailCliente.Width = 150;
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
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(96, 437);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(205, 52);
            this.BtnAceptar.TabIndex = 2;
            this.BtnAceptar.Text = "Seleccionar Cliente";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(798, 437);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 52);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TmrBuscarCliente
            // 
            this.TmrBuscarCliente.Interval = 800;
            this.TmrBuscarCliente.Tick += new System.EventHandler(this.TmrBuscarCliente_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escriba para buscar..";
            // 
            // FrmClienteSeleccionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 551);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.TxtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClienteSeleccionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Cliente";
            this.Load += new System.EventHandler(this.FrmClienteSeleccionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedulaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEmailCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDireccionCliente;
        private System.Windows.Forms.Timer TmrBuscarCliente;
        private System.Windows.Forms.Label label1;
    }
}