using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ServicioCarga
    {
        //Atributos 
        public int IDCarga { get; set; }
        public string TipoCarga { get; set; }
        public decimal PrecioExtraCarga { get; set; }

        //Operacion
        public DataTable ListarServicioCarga()
        {
            DataTable R = new DataTable();


            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPServicioCargaListar");

            return R;
        }

    }
}
