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
    public partial class frmEmpleadoss : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClEmpleadoL objEmpleadoL = new ClEmpleadoL();
            DataTable empleado = new DataTable();
            List<clEmpleadoE> listarCar = new List<clEmpleadoE>();
            
            empleado = objEmpleadoL.mtdListarEmple();


           gvemple.DataSource = empleado;
            gvemple.DataBind();
        }

       

        protected void gvemple_RowCommand1(object sender, GridViewCommandEventArgs e)
        {

        }
    }
    
}