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
    public partial class FrmServiciosGestion : Form
    {

        public Logica.Models.Servicio MiServicioLocal { get; set; }

        public FrmServiciosGestion()
        {
            InitializeComponent();

            MiServicioLocal = new Logica.Models.Servicio();
        }

 

        private void FrmServiciosGestion_Load(object sender, EventArgs e)
        {
            MdiParent = ObjetosGlobales.MiFormPrincipal;

            ListarServiciosActivos();

            CargarTerreno();

            CargarCarga();

            CargarDistanciaExtra();

            LimpiarForm();

            //ActivarAgregar();
        }

        private void LimpiarForm()
        {
            TxtCodigo.Clear();
            TxtDirección.Clear();
            TxtDistancia.Clear();
            TxtPrecioU.Clear();
            CboxDistanciaExtra.SelectedIndex = -1;
            CboxTipoCarga.SelectedIndex = -1;
            CboxTipoTerreno.SelectedIndex = -1;
        }

        private void CargarTerreno()
        {
            Logica.Models.ServicioTerreno MiServicioTerreno = new Logica.Models.ServicioTerreno();

            DataTable ListaTipos = new DataTable();

            ListaTipos = MiServicioTerreno.ListarServicioTerreno();

            CboxTipoTerreno.ValueMember = "id"; //no se ve graficamente
            CboxTipoTerreno.DisplayMember = "d"; //se muestra

            CboxTipoTerreno.DataSource = ListaTipos;

            CboxTipoTerreno.SelectedIndex = -1; //para que en frm no salga nada seleccionado

        }

        private void CargarCarga()
        {
            Logica.Models.ServicioCarga MiServicioCarga = new Logica.Models.ServicioCarga();

            DataTable ListaTipos = new DataTable();

            ListaTipos = MiServicioCarga.ListarServicioCarga();

            CboxTipoCarga.ValueMember = "id"; //no se ve graficamente
            CboxTipoCarga.DisplayMember = "d"; //se muestra

            CboxTipoCarga.DataSource = ListaTipos;

            CboxTipoCarga.SelectedIndex = -1; //para que en frm no salga nada seleccionado

        }

        private void CargarDistanciaExtra()
        {
            Logica.Models.ServicioDistanciaExtra MiServicioDistanciaExtra = new Logica.Models.ServicioDistanciaExtra();

            DataTable ListaTipos = new DataTable();

            ListaTipos = MiServicioDistanciaExtra.ListarServicioDistanciaExtra();

            CboxDistanciaExtra.ValueMember = "id"; //no se ve graficamente
            CboxDistanciaExtra.DisplayMember = "d"; //se muestra

            CboxDistanciaExtra.DataSource = ListaTipos;

            CboxDistanciaExtra.SelectedIndex = -1; //para que en frm no salga nada seleccionado

        }


        private void ListarServiciosActivos()
        {
            //codigo reutilizable
            Logica.Models.Servicio MiServicio = new Logica.Models.Servicio();

            //SdListarActivos
            DataTable dt = MiServicio.ListarServicioActivo();

            //mostrar datos del dgv
            DgvListaServicios.DataSource = dt;

        }

        private void ListarServiciosDesactivados()
        {
            //codigo reutilizable
            Logica.Models.Servicio MiServicio = new Logica.Models.Servicio();

            //SdUsuariosListarActivos
            DataTable dt = MiServicio.ListarInactivos();

            //mostrar datos del dgv
            DgvListaServicios.DataSource = dt;

            DgvListaServicios.ClearSelection();

        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtDirección.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtDistancia.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtPrecioU.Text.Trim()) &&
                CboxTipoTerreno.SelectedIndex > -1 &&
                CboxTipoCarga.SelectedIndex > -1 &&
                CboxDistanciaExtra.SelectedIndex > -1)
            {

                R = true;

            }
            else
            {
                if (string.IsNullOrEmpty(TxtDirección.Text.Trim()))
                {
                    MessageBox.Show("La Dirección es requerida!", "Error de validación!", MessageBoxButtons.OK);
                    TxtDirección.Focus();
                    return false;
                }


                if (string.IsNullOrEmpty(TxtDistancia.Text.Trim()))
                {
                    MessageBox.Show("La Distancia es requerida!", "Error de validación!", MessageBoxButtons.OK);
                    TxtDistancia.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtPrecioU.Text.Trim()))
                {
                    MessageBox.Show("El Precio Unitario es requerido!", "Error de validación!", MessageBoxButtons.OK);
                    TxtPrecioU.Focus();
                    return false;
                }


                if (CboxTipoCarga.SelectedIndex == -1)
                {
                    MessageBox.Show("El Tipo de Carga es requerido!", "Error de validación!", MessageBoxButtons.OK);
                    CboxTipoCarga.Focus();
                    return false;
                }

                if (CboxTipoTerreno.SelectedIndex == -1)
                {
                    MessageBox.Show("El Tipo de Terreno es requerido!", "Error de validación!", MessageBoxButtons.OK);
                    CboxTipoTerreno.Focus();
                    return false;
                }

                if (CboxDistanciaExtra.SelectedIndex == -1)
                {
                    MessageBox.Show("La cantidad de Distancia Extra es requerida!", "Error de validación!", MessageBoxButtons.OK);
                    CboxDistanciaExtra.Focus();
                    return false;
                }

            }

            return R;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {

                string Pregunta = string.Format("El servicio de {0} va ser guardado, ¿Desea continuar?", TxtDirección.Text.Trim());

                DialogResult RespuestaDeUsuario = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if (RespuestaDeUsuario == DialogResult.Yes)
                {
                    MiServicioLocal.DireccionServicio = TxtDirección.Text.Trim();
                    MiServicioLocal.DistanciaServicio = TxtDistancia.Text.Trim();
                    MiServicioLocal.PrecioUnitarioServicio = Convert.ToDecimal(TxtPrecioU.Text.Trim());
                    MiServicioLocal.MiServicioCarga.IDCarga = Convert.ToInt32(CboxTipoCarga.SelectedValue);
                    MiServicioLocal.MiServicioTerreno.IDTerreno = Convert.ToInt32(CboxTipoTerreno.SelectedValue);
                    MiServicioLocal.MiServicioDistanciaExtra.IDDistanciaExtra = Convert.ToInt32(CboxDistanciaExtra.SelectedValue);

                    bool A = MiServicioLocal.ConsultarPorDireccion();

                    if (!A)
                    {
                        if (MiServicioLocal.Agregar())
                        {
                            MessageBox.Show("Servicio Agregado con Éxito!!", "Respuesta éxitosa", MessageBoxButtons.OK);


                        }
                        else
                        {
                            MessageBox.Show("Error al Agregar Servicio!!", "Respuesta fallida", MessageBoxButtons.OK);
                        }

                        ListarServiciosActivos();
                        LimpiarForm();
                    }
                    else
                    {

                        if (A)
                        {
                            MessageBox.Show("Ya existe un Servicio con la misma Direccion!!", "Respuesta fallida", MessageBoxButtons.OK);
                        }

                    }


                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {

                string Pregunta = string.Format("La información del Servicio {0} va ser modificada, ¿Desea continuar?", TxtDirección.Text.Trim());

                DialogResult RespuestaDeUsuario = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if (RespuestaDeUsuario == DialogResult.Yes)
                {

                    MiServicioLocal.DireccionServicio = TxtDirección.Text.Trim();
                    MiServicioLocal.DistanciaServicio = TxtDistancia.Text.Trim();
                    MiServicioLocal.PrecioUnitarioServicio = Convert.ToDecimal(TxtPrecioU.Text.Trim());
                    MiServicioLocal.MiServicioCarga.IDCarga = Convert.ToInt32(CboxTipoCarga.SelectedValue);
                    MiServicioLocal.MiServicioTerreno.IDTerreno = Convert.ToInt32(CboxTipoTerreno.SelectedValue);
                    MiServicioLocal.MiServicioDistanciaExtra.IDDistanciaExtra = Convert.ToInt32(CboxDistanciaExtra.SelectedValue);


                    if (MiServicioLocal.Editar())
                    {
                        MessageBox.Show("Servicio Modificado con Éxito!!", "Respuesta éxitosa", MessageBoxButtons.OK);
                        ListarServiciosActivos();
                        LimpiarForm();
                        ActivarAgregar();

                    }
                    else
                    {
                        MessageBox.Show("Error al Modificar Servicio!!", "Respuesta fallida", MessageBoxButtons.OK);
                    }

                }

            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarAgregar(); //que tan necesario?
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

        private void DgvListaServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaServicios.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgvListaServicios.SelectedRows[0];

                int IdServicioSeleccionado = Convert.ToInt32(Fila.Cells["CIDServicio"].Value);


                MiServicioLocal = new Logica.Models.Servicio();
                MiServicioLocal = MiServicioLocal.ConsultarPorID(IdServicioSeleccionado);

                if (MiServicioLocal.IDServicio > 0)
                {
                    //se presenta la info en los controles respectivos usando el obk MiUsuarioLocal
                    //como fuente de datos

                    LimpiarForm();
                    TxtCodigo.Text = MiServicioLocal.IDServicio.ToString();
                    TxtDirección.Text = MiServicioLocal.DireccionServicio;
                    TxtDistancia.Text = MiServicioLocal.DistanciaServicio;
                    TxtPrecioU.Text = MiServicioLocal.PrecioUnitarioServicio.ToString();

                    CboxTipoTerreno.SelectedValue = MiServicioLocal.MiServicioTerreno.IDTerreno;
                    CboxTipoCarga.SelectedValue = MiServicioLocal.MiServicioCarga.IDCarga;
                    CboxDistanciaExtra.SelectedValue = MiServicioLocal.MiServicioDistanciaExtra.IDDistanciaExtra;

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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Acá se va consultar ID previamente, a diferencia de Editar() que se ejecutó directamente
            if (MiServicioLocal.IDServicio > 0)
            {
                Logica.Models.Servicio ServicioConsulta = new Logica.Models.Servicio();
                ServicioConsulta = MiServicioLocal.ConsultarPorID(MiServicioLocal.IDServicio);

                if (ServicioConsulta.IDServicio > 0)
                {
                    string Mensaje = "";

                    if (CbVerActivos.Checked)
                    {
                        Mensaje = string.Format("¿Desea continuar con la eliminación del Servicio de {0}?", MiServicioLocal.DireccionServicio);
                    }
                    else
                    {
                        Mensaje = string.Format("¿Desea continuar con la activación del Servicio de {0}?", MiServicioLocal.DireccionServicio);
                    }

                    //string Mensaje = string.Format("¿Desea continuar con la eliminación del usuario {0}?", MiUsuarioLocal.Nombre);
                    DialogResult Resp = MessageBox.Show(Mensaje, "???", MessageBoxButtons.YesNo);

                    if (Resp == DialogResult.Yes)
                    {

                        if (CbVerActivos.Checked)
                        {
                            if (MiServicioLocal.Eliminar())
                            {
                                MessageBox.Show("Servicio Eliminado con éxito", "Respuesta exitosa", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            if (MiServicioLocal.Activar())
                            {
                                MessageBox.Show("Servicio Activado con éxito", "Respuesta exitosa", MessageBoxButtons.OK);
                            }

                        }
                        CbVerActivos.Checked = true;
                        ListarServiciosActivos();
                        LimpiarForm();
                        ActivarAgregar();

                    }
                }
            }
        }

        private void CbVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (CbVerActivos.Checked)
            {
                BtnEliminar.Text = "Eliminar";
                ListarServiciosActivos();
                LimpiarForm();
                ActivarAgregar();
            }
            else
            {
                BtnEliminar.Text = "Activar";
                ListarServiciosDesactivados();
                LimpiarForm();
                ActivarEditarYEliminar();

            }
        }
    }
}
