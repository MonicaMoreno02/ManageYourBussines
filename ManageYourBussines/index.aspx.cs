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
            clProductoL objProductoL = new clProductoL();
            Repeater1.DataSource = objProductoL.mtdListarP();
            Repeater1.DataBind();




        }

        protected void btnModal_Click(object sender, EventArgs e)
        {
            clProductoL objProductoL = new clProductoL();
            List<clProductoE> ListarProducto = new List<clProductoE>();
            ListarProducto=objProductoL.mtdListarP();

           
            
                int lista =3 ;
                int idProducto = ListarProducto[lista].idProducto;
                string imagen = ListarProducto[lista].imagen;
                float precio = ListarProducto[lista].precio;
                string descripcion = ListarProducto[lista].descripcion;


            

        }

        protected void btnModal_Click1(object sender, EventArgs e)
        {
            clProductoL objProductoL = new clProductoL();
            List<clProductoE> ListarProducto = new List<clProductoE>();
            ListarProducto = objProductoL.mtdListarP();
        }
    }

        
}
 