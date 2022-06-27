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
            clBalanceL objEstadisticas = new clBalanceL();
            List<clBalanceE> listaProductos = new List<clBalanceE>();

            listaProductos = objEstadisticas.mtdListarGraficasL();

            
            string[] series = listaProductos;
            chartEstadisticas.Titles.Add("Producto-Cantidad");
        }
    }
}