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
    public partial class frmClientesVendedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static List<clUsuarioE> mtdListarP()
        {
            clClienteL objClienteL = new clClienteL();
            List<clUsuarioE> objListaCliente = new List<clUsuarioE>();

            objListaCliente = objClienteL.mtdListarL();

            return objListaCliente;
        }


        //PAOLA:listar datos de ventas de cada cliente

        protected void btnAceptar_Click1(object sender, EventArgs e)
        {
            dgModal.DataSource = null;

            clClienteL objDatosVentas = new clClienteL();
            List<clDetallesE> listaDetallesP = new List<clDetallesE>();

            int idCliente = int.Parse(TextBox1.Text);
            //int idCliente = 1;

            listaDetallesP = objDatosVentas.mtdListarDetallesL(idCliente);

            dgModal.DataSource = listaDetallesP;
            dgModal.DataBind();
        }

        protected void btnCerrar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("frmClientesVendedor.aspx");

        }
    }
}