using ManageYourBussines.Entidades;
using ManageYourBussines.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using GemBox.Spreadsheet;

namespace ManageYourBussines.Presentacion
{
    public partial class frmInventario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            clProductoL objProductoL = new clProductoL();
            List<clProductoE> listInvent = new List<clProductoE>();
            listInvent = objProductoL.mtdListarP();

            DataTable inventario = new DataTable();
            inventario.Columns.Add(new DataColumn("#", typeof(int)));
            inventario.Columns.Add(new DataColumn("idproducto", typeof(string)));

            inventario.Columns.Add(new DataColumn("nombre", typeof(string)));
            inventario.Columns.Add(new DataColumn("describcion", typeof(string)));
            inventario.Columns.Add(new DataColumn("precio", typeof(float)));
            inventario.Columns.Add(new DataColumn("cantidadStock", typeof(int)));
            inventario.Columns.Add(new DataColumn("total", typeof(float)));

            int cuenta = listInvent.Count;
            int num = cuenta + 1;
            float vtot = 0;
            float total = 0;
            for (int i = 0; i < num; i++)
            {


                if (i != cuenta)
                {
                    int numero = i + 1;
                    int idproducto = listInvent[i].idProducto;
                    string nombre = listInvent[i].nombre;
                    string describcion = listInvent[i].descripcion;
                    float precio = listInvent[i].precio;
                    int cantidadstok = listInvent[i].cantidadStock;
                    total = precio * cantidadstok;
                    vtot = vtot + total;

                    DataRow row = inventario.NewRow();
                    row["#"] = numero;
                    row["idproducto"] = idproducto;
                    ;
                    row["nombre"] = nombre;
                    row["describcion"] = describcion;
                    row["precio"] = precio;

                    row["cantidadstock"] = cantidadstok;
                    row["total"] = total;
                    inventario.Rows.Add(row);






                }
                else
                {
                    total = vtot;

                    DataRow row = inventario.NewRow();
                    row["#"] = i + 1;

                    row["nombre"] = "vtotal";
                    row["describcion"] = "";
                    row["precio"] = 0;

                    row["cantidadstock"] = 0;
                    row["total"] = total;
                    inventario.Rows.Add(row);

                }
                gvInventario.DataSource = inventario;
                gvInventario.DataBind();


                //int cuenta=listInvent.Count;
                //for (int i = 0; i < cuenta; i++)
                //{
                //    string producto = listInvent[i].nombre;
                //    string idproducto= listInvent[i].idProducto.ToString();
                //    ListItem j;
                //    j = new ListItem(producto,idproducto);
                //    dpProducto.Items.Add(j);


                //}

            }
        }

        protected void btnreport_Click(object sender, EventArgs e)
        { // If you are using the Professional version, enter your serial key below.
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            // Create test DataSet with five DataTables
            DataSet dataSet = new DataSet();
            for (int i = 0; i < 1; i++)
            {
                clProductoL objProductoL = new clProductoL();
                List<clProductoE> listInvent = new List<clProductoE>();
                listInvent = objProductoL.mtdListarP();

                DataTable dataTable = new DataTable("Table " + (i + 1));
                dataTable.Columns.Add(new DataColumn("#", typeof(int)));
                dataTable.Columns.Add(new DataColumn("idproducto", typeof(string)));

                dataTable.Columns.Add(new DataColumn("nombre", typeof(string)));
                dataTable.Columns.Add(new DataColumn("describcion", typeof(string)));
                dataTable.Columns.Add(new DataColumn("precio", typeof(float)));
                dataTable.Columns.Add(new DataColumn("cantidadStock", typeof(int)));
                dataTable.Columns.Add(new DataColumn("total", typeof(float)));


                int cuenta = listInvent.Count;
                int num = cuenta + 1;
                float vtot = 0;
                float total = 0;
                for (int j = 0; i < num; i++)
                {


                    if (i != cuenta)
                    {
                        int numero = i + 1;
                        int idproducto = listInvent[i].idProducto;
                        string nombre = listInvent[i].nombre;
                        string describcion = listInvent[i].descripcion;
                        float precio = listInvent[i].precio;
                        int cantidadstok = listInvent[i].cantidadStock;
                        total = precio * cantidadstok;
                        vtot = vtot + total;

                        DataRow row = dataTable.NewRow();
                        row["#"] = numero;
                        row["idproducto"] = idproducto;
                        ;
                        row["nombre"] = nombre;
                        row["describcion"] = describcion;
                        row["precio"] = precio;

                        row["cantidadstock"] = cantidadstok;
                        row["total"] = total;
                        dataTable.Rows.Add(row);






                    }
                    else
                    {
                        total = vtot;

                        DataRow row = dataTable.NewRow();
                        row["#"] = i + 1;

                        row["nombre"] = "vtotal";
                        row["describcion"] = "";
                        row["precio"] = 0;

                        row["cantidadstock"] = 0;
                        row["total"] = total;
                        dataTable.Rows.Add(row);

                    }
                    //dataSet.Tables.Add(dataTable);
                }

                // Create and fill a sheet for every DataTable in a DataSet
                var workbook = new ExcelFile();
                foreach (DataTable dataTable1 in dataSet.Tables)
                {
                    ExcelWorksheet worksheet = workbook.Worksheets.Add(dataTable.TableName);

                    // Insert DataTable to an Excel worksheet.
                    worksheet.InsertDataTable(dataTable,
                        new InsertDataTableOptions()
                        {
                            ColumnHeaders = true
                        });
                }

                workbook.Save("D:/file.xlsx");
            }
        }
    }
}

        