using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{
    public partial class frmProductos2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string valor = Convert.ToString(Request.QueryString["idP"]);
            //lblID.Attributes.Add("style", "DISPLAY:none");
            lblID.Text = valor;
            //int idProducto = int.Parse(valor);

        }
    }
}