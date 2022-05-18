using ManageYourBussines.Entidades;
using ManageYourBussines.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ManageYourBussines
{
    public partial class index : System.Web.UI.Page
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
            clUsuarioE objDatosClien = new clUsuarioE();
            objDatosClien = objUsuariosL.mtdLogin(objDatos);
            if (objDatosClien != null)
            {
            



                Session["usuario"] = objDatos.nombres + " " + objDatos.apellidos;
                Response.Redirect("index.aspx");





            }
            else
            {
                lblMensaje.Text = "usuario no Registrado ";
            }

        }

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Recuperar.aspx");
        }
    }

}
