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
    public partial class frmRegisEmpleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            LblTipoEmpleado.Text = ddlTipoEmpleado.SelectedValue.ToString();

            clEmpleadoE objEmpleadoE = new clEmpleadoE();
            objEmpleadoE.documento = txtDocumentoRegis.Text;
            objEmpleadoE.nombreEmpleado = txtNombreRegis.Text;
            objEmpleadoE.apellidos = txtApellidoRegis.Text;
            objEmpleadoE.tipoEmpleado = LblTipoEmpleado.Text;
            objEmpleadoE.email = txtEmailRegis.Text;
            objEmpleadoE.clave = txtClaveRegis.Text;


            clEmpleadoL objDatosEmpleado = new clEmpleadoL();
            int resultado = objDatosEmpleado.mtdRegistrarEmple(objEmpleadoE);

            if (resultado != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Registro guardado correctamente:(');", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Algo ha salido mal y no hemos guardado tu registro :(');", true);
            }

            txtDocumentoRegis.Text = " ";
            txtNombreRegis.Text = " ";
            txtApellidoRegis.Text = " ";
            LblTipoEmpleado.Text = " ";
            txtEmailRegis.Text = " ";
            txtClaveRegis.Text = " ";

            Response.Redirect("frmEmpleados.aspx");
        }
    }
}