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
            consultar();
        }

      
        protected void consultar()
        {
            clUsuarioE objDatos = new clUsuarioE();
            objDatos.idCliente = int.Parse(Session["idCliente"].ToString());

            clUsuarioL objUsuarioL = new clUsuarioL();
            clUsuarioE objDatosReci = new clUsuarioE();
            objDatosReci = objUsuarioL.mtdEmpleado(objDatos);


            txtDocumento.Text = objDatosReci.documento;
            txtnombreCliente.Text = objDatosReci.nombreCliente;
            txtapellidos.Text = objDatosReci.apellidos;
            txttelefono.Text = objDatosReci.telefono;
            txtDireccion.Text = objDatosReci.direccion;
            txtEmail.Text = objDatosReci.emailCliente;
            txtClave.Text = objDatosReci.claveCliente;


        }








        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            clUsuarioE objUsuarioE = new clUsuarioE();

            objUsuarioE.idCliente = int.Parse(Session["idCliente"].ToString());
            objUsuarioE.documento = txtDocumento.Text;
            objUsuarioE.nombreCliente = txtnombreCliente.Text;
            objUsuarioE.apellidos = txtapellidos.Text;
            objUsuarioE.telefono = txttelefono.Text;
            objUsuarioE.direccion = txtDireccion.Text;
            objUsuarioE.emailCliente = txtEmail.Text;
            objUsuarioE.claveCliente = txtClave.Text;







            clUsuarioL objUusarios = new clUsuarioL();

            int filas = objUusarios.mtdEditarPersona(objUsuarioE);
            if (filas > 0)
            {
                Session["usuario"] = txtnombreCliente.Text;
                Response.Redirect("editarDatos.aspx");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "swal('info clente','Vuelva a cargar la página y compruebe la inserción','success')", true);

            }
            else
            {

            }
        }
        protected void btnDatos_Click1(object sender, EventArgs e)
        {
            clUsuarioE objDatos = new clUsuarioE();
            objDatos.idCliente = int.Parse(Session["idCliente"].ToString());



            clUsuarioL objDatosUser = new clUsuarioL();
            clUsuarioE objDatosReci = new clUsuarioE();
            objDatosReci = objDatosUser.mtdEmpleado(objDatos);

            txtDocumento.Text = objDatosReci.documento;
            txtnombreCliente.Text = objDatosReci.nombreCliente;
            txtapellidos.Text = objDatosReci.apellidos;
            txttelefono.Text = objDatosReci.telefono;
            txtDireccion.Text = objDatosReci.direccion;
            txtEmail.Text = objDatosReci.emailCliente;
            txtClave.Text = objDatosReci.claveCliente;


        }
    }
}
