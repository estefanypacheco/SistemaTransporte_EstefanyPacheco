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
    public partial class FrmUsuariosGestion : Form
    {


        DataTable ListaUsuarios = new DataTable();

        //atributos 
        //Objeto local
        public Logica.Models.Usuario MiUsuarioLocal { get; set; }


        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario(); // instancia
                
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {

            MdiParent = ObjetosGlobales.MiFormPrincipal;

            ListarUsuariosActivos();

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
            TxtContrasennia.Clear();
            CboxTipoUsuario.SelectedIndex = -1;
        }

        private void CargarRoldeUsuario()
        {
            Logica.Models.UsuarioRol MiUsuarioRol = new Logica.Models.UsuarioRol();

            DataTable ListaRoles = new DataTable();

            ListaRoles = MiUsuarioRol.ListarRolUsuario();

            CboxTipoUsuario.ValueMember = "id"; //no se ve graficamente
            CboxTipoUsuario.DisplayMember = "d"; //se muestra

            CboxTipoUsuario.DataSource = ListaRoles;

            CboxTipoUsuario.SelectedIndex = -1; //para que en frm no salga nada seleccionado


        }


        private void ListarUsuariosActivos()
        {
            //codigo reutilizable
            Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();

            //SdUsuariosListarActivos
            DataTable dt = MiUsuario.ListarActivos();

            //mostrar datos del dgv
            DgvListaUsuarios.DataSource = dt;

            DgvListaUsuarios.ClearSelection();

        }

        private void ListarUsuariosDesactivados()
        {
            //codigo reutilizable
            Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();

            //SdUsuariosListarActivos
            DataTable dt = MiUsuario.ListarInactivos();

            //mostrar datos del dgv
            DgvListaUsuarios.DataSource = dt;

            DgvListaUsuarios.ClearSelection();

        }


        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTelefono.Text.Trim()) &&
                CboxTipoUsuario.SelectedIndex > -1)
            {

                if (BtnEditar.Enabled)
                {
                    //si estamos editando la contra es opcional y poder retornar true acá
                    R = true;
                }
                else
                {
                    //si btn editar está apagado  es que estamos en modo agregar y debemos validar password
                    if (!string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
                    {
                        R = true;
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(TxtNombre.Text.Trim()))
                {
                    MessageBox.Show("El Nombre es requerido!", "Error de validación!", MessageBoxButtons.OK);
                    TxtNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtEmail.Text.Trim()))
                {
                    MessageBox.Show("El Email es requerido!", "Error de validación!", MessageBoxButtons.OK);
                    TxtEmail.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtCedula.Text.Trim()))
                {
                    MessageBox.Show("La Cédula es requerida!", "Error de validación!", MessageBoxButtons.OK);
                    TxtCedula.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtTelefono.Text.Trim()))
                {
                    MessageBox.Show("El Teléfono es requerido!", "Error de validación!", MessageBoxButtons.OK);
                    TxtTelefono.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
                {
                    MessageBox.Show("La Contraseña es requerida!", "Error de validación!", MessageBoxButtons.OK);
                    TxtContrasennia.Focus();
                    return false;
                }

                if (CboxTipoUsuario.SelectedIndex == -1 )
                {
                    MessageBox.Show("El Tipo de Usuario es requerido!", "Error de validación!", MessageBoxButtons.OK);
                    CboxTipoUsuario.Focus();
                    return false;
                }

            }

            return R;
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Validaciones de datos minimos
            

            if (ValidarDatosRequeridos())
            {

                string Pregunta = string.Format("El usuario {0} va ser guardado, ¿Desea continuar?", TxtNombre.Text.Trim());

                DialogResult RespuestaDeUsuario = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if (RespuestaDeUsuario == DialogResult.Yes)
                {
                    MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
                    MiUsuarioLocal.EmailUsuario = TxtEmail.Text.Trim();
                    MiUsuarioLocal.CedulaUsuario = TxtCedula.Text.Trim();
                    MiUsuarioLocal.TelefonoUsuario = TxtTelefono.Text.Trim();
                    MiUsuarioLocal.ContraseniaUsuario = TxtContrasennia.Text.Trim();
                    MiUsuarioLocal.MiRolUsuario.IDUsuarioRol = Convert.ToInt32(CboxTipoUsuario.SelectedValue);

                    bool A = MiUsuarioLocal.ConsultarPorCedula();

                    bool B = MiUsuarioLocal.ConsultarPorEmail();

                    if (!A && !B)
                    {
                        if (MiUsuarioLocal.Agregar())
                        {
                            MessageBox.Show("Usuario Agregado con Éxito!!", "Respuesta éxitosa", MessageBoxButtons.OK);
                            

                        }
                        else
                        {
                            MessageBox.Show("Error al Agregar Usuario!!", "Respuesta fallida", MessageBoxButtons.OK);
                        }

                        ListarUsuariosActivos();
                        LimpiarForm();
                    }
                    else
                    {

                        if (A)
                        {
                            MessageBox.Show("Ya existe un Usuario con la misma Cédula!!", "Respuesta fallida", MessageBoxButtons.OK);
                        }
                        if (B)
                        {
                            MessageBox.Show("Ya existe un Usuario con el mismo Email!!", "Respuesta fallida", MessageBoxButtons.OK);
                        }

                    }


                }

            }

            //LimpiarForm();

        }

        private void DgvListaUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            DgvListaUsuarios.ClearSelection();

        }

        //Validaciones de caracteres. KeyPress

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e, true);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, true);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, false, true);
        }

        private void TxtContrasennia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e);
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


        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaUsuarios.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgvListaUsuarios.SelectedRows[0];

                int IdUsuarioSeleccionado = Convert.ToInt32(Fila.Cells["CIDUsuario"].Value);
                

                MiUsuarioLocal = new Logica.Models.Usuario();
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID(IdUsuarioSeleccionado);

                if (MiUsuarioLocal.IDUsuario > 0)
                {
                    //se presenta la info en los controles respectivos usando el obk MiUsuarioLocal
                    //como fuente de datos

                    LimpiarForm();
                    TxtCodigo.Text = MiUsuarioLocal.IDUsuario.ToString();
                    TxtNombre.Text = MiUsuarioLocal.Nombre;
                    TxtEmail.Text = MiUsuarioLocal.EmailUsuario;
                    TxtCedula.Text = MiUsuarioLocal.CedulaUsuario;
                    TxtTelefono.Text = MiUsuarioLocal.TelefonoUsuario;
                    CboxTipoUsuario.SelectedValue = MiUsuarioLocal.MiRolUsuario.IDUsuarioRol;

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
            //codigo similar al agregar
            if (ValidarDatosRequeridos())
            {

                string Pregunta = string.Format("La información del usuario {0} va ser modificada, ¿Desea continuar?", TxtNombre.Text.Trim());

                DialogResult RespuestaDeUsuario = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if (RespuestaDeUsuario == DialogResult.Yes)
                {
                    MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
                    MiUsuarioLocal.EmailUsuario = TxtEmail.Text.Trim();
                    MiUsuarioLocal.CedulaUsuario = TxtCedula.Text.Trim();
                    MiUsuarioLocal.TelefonoUsuario = TxtTelefono.Text.Trim();
                    MiUsuarioLocal.ContraseniaUsuario = TxtContrasennia.Text.Trim();
                    MiUsuarioLocal.MiRolUsuario.IDUsuarioRol = Convert.ToInt32(CboxTipoUsuario.SelectedValue);


                        if (MiUsuarioLocal.Editar())
                        {
                            MessageBox.Show("Usuario Modificado con Éxito!!", "Respuesta éxitosa", MessageBoxButtons.OK);
                            ListarUsuariosActivos();
                            LimpiarForm();
                            ActivarAgregar();

                        }
                        else
                        {
                            MessageBox.Show("Error al Modificar Usuario!!", "Respuesta fallida", MessageBoxButtons.OK);
                        }
            
                }

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

        private void BtnVer_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;
        }

        private void BtnVer_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Acá se va consultar ID previamente, a diferencia de Editar() que se ejecutó directamente
            if (MiUsuarioLocal.IDUsuario > 0)
            {
                Logica.Models.Usuario UsuarioConsulta = new Logica.Models.Usuario();
                UsuarioConsulta = MiUsuarioLocal.ConsultarPorID(MiUsuarioLocal.IDUsuario);

                if (UsuarioConsulta.IDUsuario > 0)
                {
                    string Mensaje = "";

                    if (CbVerActivos.Checked)
                    {
                         Mensaje = string.Format("¿Desea continuar con la eliminación del usuario {0}?", MiUsuarioLocal.Nombre);
                    }
                    else
                    {
                         Mensaje = string.Format("¿Desea continuar con la activación del usuario {0}?", MiUsuarioLocal.Nombre);
                    }

                    //string Mensaje = string.Format("¿Desea continuar con la eliminación del usuario {0}?", MiUsuarioLocal.Nombre);
                    DialogResult Resp = MessageBox.Show(Mensaje, "???", MessageBoxButtons.YesNo);

                    if (Resp == DialogResult.Yes)
                    {

                        if (CbVerActivos.Checked)
                        {
                            if (MiUsuarioLocal.Eliminar())
                            {
                                MessageBox.Show("Usuario Eliminado con éxito", "Respuesta exitosa", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            if (MiUsuarioLocal.Activar())
                            {
                                MessageBox.Show("Usuario Activado con éxito", "Respuesta exitosa", MessageBoxButtons.OK);
                            }

                        }
                            CbVerActivos.Checked = true;
                            ListarUsuariosActivos();
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
                ListarUsuariosActivos();
                LimpiarForm();
                ActivarAgregar();
            }
            else
            {
                BtnEliminar.Text = "Activar";
                ListarUsuariosDesactivados();
                LimpiarForm();
                ActivarEditarYEliminar();

            }
        }

        private void BuscarUsuario(string Filtro = "")
        {

            ListaUsuarios = new DataTable();

            ListaUsuarios = MiUsuarioLocal.BuscarUsuario(true, Filtro);

            DgvListaUsuarios.DataSource = ListaUsuarios;

            DgvListaUsuarios.ClearSelection();

        }


        private void TrmBuscar_Tick(object sender, EventArgs e)
        {
            TrmBuscar.Enabled = false;

            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                string Filtro = TxtBuscar.Text.Trim();

                BuscarUsuario(Filtro);

            }
            else
            {

                BuscarUsuario();
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
