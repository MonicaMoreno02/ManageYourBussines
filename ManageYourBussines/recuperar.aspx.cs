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
    public partial class recuperar : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
           
            clUsuarioE objEmpleadoE = new clUsuarioE();
            objEmpleadoE.email = txtEmail.Text;
            var user = new clUsuarioL();
            var result = user.recoverPassword(objEmpleadoE);
            if (result != null)
            {
                

                ClientScript.RegisterStartupScript(
                       this.GetType(),
                       Guid.NewGuid().ToString(),


                       string.Format("alert('{0}');", "# Se envio a tu correo una contraseña nueva para iniciar sesión"),
                       true
                   );


                //ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "AlertaLoginContrasenia", "window.onload = function(){ alert('se envio su contrasena a su correo .'); };", true);
                Response.Redirect("index.aspx");

            }
            else
            {
                ClientScript.RegisterStartupScript(
                       this.GetType(),
                       Guid.NewGuid().ToString(),
                       string.Format("alert('{0}');", "#El correo no  fue enccontrado "),
                       true
                   );
            }
        
            
        }
    }
    
}