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
    public partial class FrmClientesGestion : Form
    {

        public Logica.Models.Cliente MiClienteLocal { get; set; }

        public FrmClientesGestion()
        {
            InitializeComponent();
            MiClienteLocal = new Logica.Models.Cliente();
        }


        private void FrmClientesGestion_Load(object sender, EventArgs e)
        {


            MdiParent = ObjetosGlobales.MiFormPrincipal;

            ListarClientesActivos();

            CargarRoldeUsuario();

            LimpiarForm();

            ActivarAgregar();
        }

        private void LimpiarForm()
        {
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtEmail.Clear();
            TxtCedula.Clear();
            TxtTelefono.Clear();
            TxtDireccion.Clear();
            CboxTipoCliente.SelectedIndex = -1;
        }

        private void CargarRoldeUsuario()
        {
            Logica.Models.ClienteTipo MiClienteTipo = new Logica.Models.ClienteTipo();

            DataTable ListaTipos = new DataTable();

            ListaTipos = MiClienteTipo.ListarTipoCliente();

            CboxTipoCliente.ValueMember = "id"; //no se ve graficamente
            CboxTipoCliente.DisplayMember = "d"; //se muestra

            CboxTipoCliente.DataSource = ListaTipos;

            CboxTipoCliente.SelectedIndex = -1; //para que en frm no salga nada seleccionado

        }


        private void ListarClientesActivos()
        {
            //codigo reutilizable
            Logica.Models.Cliente MiCliente = new Logica.Models.Cliente();

            //SdListarActivos
            DataTable dt = MiCliente.ListarClienteActivo();

            //mostrar datos del dgv
            DgvListaClientes.DataSource = dt;

        }


        private void ListarClientesDesactivados()
        {
            //codigo reutilizable
            Logica.Models.Cliente MiCliente = new Logica.Models.Cliente();

            //SdUsuariosListarActivos
            DataTable dt = MiCliente.ListarInactivos();

            //mostrar datos del dgv
            DgvListaClientes.DataSource = dt;

            DgvListaClientes.ClearSelection();

        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTelefono.Text.Trim()) &&
                CboxTipoCliente.SelectedIndex > -1) 
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


                if (CboxTipoCliente.SelectedIndex == -1)
                {
                    MessageBox.Show("El Tipo de Cliente es requerido!", "Error de validación!", MessageBoxButtons.OK);
                    CboxTipoCliente.Focus();
                    return false;
                }

            }

            return R;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {

                string Pregunta = string.Format("El cliente {0} va ser guardado, ¿Desea continuar?", TxtNombre.Text.Trim());

                DialogResult RespuestaDeUsuario = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if (RespuestaDeUsuario == DialogResult.Yes)
                {
                    MiClienteLocal.NombreCliente = TxtNombre.Text.Trim();
                    MiClienteLocal.EmailCliente = TxtEmail.Text.Trim();
                    MiClienteLocal.DireccionCliente = TxtDireccion.Text.Trim();
                    MiClienteLocal.CedulaCliente = TxtCedula.Text.Trim();
                    MiClienteLocal.TelefonoCliente = TxtTelefono.Text.Trim();
                    MiClienteLocal.MiTipoCliente.IDClienteTipo = Convert.ToInt32(CboxTipoCliente.SelectedValue);

                    bool A = MiClienteLocal.ConsultarPorCedula();

                    bool B = MiClienteLocal.ConsultarPorEmail();

                    if (!A && !B)
                    {
                        if (MiClienteLocal.Agregar())
                        {
                            MessageBox.Show("Cliente Agregado con Éxito!!", "Respuesta éxitosa", MessageBoxButtons.OK);


                        }
                        else
                        {
                            MessageBox.Show("Error al Agregar Cliente!!", "Respuesta fallida", MessageBoxButtons.OK);
                        }

                        ListarClientesActivos();
                        LimpiarForm();
                    }
                    else
                    {

                        if (A)
                        {
                            MessageBox.Show("Ya existe un Cliente con la misma Cédula!!", "Respuesta fallida", MessageBoxButtons.OK);
                        }
                        if (B)
                        {
                            MessageBox.Show("Ya existe un Cliente con el mismo Email!!", "Respuesta fallida", MessageBoxButtons.OK);
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            string Pregunta = string.Format("La información del cliente {0} va ser modificada, ¿Desea continuar?", TxtNombre.Text.Trim());

            DialogResult RespuestaDeUsuario = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

            if (RespuestaDeUsuario == DialogResult.Yes)
            {

                MiClienteLocal.NombreCliente = TxtNombre.Text.Trim();
                MiClienteLocal.EmailCliente = TxtEmail.Text.Trim();
                MiClienteLocal.TelefonoCliente = TxtTelefono.Text.Trim();
                MiClienteLocal.CedulaCliente = TxtCedula.Text.Trim();
                MiClienteLocal.DireccionCliente = TxtDireccion.Text.Trim();
                MiClienteLocal.MiTipoCliente.IDClienteTipo = Convert.ToInt32(CboxTipoCliente.SelectedValue);



                if (MiClienteLocal.Editar())
                {
                    MessageBox.Show("Cliente Modificado con Éxito!!", "Respuesta éxitosa", MessageBoxButtons.OK);
                    ListarClientesActivos();
                    LimpiarForm();
                    ActivarAgregar();

                }
                else
                {
                    MessageBox.Show("Error al Modificar Cliente!!", "Respuesta fallida", MessageBoxButtons.OK);
                }

            }
        }

        private void DgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaClientes.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgvListaClientes.SelectedRows[0];

                int IdClienteSeleccionado = Convert.ToInt32(Fila.Cells["CIDCliente"].Value);


                MiClienteLocal = new Logica.Models.Cliente();
                MiClienteLocal = MiClienteLocal.ConsultarPorID(IdClienteSeleccionado);

                if (MiClienteLocal.IDCliente > 0)
                {
                    //se presenta la info en los controles respectivos usando el obk MiUsuarioLocal
                    //como fuente de datos

                    LimpiarForm();
                    TxtCodigo.Text = MiClienteLocal.IDCliente.ToString();
                    TxtNombre.Text = MiClienteLocal.NombreCliente;
                    TxtEmail.Text = MiClienteLocal.EmailCliente;
                    TxtCedula.Text = MiClienteLocal.CedulaCliente;
                    TxtTelefono.Text = MiClienteLocal.TelefonoCliente;
                    TxtDireccion.Text = MiClienteLocal.DireccionCliente;
                    CboxTipoCliente.SelectedValue = MiClienteLocal.MiTipoCliente.IDClienteTipo;

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
            if (MiClienteLocal.IDCliente > 0)
            {
                Logica.Models.Cliente ClienteConsulta = new Logica.Models.Cliente();
                ClienteConsulta = MiClienteLocal.ConsultarPorID(MiClienteLocal.IDCliente);

                if (ClienteConsulta.IDCliente > 0)
                {
                    string Mensaje = "";

                    if (CbVerActivos.Checked)
                    {
                        Mensaje = string.Format("¿Desea continuar con la eliminación del cliente {0}?", MiClienteLocal.NombreCliente);
                    }
                    else
                    {
                        Mensaje = string.Format("¿Desea continuar con la activación del cliente {0}?", MiClienteLocal.NombreCliente);
                    }

                    //string Mensaje = string.Format("¿Desea continuar con la eliminación del usuario {0}?", MiUsuarioLocal.Nombre);
                    DialogResult Resp = MessageBox.Show(Mensaje, "???", MessageBoxButtons.YesNo);

                    if (Resp == DialogResult.Yes)
                    {

                        if (CbVerActivos.Checked)
                        {
                            if (MiClienteLocal.Eliminar())
                            {
                                MessageBox.Show("Cliente eliminado con éxito", "Respuesta exitosa", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            if (MiClienteLocal.Activar())
                            {
                                MessageBox.Show("Cliente activado con éxito", "Respuesta exitosa", MessageBoxButtons.OK);
                            }

                        }
                        CbVerActivos.Checked = true;
                        ListarClientesActivos();
                        LimpiarForm();
                        ActivarAgregar();

                    }
                }
            }
        }

        private void DgvListaClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaClientes.ClearSelection();
        }

        private void CbVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (CbVerActivos.Checked)
            {
                BtnEliminar.Text = "Eliminar";
                ListarClientesActivos();
                LimpiarForm();
                ActivarAgregar();
            }
            else
            {
                BtnEliminar.Text = "Activar";
                ListarClientesDesactivados();
                LimpiarForm();
                ActivarEditarYEliminar();

            }
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarAgregar(); //que tan necesario?
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
    }
}