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
    public partial class frmTarea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtIdTareaEditar.Attributes.Add("style", "DISPLAY:none");
            txtIdTarea.Attributes.Add("style", "DISPLAY:none");
        }
        [WebMethod]

        public static List<clTareasE> mtdListarTar()
        {
            clTareasL objTareaL = new clTareasL();
            List<clTareasE> listarTarea = new List<clTareasE>();
            listarTarea = objTareaL.mtdListarTareas();
            return listarTarea;
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            clTareasE objDatos = new clTareasE();
            objDatos.idTareas = int.Parse(txtIdTareaEditar.Text);
            objDatos.nombreTarea = txtNombreEditar.Text;
            objDatos.descripcionTarea = txtDescripcionEditar.Text;
            objDatos.estado = txtEstadoEditar.Text;
            objDatos.tiempo = int.Parse(txtTiempoEditar.Text);


            clTareasL objEmpleadoL = new clTareasL();
            int resultado = objEmpleadoL.mtdEditar(objDatos);

            if (resultado != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Registro editado correctamente:(');", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No se ha podido editar el registro:(');", true);
            }

        }
        int idTareas = 0;
        protected void txtEliminar_Click(object sender, EventArgs e)
        {

            idTareas = int.Parse(txtIdTarea.Text);
            clTareasL objDatosL = new clTareasL();
            int resultado = objDatosL.mtdEliminar(idTareas);


            if (resultado != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Registro eliminar¿do correctamente:(');", true);
                Response.Redirect("frmTarea.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Algo ha salido mal y no hemos eliminado tu registro :(');", true);
                Response.Redirect("frmTarea.aspx");
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string estado = "inactivo";
            clTareasE objTarea = new clTareasE();
            objTarea.nombreTarea = txtNombreTarea.Text;
            objTarea.descripcionTarea = txtDescripcionTarea.Text;
            objTarea.estado = estado;
            objTarea.tiempo = int.Parse(txtTiempo.Text);


            clTareasL objTareas = new clTareasL();

            int filas = objTareas.mtdRegistrarTarea(objTarea);
            if (filas != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('se ha registrado correctamente la tarea');", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('no se pudo agregar la tarea');", true);
            }
        }
    }
}
