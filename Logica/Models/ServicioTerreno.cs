using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ServicioTerreno
    {

        //Atributos 
        public int IDTerreno { get; set; }
        public string TipoTerreno { get; set; }
        public decimal PrecioExtraTerreno { get; set; }

        //Operacion
        public DataTable ListarServicioTerreno()
        {
            DataTable R = new DataTable();


            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPServicioTerrenoListar");

            return R;
        }

    }
}
