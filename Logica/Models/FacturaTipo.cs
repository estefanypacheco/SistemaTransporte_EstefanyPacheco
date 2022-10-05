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
        private int idFacturaTipo;

        public int IDFacturaTipo
        {
            get {return idFacturaTipo; }
            set { idFacturaTipo = value;}   

        }

        //propiedad de forma simplicada
        public string TipoFactura { get; set; }

        //Operacion
        public DataTable ListarFactura()
        {
            DataTable R = new DataTable();

            return R;
        }



    }
}
