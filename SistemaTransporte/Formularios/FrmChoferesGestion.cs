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
    public partial class FrmChoferesGestion : Form
    {
        public Logica.Models.Chofer MiChoferLocal { get; set; }

        public FrmChoferesGestion()
        {
            InitializeComponent();

            MiChoferLocal = new Logica.Models.Chofer();

        }



        private void LimpiarForm()
        {
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtEmail.Clear();
            TxtCedula.Clear();
            TxtTelefono.Clear();
            TxtDireccion.Clear();
            CboxLicenciaChofer.SelectedIndex = -1;
        }


        private void CargarLicenciaChofer()
        {
            Logica.Models.ChoferLicencia MiChoferLicencia = new Logica.Models.ChoferLicencia();

            DataTable ListaLicencias = new DataTable();

            ListaLicencias = MiChoferLicencia.ListarLicencia();

            CboxLicenciaChofer.ValueMember = "id"; //no se ve graficamente
            CboxLicenciaChofer.DisplayMember = "d"; //se muestra

            CboxLicenciaChofer.DataSource = ListaLicencias;

            CboxLicenciaChofer.SelectedIndex = -1; //para que en frm no salga nada seleccionado

        }

        private void ListarChoferesActivos()
        {
            //codigo reutilizable
            Logica.Models.Chofer MiChofer = new Logica.Models.Chofer();

            //SdListarActivos
            DataTable dt = MiChofer.ListarActivosChofer();

            //mostrar datos del dgv
            DgvListaChoferes.DataSource = dt;

        }


        private void ListarChoferesDesactivados()
        {
            Logica.Models.Chofer MiChofer = new Logica.Models.Chofer();

            //SdUsuariosListarActivos
            DataTable dt = MiChofer.ListarInactivos();

            //mostrar datos del dgv
            DgvListaChoferes.DataSource = dt;

            DgvListaChoferes.ClearSelection();

        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTelefono.Text.Trim()) &&
                CboxLicenciaChofer.SelectedIndex > -1)
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


                if (string.IsNullOrEmpty(TxtCedula.Text.Trim()))
                {
                    MessageBox.Show("La Cédula es requerida!", "Error de validación!", MessageBoxButtons.OK);
                    TxtCedula.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtEmail.Text.Trim()))
                {
                    MessageBox.Show("El Email es requerido!", "Error de validación!", MessageBoxButtons.OK);
                    TxtTelefono.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtTelefono.Text.Trim()))
                {
                    MessageBox.Show("El Teléfono es requerido!", "Error de validación!", MessageBoxButtons.OK);
                    TxtTelefono.Focus();
                    return false;
                }


                if (string.IsNullOrEmpty(TxtDireccion.Text.Trim()))
                {
                    MessageBox.Show("La dirección es requerida!", "Error de validación!", MessageBoxButtons.OK);
                    TxtTelefono.Focus();
                    return false;
                }


                if (CboxLicenciaChofer.SelectedIndex == -1)
                {
                    MessageBox.Show("El Tipo de Licencia es requerida!", "Error de validación!", MessageBoxButtons.OK);
                    CboxLicenciaChofer.Focus();
                    return false;
                }

            }

            return R;
        }


        private void ListarChoferes()
        {
            //codigo reutilizable
            Logica.Models.Chofer MiChofer = new Logica.Models.Chofer();

            //SdUsuariosListarActivos
            DataTable dt = MiChofer.ListarChoferes();

            //mostrar datos del dgv
            DgvListaChoferes.DataSource = dt;

            DgvListaChoferes.ClearSelection();

        }



        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {

                string Pregunta = string.Format("El chofer {0} va ser guardado, ¿Desea continuar?", TxtNombre.Text.Trim());

                DialogResult RespuestaDeUsuario = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if (RespuestaDeUsuario == DialogResult.Yes)
                {
                    MiChoferLocal.NombreChofer = TxtNombre.Text.Trim();
                    MiChoferLocal.EmailChofer = TxtEmail.Text.Trim();
                    MiChoferLocal.DireccionChofer = TxtDireccion.Text.Trim();
                    MiChoferLocal.CedulaChofer = TxtCedula.Text.Trim();
                    MiChoferLocal.TelefonoChofer = TxtTelefono.Text.Trim();
                    MiChoferLocal.MiLicencia.IDLicencia = Convert.ToInt32(CboxLicenciaChofer.SelectedValue);

                    bool A = MiChoferLocal.ConsultarPorCedula();

                    bool B = MiChoferLocal.ConsultarPorEmail();

                    if (!A && !B)
                    {
                        if (MiChoferLocal.Agregar())
                        {
                            MessageBox.Show("Chofer Agregado con Éxito!!", "Respuesta éxitosa", MessageBoxButtons.OK);


                        }
                        else
                        {
                            MessageBox.Show("Error al Agregar Chofer!!", "Respuesta fallida", MessageBoxButtons.OK);
                        }

                        ListarChoferesActivos();
                        LimpiarForm();
                    }
                    else
                    {

                        if (A)
                        {
                            MessageBox.Show("Ya existe un Chofer con la misma Cédula!!", "Respuesta fallida", MessageBoxButtons.OK);
                        }
                        if (B)
                        {
                            MessageBox.Show("Ya existe un Chofer con el mismo Email!!", "Respuesta fallida", MessageBoxButtons.OK);
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
            ActivarAgregar(); 
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //codigo similar al agregar
            if (ValidarDatosRequeridos())
            {

                string Pregunta = string.Format("La información del Chofer {0} va ser modificada, ¿Desea continuar?", TxtNombre.Text.Trim());

                DialogResult RespuestaDeUsuario = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if (RespuestaDeUsuario == DialogResult.Yes)
                {


                    MiChoferLocal.NombreChofer = TxtNombre.Text.Trim();
                    MiChoferLocal.EmailChofer = TxtEmail.Text.Trim();
                    MiChoferLocal.DireccionChofer = TxtDireccion.Text.Trim();
                    MiChoferLocal.CedulaChofer = TxtCedula.Text.Trim();
                    MiChoferLocal.TelefonoChofer = TxtTelefono.Text.Trim();
                    MiChoferLocal.MiLicencia.IDLicencia = Convert.ToInt32(CboxLicenciaChofer.SelectedValue);


                    if (MiChoferLocal.Editar())
                    {
                        MessageBox.Show("Chofer Modificado con Éxito!!", "Respuesta éxitosa", MessageBoxButtons.OK);
                        ListarChoferesActivos();
                        LimpiarForm();
                        ActivarAgregar();

                    }
                    else
                    {
                        MessageBox.Show("Error al Modificar Chofer!!", "Respuesta fallida", MessageBoxButtons.OK);
                    }

                }

            }
        }

        private void DgvListaChoferes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaChoferes.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgvListaChoferes.SelectedRows[0];

                int IdChoferSeleccionado = Convert.ToInt32(Fila.Cells["CIDChofer"].Value);


                MiChoferLocal = new Logica.Models.Chofer();
                MiChoferLocal = MiChoferLocal.ConsultarPorID(IdChoferSeleccionado);

                if (MiChoferLocal.IDChofer > 0)
                {
                    //se presenta la info en los controles respectivos usando el obk MiUsuarioLocal
                    //como fuente de datos

                    LimpiarForm();
                    TxtCodigo.Text = MiChoferLocal.IDChofer.ToString();
                    TxtNombre.Text = MiChoferLocal.NombreChofer;
                    TxtEmail.Text = MiChoferLocal.EmailChofer;
                    TxtCedula.Text = MiChoferLocal.CedulaChofer;
                    TxtTelefono.Text = MiChoferLocal.TelefonoChofer;
                    TxtDireccion.Text = MiChoferLocal.DireccionChofer;
                    CboxLicenciaChofer.SelectedValue = MiChoferLocal.MiLicencia.IDLicencia;

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
            if (MiChoferLocal.IDChofer > 0)
            {
                Logica.Models.Chofer ChoferConsulta = new Logica.Models.Chofer();
                ChoferConsulta = MiChoferLocal.ConsultarPorID(MiChoferLocal.IDChofer);

                if (ChoferConsulta.IDChofer > 0)
                {
                    string Mensaje = "";

                    if (CbVerActivos.Checked)
                    {
                        Mensaje = string.Format("¿Desea continuar con la eliminación del chofer {0}?", MiChoferLocal.NombreChofer);
                    }
                    else
                    {
                        Mensaje = string.Format("¿Desea continuar con la activación del chofer {0}?", MiChoferLocal.NombreChofer);
                    }

                    //string Mensaje = string.Format("¿Desea continuar con la eliminación del usuario {0}?", MiUsuarioLocal.Nombre);
                    DialogResult Resp = MessageBox.Show(Mensaje, "???", MessageBoxButtons.YesNo);

                    if (Resp == DialogResult.Yes)
                    {

                        if (CbVerActivos.Checked)
                        {
                            if (MiChoferLocal.Eliminar())
                            {
                                MessageBox.Show("Chofer eliminado con éxito", "Respuesta exitosa", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            if (MiChoferLocal.Activar())
                            {
                                MessageBox.Show("Chofer activado con éxito", "Respuesta exitosa", MessageBoxButtons.OK);
                            }

                        }
                        CbVerActivos.Checked = true;
                        ListarChoferesActivos();
                        LimpiarForm();
                        ActivarAgregar();

                    }
                }
            }
        }

        private void DgvListaChoferes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaChoferes.ClearSelection();
        }

        private void CbVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (CbVerActivos.Checked)
            {
                BtnEliminar.Text = "Eliminar";
                ListarChoferesActivos();
                LimpiarForm();
                ActivarAgregar();
            }
            else
            {
                BtnEliminar.Text = "Activar";
                ListarChoferesDesactivados();
                LimpiarForm();
                ActivarEditarYEliminar();

            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()) && !Herramientas.ValidarEmail(TxtEmail.Text.Trim()))
            {
                MessageBox.Show("El formato de email es incorrecto!", "Error de validaión", MessageBoxButtons.OK);
                TxtEmail.Focus();
                TxtEmail.SelectAll();
            }
        }

        private void FrmChoferesGestion_Load(object sender, EventArgs e)
        {
            MdiParent = ObjetosGlobales.MiFormPrincipal;

            ListarChoferesActivos();

            CargarLicenciaChofer();

            LimpiarForm();

            ActivarAgregar();
        }
    }
}
