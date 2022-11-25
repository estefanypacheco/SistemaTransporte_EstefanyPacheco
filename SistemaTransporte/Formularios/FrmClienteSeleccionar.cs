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
    public partial class FrmClienteSeleccionar : Form
    {

        DataTable ListaClientes = new DataTable();

        public Logica.Models.Cliente MiCliente { get; set; }


        public FrmClienteSeleccionar()
        {
            InitializeComponent();

            MiCliente = new Logica.Models.Cliente();

        }

        private void FrmClienteSeleccionar_Load(object sender, EventArgs e)
        {
            LlenarListaClientes();

        }

        private void LlenarListaClientes(string Filtro = "")
        {

            ListaClientes = new DataTable();

            ListaClientes = MiCliente.BuscarCliente(true, Filtro);

            DgvLista.DataSource = ListaClientes;

            DgvLista.ClearSelection();
        
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            if (DgvLista.SelectedRows.Count == 1)
            {

                DataGridViewRow Fila = DgvLista.SelectedRows[0];

                int IdCliente = Convert.ToInt32(Fila.Cells["CIDCliente"].Value);
                string Nombre = Convert.ToString(Fila.Cells["CNombreCliente"].Value);
                string Cedula = Convert.ToString(Fila.Cells["CCedulaCliente"].Value);
                string Telefono = Convert.ToString(Fila.Cells["CTelefonoCliente"].Value);
                string Email = Convert.ToString(Fila.Cells["CEmailCliente"].Value);
                string Direccion = Convert.ToString(Fila.Cells["CDireccionCliente"].Value);

                ObjetosGlobales.MiFormFactura.FacturaLocal.MiCliente.IDCliente = IdCliente;
                ObjetosGlobales.MiFormFactura.FacturaLocal.MiCliente.NombreCliente = Nombre;
                ObjetosGlobales.MiFormFactura.FacturaLocal.MiCliente.CedulaCliente = Cedula;
                ObjetosGlobales.MiFormFactura.FacturaLocal.MiCliente.TelefonoCliente = Telefono;
                ObjetosGlobales.MiFormFactura.FacturaLocal.MiCliente.EmailCliente = Email;
                ObjetosGlobales.MiFormFactura.FacturaLocal.MiCliente.DireccionCliente = Direccion;

                DialogResult = DialogResult.OK;

            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            TmrBuscarCliente.Enabled = false;

        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            //se enciende el tiempo de  busqueda
            TmrBuscarCliente.Enabled = true;
            
        }

        private void TmrBuscarCliente_Tick(object sender, EventArgs e)
        {
            //debemos apagar el timer apr aque el codigo no se ejecute cada 800ms
            TmrBuscarCliente.Enabled = false;

            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                string Filtro = TxtBuscar.Text.Trim();

                LlenarListaClientes(Filtro);

            }
            else
            {

                LlenarListaClientes();
            }

        }

        private void DgvLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvLista.ClearSelection();
        }
    }
}
