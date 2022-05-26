using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{
    public partial class frmEmpleadoss : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clCarritoL objCarritoL = new clCarritoL();
            DataTable carrito = new DataTable();
            List<clCarritoE> listarCar = new List<clCarritoE>();
            //Session["objeto"] = objCarritoL.mtdListcar();
            carrito = objCarritoL.mtdListcar();


            gvCar.DataSource = carrito;
            gvCar.DataBind();
        }

        protected void gvCar_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "eliminar")
            {
                int lista = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvCar.Rows[lista];

                clCarritoL objCarritoL = new clCarritoL();
                DataTable carrito = new DataTable();

                carrito = objCarritoL.mtdListcar();

                int cuen = carrito.Rows.Count;
                cuen = cuen - 2;
                if (cuen >= lista)
                {
                    int idproducto = int.Parse(carrito.Rows[lista]["idproducto"].ToString());
                    int idcliente = int.Parse(carrito.Rows[lista]["idcliente"].ToString());


                    clCarritoE objcarrito = new clCarritoE();

                    objcarrito.idcliente = idcliente;
                    objcarrito.idproducto = idproducto;
                    clCarritoL objVehiculoL = new clCarritoL();
                    int filas = objVehiculoL.mtdEliminarCar(objcarrito);

                    if (filas > 0)
                    {

                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('eliminado correctamente');", true);
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('error');", true);

                    }
                    clCarritoL objCarrito1L = new clCarritoL();
                    DataTable dt = new DataTable();
                    List<clCarritoE> listarCar1 = new List<clCarritoE>();
                    dt = objCarrito1L.mtdListcar();



                    gvCar.DataSource = dt;
                    gvCar.DataBind();
                }



            }
            if (e.CommandName == "aumentar")
            {
                int lista = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvCar.Rows[lista];
                string valor = gvCar.Rows[lista].Cells[5].Text;
                int cantidad = int.Parse(valor);
                cantidad = cantidad + 1;

                clCarritoL objCarritoL = new clCarritoL();
                DataTable carrito = new DataTable();

                carrito = objCarritoL.mtdListcar();
                int cuen = carrito.Rows.Count;
                cuen = cuen - 2;
                if (cuen >= lista)
                {


                    int idproducto = int.Parse(carrito.Rows[lista]["idproducto"].ToString());
                    int idcliente = int.Parse(carrito.Rows[lista]["idcliente"].ToString());

                    clCarritoE objcarrito = new clCarritoE();
                    objcarrito.idproducto = idproducto;
                    objcarrito.idcliente = idcliente;
                    objcarrito.catidad = cantidad;
                    clCarritoL objcarritoL = new clCarritoL();

                    int filas = objcarritoL.mtdaumentar(objcarrito);

                    clCarritoL objCarrito1L = new clCarritoL();
                    DataTable dt = new DataTable();
                    List<clCarritoE> listarCar1 = new List<clCarritoE>();
                    dt = objCarrito1L.mtdListcar();

                }
            }
            if (e.CommandName == "disminuir")
            {
                int lista = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvCar.Rows[lista];
                string valor = gvCar.Rows[lista].Cells[5].Text;
                int cantidad = int.Parse(valor);
                cantidad = cantidad - 1;

                clCarritoL objCarritoL = new clCarritoL();
                DataTable carrito = new DataTable();

                carrito = objCarritoL.mtdListcar();
                int cuen = carrito.Rows.Count;
                cuen = cuen - 2;
                if (cuen >= lista)
                {
                    int idproducto = int.Parse(carrito.Rows[lista]["idproducto"].ToString());
                    int idcliente = int.Parse(carrito.Rows[lista]["idcliente"].ToString());

                    clCarritoE objcarrito = new clCarritoE();
                    objcarrito.idproducto = idproducto;
                    objcarrito.idcliente = idcliente;
                    objcarrito.catidad = cantidad;
                    clCarritoL objcarritoL = new clCarritoL();

                    int filas = objcarritoL.mtdaumentar(objcarrito);

                    clCarritoL objCarrito1L = new clCarritoL();
                    DataTable dt = new DataTable();
                    List<clCarritoE> listarCar1 = new List<clCarritoE>();
                    dt = objCarrito1L.mtdListcar();
                }
            }



        }
    }
    
}