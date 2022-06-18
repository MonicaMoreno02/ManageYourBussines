using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            lblEmpleado.Text = Session["usuario"].ToString();
            lblApellidos.Text = Session["idCliente"].ToString();
            lblEmpleado1.Text = Session["empleado"].ToString();
        }
      

        

        //protected void btnCerrarSesion_Click(object sender, EventArgs e)
        //{

        //    Session.RemoveAll();
        //    Response.Redirect("../index.aspx");
        //}

        //protected void btnCerrarSesion_Click1(object sender, EventArgs e)
        //{
        //    Session.RemoveAll();
        //    Response.Redirect("../index.aspx");
        //}

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        protected void btnEditar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("editarDatos.aspx");
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

            Session.Abandon();


            //FormsAuthentication.SignOut();
            //HttpContext.Current.Response.Redirect("Autenticaci Login/frmLoginEmpresa.aspx", true); /* tu pagina de logueo*/


            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));



            Response.Redirect("../index.aspx");

        }
    }
}