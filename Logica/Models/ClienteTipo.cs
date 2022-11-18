using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ClienteTipo
    {

        //Atributos Simples
        private int idClienteTipo;

        public int IDClienteTipo
        {
            get { return idClienteTipo; }
            set { idClienteTipo = value; }

        }

        //propiedad de forma simplicada
        public string TipoCliente { get; set; }

        //Operacion
        public DataTable ListarTipoCliente()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPClienteTipoListar");

            return R;

        }
    }
}
