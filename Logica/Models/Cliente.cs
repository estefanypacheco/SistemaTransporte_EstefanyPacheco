using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Cliente
    {

        //Atributos Simples con forma simplificada
        public int IDCliente { get; set; }
        public string NombreCliente { get; set; }
        public string CedulaCliente { get; set; }
        public int TelefonoCliente { get; set; }
        public string EmailCliente { get; set; }
        public string DireccionCliente { get; set; }
        public bool ActivoCliente { get; set; }

        //Atributo Compuesto
        ClienteTipo MiTipoCliente { get; set; }

        //constructor de la clase para instanciar el atributo compuesto simple
        public Cliente()
        {
            //instanciar objetos compuestos

            MiTipoCliente = new ClienteTipo();


        }

        //Operaciones de la clase: BÁSICOS

        //AGREGAR
        public bool Agregar(string pNombre, string pCedula, int pTelefono, string pEmail  = "", string pDireccion = "" )
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
        public bool Editar(int pIDCliente, string pNombre, string pCedula, int pTelefono, string pEmail = "", string pDireccion = "")
        {
            bool R = false;



            return R;
        }

        //ELIMINAR (DESACTIVAR)
        public bool Eliminar(int pIDCliente)
        {
            bool R = false;



            return R;

        }


        //CONSULTAR POR: (3 opciones)
        public bool ConsultarPorID(int pIDCliente)
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
        public DataTable ListarClienteActivo(bool VerActivos = true)
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable ListarClienteInactivo(bool VerActivos = false)
        {
            DataTable R = new DataTable();

            return R;
        }













    }
}
