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
    public partial class FrmEmpresa : Form
    {
        public FrmEmpresa()
        {
            InitializeComponent();

        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            ListarEmpresa();
        }


        private void ListarEmpresa()
        {
            //codigo reutilizable
            Logica.Models.Empresa MiEmpresa = new Logica.Models.Empresa();

            //SdListarActivos
            DataTable dt = MiEmpresa.ListarEmpresa();

            //mostrar datos del dgv
            dgvEmpresa.DataSource = dt;

        }

    }
}

