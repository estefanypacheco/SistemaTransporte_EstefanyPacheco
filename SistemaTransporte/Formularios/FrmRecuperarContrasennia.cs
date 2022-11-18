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
    public partial class FrmRecuperarContrasennia : Form
    {

        bool CorreoEnviadoOk { get; set; }

        public FrmRecuperarContrasennia()
        {
            InitializeComponent();
            CorreoEnviadoOk = false;
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();

            this.Hide();
        }


        private bool UsuarioExiste()
        {
            bool R = false;

            Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();

            MiUsuario.EmailUsuario = txtEmail.Text.Trim();

            bool UsuarioExiste = MiUsuario.ConsultarPorEmail();

            if (UsuarioExiste)
            {
                R = true;
            }

            return R;
        }

        private void Limpiar()
        {
            btnAceptar.Enabled = false;
            txtCodigo.Enabled = false;
            txtNuevaContra.Enabled = false;
            txtConfirmarContra.Enabled = false;
            txtNuevaContra.Text = "";
            txtConfirmarContra.Text = "";
            txtCodigo.Text = "";
        }


        private bool ValidarDatos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(txtCodigo.Text.Trim()) &&
                !string.IsNullOrEmpty(txtNuevaContra.Text.Trim()) &&
                !string.IsNullOrEmpty(txtConfirmarContra.Text.Trim()))
            {
                if ((txtNuevaContra.Text.Trim() == txtConfirmarContra.Text.Trim()) &&
                    ObjetosGlobales.MiUsuarioGlobal.CodigoVerificacion == txtCodigo.Text.Trim())
                {
                    R = true;
                }
                if (string.IsNullOrEmpty(txtConfirmarContra.Text.Trim()))
                {
                    MessageBox.Show("Debes indicar el Código de Verificación!", "Error de Validación!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmarContra.Focus();
                    return false;
                }
                if (ObjetosGlobales.MiUsuarioGlobal.CodigoVerificacion != txtCodigo.Text.Trim())
                {
                    MessageBox.Show("El Código de Verificación escrito es Incorrecto!", "Error de Validación!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.SelectAll();
                    txtCodigo.Focus();
                    return false;
                }
                if (txtNuevaContra.Text.Trim() != txtConfirmarContra.Text.Trim())
                {
                    MessageBox.Show("Las Contraseñas no coinciden!", "Error de Validación!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNuevaContra.SelectAll();
                    txtConfirmarContra.SelectAll();
                    return false;
                }
            }

            return R;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {


            CorreoEnviadoOk = false;

            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()) && UsuarioExiste())
            {
                btnEnviar.Enabled = true;

                Logica.Models.GestionEmail MiEmail = new Logica.Models.GestionEmail();
                Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();

                MiUsuario.EmailUsuario = txtEmail.Text.Trim();

                Random rdn = new Random();

                string CodigoVerificacion = "ABCDEFGHJKLMNOPQRSTUVWXYZ1234567890";

                int longitud = CodigoVerificacion.Length;

                char letra;

                string codigoAleatorio = string.Empty;

                for (int i = 0; i < 8; i++)
                {
                    letra = CodigoVerificacion[rdn.Next(longitud)];
                    codigoAleatorio += letra.ToString();
                }

                CodigoVerificacion = codigoAleatorio;

                MiUsuario.CodigoVerificacion = CodigoVerificacion;

                ObjetosGlobales.MiUsuarioGlobal.CodigoVerificacion = CodigoVerificacion;

                if (MiUsuario.GuardarCodigoVerificacion())
                {
                    MiEmail.Asunto = "REESTABLECER CONTRASEÑA DE USUARIO DEL SISTEMA";
                    MiEmail.CorreoDestino = MiUsuario.EmailUsuario;

                    string Mensaje = string.Format("Sistema Transportes - Su Código secreto de Recuperación es: {0}", CodigoVerificacion);

                    MiEmail.Mensaje = Mensaje;

                }

                if (MiEmail.EnviarCorreo_Net_Mail_SmtpClient())
                {
                    CorreoEnviadoOk = true;
                    MessageBox.Show("Correo de Verificación enviado correctamente!," +
                        " ahora ingrese el Código enviado a su Correo!",
                        "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo.Enabled = true;
                    txtNuevaContra.Enabled = true;
                    txtConfirmarContra.Enabled = true;
                    btnAceptar.Enabled = true;
                    txtCodigo.Focus();
                }
            }
            else
            {
                if (!UsuarioExiste())
                {
                    MessageBox.Show("El Correo indicado no pertenece a ningún Usuario!", "Error de Validación!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                if (!Herramientas.ValidarEmail(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("El Email no tiene formato correcto!", "Error de validación!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnEnviar.Enabled = false;
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                }
                else
                {
                    btnEnviar.Enabled = true;
                }
            }
            else
            {
                btnEnviar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (CorreoEnviadoOk && ValidarDatos())
            {
                Logica.Models.Usuario ObjUsuario = new Logica.Models.Usuario();

                ObjUsuario.EmailUsuario = txtEmail.Text.Trim();
                ObjUsuario.ContraseniaUsuario = txtNuevaContra.Text.Trim();

                ObjUsuario.CodigoVerificacion = txtCodigo.Text.Trim();

                if (ObjUsuario.ValidarCodigosDeVerificacion())
                {
                    if (ObjUsuario.GuardarCodigoVerificacion())
                    {
                        ObjUsuario.CodigoVerificacion = "";
                        ObjUsuario.GuardarCodigoVerificacion();

                        MessageBox.Show("La Contraseña se ha cambiado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        this.Hide();
                    }
                }
            }
        }
    }
}
