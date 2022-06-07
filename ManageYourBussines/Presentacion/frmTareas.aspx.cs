using ManageYourBussines.Entidades;
using ManageYourBussines.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{
    public partial class frmTareas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clTareasL objTareaL = new clTareasL();
            DataTable tarea = new DataTable();
            List<clTareasE> listarCar = new List<clTareasE>();

            tarea = objTareaL.mtdListarTareas();


            gv.DataSource = tarea;
            gv.DataBind();
        }

        protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}