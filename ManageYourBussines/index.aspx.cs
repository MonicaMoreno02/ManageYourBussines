using ManageYourBussines.Entidades;
using ManageYourBussines.Logica;
using System;
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
            //SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "SELECT * FROM imagen INNER JOIN producto ON imagen.idProducto = producto.idProducto; ";
            //cmd.CommandType = CommandType.Text;
            //cmd.Connection = conexionSQL;
            //conexionSQL.Open();

            //DataTable productoBD = new DataTable();
            //productoBD.Load(cmd.ExecuteReader());

            //Repeater1.DataSource = productoBD;
            //Repeater1.DataBind();
            //conexionSQL.Close();

            if(!this.IsPostBack)
            { 
                
            }

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

       

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            Response.Redirect("Presentacion/frmProductos.aspx");
        }
    }

        
    }
 