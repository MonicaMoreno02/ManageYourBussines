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
            txtEmail.Text = objDatosReci.email;
            txtClave.Text = objDatosReci.clave;


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
            objUsuarioE.email = txtEmail.Text;
            objUsuarioE.clave = txtClave.Text;



            //string FileName = txtNumeroDocumento.Text;
            //string nombreArchivo = fCargaImagen.FileName;

            //string ruta = "~/Presentacion/Recursos/assets/images/faces/" + nombreArchivo;
            ////string ruta1 = "~/Presentacion/Recursos/assets/images/faces/" + txtNumeroDocumento.Text;




            //fCargaImagen.SaveAs(Server.MapPath(ruta) + txtNumeroDocumento.Text);
            //objEmpleadoE.email = txtCorreo.Text;
            //objEmpleadoE.clave = txtClave.Text;
            //objEmpleadoE.imagen = nombreArchivo;



            clUsuarioL objUusarios = new clUsuarioL();

            int filas = objUusarios.mtdEditarPersona(objUsuarioE);
            if (filas > 0)
            {
                Session["usuario"] = txtnombreCliente.Text;
                Response.Redirect("editarDatos.aspx");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "swal('Habitación Editada','Vuelva a cargar la página y compruebe la inserción','success')", true);

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
                txtEmail.Text = objDatosReci.email;
                txtClave.Text = objDatosReci.clave;


            }
        }

    
}
