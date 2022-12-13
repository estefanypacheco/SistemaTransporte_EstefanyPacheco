using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Transporte
    {

        public int IDTransporte { get; set; }
        public string NombreTransporte { get; set; }
        public string DescripcionTransporte { get; set; }
        public string Placa { get; set; }
        public bool ActivoTransporte { get; set; }

        //Atributo Compuesto
        public TransporteTipo MiTransporteTipo { get; set; }

        //constructor de la clase para instanciar el atributo compuesto simple
        public Transporte()
        {
            //instanciar objetos compuestos
            MiTransporteTipo = new TransporteTipo();
        }

        //AGREGAR
        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn3 = new Conexion();

            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.NombreTransporte));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Descripcion", this.DescripcionTransporte));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Placa", this.Placa));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@IDTransporteTipo", this.MiTransporteTipo.IDTransporteTipo));

            int CantidadRegistrosAfectados = MiCnn3.HacerDML("SPTransporteAgregar");

            if (CantidadRegistrosAfectados > 0)
            {
                R = true;
            }

            return R;

        }


        public Transporte ConsultarPorID(int pIdTransporte)
        {
            Transporte R = new Transporte();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Id", pIdTransporte));

            DataTable DatosDeChofer = new DataTable();

            DatosDeChofer = MiCnn.HacerSelect("SPTransporteConsultarPorID");

            if (DatosDeChofer != null && DatosDeChofer.Rows.Count > 0)
            {
                DataRow MisDatos = DatosDeChofer.Rows[0];

                R.IDTransporte = Convert.ToInt32(MisDatos["IDTransporte"]);
                R.NombreTransporte = Convert.ToString(MisDatos["NombreTransporte"]);
                R.DescripcionTransporte = Convert.ToString(MisDatos["DescripcionTransporte"]);
                R.Placa = Convert.ToString(MisDatos["Placa"]);
                R.ActivoTransporte = Convert.ToBoolean(MisDatos["ActivoTransporte"]);

                R.MiTransporteTipo.IDTransporteTipo = Convert.ToInt32(MisDatos["IDTransporte"]);
                R.MiTransporteTipo.TipoTransporte = Convert.ToString(MisDatos["TipoTransporte"]);


            }

            return R;

        }


        public DataTable BuscarTransporte(bool VerActivos = true, string Filtro = "")
        {

            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.HacerSelect("SPTransportesBuscar");

            return R;
        }

        public bool Activar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@id", IDTransporte));

            int Resultado = MiCnn.HacerDML("SPTransporteActivar");

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


            Transporte transporteConsulta = new Transporte();

            transporteConsulta = ConsultarPorID(this.IDTransporte);

            if (transporteConsulta.IDTransporte > 0)
            {


                Conexion MyCnn = new Conexion();


                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Id", this.IDTransporte));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.NombreTransporte));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Descripcion", this.DescripcionTransporte));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Placa", this.Placa));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IDTransporteTipo", this.MiTransporteTipo.IDTransporteTipo));

                int Resultado = MyCnn.HacerDML("SPTransporteEditar");

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

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@id", IDTransporte));

            int Resultado = MiCnn.HacerDML("SPTransporteDesactivar");

            if (Resultado > 0)
            {
                R = true;
            }

            return R;


        }

        public DataTable ListarActivosTransporte(bool VerActivos = true)
        {

            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPTransportesListarActivos");

            return R;
        }



        public bool  ConsultarPorPlaca()
        {
            bool R = false;

            Conexion MiCnn2 = new Conexion();

            //se agregan los params SP requiere
            MiCnn2.ListadoDeParametros.Add(new SqlParameter("@Placa", this.Placa));

            DataTable Consulta = MiCnn2.HacerSelect("SPTransporteConsultarPorPlaca");

            if (Consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;

        }



        //LISTAR
        public DataTable ListarTransportes()
        {
            DataTable R = new DataTable();


            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPTransportesListar");


            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPTransporteListarInactivos");

            return R;
        }


    }
}
