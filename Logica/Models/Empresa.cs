using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Empresa
    {
        //Atributos
        public int IDEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string CedulaEmpresa { get; set; }
        public string EmailEmpresa { get; set; }
        public string DireccionEmpresa { get; set; }


        //funciones
        public DataTable ListarEmpresa()
        {

            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.HacerSelect("SPEmpresaListar");

            return R;

        }

        public DataTable ListarEmpresaDetalle()
        {

            DataTable R = new DataTable();

            Conexion MiCnn1 = new Conexion();

            R = MiCnn1.HacerSelect("SPEmpresaListar2");

            return R;

        }



    }
}
