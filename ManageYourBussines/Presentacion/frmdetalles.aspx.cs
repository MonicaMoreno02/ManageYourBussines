using ManageYourBussines.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{
    public partial class frmdetalles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                clProductoL objProductoL = new clProductoL();
                Repeater2.DataSource = objProductoL.mtdListarProducto();
                Repeater2.DataBind();
            }
        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;

            // Buscamos el control en ese item 
            Label lbl = (Label)item.FindControl("LabelDato");

            int idProducto = int.Parse(lbl.Text);

            Response.Redirect("frmProductos2.aspx?idP=" + idProducto);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListItem i;
            i = new ListItem("Menor Precio");
            ddlLista.Items.Add(i);
            i = new ListItem("Mayor Precio");
            ddlLista.Items.Add(i);
        }
    }
}