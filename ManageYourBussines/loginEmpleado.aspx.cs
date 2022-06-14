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
        //}
        //metodo de inicio de sesion en login de empleados y de recuperacion de cotraseña
        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            //if (.[0][4].ToString() == "Vendedor")
            //{

            //}
            clEmpleadoE objDatos = new clEmpleadoE();
            objDatos.email = txtEmailEmpledo.Text;
            objDatos.clave = txtClaveEmpleado.Text;

            clEmpleadoL objUsuariosL = new clEmpleadoL();
            clEmpleadoE objDatosClien = new clEmpleadoE();
            objDatosClien = objUsuariosL.mtdLogin(objDatos);
            if (objDatosClien != null)
            {



                Session["EmpleadosVen"] = objDatos.nombreEmpleado + " " + objDatos.apellidos;
                //Session["nombreEmpleado"] = objDatosClien.nombreEmpleado;
                //Session["apellidos"] = objDatosClien.apellidosEmple;
                Response.Redirect("Presentacion/frmvendedor.aspx");






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
