using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaTransporte.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestiónDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ObjetosGlobales.FrmClientesGestion.Visible)
            {
                ObjetosGlobales.FrmClientesGestion = new FrmClientesGestion();
                ObjetosGlobales.FrmClientesGestion.Show();


            }

        }



        private void gestiónDeUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!ObjetosGlobales.FrmUsuariosGestion.Visible)
            {
                ObjetosGlobales.FrmUsuariosGestion = new FrmUsuariosGestion();
                ObjetosGlobales.FrmUsuariosGestion.Show();


            }

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            string UsuarioLogueado = string.Format("{0} ({1}) / Tipo Usuario:{2}", ObjetosGlobales.MiUsuarioGlobal.Nombre,
                ObjetosGlobales.MiUsuarioGlobal.EmailUsuario,
                ObjetosGlobales.MiUsuarioGlobal.MiRolUsuario.RolUsuario);

            LblUsuarioLogin.Text = UsuarioLogueado;

            //ahora damos permisos segun tipo de usuario
            switch (ObjetosGlobales.MiUsuarioGlobal.MiRolUsuario.IDUsuarioRol)
            {
                //admin
                case 1:

                    break;
                //colaborador
                case 2:
                    MnuUsuariosGestion.Enabled = false;
                    MnuTransportesGestion.Enabled = false;
                    MnuServiciosGestion.Enabled = false;
                    MnuChoferesGestion.Enabled = false;
  
                    break;
            }



        }

        private void gestiónDeChoferesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ObjetosGlobales.FrmChoferesGestion.Visible)
            {
                ObjetosGlobales.FrmChoferesGestion = new FrmChoferesGestion();
                ObjetosGlobales.FrmChoferesGestion.Show();


            }
        }

        private void gestiónDeTransportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ObjetosGlobales.FrmTransportesGestion.Visible)
            {
                ObjetosGlobales.FrmTransportesGestion = new FrmTransportesGestion();
                ObjetosGlobales.FrmTransportesGestion.Show();


            }
        }

        private void gestiónDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ObjetosGlobales.FrmServiciosGestion.Visible)
            {
                ObjetosGlobales.FrmServiciosGestion = new FrmServiciosGestion();
                ObjetosGlobales.FrmServiciosGestion.Show();


            }

        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ObjetosGlobales.FrmEmpresa.Visible)
            {
                ObjetosGlobales.FrmEmpresa = new FrmEmpresa();
                ObjetosGlobales.FrmEmpresa.Show();


            }
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();

        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MnuInfoSistema_Click(object sender, EventArgs e)
        {
            ObjetosGlobales.FrmSobreSistema = new FrmSobreSistema();
            ObjetosGlobales.FrmSobreSistema.Show();
        }


        private void MnuFacturar_Click(object sender, EventArgs e)
        {
            if (!ObjetosGlobales.MiFormFactura.Visible)
            {
                ObjetosGlobales.MiFormFactura = new FrmFacturacion();
                ObjetosGlobales.MiFormFactura.Show();
            }
        }

        // private void TmrEstablecerFechaHora_Tick(object sender, EventArgs e)
        //{
        //   LblFechaHora.Text = DateTime.Now.ToLongDateString() + "/" + DateTime.Now.ToShortTimeString();

        //}



    }
}
