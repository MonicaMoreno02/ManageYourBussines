using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{
    public partial class frmAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!this.IsPostBack)
            //{
                
            //}
        }

        protected void BtnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/index.aspx");
        }
    }
}