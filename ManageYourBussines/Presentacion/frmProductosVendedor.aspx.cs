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
    public partial class frmProductosVendedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static List<clProductoE> mtdListarProducto()
        {
            clProductoL objProductoL = new clProductoL();
            List<clProductoE> listarProductos = new List<clProductoE>();
            listarProductos = objProductoL.mtdListarP();
            return listarProductos;

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmInicioEmpleados.aspx");

        }
    }
}