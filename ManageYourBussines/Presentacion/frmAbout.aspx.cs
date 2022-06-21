using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{ 
    public partial class frmAbout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            //Label lblUsuario = this.Master.FindControl("lblUsuario") as Label;
            //Button btnIngresarLogin = this.Master.FindControl("btnIngresarLogin") as Button;
            //HtmlAnchor crearCuenta = (HtmlAnchor)this.Master.FindControl("crearCuenta");
            //HtmlAnchor crearEvento = (HtmlAnchor)this.Master.FindControl("crearEvento");

            //crearEvento.Visible = true;

            //if (Session["cliente"] == null && Session["idCliente"] == null && Session["empleado"] == null
            //    && Session["idEmpleado"] == null)
            //{
            //    lblUsuario.Visible = false;


            //}
            //else
            //{

            //    lblUsuario.Visible = true;
            //    btnIngresarLogin.Visible = false;

            //    if (Session["cliente"] == null)
            //    {
            //        lblUsuario.Text = Session["empleado"].ToString();
            //        crearCuenta.Visible = true;


            //        if (Session["idTipoRol"].ToString() == "3")
            //        {
            //            crearEvento.Visible = true;
            //        }

            //    }
            //    else
            //    {
            //        lblUsuario.Text = Session["cliente"].ToString();
            //        crearCuenta.Visible = false;


            //        if (Session["idTipoRol"].ToString() == "3")
            //        {
            //            crearEvento.Visible = true;
            //        }
            //    }
            //    lblUsuario.Text = Session["empleado"].ToString();

            //}
        }



        protected void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}