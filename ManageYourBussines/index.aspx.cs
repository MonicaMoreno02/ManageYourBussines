﻿using ManageYourBussines.Entidades;
using ManageYourBussines.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace ManageYourBussines
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cliente"] != null || Session["idCliente"] != null || Session["empleado"] != null
                 || Session["idEmpleado"] != null)
            {
                //Response.Redirect("Presentacion/frmHome.aspx");


            }
            //Session["cliente"] = null;


        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {


            if (txtEmail.Text == "" || txtClave.Text == "")
            {

                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Los datos debe estar completos!', 'info')</script>");

            }
            else if (idTipoUsuario.SelectedValue == "Tipo usuario")
            {

                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Seleccione tipo de Usuario!', 'info')</script>");


            }
            else
            {
                if (idTipoUsuario.SelectedValue == "Cliente")


                { 

                    clUsuarioE objDatosE = new clUsuarioE();
                    clLoginL objLoginL = new clLoginL();
                    clUsuarioE objDatossele = new clUsuarioE();

                    objDatosE.email = txtEmail.Text;
                    objDatosE.clave = txtClave.Text;

          
                 
                   
                    objDatossele = objLoginL.mtdLoginUsuario(objDatosE);

                    if (objDatossele != null)
                    {
                        if (objDatossele.clave == txtClave.Text)
                        {
                            Session["cliente"] = " " + objDatossele.idCliente;
                            Session["idCliente"] = objDatossele.idCliente;
                            //Session["idTipoRol"] = objDatossele.idTipoRol;

                            //Session["nombreCliente"] = objDatossele.nombreCliente;
                            //Session["apellidosCliente"] = objDatossele.apellidos;

                            Response.Redirect("Presentacion/frmHome.aspx");
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Contraseña incorrecta!', 'info')</script>");
                        }


                    }
                    else
                    {

                        ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Usuario No encontrado!', 'info')</script>");


                    }

                }
                else
                {
                    clEmpleadoE objDatosE = new clEmpleadoE();
                    clLoginL objLoginL = new clLoginL();
                    clEmpleadoE objLLoginEmple = new clEmpleadoE();
                    objDatosE.emailEmpleado = txtEmail.Text;
                    objDatosE.claveEmpleado = txtClave.Text;
                    objLLoginEmple = objLoginL.mtdLoginEmpleado(objDatosE);

                    if (objLLoginEmple != null)
                    {
                        if (objLLoginEmple.claveEmpleado == txtClave.Text)
                        {
                            Session["empleado"] = " " + objLLoginEmple.nombreEmpleado;
                            Session["idEmpleado"] = objLLoginEmple.idEmpleado;
                            //Session["idTipoRol"] = objLLoginEmple.idTipoRol;
                            Response.Redirect("Presentacion/frmAbout.aspx");

                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Clave incorrecta!', 'info')</script>");
                        }


                    }
                    else
                    {

                        ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Usuario No encontrado!', 'info')</script>");


                    }

                }


            }


            //clUsuarioE objDatos = new clUsuarioE();
            //objDatos.email = txtEmail.Text;
            //objDatos.clave = txtClave.Text;

            //clUsuarioL objUsuariosL = new clUsuarioL();
            //clUsuarioE objDatosClien = new clUsuarioE();
            //objDatosClien = objUsuariosL.mtdLogin(objDatos);
            //if (objDatosClien != null)
            //{




            //    Session["usuario"] = objDatos.nombreCliente + " " + objDatos.apellidos;
            //    Response.Redirect("index.aspx");





            //}
            //else
            //{
            //    lblMensaje.Text = "usuario no Registrado ";
            //}

        }

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Recuperar.aspx");
        }
    }

}




