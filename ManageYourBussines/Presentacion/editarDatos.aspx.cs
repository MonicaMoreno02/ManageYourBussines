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
    public partial class editarDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cliente"].ToString() != "0")
            {
                Consultar();
            }
        }
            protected void Consultar()
            {
                clUsuarioE objDatos = new clUsuarioE();
                objDatos.idCliente = int.Parse(Session["cliente"].ToString());

                clLoginL objEmpleadoL = new clLoginL();
                clUsuarioE objDatosReci = new clUsuarioE();
                objDatosReci = objEmpleadoL.mtdEmpleado(objDatos);




            //lblEmpleado.Text = objDatosReci.documento;
            //    lblApellidos.Text = objDatosReci.nombreCliente;
            //    lblCorreo.Text = objDatosReci.apellidos;
            //    lblTipoDocumento.Text = objDatosReci.telefono;
            //    lblDocumento.Text = objDatosReci.direccion;
            //    lblTelefono.Text = objDatosReci.email;
            //    lblCargo.Text = objDatosReci.clave;
 
            }

            protected void btnActualizar_Click(object sender, EventArgs e)
            {



                clUsuarioE objUsurrioE = new clUsuarioE();

            objUsurrioE.idCliente = int.Parse(Session["idUser"].ToString());
            objUsurrioE.documento = txtNombres.Text;
            objUsurrioE.nombreCliente = txtApellidos.Text;
            objUsurrioE.apellidos = ddlTipoDocumento.Text;
            objUsurrioE.telefono = txtNumeroDocumento.Text;
            objUsurrioE.direccion = txtNumeroTelefonico.Text;

            //string FileName = txtNumeroDocumento.Text;



            objUsurrioE.email = txtCorreo.Text;
            objUsurrioE.clave = txtClave.Text;
           


                clLoginL objActualizar = new clLoginL();

                int filas = objActualizar.mtdEditarPersona(objUsurrioE);
                if (filas > 0)
                {
                    Session["user"] = txtNombres.Text;
                    Response.Redirect("frmConfiguracionEmpleados.aspx");
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "swal('Habitación Editada','Vuelva a cargar la página y compruebe la inserción','success')", true);

                }
                else
                {

                }
            }

            protected void Button1_Click(object sender, EventArgs e)
            {
                
            }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            clUsuarioE objDatos = new clUsuarioE();
            objDatos.idCliente = int.Parse(Session["cliente"].ToString());

            clLoginL objEmpleadoL = new clLoginL();
            clUsuarioE objDatosReci = new clUsuarioE();
            objDatosReci = objEmpleadoL.mtdEmpleado(objDatos);

            txtNombres.Text = objDatosReci.documento;
            txtApellidos.Text = objDatosReci.nombreCliente;
            ddlTipoDocumento.Text = objDatosReci.apellidos;
            txtNumeroDocumento.Text = objDatosReci.telefono;
            txtCorreo.Text = objDatosReci.direccion;
            txtNumeroTelefonico.Text = objDatosReci.email;
            txtClave.Text = objDatosReci.clave;

        }
    }
}
    
