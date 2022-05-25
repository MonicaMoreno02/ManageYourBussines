using ManageYourBussines.Entidades;
using ManageYourBussines.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{
    public partial class frmInventario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clProductoL objProductoL = new clProductoL();
            List<clProductoE> listInvent=new List<clProductoE>();
           listInvent = objProductoL.mtdListarP();
            gvInventario.DataSource = listInvent;
            gvInventario.DataBind();


            

        }
    }
}