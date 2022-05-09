using ManageYourBussines.Entidades;
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
        string CadenaConexion = "Data Source=.;Initial Catalog=dbManage;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM imagen INNER JOIN producto ON imagen.idProducto = producto.idProducto; ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable productoBD = new DataTable();
            productoBD.Load(cmd.ExecuteReader());

            Repeater1.DataSource = productoBD;
            Repeater1.DataBind();
            conexionSQL.Close();
        }

        protected void btnModal_Click(object sender, EventArgs e)
        {
            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM imagen INNER JOIN producto ON imagen.idProducto = producto.idProducto; ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable productoBD = new DataTable();
            productoBD.Load(cmd.ExecuteReader());

            
        }
    }

        
    }
 