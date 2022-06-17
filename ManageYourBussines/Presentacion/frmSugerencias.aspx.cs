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
    public partial class frmSugerencias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static List<clSugerenciasE> mtdListarSugerenciasP()
        {
            clSugerenciasL objSugerenciasL = new clSugerenciasL();
            List<clSugerenciasE> objListaS = new List<clSugerenciasE>();
            objListaS = objSugerenciasL.mtdListarS();
            return objListaS;
        }
    }
}