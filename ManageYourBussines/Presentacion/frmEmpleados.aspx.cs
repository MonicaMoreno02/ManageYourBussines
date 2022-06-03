using ManageYourBussines.Entidades;
using ManageYourBussines.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{
    public partial class frmEmpleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static List<clEmpleadoE>mtdListar()
        {
            clEmpleadoL objEmpleado = new clEmpleadoL();
            List<clEmpleadoE> listaEmpleados = new List<clEmpleadoE>();

            listaEmpleados = objEmpleado.mtdListarEmpleadoL();

            return listaEmpleados;
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            clPersonaE objDatos = new clPersonaE();
            objDatos.idPersona = int.Parse(txtID.Text);
            objDatos.documento = txtDocumento.Text;
            objDatos.nombres = txtNombres.Text;
            objDatos.apellidos = txtApellidos.Text;
            objDatos.email = txtEmail.Text;
            objDatos.celular = txtCelular.Text;

            clPersonaL objPersonaL = new clPersonaL();
            objPersonaL.mtdEditarPersona(objDatos);

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            clEmpleadoE objDatos = new clEmpleadoE();
            objDatos.
        }
    }
}