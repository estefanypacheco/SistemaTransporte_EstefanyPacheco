using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
     public class Chofer
    {
        public int IDChofer { get; set; }
        public string NombreChofer { get; set; }
        public string CedulaChofer { get; set; }
        public string TelefonoChofer { get; set; }
        public string DireccionChofer { get; set; }
        public string EmailChofer { get; set; }
        public bool ActivoChofer { get; set; }

        //Atributo Compuesto
        public ChoferLicencia MiLicencia { get; set; }

        //constructor de la clase para instanciar el atributo compuesto simple
        public Chofer()
        {
            //instanciar objetos compuestos
            MiLicencia = new ChoferLicencia();
        }

        //AGREGAR
        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn3 = new Conexion();

            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.NombreChofer));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.TelefonoChofer));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Email", this.EmailChofer));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Direccion", this.DireccionChofer));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.CedulaChofer));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@IDLicencia", this.MiLicencia.IDLicencia));

            int CantidadRegistrosAfectados = MiCnn3.HacerDML("SPChoferesAgregar");

            if (CantidadRegistrosAfectados > 0)
            {
                R = true;
            }

            return R;

        }


        public Chofer ConsultarPorID(int pIdChofer)
        {
            Chofer R = new Chofer();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Id", pIdChofer));

            DataTable DatosDeChofer = new DataTable();

            DatosDeChofer = MiCnn.HacerSelect("SPChoferesConsultarPorID");

            if (DatosDeChofer != null && DatosDeChofer.Rows.Count > 0)
            {
                DataRow MisDatos = DatosDeChofer.Rows[0];

                R.IDChofer = Convert.ToInt32(MisDatos["IDChofer"]);
                R.NombreChofer = Convert.ToString(MisDatos["NombreChofer"]);
                R.EmailChofer = Convert.ToString(MisDatos["EmailChofer"]);
                R.CedulaChofer = Convert.ToString(MisDatos["CedulaChofer"]);
                R.TelefonoChofer = Convert.ToString(MisDatos["TelefonoChofer"]);
                R.DireccionChofer = Convert.ToString(MisDatos["DireccionChofer"]);
                R.ActivoChofer = Convert.ToBoolean(MisDatos["ActivoChofer"]);

                R.MiLicencia.IDLicencia = Convert.ToInt32(MisDatos["IDLicencia"]);
                R.MiLicencia.TipoLicencia = Convert.ToString(MisDatos["TipoLicencia"]);


            }

            return R;

        }



        public bool Activar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@id", IDChofer));

            int Resultado = MiCnn.HacerDML("SPChoferActivar");

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


            Chofer choferConsulta = new Chofer();

            choferConsulta = ConsultarPorID(this.IDChofer);

            if (choferConsulta.IDChofer > 0)
            {
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Id", this.IDChofer));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.NombreChofer));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.CedulaChofer));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.TelefonoChofer));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Email", this.EmailChofer));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Direccion", this.DireccionChofer));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IDLicencia", this.MiLicencia.IDLicencia));

                int Resultado = MyCnn.HacerDML("SPChoferEditar");

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

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@id", IDChofer));

            int Resultado = MiCnn.HacerDML("SPChoferDesactivar");

            if (Resultado > 0)
            {
                R = true;
            }

            return R;


        }

        public DataTable ListarActivosChofer(bool VerActivos = true)
        {

            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPChoferesListarActivos");

            return R;
        }



        public bool ConsultarPorEmail()
        {
            bool R = false;

            Conexion MiCnn2 = new Conexion();

            //se agregan los params SP requiere
            MiCnn2.ListadoDeParametros.Add(new SqlParameter("@Email", this.EmailChofer));

            DataTable Consulta = MiCnn2.HacerSelect("SPChoferesConsultarPorEmail");

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
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.CedulaChofer));

            DataTable Consulta = MiCnn.HacerSelect("SPChoferesConsultarPorCedula");

            if (Consulta.Rows.Count > 0)
            {
                R = true;
            }


            return R;

        }



        //LISTAR
        public DataTable ListarChoferes()
        {
            DataTable R = new DataTable();


            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect ("SPChoferesListar");


            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPChoferesListarInactivos");

            return R;
        }



        public DataTable BuscarChofer(bool VerActivos = true, string Filtro = "")
        {

            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.HacerSelect("SPChoferesBuscar");

            return R;
        }


    }
}
