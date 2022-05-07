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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            clClienteE objClientesE = new clClienteE();

            objClientesE.documento = txtDocumento.Text;
            objClientesE.nombres = txtNombres.Text;
            objClientesE.apellidos = txtApellidos.Text;
            objClientesE.telefono = txtTelefono.Text;
            objClientesE.direccion = txtDireccion.Text;
            objClientesE.email = txtEmail.Text;
            //objClientesE.clave = txtClave.Text;





            clClienteL objProductosL = new clClienteL();

            int filas = objProductosL.mtdRegistrarCliente(objClientesE);
            if (filas > 0)

            {

                //< div class="alert alert-info">
                // <strong>Info!</strong> This alert box could indicate a neutral informative change or action.
                //     </div>
                lblMensaje.Text = "producto registrado ";

            }
            else
            {
                lblMensaje.Text = "error al registrar el producto  ";
            }

         


        }


        protected void cmdLimpiar_Click(object sender, EventArgs e)
        {
            //object p = txtDocumento.Clear();
            //object p1 = txtNombres.Clear();
            //txtApellidos.Clear();
            //txtTelefono.Clear();
            //txtDireccion.Clear();
            //txtEmail.Clear();
            //txtDocumento.Focus();

        }
    }
}