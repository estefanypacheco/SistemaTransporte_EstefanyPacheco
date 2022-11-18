using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTransporte
{
    public static class ObjetosGlobales
    {
        /* Se definen los objetos que pueden ser visibles desde todo el sistema.
         * La clase static no es necesario instanciarla ya que se auto instancia al
         * ejecutar la app 
         
         Se define un objeto tipo FrmPrincipal para el mecanismo de login y logout
         ojo al using System.Windows.Forms; de arriba
         */

        public static Form MiFormPrincipal = new Formularios.FrmPrincipal();

        public static Formularios.FrmUsuariosGestion FrmUsuariosGestion = new Formularios.FrmUsuariosGestion();

        // Usuario que sera visible en la totalidad del sistema, si el proceso de Login es correcto

        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();


        public static Logica.Models.Servicio MiServicioGlobal = new Logica.Models.Servicio();
        public static Logica.Models.Cliente MiClienteGlobal = new Logica.Models.Cliente();
        public static Logica.Models.Chofer MiChoferGlobal = new Logica.Models.Chofer();

        public static Formularios.FrmLogin FrmLogin = new Formularios.FrmLogin();
        public static Formularios.FrmRecuperarContrasennia FrmRecuperarContrasennia = new Formularios.FrmRecuperarContrasennia();
        public static Formularios.FrmChoferesGestion FrmChoferesGestion = new Formularios.FrmChoferesGestion();
        public static Formularios.FrmTransportesGestion FrmTransportesGestion = new Formularios.FrmTransportesGestion();
        public static Formularios.FrmServiciosGestion FrmServiciosGestion = new Formularios.FrmServiciosGestion();
        public static Formularios.FrmClientesGestion FrmClientesGestion = new Formularios.FrmClientesGestion();
        public static Formularios.FrmFacturacion MiFormFactura = new Formularios.FrmFacturacion();
        public static Formularios.FrmBusquedaServicioFactura FrmBusquedaServicioFactura = new Formularios.FrmBusquedaServicioFactura();
        public static Formularios.FrmBusquedaClienteFactura FrmBusquedaClienteFactura = new Formularios.FrmBusquedaClienteFactura();
        public static Formularios.FrmBusquedaTransporteClienteFactura FrmBusquedaTransporteClienteFactura = new Formularios.FrmBusquedaTransporteClienteFactura();
        public static Formularios.FrmBusquedaChoferFactura FrmBusquedaChoferFactura = new Formularios.FrmBusquedaChoferFactura();
        public static Formularios.FrmAnularFactura FrmAnularFactura = new Formularios.FrmAnularFactura();
        public static Formularios.FrmEmpresa FrmEmpresa = new Formularios.FrmEmpresa();
        public static Formularios.FrmSobreSistema FrmSobreSistema = new Formularios.FrmSobreSistema();

    }
}
