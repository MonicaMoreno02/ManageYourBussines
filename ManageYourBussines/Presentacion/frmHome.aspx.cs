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
    public partial class frmHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                if (!this.IsPostBack)
            {
                this.BindRepeater();
            }



            int cliente = 2;


            clCarritoE objDatosPro = new clCarritoE();
            objDatosPro.idcliente = cliente;
            clCarritoL objCarL = new clCarritoL();
            int numer = objCarL.Mtdcar(objDatosPro);
            lbnumero.Text = numer.ToString();


        }
        public void BindRepeater()
        {

            ///auto posbak

            clProductoL objProductoL = new clProductoL();
            repeater2.DataSource = objProductoL.mtdListarP();
            repeater2.DataBind();


        }
        public void Getcarrito(object sender, EventArgs e)
        {  ///boton carrito

            int cliente = 1;
            int idproduc = 4;
            clCarritoE objDatosptod = new clCarritoE();
            objDatosptod.idcliente = cliente;
            objDatosptod.idproducto = idproduc;
            clCarritoL objprod = new clCarritoL();
            int numer = objprod.MtdcarPro(objDatosptod);




            if (numer == 0)
            {
                int idproducto = 3;
                string nombre = "mesa";
                string describsion = "tiene 4 patas la mesa";
                float precio = 2000;
                int cantidadstock = 20;
                string Imagen = "recursos\\images\\dinosaurio.png";
                int catidad = 1;
                int idcliente = 2;




                //Reference the Repeater Item using Button.
                //RepeaterItem item = (sender as Button).NamingContainer as RepeaterItem;


                clCarritoE objcarrito = new clCarritoE();

                objcarrito.idproducto = idproducto;
                objcarrito.idcliente = idcliente;
                objcarrito.describcion = describsion;
                objcarrito.precio = precio;
                objcarrito.cantidadstock = cantidadstock;
                objcarrito.catidad = catidad;
                objcarrito.nombre = nombre;
                objcarrito.Imagen = Imagen;

                clCarritoL objCarritoL = new clCarritoL();
                int filas = objCarritoL.mtdRegistrarCar(objcarrito);

                if (filas > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('carrito agregado correctamente');", true);

                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('jhhh');", true);
                }

            } 
        }

            protected void btnDetalles_Click(object sender, EventArgs e)
            {
                Response.Redirect("Presentacion\\frmProductos.aspx");
            }

        protected void btncarrito_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmcarrito.aspx");
        }
    }
    }