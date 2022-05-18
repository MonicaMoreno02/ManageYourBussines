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

            clUsuarioE objDatos = new clUsuarioE();
            objDatos.email = txtEmail.Text;
            objDatos.clave = txtClave.Text;

            clUsuarioL objUsuariosL = new clUsuarioL();

            objDatos = objUsuariosL.mtdLogin(objDatos);
            if (objDatos != null)
            {



               

                Session["usuario"] = objDatos.nombres + " " + objDatos.apellidos;
                Response.Redirect("frmProductos.aspx");




            }
            else
            {
                lblMensaje.Text = "usuario no Registrado ";
            }

        }
    }
}
