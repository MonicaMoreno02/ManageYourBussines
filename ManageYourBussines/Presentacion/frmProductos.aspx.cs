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
    public partial class frmProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string valor = Convert.ToString(Request.QueryString["idP"]);
            lblID.Attributes.Add("style", "DISPLAY:none");
            lblID.Text = valor;
            int idProducto = int.Parse(valor);


            clProductoE objProducto = new clProductoE();
            objProducto.idProducto = idProducto;
            clProductoL objProductos = new clProductoL();
            List<clProductoE> listarProductos = new List<clProductoE>();
            listarProductos = objProductos.mtdListarD(objProducto);


            string nombre = listarProductos[0].nombre;
            lbnombre.Text = nombre;
            string imagen = listarProductos[0].imagen;
            Image1.ImageUrl = imagen;
            string imagen1 = listarProductos[0].imagen;
            string descripcion = listarProductos[0].descripcion;
            lbDescripcion.Text = descripcion;
            string material = listarProductos[0].material;
            lbMaterial.Text = material;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmHome.aspx");
        }
    }
}