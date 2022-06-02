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
    public partial class frmVenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clVentaL objVentaL = new clVentaL();
            List<clVentaE> lista = new List<clVentaE>();
            lista = objVentaL.mtdListarVenta();
            GridView1.DataSource = lista;
            GridView1.DataBind();
            GridView1.UseAccessibleHeader = true;
            //GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
}