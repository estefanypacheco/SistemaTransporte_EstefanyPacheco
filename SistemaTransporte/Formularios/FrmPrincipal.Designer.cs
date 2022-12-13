
namespace SistemaTransporte.Formularios
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuClientesGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuServiciosGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTransportesGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuChoferesGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPuntoDeVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFacturar = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUsuariosGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuInfoSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblUsuarioLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.MnuPuntoDeVenta,
            this.seguridadToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuClientesGestion,
            this.MnuServiciosGestion,
            this.MnuTransportesGestion,
            this.MnuChoferesGestion});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(147, 29);
            this.mantenimientosToolStripMenuItem.Text = "Administración";
            this.mantenimientosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientosToolStripMenuItem_Click);
            // 
            // MnuClientesGestion
            // 
            this.MnuClientesGestion.Name = "MnuClientesGestion";
            this.MnuClientesGestion.Size = new System.Drawing.Size(295, 34);
            this.MnuClientesGestion.Text = "Gestión de Clientes";
            this.MnuClientesGestion.Click += new System.EventHandler(this.gestiónDeClientesToolStripMenuItem_Click);
            // 
            // MnuServiciosGestion
            // 
            this.MnuServiciosGestion.Name = "MnuServiciosGestion";
            this.MnuServiciosGestion.Size = new System.Drawing.Size(295, 34);
            this.MnuServiciosGestion.Text = "Gestión de Servicios";
            this.MnuServiciosGestion.Click += new System.EventHandler(this.gestiónDeServiciosToolStripMenuItem_Click);
            // 
            // MnuTransportesGestion
            // 
            this.MnuTransportesGestion.Name = "MnuTransportesGestion";
            this.MnuTransportesGestion.Size = new System.Drawing.Size(295, 34);
            this.MnuTransportesGestion.Text = "Gestión de Transportes";
            this.MnuTransportesGestion.Click += new System.EventHandler(this.gestiónDeTransportesToolStripMenuItem_Click);
            // 
            // MnuChoferesGestion
            // 
            this.MnuChoferesGestion.Name = "MnuChoferesGestion";
            this.MnuChoferesGestion.Size = new System.Drawing.Size(295, 34);
            this.MnuChoferesGestion.Text = "Gestión de Choferes";
            this.MnuChoferesGestion.Click += new System.EventHandler(this.gestiónDeChoferesToolStripMenuItem_Click);
            // 
            // MnuPuntoDeVenta
            // 
            this.MnuPuntoDeVenta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFacturar});
            this.MnuPuntoDeVenta.Name = "MnuPuntoDeVenta";
            this.MnuPuntoDeVenta.Size = new System.Drawing.Size(80, 29);
            this.MnuPuntoDeVenta.Text = "Ventas";
            // 
            // MnuFacturar
            // 
            this.MnuFacturar.Name = "MnuFacturar";
            this.MnuFacturar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.MnuFacturar.Size = new System.Drawing.Size(295, 34);
            this.MnuFacturar.Text = "Punto de Venta";
            this.MnuFacturar.Click += new System.EventHandler(this.MnuFacturar_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuUsuariosGestion});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.seguridadToolStripMenuItem_Click);
            // 
            // MnuUsuariosGestion
            // 
            this.MnuUsuariosGestion.Name = "MnuUsuariosGestion";
            this.MnuUsuariosGestion.Size = new System.Drawing.Size(272, 34);
            this.MnuUsuariosGestion.Text = "Gestión de Usuarios";
            this.MnuUsuariosGestion.Click += new System.EventHandler(this.gestiónDeUsuariosToolStripMenuItem1_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuInfoSistema,
            this.MnuEmpresa});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // MnuInfoSistema
            // 
            this.MnuInfoSistema.Name = "MnuInfoSistema";
            this.MnuInfoSistema.Size = new System.Drawing.Size(297, 34);
            this.MnuInfoSistema.Text = "Sistema de Transportes";
            this.MnuInfoSistema.Click += new System.EventHandler(this.MnuInfoSistema_Click);
            // 
            // MnuEmpresa
            // 
            this.MnuEmpresa.Name = "MnuEmpresa";
            this.MnuEmpresa.Size = new System.Drawing.Size(297, 34);
            this.MnuEmpresa.Text = "Empresa";
            this.MnuEmpresa.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LblUsuarioLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 32);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 25);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // LblUsuarioLogin
            // 
            this.LblUsuarioLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarioLogin.Name = "LblUsuarioLogin";
            this.LblUsuarioLogin.Size = new System.Drawing.Size(25, 25);
            this.LblUsuarioLogin.Text = "U";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1084, 579);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Sistema Transportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuClientesGestion;
        private System.Windows.Forms.ToolStripMenuItem MnuServiciosGestion;
        private System.Windows.Forms.ToolStripMenuItem MnuTransportesGestion;
        private System.Windows.Forms.ToolStripMenuItem MnuChoferesGestion;
        private System.Windows.Forms.ToolStripMenuItem MnuPuntoDeVenta;
        private System.Windows.Forms.ToolStripMenuItem MnuFacturar;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuInfoSistema;
        private System.Windows.Forms.ToolStripMenuItem MnuEmpresa;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuUsuariosGestion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LblUsuarioLogin;
    }
}