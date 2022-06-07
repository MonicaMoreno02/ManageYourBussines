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
    public partial class registrarTareas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

            clRegistroE objRegistro = new clRegistroE();
            objRegistro.nombreTarea = txtNombreT.Text;
            objRegistro.descripcionTarea = txtDescripcion.Text;

            clRegistroL objRegistroL = new clRegistroL();
            int filas = objRegistroL.mtdRegistrarTarea(objRegistro);
            if (filas > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "AlertaLoginContrasenia", "window.onload = function(){ alert('Se ha registrado correctamente .'); };", true);

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "AlertaLoginContrasenia", "window.onload = function(){ alert('error no se ha registrafo registrado correctamente .'); };", true);

            }
        }
    }
}