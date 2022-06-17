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
    public partial class frmTareas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static List<clTareasE> mtdListarTarea()
        {
            clTareasL objPersonaL = new clTareasL();
            List<clTareasE> listaPersonas = new List<clTareasE>();
            listaPersonas = objPersonaL.mtdListarTareas();
            return listaPersonas;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string estado = "inactivo";
            clTareasE objTarea = new clTareasE();
            objTarea.nombreTareas = txtNombreTarea.Text;
            objTarea.descripcionTareas = txtDescripcionTarea.Text;
            objTarea.estado = estado;
            objTarea.tiempo = int.Parse(txtTiempo.Text);
           

            clTareasL objTareas = new clTareasL();
           
            int filas = objTareas.mtdRegistrarTarea(objTarea);
            if (filas!=0)
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