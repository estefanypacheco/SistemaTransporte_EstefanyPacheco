using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ChoferLicencia
    {

        public int IDLicencia { get; set; }
        public string TipoLicencia { get; set; }
        public string Descripcion { get; set; }

        public DataTable ListarLicencia()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPLicenciaChoferListar");

            return R;
        }

    }
}
