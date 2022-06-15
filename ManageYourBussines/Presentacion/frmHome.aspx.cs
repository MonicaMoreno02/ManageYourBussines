using ManageYourBussines.Entidades;
using ManageYourBussines.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{
    public partial class frmHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Label lblUsuario = this.Master.FindControl("lblUsuario") as Label;
            HtmlAnchor crearCuenta = (HtmlAnchor)this.Master.FindControl("crearCuenta");
            HtmlAnchor crearEvento = (HtmlAnchor)this.Master.FindControl("crearEvento");

            //crearEvento.Visible = false;

            if (Session["cliente"] == null && Session["idCliente"] == null && Session["empleado"] == null
                && Session["idEmpleado"] == null)
            {
                lblUsuario.Visible = false;


            }
            else
            {

                lblUsuario.Visible = true;
                //btnIngresarLogin.Visible = false;

                if (Session["empleado"] == null)
                {
                    lblUsuario.Text = Session["cliente"].ToString();
                    //crearCuenta.Visible = false;


                    //if (Session["idTipoRol"].ToString() == "3")
                    //{
                    //    crearEvento.Visible = true;
                    //}

                }
                else
                {
                    lblUsuario.Text = Session["empleado"].ToString();
                    //crearCuenta.Visible = false;


                    //if (Session["idTipoRol"].ToString() == "3")
                    //{
                    //    crearEvento.Visible = true;
                    //}
                }




                //txtID.Attributes.Add("style", "DISPLAY:none");
            }
        }



        //protected void btnEditar_Click(object sender, EventArgs e)


        //{
        //    clUsuarioE objDatos = new clUsuarioE();
        //    objDatos.idCliente = int.Parse(txtID.Text);
        //    objDatos.documento = txtDocumento.Text;
        //    objDatos.nombreCliente = txtNombres.Text;
        //    objDatos.apellidos = txtApellidos.Text;
        //    objDatos.telefono = txtTelefono.Text;
        //    objDatos.direccion = txtDireccion.Text;




        //    objDatos.email = txtEmail.Text;
        //    objDatos.clave = txtClave.Text;

        //    clLoginL objPersonaL = new clLoginL();
        //    int filas = objPersonaL.mtdEditarPersona(objDatos);

        //    if (filas > 0)
        //    {
        //        Session["cliente"] = txtNombres.Text;

        //    }


        }

        //    protected void btnCerrarSesion_Click1(object sender, EventArgs e)
        //    {
        //        Session.RemoveAll();
        //        Response.Redirect("../index.aspx");

        //    }
        //}
    
}