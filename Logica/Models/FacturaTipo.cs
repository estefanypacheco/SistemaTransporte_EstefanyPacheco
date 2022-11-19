using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class FacturaTipo
    {

        //Atributos Simples
        public int IDFacturaTipo { get; set; }


        //propiedad de forma simplicada
        public string TipoFactura { get; set; }

        //Operacion
        public DataTable ListarFactura()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPFacturaTipoListar");

            return R;
        }

    }
}
