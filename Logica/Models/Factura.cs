using System;
using System.Collections.Generic;
using System.Data;
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
        public decimal Total { get; set; }
        public string Anotacion { get; set; }

        //composiciones simples

        public FacturaTipo MiTipo { get; set; }
        public Empresa MiEmpresa { get; set; }
        public Cliente MiCliente { get; set; }
        public Usuario MiUsuario { get; set; }
        public Transporte MiTransporte { get; set; }
        public Chofer MiChofer { get; set; }

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


        private void Totalizar()
        {

            decimal R = 0;
            //asignar valores a los decimales de arriba
        }

        public DataTable AsignarEsquemaDetalle() { 

            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPFacturaDetalleEsquema", true);

            R.PrimaryKey = null;


            return R;
        }

    }
}
