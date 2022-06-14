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

        protected void btnCarrito_Click(object sender, EventArgs e)
        {
            int idProducto = int.Parse(lblID.Text);

            string idc = Convert.ToString(Session["idc"]);
            int idClien = int.Parse(idc);


            clCarritoE objDatosptod = new clCarritoE();
            objDatosptod.idcliente = idClien;
            objDatosptod.idproducto = idProducto;
            clCarritoL objprod = new clCarritoL();
            int numer = objprod.MtdcarPro(objDatosptod);

            if (numer == 0)
            {
                clProductoE objProducto = new clProductoE();
                objProducto.idProducto = idProducto;
                clProductoL objProductoL = new clProductoL();
                List<clProductoE> listar = new List<clProductoE>();
                listar = objProductoL.mtdListarProd(objProducto);

                string nombre = listar[0].nombre;
                string describsion = listar[0].descripcion;
                float precio = listar[0].precio;
                int cantidadstock = listar[0].cantidadStock;
                string Imagen = listar[0].imagen;
                int catidad = 1;
               




                //Reference the Repeater Item using Button.
                //RepeaterItem item = (sender as Button).NamingContainer as RepeaterItem;


                clCarritoE objcarrito = new clCarritoE();

                objcarrito.idproducto = idProducto;
                objcarrito.idcliente = idClien;
                objcarrito.describcion = describsion;
                objcarrito.precio = precio;
                objcarrito.cantidadstock = cantidadstock;
                objcarrito.catidad = catidad;
                objcarrito.nombre = nombre;
                objcarrito.Imagen = Imagen;

                clCarritoL objCarritoL = new clCarritoL();
                int filas = objCarritoL.mtdRegistrarCar(objcarrito);
                int fil = filas;
                if (fil > 0)
                {

                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('carrito agregado correctamente');", true);
                  
                  
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('jhhh');", true);
                }

              
            }
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('El producto ya esta agregado');", true);
        }
    }
}