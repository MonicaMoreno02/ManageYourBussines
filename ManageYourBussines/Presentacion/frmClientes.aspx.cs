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


        }

        [WebMethod]
        public static List<clUsuarioE> mtdListarP()
        {
            clClienteL objClienteL = new clClienteL();
            List<clUsuarioE> objListaCliente = new List<clUsuarioE>();

            objListaCliente = objClienteL.mtdListarL();

            return objListaCliente;
        }

               

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            clClienteL objDatosVentas = new clClienteL();
            List<clDetallesE> listaDetallesP = new List<clDetallesE>();

            int idCliente = int.Parse(txtIdCliente.Text);

            listaDetallesP = objDatosVentas.mtdListarDetallesL(idCliente);

            dgModal.DataSource = listaDetallesP;
            dgModal.DataBind();

            //txtIdCliente.Text = " ";
        }
    }
}