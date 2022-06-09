using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ManageYourBussines
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

            Session["usuarioPersona"] = null;
            Session["idUsuarioPersona"] = null;
            Session["cliente"]=null;
            Session["idCliente"]=null ;
            Session["nombreEmpleado"]=null;
            Session["apellidosEmple"] = null;
            //Session["nombreCliente"] = null;
            //Session["apellidosCliente"] = null;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Session["empleado"] = null;
            Session["idEmpleado"] = null;



            Session["usuarioPersona"] = null;
            Session["idUsuarioPersona"] = null;
            Session["cliente"] = null;
            Session["idCliente"] = null;
            Session["nombreEmpleado"] = null;
            Session["apellidosEmple"] = null;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}