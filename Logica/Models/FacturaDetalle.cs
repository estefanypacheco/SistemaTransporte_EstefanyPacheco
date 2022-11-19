using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class FacturaDetalle
    {
        //Simples
        public string DescripcionItem { get; set; }
        public int CantidadFactura { get; set; }
        public decimal PrecioUnitarioDetalle { get; set; }
        public decimal PorcentajeDetalle { get; set; }
        public decimal SubTotalLinea { get; set; }
        public decimal TotalLinea { get; set; }

        //Compuesto
        Servicio MiServicio { get; set; }

        public FacturaDetalle()
        {
            //instanciar objetos compuestos
            MiServicio = new Servicio();

        }



    }
}
