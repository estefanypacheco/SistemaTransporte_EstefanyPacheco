using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Factura
    {
        //Simples
        public int IDFactura { get; set; }
        public int NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public string Anotacion { get; set; }


        public static int incremento {get; set;}

        //composiciones simples

        public FacturaTipo MiTipo { get; set; }
        public Empresa MiEmpresa { get; set; }
        public Cliente MiCliente { get; set; }
        public Usuario MiUsuario { get; set; }
        public Transporte MiTransporte { get; set; }
        public Chofer MiChofer { get; set; }
       // public FacturaDetalle MiFacturaDetalle { get; set; }

        //composicion multiple
        public List<FacturaDetalle> DetalleItems { get; set; }

        //constructor
        public Factura()
        {
            MiTipo = new FacturaTipo();
            MiEmpresa = new Empresa();
            MiCliente = new Cliente();
            MiUsuario = new Usuario();
            MiTransporte = new Transporte();
            MiChofer = new Chofer();
            DetalleItems = new List<FacturaDetalle>();

        }

        public bool Agregar()
        {
            bool R = false;

            //Cuando se agregar encanbezado detalle se hace en dos partes:
            //1. encabezado y obtenemos ID creado
            //2. iteración por cada detalle, se guardan los detalles

            Conexion MiCnnEncabezado = new Conexion();


           // MiCnnEncabezado.ListadoDeParametros.Add(new SqlParameter("@numero", this.NumeroFactura));
            MiCnnEncabezado.ListadoDeParametros.Add(new SqlParameter("@fecha", this.Fecha));
            //MiCnnEncabezado.ListadoDeParametros.Add(new SqlParameter("@subtotal", this.SubTotal));
            //MiCnnEncabezado.ListadoDeParametros.Add(new SqlParameter("@descuentos", this.Descuento));
            //MiCnnEncabezado.ListadoDeParametros.Add(new SqlParameter("@total", this.Total));
            MiCnnEncabezado.ListadoDeParametros.Add(new SqlParameter("@notas", this.Anotacion));

            MiCnnEncabezado.ListadoDeParametros.Add(new SqlParameter("@idtipo", this.MiTipo.IDFacturaTipo));
            MiCnnEncabezado.ListadoDeParametros.Add(new SqlParameter("@idcliente", this.MiCliente.IDCliente));
            MiCnnEncabezado.ListadoDeParametros.Add(new SqlParameter("@idchofer", this.MiChofer.IDChofer));
            MiCnnEncabezado.ListadoDeParametros.Add(new SqlParameter("@idtransporte", this.MiTransporte.IDTransporte));
            MiCnnEncabezado.ListadoDeParametros.Add(new SqlParameter("@idempresa", this.MiEmpresa.IDEmpresa));
            MiCnnEncabezado.ListadoDeParametros.Add(new SqlParameter("@idusuario", this.MiUsuario.IDUsuario));



            Object Retorno = MiCnnEncabezado.HacerSelectEscalar("SPFacturaAgregarEncabezado");

            int IdFacturaRecienCreada = 0;

            if (Retorno != null)
            {
                IdFacturaRecienCreada = Convert.ToInt32(Retorno.ToString());

                foreach (FacturaDetalle item in this.DetalleItems)
                {
                    Conexion MiCnnDetalle = new Conexion();

                    MiCnnDetalle.ListadoDeParametros.Add(new SqlParameter("@idfactura", IdFacturaRecienCreada));
                    MiCnnDetalle.ListadoDeParametros.Add(new SqlParameter("@idservicio", item.MiServicio.IDServicio));
                    MiCnnDetalle.ListadoDeParametros.Add(new SqlParameter("@direccionitem", item.DireccionItem));
                    MiCnnDetalle.ListadoDeParametros.Add(new SqlParameter("@cantidad", item.CantidadFactura));
                    MiCnnDetalle.ListadoDeParametros.Add(new SqlParameter("@precio", item.PrecioUnitarioDetalle));
                    MiCnnDetalle.ListadoDeParametros.Add(new SqlParameter("@porcentajedescuento", item.PorcentajeDetalle));
                    MiCnnDetalle.ListadoDeParametros.Add(new SqlParameter("@subtotallinea", item.SubTotalLinea));
                    MiCnnDetalle.ListadoDeParametros.Add(new SqlParameter("@totallinea", item.TotalLinea));

                    MiCnnDetalle.HacerDML("SPFacturaAgregarDetalle");

                }

                R = true;
                //acumulador necesario?
            }

            return R;

        }


        //ELIMINAR (DESACTIVAR)
        public bool Eliminar(int pIDFactura)
        {
            bool R = false;



            return R;

        }


        public bool ConsultarPorNumeroFact(int pNumeroFactura)
        {
            bool R = false;

            return R;

        }


        public DataTable ListarPorRangoDeFechas(DateTime pFechaInicial, DateTime pFechaFinal)
        {
            DataTable R = new DataTable();

            return R;

        }

        public DataTable ListarPorCliente(int pIDCliente)
        {
            DataTable R = new DataTable();

            return R;

        }

        public DataTable ListarPorUsuario(int pIDUsuario)
        {
            DataTable R = new DataTable();

            return R;

        }




        public DataTable AsignarEsquemaDetalle() { 

            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPFacturaDetalleEsquema",true);

            R.PrimaryKey = null;


            return R;
        }

    }
}
