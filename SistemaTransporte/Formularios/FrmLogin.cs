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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void BtnAccesoRapido_Click(object sender, EventArgs e)
        {
            ObjetosGlobales.MiFormPrincipal.Show();
            this.Hide();
        }

        private void PbVerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;
        }

        private void PbVerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true;
        }


        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtCorreo.Text.Trim()) && 
                !string.IsNullOrEmpty(TxtContrasennia.Text.Trim()) &&
                Herramientas.ValidarEmail(TxtCorreo.Text.Trim()))
            {
                R = true;
            }
            else
            {


                if (string.IsNullOrEmpty(TxtCorreo.Text.Trim()))
                {
                    MessageBox.Show("Falta el email del usuario.", "Error de validación", MessageBoxButtons.OK);
                    TxtCorreo.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
                {
                    MessageBox.Show("Falta la contraseña del usuario.", "Error de validación", MessageBoxButtons.OK);
                    TxtContrasennia.Focus();
                    return false;
                }

                if (!Herramientas.ValidarEmail(TxtCorreo.Text.Trim()))
                {
                    MessageBox.Show("El formato de Email no está correcto.", "Error de validación", MessageBoxButtons.OK);
                    TxtCorreo.Focus();
                    TxtCorreo.SelectAll();
                    return false;
                }

            }


            return R;

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();

                string user = TxtCorreo.Text.Trim();
                string password = TxtContrasennia.Text.Trim();

                ObjetosGlobales.MiUsuarioGlobal = MiUsuario.ValidarIngreso(user, password);

                if (ObjetosGlobales.MiUsuarioGlobal != null &&
                    ObjetosGlobales.MiUsuarioGlobal.IDUsuario > 0)
                {
                    ObjetosGlobales.MiFormPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email o contraseña incorrectos", "Error de validación", MessageBoxButtons.OK);
                    TxtContrasennia.Focus();
                    TxtContrasennia.SelectAll();
                }
                


            }




        }

        private void LblRecuperarContrasennia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ObjetosGlobales.FrmRecuperarContrasennia.Show();

            if (!string.IsNullOrEmpty(TxtCorreo.Text.Trim()))
            {
                ObjetosGlobales.FrmRecuperarContrasennia.txtEmail.Text = TxtCorreo.Text.Trim();
            }
        }
    }
}
