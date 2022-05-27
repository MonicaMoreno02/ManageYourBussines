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
            objClientesE.nombres = txtNombres.Text;
            objClientesE.apellidos = txtApellidos.Text;
            objClientesE.telefono = txtTelefono.Text;
            objClientesE.direccion = txtDireccion.Text;
            objClientesE.email = txtEmail.Text;
            objClientesE.clave = txtClave.Text;


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

        protected void btnIngresar_Click(object sender, EventArgs e)
        {


          
            
                clUsuarioE objDatos = new clUsuarioE();
                objDatos.email = txtEmail.Text;
                objDatos.clave = txtClave.Text;

                clUsuarioL objUsuariosL = new clUsuarioL();
                clUsuarioE objDatosClien = new clUsuarioE();
                objDatosClien = objUsuariosL.mtdLogin(objDatos);
                if (objDatosClien != null)
                {


                    //lblUsuario.Text = objDatosClien.nombres + " " + objDatosClien.apellidos;

                    //Session["usuario"] = objDatos.nombres + " " + objDatos.apellidos;
                    Response.Redirect("index.aspx");

                    //lblUsuario.Text = clSesionE.nombres + " " + clSesionE.apellidos;



                }
                else
                {
                    //lblMensaje.Text = "usuario no Registrado ";
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "AlertaLoginContrasenia", "window.onload = function(){ alert('La contraseña es incorrecta.'); };", true);

                }
            
        }

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Recuperar.aspx");
        }
    }
}