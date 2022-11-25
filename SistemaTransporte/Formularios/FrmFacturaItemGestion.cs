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
    public partial class FrmFacturaItemGestion : Form
    {

        DataTable ListaItems { get; set; }
        Logica.Models.Servicio MiServicio { get; set; }

        public FrmFacturaItemGestion()
        {
            InitializeComponent();

            ListaItems = new DataTable();
            MiServicio = new Logica.Models.Servicio();

        }

        private void DgvListaItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaItems.ClearSelection();

        }

        private void FrmFacturaItemGestion_Load(object sender, EventArgs e)
        {
            LlenarListaItems();
        }

        private void LlenarListaItems(string Filtro = "")
        {
            ListaItems = new DataTable();

            ListaItems = MiServicio.BuscarServicio(true, Filtro);

            DgvListaItems.DataSource = ListaItems;

            DgvListaItems.ClearSelection();


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarItem())
            {
                //cargamos el item de detalle del servicio de facturacion
                //debemos crear una fila para el datatable de detalle, y llenamos con info la fila que seleccionamos

                DataRow NuevaLineaDetalleDeFactura = ObjetosGlobales.MiFormFactura.ListaDetallesLocal.NewRow();


                NuevaLineaDetalleDeFactura["IDServicio"] = MiServicio.IDServicio;
                NuevaLineaDetalleDeFactura["DireccionItem"] = MiServicio.DireccionServicio;

                NuevaLineaDetalleDeFactura["CantidadFactura"] = txtCantidad.Value;
                NuevaLineaDetalleDeFactura["PorcentajeDescuento"] = Convert.ToDecimal(txtDescuento.Text.Trim());
                NuevaLineaDetalleDeFactura["PrecioUnitarioDetalle"] = MiServicio.PrecioUnitarioServicio;

                NuevaLineaDetalleDeFactura["SubTotalLinea"] = txtCantidad.Value * MiServicio.PrecioUnitarioServicio; //esto se va calcular en el form de facturación

                //calculo de descuento
                decimal PorcentajeDescuento = Convert.ToDecimal(txtDescuento.Text.Trim());

                decimal PrecioMenosDescuento = MiServicio.PrecioUnitarioServicio - ((MiServicio.PrecioUnitarioServicio * PorcentajeDescuento)/100);


                decimal TotalLineaDetalle = PrecioMenosDescuento * txtCantidad.Value;

                NuevaLineaDetalleDeFactura["TotalLinea"] = TotalLineaDetalle;



                //se llenan as lineas, y se procede a adjuntarlo al datatable de detalles del form de facturaci´n

                ObjetosGlobales.MiFormFactura.ListaDetallesLocal.Rows.Add(NuevaLineaDetalleDeFactura);


                //retornamos un OK
                DialogResult = DialogResult.OK;

            }
        }


        private bool ValidarItem()
        {

            bool R = false;

            if (DgvListaItems.SelectedRows.Count == 1 && txtCantidad.Value > 0)
            {

                R = true;
            }
            else
            {
                if (DgvListaItems.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un Item de la lista", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                if (txtCantidad.Value == 0)
                {
                    MessageBox.Show("Debe seleccionar una cantidad de servicios, diferente a 0", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
            }

            return R;

        }



        private void TrmBuscarItem_Tick(object sender, EventArgs e)
        {
            TrmBuscarItem.Enabled = false;

            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                string Filtro = TxtBuscar.Text.Trim();

                LlenarListaItems(Filtro);

            }
            else
            {

                LlenarListaItems();
            }
        }

        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            TrmBuscarItem.Enabled = false;
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            TrmBuscarItem.Enabled = true;
        }

        private void CalcularPrecioFinal(Logica.Models.Servicio pServicio, decimal PorcentajeDescuento)
        {
            decimal PrecioConDescuento = pServicio.PrecioUnitarioServicio - ((pServicio.PrecioUnitarioServicio * PorcentajeDescuento)/100);

            txtPrecioFinal.Text = PrecioConDescuento.ToString();


        }



        private void DgvListaItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaItems.SelectedRows.Count ==1)
            {
                DataGridViewRow FilaSeleccionada = DgvListaItems.SelectedRows[0];
                int IdServicioSeleccionado = Convert.ToInt32(FilaSeleccionada.Cells["CIDServicio"].Value);

                MiServicio = MiServicio.ConsultarPorID(IdServicioSeleccionado);

                if (MiServicio.IDServicio > 0)
                {
                    txtPrecioUnitario.Text = MiServicio.PrecioUnitarioServicio.ToString();

                    CalcularPrecioFinal(MiServicio, Convert.ToDecimal(txtDescuento.Text.Trim()));
                }


            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescuento.Text.Trim()))
            {
                txtDescuento.Text = "0";
                txtDescuento.SelectAll();
            }
            else
            {

                    CalcularPrecioFinal(MiServicio, Convert.ToDecimal(txtDescuento.Text.Trim()));
                

            }
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e, true);
        }
    }
}
