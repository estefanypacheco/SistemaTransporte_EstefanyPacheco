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
    public partial class FrmTransportesGestion : Form
    {

        DataTable ListaTransportes = new DataTable();


        public Logica.Models.Transporte MiTransporteLocal { get; set; }

        public FrmTransportesGestion()
        {
            InitializeComponent();

            MiTransporteLocal = new Logica.Models.Transporte();
        }

        private void LimpiarForm()
        {
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtDescripcion.Clear();
            TxtPlaca.Clear();
            CboxTipoTransporte.SelectedIndex = -1;
        }


        private void FrmTransportesGestion_Load(object sender, EventArgs e)
        {

            MdiParent = ObjetosGlobales.MiFormPrincipal;

            ListarTransportesActivos();
            CargarTipoTransporte();
            LimpiarForm();
            ActivarAgregar();
            BuscarTransporte();
        }


        private void CargarTipoTransporte()
        {
            Logica.Models.TransporteTipo MiTransporteTipo = new Logica.Models.TransporteTipo();

            DataTable ListaTiposTransporte = new DataTable();

            ListaTiposTransporte = MiTransporteTipo.ListarTransporteTipo();

            CboxTipoTransporte.ValueMember = "id"; //no se ve graficamente
            CboxTipoTransporte.DisplayMember = "d"; //se muestra

            CboxTipoTransporte.DataSource = ListaTiposTransporte;

            CboxTipoTransporte.SelectedIndex = -1; //para que en frm no salga nada seleccionado


        }

        private void ListarTransportesActivos()
        {
            //codigo reutilizable
            Logica.Models.Transporte MiTransporte = new Logica.Models.Transporte();

            //SdListarActivos
            DataTable dt = MiTransporte.ListarActivosTransporte();

            //mostrar datos del dgv
            DgvListaTransportes.DataSource = dt;

        }


        private void ListarTransportesDesactivados()
        {
            Logica.Models.Transporte MiTransporte = new Logica.Models.Transporte();

            //SdUsuariosListarActivos
            DataTable dt = MiTransporte.ListarInactivos();

            //mostrar datos del dgv
            DgvListaTransportes.DataSource = dt;

            DgvListaTransportes.ClearSelection();

        }


        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtDescripcion.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtPlaca.Text.Trim()) &&
                CboxTipoTransporte.SelectedIndex > -1)
            {

                R = true;

            }
            else
            {
                if (string.IsNullOrEmpty(TxtNombre.Text.Trim()))
                {
                    MessageBox.Show("El Nombre es requerido!", "Error de validación!", MessageBoxButtons.OK);
                    TxtNombre.Focus();
                    return false;
                }


                if (string.IsNullOrEmpty(TxtDescripcion.Text.Trim()))
                {
                    MessageBox.Show("La Descripcion es requerida!", "Error de validación!", MessageBoxButtons.OK);
                    TxtDescripcion.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtPlaca.Text.Trim()))
                {
                    MessageBox.Show("La placa es requerida!", "Error de validación!", MessageBoxButtons.OK);
                    TxtPlaca.Focus();
                    return false;
                }




                if (CboxTipoTransporte.SelectedIndex == -1)
                {
                    MessageBox.Show("El Tipo de Transporte es requerida!", "Error de validación!", MessageBoxButtons.OK);
                    CboxTipoTransporte.Focus();
                    return false;
                }

            }

            return R;
        }

        private void ListarTransportes()
        {
            //codigo reutilizable
            Logica.Models.Transporte MiTransporte = new Logica.Models.Transporte();

            //SdUsuariosListarActivos
            DataTable dt = MiTransporte.ListarTransportes();

            //mostrar datos del dgv
            DgvListaTransportes.DataSource = dt;

            DgvListaTransportes.ClearSelection();


        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {

                string Pregunta = string.Format("El transporte {0} va ser guardado, ¿Desea continuar?", TxtNombre.Text.Trim());

                DialogResult RespuestaDeUsuario = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if (RespuestaDeUsuario == DialogResult.Yes)
                {
                    MiTransporteLocal.NombreTransporte = TxtNombre.Text.Trim();
                    MiTransporteLocal.DescripcionTransporte = TxtDescripcion.Text.Trim();
                    MiTransporteLocal.Placa = TxtPlaca.Text.Trim();
                    MiTransporteLocal.MiTransporteTipo.IDTransporteTipo = Convert.ToInt32(CboxTipoTransporte.SelectedValue);

                    bool A = MiTransporteLocal.ConsultarPorPlaca();



                    if (!A)
                    {
                        if (MiTransporteLocal.Agregar())
                        {
                            MessageBox.Show("Transporte Agregado con Éxito!!", "Respuesta éxitosa", MessageBoxButtons.OK);


                        }
                        else
                        {
                            MessageBox.Show("Error al Agregar Transporte!!", "Respuesta fallida", MessageBoxButtons.OK);
                        }

                        ListarTransportesActivos();
                        LimpiarForm();
                    }
                    else
                    {

                        if (A)
                        {
                            MessageBox.Show("Ya existe un Transporte con la misma Placa!!", "Respuesta fallida", MessageBoxButtons.OK);
                        }

                    }


                }
            }
        }

        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarEditarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarAgregar(); //que tan necesario?
        }

        private void DgvListaTransportes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaTransportes.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgvListaTransportes.SelectedRows[0];

                int IdTransporteSeleccionado = Convert.ToInt32(Fila.Cells["CIDTransporte"].Value);


                MiTransporteLocal = new Logica.Models.Transporte();
                MiTransporteLocal = MiTransporteLocal.ConsultarPorID(IdTransporteSeleccionado);

                if (MiTransporteLocal.IDTransporte > 0)
                {
                    //se presenta la info en los controles respectivos usando el obk MiUsuarioLocal
                    //como fuente de datos

                    LimpiarForm();
                    TxtCodigo.Text = MiTransporteLocal.IDTransporte.ToString();
                    TxtNombre.Text = MiTransporteLocal.NombreTransporte;
                    TxtDescripcion.Text = MiTransporteLocal.DescripcionTransporte;
                    TxtPlaca.Text = MiTransporteLocal.Placa;
                    CboxTipoTransporte.SelectedValue = MiTransporteLocal.MiTransporteTipo.IDTransporteTipo;

                    ActivarEditarYEliminar();

                    if (CbVerActivos.Checked)
                    {
                        GbDetalles.Enabled = true;
                        BtnEditar.Enabled = true;
                    }
                    else
                    {
                        GbDetalles.Enabled = false;
                        BtnEditar.Enabled = false;

                    }

                }

            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

            if (ValidarDatosRequeridos())
            {
                string Pregunta = string.Format("La información del transporte {0} va ser modificada, ¿Desea continuar?", TxtNombre.Text.Trim());

                DialogResult RespuestaDeUsuario = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if (RespuestaDeUsuario == DialogResult.Yes)
                {

                    MiTransporteLocal.NombreTransporte = TxtNombre.Text.Trim();
                    MiTransporteLocal.DescripcionTransporte = TxtDescripcion.Text.Trim();
                    MiTransporteLocal.Placa = TxtPlaca.Text.Trim();
                    MiTransporteLocal.MiTransporteTipo.IDTransporteTipo = Convert.ToInt32(CboxTipoTransporte.SelectedValue);



                    if (MiTransporteLocal.Editar())
                    {
                        MessageBox.Show("Transporte Modificado con Éxito!!", "Respuesta éxitosa", MessageBoxButtons.OK);
                        ListarTransportesActivos();
                        LimpiarForm();
                        ActivarAgregar();

                    }
                    else
                    {
                        MessageBox.Show("Error al Modificar Cliente!!", "Respuesta fallida", MessageBoxButtons.OK);
                    }

                }
            }
        }



        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Acá se va consultar ID previamente, a diferencia de Editar() que se ejecutó directamente
            if (MiTransporteLocal.IDTransporte > 0)
            {
                Logica.Models.Transporte TransporteConsulta = new Logica.Models.Transporte();
                TransporteConsulta = MiTransporteLocal.ConsultarPorID(MiTransporteLocal.IDTransporte);

                if (TransporteConsulta.IDTransporte > 0)
                {
                    string Mensaje = "";

                    if (CbVerActivos.Checked)
                    {
                        Mensaje = string.Format("¿Desea continuar con la eliminación del transporte {0}?", MiTransporteLocal.NombreTransporte);
                    }
                    else
                    {
                        Mensaje = string.Format("¿Desea continuar con la activación del transporte {0}?", MiTransporteLocal.NombreTransporte);
                    }

                    //string Mensaje = string.Format("¿Desea continuar con la eliminación del usuario {0}?", MiUsuarioLocal.Nombre);
                    DialogResult Resp = MessageBox.Show(Mensaje, "???", MessageBoxButtons.YesNo);

                    if (Resp == DialogResult.Yes)
                    {

                        if (CbVerActivos.Checked)
                        {
                            if (MiTransporteLocal.Eliminar())
                            {
                                MessageBox.Show("Transporte eliminado con éxito", "Respuesta exitosa", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            if (MiTransporteLocal.Activar())
                            {
                                MessageBox.Show("Transporte activado con éxito", "Respuesta exitosa", MessageBoxButtons.OK);
                            }

                        }
                        CbVerActivos.Checked = true;
                        ListarTransportesActivos();
                        LimpiarForm();
                        ActivarAgregar();

                    }
                }
            }
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarAgregar(); //que tan necesario?
        }

        private void DgvListaTransportes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaTransportes.ClearSelection();
        }

        private void CbVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (CbVerActivos.Checked)
            {
                BtnEliminar.Text = "Eliminar";
                ListarTransportesActivos();
                LimpiarForm();
                ActivarAgregar();
            }
            else
            {
                BtnEliminar.Text = "Activar";
                ListarTransportesDesactivados();
                LimpiarForm();
                ActivarEditarYEliminar();

            }
        }


        private void BuscarTransporte(string Filtro = "")
        {

            ListaTransportes = new DataTable();

            ListaTransportes = MiTransporteLocal.BuscarTransporte(true, Filtro);

            DgvListaTransportes.DataSource = ListaTransportes;

            DgvListaTransportes.ClearSelection();

        }

        private void TrmBuscar_Tick(object sender, EventArgs e)
        {
            TrmBuscar.Enabled = false;

            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                string Filtro = TxtBuscar.Text.Trim();

                BuscarTransporte(Filtro);

            }
            else
            {

                BuscarTransporte();
            }
        }

        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            TrmBuscar.Enabled = false;
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            TrmBuscar.Enabled = true;
        }
    }

}
