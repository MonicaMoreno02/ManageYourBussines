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
    public partial class frmdetalles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                clProductoL objProductoL = new clProductoL();
                Repeater2.DataSource = objProductoL.mtdListarProducto();
                Repeater2.DataBind();
            }
        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;

            // Buscamos el control en ese item 
            Label lbl = (Label)item.FindControl("LabelDato");

            int idProducto = int.Parse(lbl.Text);

            Response.Redirect("frmProductos2.aspx?idP=" + idProducto);
        }


        public void Getcarrito(object sender, EventArgs e)
        {  ///boton carrito



            Button btn = (Button)sender;
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;

            // Buscamos el control en ese item 
            Label lbl = (Label)item.FindControl("LabelDato");

            int idProducto = int.Parse(lbl.Text);

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
                    fil = -1;
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('jhhh');", true);
                }


            }
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('El producto ya esta agregado');", true);
        }

        //protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ListItem i;
        //    i = new ListItem("Menor Precio");
        //    ddlLista.Items.Add(i);
        //    i = new ListItem("Mayor Precio");
        //    ddlLista.Items.Add(i);
        //}
    }
}