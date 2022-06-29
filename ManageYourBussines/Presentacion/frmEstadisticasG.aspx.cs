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
    public partial class frmEstadisticasG : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected string obtenerDatos()
        {

            clBalanceL objDatos = new clBalanceL();
            DataTable Datos = new DataTable();

            Datos = objDatos.mtdListarGraficasL();
            string strDatos;

            strDatos = "['Task','Hours'],";

            foreach (DataRow dr in Datos.Rows)
            {
                strDatos = strDatos + "[";
                strDatos = strDatos + "'" + dr[0] + "'" + "," + dr[1];
                strDatos = strDatos + "],";
            }

            strDatos = strDatos + "]";
            return strDatos;
        }
    }
}