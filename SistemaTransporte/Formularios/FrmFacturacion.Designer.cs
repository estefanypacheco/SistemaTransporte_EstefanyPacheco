
namespace SistemaTransporte.Formularios
{
    partial class FrmFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CboxTransporte = new System.Windows.Forms.ComboBox();
            this.CboxChofer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnotacion = new System.Windows.Forms.TextBox();
            this.CboxTipoFactura = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LblNombreCliente = new System.Windows.Forms.Label();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboxUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CboxEmpresa = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DgvListarItems = new System.Windows.Forms.DataGridView();
            this.CIDServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDireccionItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioUnitarioDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotalLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPorcentajeDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotalLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.LblDescuento = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnItemAgregar = new System.Windows.Forms.Button();
            this.BtnEliminarLinea = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListarItems)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.3054F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.6946F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DgvListarItems, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.53731F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.46269F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1365, 794);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.BtnFacturar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1071, 690);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 101);
            this.panel1.TabIndex = 1;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancelar.Location = new System.Drawing.Point(11, 58);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(208, 34);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnFacturar.Location = new System.Drawing.Point(11, 18);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(208, 34);
            this.BtnFacturar.TabIndex = 0;
            this.BtnFacturar.Text = "Facturar";
            this.BtnFacturar.UseVisualStyleBackColor = true;
            this.BtnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.CboxTransporte);
            this.panel2.Controls.Add(this.CboxChofer);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtAnotacion);
            this.panel2.Controls.Add(this.CboxTipoFactura);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.LblNombreCliente);
            this.panel2.Controls.Add(this.TxtIdCliente);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.CboxUsuario);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DtpFechaFactura);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CboxEmpresa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 286);
            this.panel2.TabIndex = 2;
            // 
            // CboxTransporte
            // 
            this.CboxTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxTransporte.FormattingEnabled = true;
            this.CboxTransporte.Location = new System.Drawing.Point(118, 183);
            this.CboxTransporte.MaxDropDownItems = 12;
            this.CboxTransporte.Name = "CboxTransporte";
            this.CboxTransporte.Size = new System.Drawing.Size(355, 28);
            this.CboxTransporte.TabIndex = 16;
            // 
            // CboxChofer
            // 
            this.CboxChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxChofer.FormattingEnabled = true;
            this.CboxChofer.Location = new System.Drawing.Point(118, 141);
            this.CboxChofer.MaxDropDownItems = 12;
            this.CboxChofer.Name = "CboxChofer";
            this.CboxChofer.Size = new System.Drawing.Size(355, 28);
            this.CboxChofer.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Transporte:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Chofer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Anotación:";
            // 
            // txtAnotacion
            // 
            this.txtAnotacion.Location = new System.Drawing.Point(640, 52);
            this.txtAnotacion.Multiline = true;
            this.txtAnotacion.Name = "txtAnotacion";
            this.txtAnotacion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAnotacion.Size = new System.Drawing.Size(410, 217);
            this.txtAnotacion.TabIndex = 11;
            // 
            // CboxTipoFactura
            // 
            this.CboxTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxTipoFactura.FormattingEnabled = true;
            this.CboxTipoFactura.Location = new System.Drawing.Point(118, 229);
            this.CboxTipoFactura.Name = "CboxTipoFactura";
            this.CboxTipoFactura.Size = new System.Drawing.Size(355, 28);
            this.CboxTipoFactura.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo Factura:";
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.Location = new System.Drawing.Point(262, 95);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(140, 20);
            this.LblNombreCliente.TabIndex = 8;
            this.LblNombreCliente.Text = "Nombre de Cliente";
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtIdCliente.Location = new System.Drawing.Point(118, 95);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.ReadOnly = true;
            this.TxtIdCliente.Size = new System.Drawing.Size(122, 26);
            this.TxtIdCliente.TabIndex = 7;
            this.TxtIdCliente.DoubleClick += new System.EventHandler(this.TxtIdCliente_DoubleClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario:";
            // 
            // CboxUsuario
            // 
            this.CboxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxUsuario.FormattingEnabled = true;
            this.CboxUsuario.Location = new System.Drawing.Point(118, 52);
            this.CboxUsuario.MaxDropDownItems = 12;
            this.CboxUsuario.Name = "CboxUsuario";
            this.CboxUsuario.Size = new System.Drawing.Size(355, 28);
            this.CboxUsuario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // DtpFechaFactura
            // 
            this.DtpFechaFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFechaFactura.Location = new System.Drawing.Point(640, 11);
            this.DtpFechaFactura.Name = "DtpFechaFactura";
            this.DtpFechaFactura.Size = new System.Drawing.Size(410, 26);
            this.DtpFechaFactura.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empresa:";
            // 
            // CboxEmpresa
            // 
            this.CboxEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxEmpresa.Enabled = false;
            this.CboxEmpresa.FormattingEnabled = true;
            this.CboxEmpresa.Location = new System.Drawing.Point(118, 8);
            this.CboxEmpresa.Name = "CboxEmpresa";
            this.CboxEmpresa.Size = new System.Drawing.Size(355, 28);
            this.CboxEmpresa.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1071, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 286);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DgvListarItems
            // 
            this.DgvListarItems.AllowUserToAddRows = false;
            this.DgvListarItems.AllowUserToDeleteRows = false;
            this.DgvListarItems.AllowUserToOrderColumns = true;
            this.DgvListarItems.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DgvListarItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListarItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDServicio,
            this.CDireccionItem,
            this.CCantidadFactura,
            this.CPrecioUnitarioDetalle,
            this.CSubTotalLinea,
            this.CPorcentajeDescuento,
            this.CTotalLinea});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListarItems.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListarItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListarItems.Location = new System.Drawing.Point(3, 295);
            this.DgvListarItems.Name = "DgvListarItems";
            this.DgvListarItems.ReadOnly = true;
            this.DgvListarItems.RowHeadersVisible = false;
            this.DgvListarItems.RowHeadersWidth = 62;
            this.DgvListarItems.RowTemplate.Height = 28;
            this.DgvListarItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListarItems.Size = new System.Drawing.Size(1062, 389);
            this.DgvListarItems.TabIndex = 5;
            this.DgvListarItems.VirtualMode = true;
            this.DgvListarItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListarItems_CellClick);
            this.DgvListarItems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListarItems_DataBindingComplete);
            // 
            // CIDServicio
            // 
            this.CIDServicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIDServicio.DataPropertyName = "IDServicio";
            this.CIDServicio.HeaderText = "Código Servicio";
            this.CIDServicio.MinimumWidth = 8;
            this.CIDServicio.Name = "CIDServicio";
            this.CIDServicio.ReadOnly = true;
            this.CIDServicio.Width = 90;
            // 
            // CDireccionItem
            // 
            this.CDireccionItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CDireccionItem.DataPropertyName = "DireccionItem";
            this.CDireccionItem.HeaderText = "Direccion";
            this.CDireccionItem.MinimumWidth = 8;
            this.CDireccionItem.Name = "CDireccionItem";
            this.CDireccionItem.ReadOnly = true;
            this.CDireccionItem.Width = 469;
            // 
            // CCantidadFactura
            // 
            this.CCantidadFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCantidadFactura.DataPropertyName = "CantidadFactura";
            this.CCantidadFactura.HeaderText = "Cantidad";
            this.CCantidadFactura.MinimumWidth = 8;
            this.CCantidadFactura.Name = "CCantidadFactura";
            this.CCantidadFactura.ReadOnly = true;
            this.CCantidadFactura.Width = 80;
            // 
            // CPrecioUnitarioDetalle
            // 
            this.CPrecioUnitarioDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPrecioUnitarioDetalle.DataPropertyName = "PrecioUnitarioDetalle";
            this.CPrecioUnitarioDetalle.HeaderText = "Precio Unitario";
            this.CPrecioUnitarioDetalle.MinimumWidth = 8;
            this.CPrecioUnitarioDetalle.Name = "CPrecioUnitarioDetalle";
            this.CPrecioUnitarioDetalle.ReadOnly = true;
            this.CPrecioUnitarioDetalle.Width = 90;
            // 
            // CSubTotalLinea
            // 
            this.CSubTotalLinea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CSubTotalLinea.DataPropertyName = "SubTotalLinea";
            this.CSubTotalLinea.HeaderText = "SubTotal";
            this.CSubTotalLinea.MinimumWidth = 8;
            this.CSubTotalLinea.Name = "CSubTotalLinea";
            this.CSubTotalLinea.ReadOnly = true;
            this.CSubTotalLinea.Width = 90;
            // 
            // CPorcentajeDescuento
            // 
            this.CPorcentajeDescuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPorcentajeDescuento.DataPropertyName = "PorcentajeDescuento";
            this.CPorcentajeDescuento.HeaderText = "Descuento";
            this.CPorcentajeDescuento.MinimumWidth = 8;
            this.CPorcentajeDescuento.Name = "CPorcentajeDescuento";
            this.CPorcentajeDescuento.ReadOnly = true;
            this.CPorcentajeDescuento.Width = 90;
            // 
            // CTotalLinea
            // 
            this.CTotalLinea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CTotalLinea.DataPropertyName = "TotalLinea";
            this.CTotalLinea.HeaderText = "Total";
            this.CTotalLinea.MinimumWidth = 8;
            this.CTotalLinea.Name = "CTotalLinea";
            this.CTotalLinea.ReadOnly = true;
            this.CTotalLinea.Width = 150;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 690);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(859, 100);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.LblSubTotal, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.3617F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.6383F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 94);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 36);
            this.label9.TabIndex = 0;
            this.label9.Text = "SubTotal";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSubTotal.Location = new System.Drawing.Point(3, 36);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(194, 58);
            this.LblSubTotal.TabIndex = 1;
            this.LblSubTotal.Text = "0";
            this.LblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.LblDescuento, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(289, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.3617F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.6383F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 94);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // LblDescuento
            // 
            this.LblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDescuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDescuento.Location = new System.Drawing.Point(3, 36);
            this.LblDescuento.Name = "LblDescuento";
            this.LblDescuento.Size = new System.Drawing.Size(194, 58);
            this.LblDescuento.TabIndex = 2;
            this.LblDescuento.Text = "0";
            this.LblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DarkGray;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 36);
            this.label10.TabIndex = 1;
            this.label10.Text = "Descuento";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.LblTotal, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(575, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.3617F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.6383F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 94);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 36);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTotal
            // 
            this.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTotal.Location = new System.Drawing.Point(3, 36);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(194, 58);
            this.LblTotal.TabIndex = 1;
            this.LblTotal.Text = "0";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.BtnItemAgregar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnEliminarLinea, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1071, 295);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(291, 389);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // BtnItemAgregar
            // 
            this.BtnItemAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnItemAgregar.Location = new System.Drawing.Point(3, 3);
            this.BtnItemAgregar.Name = "BtnItemAgregar";
            this.BtnItemAgregar.Size = new System.Drawing.Size(285, 188);
            this.BtnItemAgregar.TabIndex = 0;
            this.BtnItemAgregar.Text = "Agregar Línea";
            this.BtnItemAgregar.UseVisualStyleBackColor = true;
            this.BtnItemAgregar.Click += new System.EventHandler(this.BtnItemAgregar_Click);
            // 
            // BtnEliminarLinea
            // 
            this.BtnEliminarLinea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEliminarLinea.Location = new System.Drawing.Point(3, 197);
            this.BtnEliminarLinea.Name = "BtnEliminarLinea";
            this.BtnEliminarLinea.Size = new System.Drawing.Size(285, 189);
            this.BtnEliminarLinea.TabIndex = 1;
            this.BtnEliminarLinea.Text = "Eliminar Línea";
            this.BtnEliminarLinea.UseVisualStyleBackColor = true;
            this.BtnEliminarLinea.Click += new System.EventHandler(this.BtnEliminarLinea_Click);
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1365, 794);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmFacturacion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación de Servicio";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListarItems)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnFacturar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechaFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboxEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboxUsuario;
        private System.Windows.Forms.Label LblNombreCliente;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboxTipoFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnotacion;
        private System.Windows.Forms.DataGridView DgvListarItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnItemAgregar;
        private System.Windows.Forms.Button BtnEliminarLinea;
        private System.Windows.Forms.ComboBox CboxTransporte;
        private System.Windows.Forms.ComboBox CboxChofer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDireccionItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioUnitarioDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotalLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPorcentajeDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotalLinea;
    }
}