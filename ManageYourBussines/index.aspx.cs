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
        string CadenaConexion = "Data Source=SOGAPRRBCFSD546\\SQLEXPRESS;Initial Catalog=dbManage;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT nombre,precio,imagen,descripcion FROM producto ORDER BY idProducto ASC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable productoBD = new DataTable();
            productoBD.Load(cmd.ExecuteReader());

            ListView1.DataSource = productoBD;
            ListView1.DataBind();
            conexionSQL.Close();
        }
       
    }
}