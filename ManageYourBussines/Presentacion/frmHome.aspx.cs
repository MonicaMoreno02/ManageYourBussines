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
    public partial class frmHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////lblCliente.Text = Session["idCliente"].ToString();
            lblUsuario1.Text = Session["idCliente"].ToString();
            //lblnombres.Text = Session["nombreCliente"].ToString();
            //lblApellidos.Text = Session["apellidosCliente"].ToString();


            //crearEvento.Visible = false;


            //txtID.Attributes.Add("style", "DISPLAY:none");
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("../index.aspx");

        }

        protected void btnEditar_Click(object sender, EventArgs e)


        {
            clUsuarioE objDatos = new clUsuarioE();
            objDatos.idCliente = int.Parse(txtID.Text);
            objDatos.documento = txtDocumento.Text;
            objDatos.nombreCliente = txtNombres.Text;
            objDatos.apellidos = txtApellidos.Text;
            objDatos.telefono = txtTelefono.Text;
            objDatos.direccion = txtDireccion.Text;




            objDatos.email = txtEmail.Text;
            objDatos.clave = txtClave.Text;

            clLoginL objPersonaL = new clLoginL();
             int filas= objPersonaL.mtdEditarPersona(objDatos);

            if (filas>0)
            {
                Session["cliente"] = txtNombres.Text;

            }


        }
    }
}
   