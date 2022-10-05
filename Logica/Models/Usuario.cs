using System;
using System.Collections.Generic;
using System.Data;
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
        public string NombreUsuario { get; set; }
        public int TelefonoUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string ContraseniaUsuario { get; set; }
        public string CedulaUsuario { get; set; }
        public string CodigoVerificacion { get; set; }
        public bool ActivoCliente { get; set; }

        //Atributo Compuesto
        UsuarioRol MiRolUsuario { get; set; }

        //constructor de la clase para instanciar el atributo compuesto simple
        public Usuario()
        {
            //instanciar objetos compuestos

            MiRolUsuario = new UsuarioRol();

        }

        //Operaciones de la clase: BÁSICOS

        //AGREGAR
        public bool Agregar(string pNombre, string pNombreUsuario, int pTelefono, string pEmail, string contrasennia,
            string pCedula, string pCodigoVerificacion)
        {
            bool R = false;

            NombreCliente = pNombre;
            CedulaCliente = pCedula;
            TelefonoCliente = pTelefono;
            EmailCliente = pEmail;
            DireccionCliente = pDireccion;

            return R;

        }

        //EDITAR
        public bool Editar(int pIDUsuario, string pNombre, string pNombreUsuario, int pTelefono, string pEmail, string contrasennia,
            string pCedula, string pCodigoVerificacion)
        {
            bool R = false;



            return R;
        }

        //ELIMINAR (DESACTIVAR)
        public bool Eliminar(int pIDUsuario)
        {
            bool R = false;



            return R;

        }


        //CONSULTAR POR: (3 opciones)
        public bool ConsultarPorID(int pIDUsuario)
        {
            bool R = false;

            return R;

        }


        public bool ConsultarPorNombre(string pNombre)
        {
            bool R = false;

            return R;

        }

        public bool ConsultarPorCedula(string pCedula)
        {
            bool R = false;

            return R;

        }

        //LISTAR
        public DataTable ListarUsuarioActivo(bool VerActivos = true)
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable ListarUsuarioInactivo(bool VerActivos = false)
        {
            DataTable R = new DataTable();

            return R;
        }


        public DataTable ListarUsuarioPorFiltro(string pNombre)
        {
            DataTable R = new DataTable();

            return R;
        }

    }
}
