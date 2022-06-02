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
    public partial class frmVenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clVentaL objVentaL = new clVentaL();
            List<clVentaE> lista = new List<clVentaE>();
            DataTable datos = new  DataTable();
            lista = objVentaL.mtdListarVenta();
            datos.Columns.Add(new DataColumn("#", typeof(int)));
            datos.Columns.Add(new DataColumn("nombre", typeof(string)));
            datos.Columns.Add(new DataColumn("codigoVenta", typeof(string)));
            datos.Columns.Add(new DataColumn("precio", typeof(float)));
            datos.Columns.Add(new DataColumn("cantidad", typeof(int)));
            datos.Columns.Add(new DataColumn("total", typeof(float)));

            int cuenta = lista.Count;
            int num = cuenta + 1;
            float vtot = 0;
            float total = 0;
            for (int i = 0; i < num; i++)
            {
                if (i!=cuenta)
                {
                    int numero = i + 1;
                    string nombre = lista[i].nombre;
                    string codigoVenta = lista[i].codigoVenta;
                    float precio = lista[i].precio;
                    int cantidad = lista[i].cantidad;
                    total = precio*cantidad;

                    vtot = vtot + total;
                }
            }

            GridView1.DataSource = lista;
            GridView1.DataBind();
            GridView1.UseAccessibleHeader = true;
            //GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
}