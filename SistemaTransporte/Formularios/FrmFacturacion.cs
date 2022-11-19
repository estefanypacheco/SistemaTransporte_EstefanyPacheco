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
    public partial class FrmFacturacion : Form
    {

        public Logica.Models.Factura FacturaLocal { get; set; }

        //para administrar los dellates de forma local vamos a usar composición de obj
        //fact local, usamos datagridview es más  versatil para implemetar un datatable local
        //ára almacenar ingo de detalles, pasará objeto compuesto para agregar esos detalles en la tabla
        //de muchos a muchos
        public DataTable ListaDetallesLocal { get; set; }


        public FrmFacturacion()
        {
            InitializeComponent();

            FacturaLocal = new Logica.Models.Factura();
            ListaDetallesLocal = new DataTable();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            MdiParent = ObjetosGlobales.MiFormPrincipal;

            CargarComboChofer();
            CargarComboEmpresa();
            CargarComboFacturaTipo();
            CargarComboTransporte();
            CargarComboUsuario();

        }

        private void Limpiar()
        {
            CboxUsuario.SelectedValue = ObjetosGlobales.MiUsuarioGlobal.IDUsuario;

            DtpFechaFactura.Value = DateTime.Now.Date;

            txtAnotacion.Clear();

            LblSubTotal.Text = "0";
            LblDescuento.Text = "0";
            LblTotal.Text = "0";

            FacturaLocal = new Logica.Models.Factura();


            //el datagridview espera tener de fondo un datatable para mostrar datos.
            //el form inicia sin mostrar datos y debería tener de fondo el dt
            //con la estructura necesaria y datos en blanco para luego poder agregar lineas.

            ListaDetallesLocal = new DataTable();
            ListaDetallesLocal = FacturaLocal.AsignarEsquemaDetalle();

            DgvListarItems.DataSource = ListaDetallesLocal;

            TxtIdCliente.Clear();
            LblNombreCliente.Text = "";
            



        }



        //combobox cargar
        private void CargarComboUsuario()
        {


            CboxUsuario.DisplayMember = "Nombre";
            CboxUsuario.ValueMember = "IDUsuario";

            CboxUsuario.DataSource = FacturaLocal.MiUsuario.ListarActivos();


            CboxUsuario.SelectedIndex = -1;

        }

        private void CargarComboEmpresa()
        {

            CboxEmpresa.DisplayMember = "desc";
            CboxEmpresa.ValueMember = "id";

            CboxEmpresa.DataSource = FacturaLocal.MiEmpresa.ListarEmpresaDetalle();


        }

        private void CargarComboChofer()
        {


            CboxChofer.DisplayMember = "NombreChofer";
            CboxChofer.ValueMember = "IDChofer";

            CboxChofer.DataSource = FacturaLocal.MiChofer.ListarActivosChofer();

            CboxChofer.SelectedIndex = -1;


        }

        private void CargarComboTransporte()
        {

            CboxTransporte.DisplayMember = "NombreTransporte";
            CboxTransporte.ValueMember = "IDTransporte";

            CboxTransporte.DataSource = FacturaLocal.MiTransporte.ListarActivosTransporte();

            CboxTransporte.SelectedIndex = -1;


        }

        private void CargarComboFacturaTipo()
        {

            CboxTipoFactura.DisplayMember = "desc";
            CboxTipoFactura.ValueMember = "id";

            CboxTipoFactura.DataSource = FacturaLocal.MiTipo.ListarFactura();



        }


    }
}
