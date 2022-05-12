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



            clProductoL obProductoL = new clProductoL();
            Repeater1.DataSource = obProductoL.mtdListarP();
            Repeater1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM imagen INNER JOIN producto ON imagen.idProducto = producto.idProducto";

            //clProductoL objProductoL = new clProductoL();
            //dgv.ListarProductos.DataSource = 
           
            
            
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
           
            }
    }

        
}
 