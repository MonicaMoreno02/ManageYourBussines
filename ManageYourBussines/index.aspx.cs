﻿using ManageYourBussines.Entidades;
using ManageYourBussines.Logica;
using ManageYourBussines.Presentacion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static ManageYourBussines.Datos.clConexion;

namespace ManageYourBussines
{
    public partial class index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clProductoL objProductoL = new clProductoL();
                Repeater2.DataSource = objProductoL.mtdListarPro();
                Repeater2.DataBind();
            }




        }

     

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            clUsuarioE objDatos = new clUsuarioE();
            objDatos.emailCliente = txtEmail.Text;
            objDatos.claveCliente = txtClave.Text;

            clUsuarioL objUsuariosL = new clUsuarioL();
            clUsuarioE objDatosClien = new clUsuarioE();
            objDatosClien = objUsuariosL.mtdLogin(objDatos);
            if (objDatosClien != null)
            {


                //lblUsuario.Text = objDatosClien.nombres + " " + objDatosClien.apellidos;

                //Session["usuario"] = objDatos.nombres + " " + objDatos.apellidos;
                Session["idc"] = objDatosClien.idCliente;
                int idClient = objDatosClien.idCliente;
                Response.Redirect("Presentacion/frmHome.aspx");

              

               
               
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

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;

            // Buscamos el control en ese item 
            Label lbl = (Label)item.FindControl("LabelDato");

            int idProducto = int.Parse(lbl.Text);

            Response.Redirect("Presentacion/frmProductos2.aspx?idP=" + idProducto);
        }
    }

        
}
 