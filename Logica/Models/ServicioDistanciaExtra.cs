using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ServicioDistanciaExtra
    {
        //Atributos 
        public int IDDistanciaExtra { get; set; }
        public string CantidadDistancia { get; set; }
        public decimal PrecioExtraDistancia { get; set; }

        //Operacion
        public DataTable ListarServicioDistanciaExtra()
        {
            DataTable R = new DataTable();


            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPServicioDistanciaExtraListar");

            return R;
        }

    }
}
