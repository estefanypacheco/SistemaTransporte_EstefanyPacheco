using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UsuarioRol
    {

        public int IDUsuarioRol { get; set; }
        public string RolUsuario { get; set; }
        public string DescripcionRol { get; set; }


        public DataTable ListarRolUsuario()
        {
            DataTable R = new DataTable();

            return R;
        }

    }
}
