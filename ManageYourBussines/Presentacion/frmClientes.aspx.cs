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
    public partial class frmClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            clClienteL objDatosVentas = new clClienteL();
            List<clDetallesE> listaDetallesP = new List<clDetallesE>();

            listaDetallesP = objDatosVentas.mtdListarDetallesL();

            dgModal.DataSource = listaDetallesP;
            dgModal.DataBind();

        }

        [WebMethod]
        public static List<clClienteE> mtdListarP()
        {
            clClienteL objClienteL = new clClienteL();
            List<clClienteE> objListaCliente = new List<clClienteE>();

            objListaCliente = objClienteL.mtdListarL();

            return objListaCliente;
        }

        
        //[WebMethod]
        //public static List<clDetallesE> mtdListaDetallesP()
        //{
        //    clClienteL objDatosVentas = new clClienteL();
        //    List<clDetallesE> listaDetallesP = new List<clDetallesE>();

        //    listaDetallesP = objDatosVentas.mtdListarDetallesL();

        //    return listaDetallesP;
        //}
    }
}