using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public string TelefonoCliente { get; set; }
        public string EmailCliente { get; set; }
        public string DireccionCliente { get; set; }
        public bool ActivoCliente { get; set; }

        //Atributo Compuesto
        public ClienteTipo MiTipoCliente { get; set; }

        //constructor de la clase para instanciar el atributo compuesto simple
        public Cliente()
        {
            //instanciar objetos compuestos

            MiTipoCliente = new ClienteTipo();


        }

        //Operaciones de la clase: BÁSICOS

        //AGREGAR
        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn3 = new Conexion();

            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.NombreCliente));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.CedulaCliente));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.TelefonoCliente));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Email", this.EmailCliente));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Direccion", this.DireccionCliente));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@IDClienteTipo", this.MiTipoCliente.IDClienteTipo));

            int CantidadRegistrosAfectados = MiCnn3.HacerDML("SPClientesAgregar");

            if (CantidadRegistrosAfectados > 0)
            {
                R = true;
            }


            return R;

        }


        public Cliente ConsultarPorID(int pIdCliente)
        {
            Cliente R = new Cliente();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Id", pIdCliente));

            DataTable DatosDeUsuario = new DataTable();

            DatosDeUsuario = MiCnn.HacerSelect("SPClientesConsultarPorID");

            if (DatosDeUsuario != null && DatosDeUsuario.Rows.Count > 0)
            {
                DataRow MisDatos = DatosDeUsuario.Rows[0];

                R.IDCliente = Convert.ToInt32(MisDatos["IDCliente"]);
                R.NombreCliente = Convert.ToString(MisDatos["NombreCliente"]);
                R.EmailCliente = Convert.ToString(MisDatos["EmailCliente"]);
                R.CedulaCliente = Convert.ToString(MisDatos["CedulaCliente"]);
                R.TelefonoCliente = Convert.ToString(MisDatos["TelefonoCliente"]);
                R.DireccionCliente = Convert.ToString(MisDatos["DireccionCliente"]);
                R.ActivoCliente = Convert.ToBoolean(MisDatos["ActivoCliente"]);

                R.MiTipoCliente.IDClienteTipo = Convert.ToInt32(MisDatos["IDClienteTipo"]);
                R.MiTipoCliente.TipoCliente = Convert.ToString(MisDatos["NombreClienteTipo"]);


            }

            return R;

        }


        public bool Activar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@id", IDCliente));

            int Resultado = MiCnn.HacerDML("SPClientesActivar");

            if (Resultado > 0)
            {
                R = true;
            }

            return R;

        }

        //EDITAR
        public bool Editar()
        {
            bool R = false;


            Cliente clienteConsulta = new Cliente();

            clienteConsulta = ConsultarPorID(this.IDCliente);

            if (clienteConsulta.IDCliente > 0)
            {
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Id", this.IDCliente));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.NombreCliente));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.CedulaCliente));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.TelefonoCliente));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Email", this.EmailCliente));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Direccion", this.DireccionCliente));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IDClienteTipo", this.MiTipoCliente.IDClienteTipo));

                int Resultado = MyCnn.HacerDML("SPClientesEditar");

                if (Resultado > 0)
                {
                    R = true;
                }
            }

            return R;
        }

        //ELIMINAR (DESACTIVAR)
        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@id", IDCliente));

            int Resultado = MiCnn.HacerDML("SPClientesDesactivar");

            if (Resultado > 0)
            {
                R = true;
            }

            return R;

        }



        //LISTAR
        public DataTable ListarClienteActivo(bool VerActivos = true)
        {

            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPClientesListarActivos");

            return R;
        }

        public DataTable BuscarCliente(bool VerActivos = true, string Filtro = "")
        {

            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.HacerSelect("SPClientesBuscar");

            return R;
        }


        public bool ConsultarPorEmail()
        {
            bool R = false;

            Conexion MiCnn2 = new Conexion();

            //se agregan los params SP requiere
            MiCnn2.ListadoDeParametros.Add(new SqlParameter("@Email", this.EmailCliente));

            DataTable Consulta = MiCnn2.HacerSelect("SPClientesConsultarPorEmail");

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
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.CedulaCliente));

            DataTable Consulta = MiCnn.HacerSelect("SPClientesConsultarPorCedula");

            if (Consulta.Rows.Count > 0)
            {
                R = true;
            }


            return R;

        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPClientesListarInactivos");

            return R;
        }

        public DataTable BuscarClienteform(bool VerActivos = true, string Filtro = "")
        {

            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.HacerSelect("SPClientesBuscarForm");

            return R;
        }











    }
}
