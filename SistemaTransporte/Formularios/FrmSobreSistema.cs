﻿using System;
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
    public partial class FrmSobreSistema : Form
    {
        public FrmSobreSistema()
        {
            InitializeComponent();
        }

        private void FrmSobreSistema_Load(object sender, EventArgs e)
        {
            MdiParent = ObjetosGlobales.MiFormPrincipal;
        }
    }
}
