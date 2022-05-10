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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            clClienteE objDatos = new clClienteE();
            objDatos.email = txtEmail.Text;
            objDatos.clave = txtClave.Text;

            clClienteL objUsuariosL = new clClienteL();
            clClienteE objDatosReci = new clClienteE();
            objDatosReci = objUsuariosL.mtdLogin(objDatos);
            if (objDatosReci != null)
            {



                //clEmpleadoE objDatosE = new clEmpleadoE();
                //objDatosE.email = txtEmail.Text;
                //objDatosE.clave = txtClave.Text;

                //clEmpleadoL objEmpleadoL = new clEmpleadoL();
                //clEmpleadoE objDatosEmple = new clEmpleadoE();
                //objDatosEmple = objEmpleadoL.mtdLogin(objDatosE);



                //if (objDatosEmple!=null)
                //{

                //    Session["usuario"] = objDatosEmple.nombres + " " + objDatosEmple.apellidos;
                //    Response.Redirect("frmProductos.aspx");
                //}

                Session["usuario"] = objDatos.nombres + " " + objDatos.apellidos;
                Response.Redirect("frmProductos.aspx");



                //lblMensaje.Text = "usuario Valido ";

                ////Session["usuario"] = "" + "" + "";
                //Session["usuario"] = txtEmail.Text;
                ////Response es para llamar la pagina 
                //Response.Redirect("presentacion/frmHome.aspx");

                //establesco la paguina de inicio q quiero q me aparesca


            }
            else
            {
                lblMensaje.Text = "usuario no Registrado ";
            }

        }
    }
}
