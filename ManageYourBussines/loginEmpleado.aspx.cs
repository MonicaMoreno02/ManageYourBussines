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
    public partial class loginEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            //if (.[0][4].ToString() == "Vendedor")
            //{

            //}
                clEmpleadoE objDatos = new clEmpleadoE();
            objDatos.emailEmpleado = txtEmailEmpledo.Text;
            objDatos.claveEmpleado = txtClaveEmpleado.Text;

            clEmpleadoL objUsuariosL = new clEmpleadoL();
            clEmpleadoE objDatosClien = new clEmpleadoE();
            objDatosClien = objUsuariosL.mtdLoginE(objDatos);
            if (objDatosClien != null)
            {



                Session["EmpleadosVen"] = objDatos.nombreEmpleado + " " + objDatos.apellidosEmple;
                //Session["nombreEmpleado"] = objDatosClien.nombreEmpleado;
                //Session["apellidos"] = objDatosClien.apellidosEmple;
                Response.Redirect("Presentacion/frmEmpleados.aspx");






            }
            else
            {
                lblMensaje.Text = "usuario no Registrado ";
            }

        }

        protected void btnRecuperarCon_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecuperarEmple.aspx");



        }
    }
}