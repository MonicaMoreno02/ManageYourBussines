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
    public partial class frmRegistrar : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{

        //}

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            clUsuarioE objClientesE = new clUsuarioE();

            objClientesE.documento = txtDocumento.Text;
            objClientesE.nombreCliente = txtNombres.Text;
            objClientesE.apellidos = txtApellidos.Text;
            objClientesE.telefono = txtTelefono.Text;
            objClientesE.direccion = txtDireccion.Text;
            objClientesE.emailCliente = txtEmail.Text;
            objClientesE.claveCliente = txtClave.Text;


            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int longitud = caracteres.Length;
            char letra;
            int longitudContrasenia = 10;
            string contraseniaAleatoria = string.Empty;
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                contraseniaAleatoria += letra.ToString();
            }

            clUsuarioL objClientesL = new clUsuarioL();

            int filas = objClientesL.mtdRegistrarCliente(objClientesE);
            if (filas > 0)

            {
                //lblMensaje.Text = "Cliente Registrado ";
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "AlertaLoginContrasenia", "window.onload = function(){ alert('Se ha registrado correctamente .'); };", true);

            }
            else
            {
                //lblMensaje.Text = "error al registraar el cliente   ";
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "AlertaLoginContrasenia", "window.onload = function(){ alert('Error al hacer el registro .'); };", true);

            }

            txtDocumento.Text = String.Empty;

            txtNombres.Text = String.Empty;
            txtApellidos.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtClave.Text = String.Empty;



        }



        protected void btncliente_Click(object sender, EventArgs e)
        {
            clUsuarioE objDatos = new clUsuarioE();
            objDatos.emailCliente =txtEmail1.Text;
            objDatos.claveCliente = txtClave1.Text;


            clUsuarioL objUsuariosL = new clUsuarioL();
            clUsuarioE bjDatosClien = new clUsuarioE();
            bjDatosClien = objUsuariosL.mtdLogin(objDatos);

            var user = new clUsuarioL();
            var result = user.recoverPassword(objDatos);

            if (bjDatosClien != null)
            {


                Session["idc"] = bjDatosClien.idCliente;
                int idClient = bjDatosClien.idCliente;

                Session["usuario"] = bjDatosClien.nombreCliente + " " + bjDatosClien.apellidos;
                Session["idCliente"] = bjDatosClien.idCliente;


                Response.Redirect("Presentacion/frmHome.aspx");






            }
            else
            {
                //lblMensaje.Text = "usuario no Registrado ";
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "AlertaLoginContrasenia", "window.onload = function(){ alert(' el email o La contraseña  es incorrecta.'); };", true);
            }
        }

        protected void btnEmpleado_Click(object sender, EventArgs e)
        {
            clEmpleadoE objDatos = new clEmpleadoE();
            objDatos.email = txtEmail1.Text;
            objDatos.clave = txtClave1.Text;

            clEmpleadoL objUsuariosL = new clEmpleadoL();
            clEmpleadoE objDatosClien = new clEmpleadoE();
            objDatosClien = objUsuariosL.mtdLoginE(objDatos);
            if (objDatosClien != null)
            {



                Session["empleado"] = objDatosClien.nombreEmpleado + " " + objDatos.apellidos;

                Session["apellidos"] = objDatosClien.apellidos;
                Response.Redirect("Presentacion/frmAdmin.aspx");






            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "AlertaLoginContrasenia", "window.onload = function(){ alert(' el email o La contraseña es incorrecta.'); };", true);

                //lblMensaje.Text = "usuario no Registrado ";
            }
        }

        protected void btnRecuperar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Recuperar.aspx");
        }
    }
}