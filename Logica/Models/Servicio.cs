using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Servicio
    {

        //Atributos
        public int IDServicio { get; set; }
        public string DistanciaServicio { get; set; }
        public decimal PrecioUnitarioServicio { get; set; }
        public string DireccionServicio { get; set; }

        //atributos compuestos
        public ServicioCarga MiServicioCarga { get; set; }
        public ServicioDistanciaExtra MiServicioDistanciaExtra { get; set; }
        public ServicioTerreno MiServicioTerreno { get; set; }

        //constructor 
        public Servicio()
        {
            //instanciar objetos compuestos

            MiServicioCarga = new ServicioCarga();
            MiServicioDistanciaExtra = new ServicioDistanciaExtra();
            MiServicioTerreno = new ServicioTerreno();

        }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn3 = new Conexion();

            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Distancia", this.DistanciaServicio));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@PrecioUnitario", this.PrecioUnitarioServicio));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Direccion", this.DireccionServicio));

            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@IDCarga", this.MiServicioCarga.IDCarga));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@IDDistanciaExtra", this.MiServicioDistanciaExtra.IDDistanciaExtra));
            MiCnn3.ListadoDeParametros.Add(new SqlParameter("@IDTerreno", this.MiServicioTerreno.IDTerreno));

            int CantidadRegistrosAfectados = MiCnn3.HacerDML("SPServicioAgregar");

            if (CantidadRegistrosAfectados > 0)
            {
                R = true;
            }


            return R;

        }


        public Servicio ConsultarPorID(int pIdServicio)
        {
            Servicio R = new Servicio();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Id", pIdServicio));

            DataTable DatosDeServicio = new DataTable();

            DatosDeServicio = MiCnn.HacerSelect("SPServicioConsultarPorID");

            if (DatosDeServicio != null && DatosDeServicio.Rows.Count > 0)
            {
                DataRow MisDatos = DatosDeServicio.Rows[0];

                R.IDServicio = Convert.ToInt32(MisDatos["IDServicio"]);
                R.DireccionServicio = Convert.ToString(MisDatos["DireccionServicio"]);
                R.DistanciaServicio = Convert.ToString(MisDatos["DistanciaServicio"]);
                R.PrecioUnitarioServicio = Convert.ToDecimal(MisDatos["PrecioUnitarioServicio"]);

                R.MiServicioCarga.IDCarga = Convert.ToInt32(MisDatos["IDCarga"]);
                R.MiServicioCarga.TipoCarga = Convert.ToString(MisDatos["TipoCarga"]);

                R.MiServicioDistanciaExtra.IDDistanciaExtra = Convert.ToInt32(MisDatos["IDDistanciaExtra"]);
                R.MiServicioDistanciaExtra.CantidadDistancia = Convert.ToString(MisDatos["CantidadDistancia"]);

                R.MiServicioTerreno.IDTerreno = Convert.ToInt32(MisDatos["IDTerreno"]);
                R.MiServicioTerreno.TipoTerreno = Convert.ToString(MisDatos["TipoTerreno"]);


            }

            return R;

        }


        public bool Activar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@id", IDServicio));

            int Resultado = MiCnn.HacerDML("SPServicioActivar");

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


            Servicio servicioConsulta = new Servicio();

            servicioConsulta = ConsultarPorID(this.IDServicio);

            if (servicioConsulta.IDServicio > 0)
            {
                Conexion MiCnn3 = new Conexion();


                MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Id", this.IDServicio));
                MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Distancia", this.DistanciaServicio));
                MiCnn3.ListadoDeParametros.Add(new SqlParameter("@PrecioUnitario", this.PrecioUnitarioServicio));
                MiCnn3.ListadoDeParametros.Add(new SqlParameter("@Direccion", this.DireccionServicio));

                MiCnn3.ListadoDeParametros.Add(new SqlParameter("@IDCarga", this.MiServicioCarga.IDCarga));
                MiCnn3.ListadoDeParametros.Add(new SqlParameter("@IDDistanciaExtra", this.MiServicioDistanciaExtra.IDDistanciaExtra));
                MiCnn3.ListadoDeParametros.Add(new SqlParameter("@IDTerreno", this.MiServicioTerreno.IDTerreno));


                int Resultado = MiCnn3.HacerDML("SPServicioEditar");

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

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@id", IDServicio));

            int Resultado = MiCnn.HacerDML("SPServicioDesactivar");

            if (Resultado > 0)
            {
                R = true;
            }

            return R;

        }



        //LISTAR
        public DataTable ListarServicioActivo(bool VerActivos = true)
        {

            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPServicioListarActivos");

            return R;
        }

        public bool ConsultarPorDireccion()
        {
            bool R = false;

            Conexion MiCnn2 = new Conexion();

            //se agregan los params SP requiere
            MiCnn2.ListadoDeParametros.Add(new SqlParameter("@Direccion", this.DireccionServicio));

            DataTable Consulta = MiCnn2.HacerSelect("SPServicioConsultarPorDireccion");

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

            R = MiCnn.HacerSelect("SPServicioListarInactivos");

            return R;
        }






    }
}
