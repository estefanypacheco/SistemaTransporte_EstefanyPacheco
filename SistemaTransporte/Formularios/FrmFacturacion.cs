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
            EstablecerFuenteDatosDataGrid();
        }


        private void Totalizar()
        {
            if (ListaDetallesLocal != null && ListaDetallesLocal.Rows.Count > 0)
            {
                //se recorren lineas del detalle y se suman ls montos.
                //se acumulan datos en variables de totalización 

                decimal SubTotal = 0;
                decimal Descuento = 0;
                decimal Total = 0;

                foreach (DataRow item in ListaDetallesLocal.Rows) 
                    {

                    SubTotal += Convert.ToDecimal(item["CantidadFactura"]) * Convert.ToDecimal(item["PrecioUnitarioDetalle"]);
                    Descuento += SubTotal * Convert.ToDecimal(item["PorcentajeDescuento"]) / 100;
                    Total += Convert.ToDecimal(item["TotalLinea"]);

                    }

                //ya que tenemos las totalizaciones se muestran.

                LblSubTotal.Text = string.Format("{0:N2}", SubTotal);
                LblDescuento.Text = string.Format("{0:N2}", Descuento);
                LblTotal.Text = string.Format("{0:N2}", Total);

            }


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


            Limpiar();

        }

        private void Limpiar()
        {
            CboxUsuario.SelectedValue = ObjetosGlobales.MiUsuarioGlobal.IDUsuario;
            DtpFechaFactura.Value = DateTime.Now.Date;
            LblNombreCliente.Text = "";
            TxtIdCliente.Clear();
            txtAnotacion.Clear();
            CboxChofer.SelectedIndex = -1;
            CboxTransporte.SelectedIndex = -1;

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
            //DgvListarItems.Rows.Clear();

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

        private void TxtIdCliente_DoubleClick(object sender, EventArgs e)
        {

            Form MiFormBuscarCliente = new Formularios.FrmClienteSeleccionar();
            DialogResult respuesta = MiFormBuscarCliente.ShowDialog();

            if (respuesta  == DialogResult.OK)
            {
                LblNombreCliente.Text = FacturaLocal.MiCliente.NombreCliente;
                TxtIdCliente.Text = FacturaLocal.MiCliente.IDCliente.ToString();

            }
            else
            {
                LblNombreCliente.Text = "";

            }


        }

        private void BtnItemAgregar_Click(object sender, EventArgs e)
        {
            Form FormSeleccionItem = new FrmFacturaItemGestion();

            DialogResult respuesta = FormSeleccionItem.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                DgvListarItems.DataSource = ListaDetallesLocal;

                //Proceso de totalizar
                Totalizar();
            }
        }

        private void CargarDetalleDeFactura()
        {

            //cargar composicion de detalles a partir del datatable de detalles local

            foreach(DataRow item in ListaDetallesLocal.Rows)
            {
                Logica.Models.FacturaDetalle detalle = new Logica.Models.FacturaDetalle();

                detalle.CantidadFactura = Convert.ToInt32(item["CantidadFactura"]);
                detalle.DireccionItem = Convert.ToString(item["DireccionItem"]);
                detalle.PorcentajeDetalle = Convert.ToDecimal(item["PorcentajeDescuento"]);
                detalle.MiServicio.IDServicio = Convert.ToInt32(item["IDServicio"]);
                detalle.PrecioUnitarioDetalle = Convert.ToDecimal(item["PrecioUnitarioDetalle"]);
                detalle.SubTotalLinea = Convert.ToDecimal(item["SubTotalLinea"]);
                detalle.TotalLinea = Convert.ToDecimal(item["TotalLinea"]);

                FacturaLocal.DetalleItems.Add(detalle);

            }

        }


        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            //efectuar validaciones, fecha no mayor a actual, que se hayan seleccionado datos, etc.

            if (ListaDetallesLocal != null && ListaDetallesLocal.Rows.Count > 0
                && CboxUsuario.SelectedIndex > -1 && CboxEmpresa.SelectedIndex > -1
                && CboxTransporte.SelectedIndex > -1 && CboxChofer.SelectedIndex > -1
                && CboxTipoFactura.SelectedIndex > -1 && !string.IsNullOrEmpty(TxtIdCliente.Text.Trim()))
            {

                //datos de encabezado
                FacturaLocal.MiCliente.IDCliente = Convert.ToInt32(TxtIdCliente.Text.Trim());
                FacturaLocal.MiTipo.IDFacturaTipo = Convert.ToInt32(CboxTipoFactura.SelectedValue);
                FacturaLocal.MiUsuario.IDUsuario = Convert.ToInt32(CboxUsuario.SelectedValue);
                FacturaLocal.MiEmpresa.IDEmpresa = Convert.ToInt32(CboxEmpresa.SelectedValue);
                FacturaLocal.MiTransporte.IDTransporte = Convert.ToInt32(CboxTransporte.SelectedValue);
                FacturaLocal.MiChofer.IDChofer = Convert.ToInt32(CboxChofer.SelectedValue);
                FacturaLocal.Fecha = DtpFechaFactura.Value.Date;
                FacturaLocal.Anotacion = txtAnotacion.Text.Trim();

                //datos de detalle
                CargarDetalleDeFactura();

                if (FacturaLocal.Agregar())
                {
                    MessageBox.Show("Factura Guardada con éxito", "Mensaje de éxito", MessageBoxButtons.OK);
                    Limpiar();

                }


            }
            else
            {
                if (string.IsNullOrEmpty(TxtIdCliente.Text.Trim()))
                {
                    MessageBox.Show("El cliente es requerido!", "Error de validación!", MessageBoxButtons.OK);
                    TxtIdCliente.Focus();
                }

                if (CboxEmpresa.SelectedIndex == -1)
                {
                    MessageBox.Show("La empresa es requerida!", "Error de validación!", MessageBoxButtons.OK);
                    CboxEmpresa.Focus();

                }
                if (CboxUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("El Usuario es requerido!", "Error de validación!", MessageBoxButtons.OK);
                    CboxUsuario.Focus();

                }
                if (CboxChofer.SelectedIndex == -1)
                {
                    MessageBox.Show("El Chofer es requerido!", "Error de validación!", MessageBoxButtons.OK);
                    CboxChofer.Focus();

                }
                if (CboxTransporte.SelectedIndex == -1)
                {
                    MessageBox.Show("El Transporte es requerido!", "Error de validación!", MessageBoxButtons.OK);
                    CboxTransporte.Focus();

                }
                if (CboxTipoFactura.SelectedIndex == -1)
                {
                    MessageBox.Show("El Tipo de Factura es requerida!", "Error de validación!", MessageBoxButtons.OK);
                    CboxTipoFactura.Focus();

                }

            }
        }



        private void BtnEliminarLinea_Click(object sender, EventArgs e)
        {
//se puede hacer con foreach

        }
    }
}
