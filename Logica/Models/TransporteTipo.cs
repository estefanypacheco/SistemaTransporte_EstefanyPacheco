using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class TransporteTipo
    {

        public int IDTransporteTipo { get; set; }
        public string TipoTransporte { get; set; }
        public string TransmisionTransporte { get; set; }


        public DataTable ListarTransporteTipo()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPTransporteTipoListar");

            return R;
        }

    }
}
