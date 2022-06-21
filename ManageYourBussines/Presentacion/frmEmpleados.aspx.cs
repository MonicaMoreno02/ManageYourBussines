using ManageYourBussines.Entidades;
using ManageYourBussines.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{
    public partial class frmEmpleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             //PAOLA: vuelve invisible los txt
              txtIDEmpleado.Attributes.Add("style", "DISPLAY:none");
              txtIDEmpleadoB.Attributes.Add("style", "DISPLAY:none");
        }


        //PAOLA:listar empleados
        [WebMethod]
        public static List<clEmpleadoE>mtdListar()
        {
            clEmpleadoL objEmpleado = new clEmpleadoL();
            List<clEmpleadoE> listaEmpleados = new List<clEmpleadoE>();

            listaEmpleados = objEmpleado.mtdListarEmpleadoL();

            return listaEmpleados;
        }

      


        //PAOLA:editar empleados

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            clEmpleadoE objDatos = new clEmpleadoE();
            objDatos.idEmpleado = int.Parse(txtIDEmpleado.Text);
            objDatos.documentoEmpleado = txtDocumento.Text;
            objDatos.nombreEmpleado = txtNombreEmpleado.Text;
            objDatos.apellidoEmpleado = txtApellidos.Text;
            objDatos.tipoEmpleado = txtTipoEmpleado.Text;
            objDatos.emailEmpleado = txtEmail.Text;
            objDatos.claveEmpleado = txtClave.Text;

            clEmpleadoL objEmpleadoL = new clEmpleadoL();
            int resultado = objEmpleadoL.mtdEditar(objDatos);

            if (resultado != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Registro editado correctamente:(');", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No se ha podido editar el registro:(');", true);
            }

            Response.Redirect("frmEmpleados.aspx");
           
        }

        


        protected void btnRegistrarE_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmRegisEmpleados.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIDEmpleadoB.Text);

            clEmpleadoL objEmpleadoL = new clEmpleadoL();
            int result = objEmpleadoL.mtdEliminar(id);

            if (result != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Registro eliminar correctamente:(');", true);
                Response.Redirect("frmEmpleados.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Algo ha salido mal y no hemos eliminado tu registro :(');", true);
                Response.Redirect("frmEmpleados.aspx");
            }
        }

        //PAOLA:eliminar empleados

    }
}