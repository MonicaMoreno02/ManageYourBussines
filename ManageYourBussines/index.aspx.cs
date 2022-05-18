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
            clClienteE objDatos = new clClienteE();
            objDatos.email = txtEmail.Text;
            objDatos.clave = txtClave.Text;

            clClienteL objUsuariosL = new clClienteL();
            clClienteE objDatosClien = new clClienteE();
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
