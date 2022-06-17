using ManageYourBussines.Entidades;
using ManageYourBussines.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{
    public partial class frmSeguridadSocial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //PAOLA:listar seguridad
        [WebMethod]
        public static List<clSeguridadE> mtdListarSeguridad()
        {
            clEmpleadoL objEmpleado = new clEmpleadoL();
            List<clSeguridadE> listaSeguridad = new List<clSeguridadE>();

            listaSeguridad = objEmpleado.mtdListarSeguridad();

            return listaSeguridad;
        }
    }
}