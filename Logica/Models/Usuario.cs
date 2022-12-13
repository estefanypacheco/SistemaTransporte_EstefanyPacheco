using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {

        //Atributos Simples con forma simplificada
        public int IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string TelefonoUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string ContraseniaUsuario { get; set; }
        public string CedulaUsuario { get; set; }
        public string CodigoVerificacion { get; set; }
        public bool ActivoCliente { get; set; }

        //Atributo Compuesto
        public UsuarioRol MiRolUsuario { get; set; }

        //constructor de la clase para instanciar el atributo compuesto simple
        public Usuario()
        {
            //instanciar objetos compuestos

            MiRolUsuario = new UsuarioRol();

        }


        public bool ValidarCodigosDeVerificacion()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            Encriptador MiEncriptador = new Encriptador();

            string PassEncriptado = MiEncriptador.EncriptarPassword(this.ContraseniaUsuario);

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Correo", this.EmailUsuario));

            DataTable Resultado = MiCnn.HacerSelect("SPUsuarioConsultarCodigoVerificacion");

            if (Resultado.Rows.Count > 0)
            {
                DataRow fila1 = Resultado.Rows[0];

                string CVerif = fila1["CV"].ToString();

                if (CVerif != "N" && CVerif == this.CodigoVerificacion)
                {

                    R = true;
                }

            }

            return R;
        }

        public bool GuardarCodigoVerificacion()
        {
            bool R = false;
            Conexion MiCnn2 = new Conexion();

            MiCnn2.ListadoDeParametros.Add(new SqlParameter("@EmailUsuario", this.EmailUsuario));
            MiCnn2.ListadoDeParametros.Add(new SqlParameter("@CodigoVerificacion", this.CodigoVerificacion));

            int CantidadRegistrosAfectados = MiCnn2.HacerDML("SPUsuarioGuardarCodigoVerificacion");

            if (CantidadRegistrosAfectados > 0)
            {
                R = true;
            }

            return R;
        }

        public bool CambiarPassword()
        {
            bool R = false;
            Conexion MiCnn2 = new Conexion();

            string PasswordEncriptado = string.Empty;


            if (!string.IsNullOrEmpty((this.ContraseniaUsuario)))
            {
                Encriptador MiEncriptador = new Encriptador();
                PasswordEncriptado = MiEncriptador.EncriptarPassword(this.ContraseniaUsuario);
            }

            MiCnn2.ListadoDeParametros.Add(new SqlParameter("@EmailUsuario", this.EmailUsuario));

            MiCnn2.ListadoDeParametros.Add(new SqlParameter("@Contrasennia", PasswordEncriptado));

            int CantidadRegistrosAfectados = MiCnn2.HacerDML("SPUsuarioModificarPassword");

            if (CantidadRegistrosAfectados > 0)
            {
                R = true;
            }

            return R;
        }

        //Operaciones de la clase: BÁSICOS

        //AGREGAR
        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn3 = new Conexion();

            Encriptador MiEncriptador = new Encriptador();

            //encriptar contraseña
            string PasswordEncriptado = MiEncriptador.EncriptarEnUnSentido(this.ContraseniaUsuario);


            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.TelefonoUsuario));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Email", this.EmailUsuario));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Contrasennia", PasswordEncriptado));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.CedulaUsuario));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@IDUsuarioRol", this.MiRolUsuario.IDUsuarioRol));

            int CantidadRegistrosAfectados = MiCnn3.HacerDML("SPUsuariosAgregar");

            if (CantidadRegistrosAfectados > 0)
            {
                R = true;
            }


            return R;

        }

        //EDITAR
        public bool Editar()
        {
            bool R = false;


            Usuario usuarioConsulta = new Usuario();

            usuarioConsulta = ConsultarPorID(this.IDUsuario);

            if (usuarioConsulta.IDUsuario > 0)
            {
                Conexion MyCnn = new Conexion();

                string PasswordEncriptado = string.Empty; //

                if (!string.IsNullOrEmpty(this.ContraseniaUsuario))
                {
                    Encriptador MiEncriptador = new Encriptador();
                    PasswordEncriptado = MiEncriptador.EncriptarEnUnSentido(this.ContraseniaUsuario);

                }

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@id", this.IDUsuario));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@nombre", this.Nombre));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@telefono", this.TelefonoUsuario));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@email", this.EmailUsuario));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@contrasennia", PasswordEncriptado));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@cedula", this.CedulaUsuario));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@idUsuarioRol", this.MiRolUsuario.IDUsuarioRol));

                int Resultado = MyCnn.HacerDML("SPUsuariosEditar");

                if (Resultado > 0)
                {
                    R = true;
                }
            }

            return R;
        }

        public bool Activar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@id", IDUsuario));

            int Resultado = MiCnn.HacerDML("SPUsuariosActivar");

            if (Resultado > 0)
            {
                R = true;
            }

            return R;

        }

        //ELIMINAR (DESACTIVAR)
        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@id", IDUsuario));

            int Resultado = MiCnn.HacerDML("SPUsuariosDesactivar");

            if (Resultado > 0) 
            {
                R = true;
            }

            return R;

        }



        public Usuario ConsultarPorID(int pIdUsuario)
        {
            Usuario R = new Usuario();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@id", pIdUsuario));

            DataTable DatosDeUsuario = new DataTable();

            DatosDeUsuario = MiCnn.HacerSelect("SPUsuariosConsultarPorID");

            if (DatosDeUsuario != null && DatosDeUsuario.Rows.Count > 0)
            {
                DataRow MisDatos = DatosDeUsuario.Rows[0];

                R.IDUsuario = Convert.ToInt32(MisDatos["IDUsuario"]);
                R.Nombre= Convert.ToString(MisDatos["Nombre"]);
                R.EmailUsuario = Convert.ToString(MisDatos["EmailUsuario"]);
                R.CedulaUsuario = Convert.ToString(MisDatos["CedulaUsuario"]);
                R.TelefonoUsuario = Convert.ToString(MisDatos["TelefonoUsuario"]);
                R.ContraseniaUsuario = Convert.ToString(MisDatos["Contrasennia"]);
                R.ActivoCliente = Convert.ToBoolean(MisDatos["ActivoUsuario"]);

                R.MiRolUsuario.IDUsuarioRol = Convert.ToInt32(MisDatos["IDUsuarioRol"]);
                R.MiRolUsuario.RolUsuario = Convert.ToString(MisDatos["UsuarioRol"]);


            }

            return R;

        }


        public Usuario ValidarIngreso(string pUsuario, string pContrasennia)
        {
            Usuario R = new Usuario();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@EmailUsuario", pUsuario));


            Encriptador MiEncriptador = new Encriptador();
            string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(pContrasennia);

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Contrasennia", ContrasenniaEncriptada));

            DataTable DatosDeUsuario = new DataTable();

            DatosDeUsuario = MiCnn.HacerSelect("SPUsuariosValidarIngreso");

            if (DatosDeUsuario != null && DatosDeUsuario.Rows.Count > 0)
            {
                DataRow MisDatos = DatosDeUsuario.Rows[0];

                R.IDUsuario = Convert.ToInt32(MisDatos["IDUsuario"]);
                R.Nombre = Convert.ToString(MisDatos["Nombre"]);
                R.EmailUsuario = Convert.ToString(MisDatos["EmailUsuario"]);
                R.CedulaUsuario = Convert.ToString(MisDatos["CedulaUsuario"]);
                R.TelefonoUsuario = Convert.ToString(MisDatos["TelefonoUsuario"]);
                R.ContraseniaUsuario = Convert.ToString(MisDatos["Contrasennia"]);
                R.ActivoCliente = Convert.ToBoolean(MisDatos["ActivoUsuario"]);
                R.MiRolUsuario.IDUsuarioRol = Convert.ToInt32(MisDatos["IDUsuarioRol"]);
                R.MiRolUsuario.RolUsuario = Convert.ToString(MisDatos["UsuarioRol"]);


            }

            return R;

        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

            Conexion MiCnn2 = new Conexion();

            //se agregan los params SP requiere
            MiCnn2.ListadoDeParametros.Add(new SqlParameter("@Email", this.EmailUsuario));

            DataTable Consulta = MiCnn2.HacerSelect("SPUsuariosConsultarPorEmail");

            if (Consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;

        }


        public bool ConsultarPorCedula()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            //se agregan los params SP requiere
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.CedulaUsuario));

            DataTable Consulta = MiCnn.HacerSelect("SPUsuariosConsultarPorCedula");

            if (Consulta.Rows.Count > 0)
            {
                R = true;
            }


            return R;

        }

        //LISTAR
        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SpUsuariosListarActivos");

            return R;
        }





        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPUsuariosListarInactivos");

            return R;
        }

        public DataTable BuscarUsuario(bool VerActivos = true, string Filtro = "")
        {

            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.HacerSelect("SPUsuariosBuscar");

            return R;
        }

    }
}
