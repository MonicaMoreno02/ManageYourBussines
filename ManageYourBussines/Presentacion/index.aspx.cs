using ManageYourBussines.Entidades;
using ManageYourBussines.Logica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static ManageYourBussines.Datos.ClConexion;

namespace ManageYourBussines
{
    public partial class index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //------cargar Repeater
          


            if (!this.IsPostBack)
            {
                this.BindRepeater();
            }


        }
        public void BindRepeater()
        {

            ///auto posbak
            clProductoL objProductoL = new clProductoL();
            Repeater2.DataSource = objProductoL.mtdListarP();
            Repeater2.DataBind();



        }
        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmProductos.aspx");
        }
    }

        
}
 