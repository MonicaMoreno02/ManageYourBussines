using GemBox.Spreadsheet;
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
    public partial class frmbalance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            clBalanceE objbalance = new clBalanceE();
            clBalanceL objbalanceL = new clBalanceL();
        
            List<clBalanceE> listbalanceE = new List<clBalanceE>();
            DataTable dtBal = new DataTable();
            listbalanceE = objbalanceL.mtdListarBal(objbalance);
            dtBal.Columns.Add(new DataColumn("#", typeof(int)));
            dtBal.Columns.Add(new DataColumn("idVenta", typeof(int)));
            dtBal.Columns.Add(new DataColumn("fechaVenta", typeof(DateTime)));
            dtBal.Columns.Add(new DataColumn("codigoVenta", typeof(string)));
            dtBal.Columns.Add(new DataColumn("totalVenta", typeof(float)));

            int cuenta = listbalanceE.Count;
            int num = cuenta + 1;
            float vtot = 0;
            float total = 0;
            for (int i = 0; i < num; i++)
            {


                if (i != cuenta)
                {
                    int numero = i + 1;
                    int idventa = listbalanceE[i].idventa;
                    DateTime fecha = listbalanceE[i].fechaVenta;
                    string codigoVenta = listbalanceE[i].codigoVenta;
                    float totalVenta = listbalanceE[i].totalVenta;

                    vtot = vtot + totalVenta;

                    DataRow row = dtBal.NewRow();
                    row["#"] = numero;
                    row["idVenta"] = idventa;
                    row["fechaVenta"] = fecha;
                    row["codigoVenta"] = codigoVenta;
                    row["totalVenta"] = totalVenta;

                    dtBal.Rows.Add(row);
                }
                else
                {
                    total = vtot;

                    DataRow row = dtBal.NewRow();
                    row["#"] = i + 1;
                    row["idVenta"] = 0;
                    row["fechaVenta"] = DateTime.Now.ToString("dd-MM-yyyy");
                    row["codigoVenta"] = "total=";
                    row["totalVenta"] = total;

                    dtBal.Rows.Add(row);

                }





            }

            gvBalance.DataSource = dtBal;
            gvBalance.DataBind();

        }

        protected void gvBalance_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "detalles")
            {
                int lista = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvBalance.Rows[lista];
                string valor = gvBalance.Rows[lista].Cells[1].Text;
                int idVen = int.Parse(valor);
                if (idVen >= 0)
                {
                    clBalanceE objdetalles = new clBalanceE();
                    clBalanceL objdetaL = new clBalanceL();
                    objdetalles.idventa = idVen;
                    List<clBalanceE> listdetaE = new List<clBalanceE>();
                    DataTable dtdet = new DataTable();
                    listdetaE = objdetaL.mtdListarDetalles(objdetalles);
                    dtdet.Columns.Add(new DataColumn("#", typeof(int)));
                    dtdet.Columns.Add(new DataColumn("idVenta", typeof(int)));
                    dtdet.Columns.Add(new DataColumn("idProducto", typeof(int)));
                    dtdet.Columns.Add(new DataColumn("cantidad", typeof(string)));
                    dtdet.Columns.Add(new DataColumn("totalVenta", typeof(float)));

                    int cuenta1 = listdetaE.Count;
                    int num1 = cuenta1 + 1;
                    float vtot1 = 0;
                    float total1 = 0;
                    for (int i = 0; i < num1; i++)
                    {


                        if (i != cuenta1)
                        {
                            int numero = i + 1;
                            int idventa = listdetaE[i].idventa;
                            int idproducto = listdetaE[i].idProducto;
                            int cantidad = listdetaE[i].cantidad;
                            float valortotal = listdetaE[i].valorTotal;

                            vtot1 = vtot1 + valortotal;

                            DataRow row1 = dtdet.NewRow();
                            row1["#"] = numero;
                            row1["idVenta"] = idventa;
                            row1["idproducto"] = idproducto;
                            row1["cantidad"] = cantidad;
                            row1["totalVenta"] = valortotal;

                            dtdet.Rows.Add(row1);
                        }
                        else
                        {
                            total1 = vtot1;

                            DataRow row1 = dtdet.NewRow();
                            row1["#"] = i + 1;
                            row1["idVenta"] = 0;
                            row1["idproducto"] = 0;
                            row1["cantidad"] = 0;
                            row1["totalVenta"] = vtot1;

                            dtdet.Rows.Add(row1);

                        }
                        gvDetalles.DataSource = dtdet;
                        gvDetalles.DataBind();

                    }


                }

                string desde = txtDesde.Text;
                string hasta = txthasta.Text;

                DataTable dtBal = new DataTable();
                List<clBalanceE> listbalanceE = new List<clBalanceE>();
                if (desde == "" || hasta == "")
                {
                    clBalanceE objbalance = new clBalanceE();
                    clBalanceL objbalanceL = new clBalanceL();
   
                   
                  
                    listbalanceE = objbalanceL.mtdListarBal(objbalance);

                }
                else
                {
                    int consult = 1;

                    clBalanceE objbalance = new clBalanceE();
                    clBalanceL objbalanceL = new clBalanceL();
                    objbalance.desde = DateTime.Parse(txtDesde.Text);
                    objbalance.Hasta = DateTime.Parse(txthasta.Text);
                    objbalance.num = consult;
                   
                    listbalanceE = objbalanceL.mtdListarBal(objbalance);
                }
                
                dtBal.Columns.Add(new DataColumn("#", typeof(int)));
                dtBal.Columns.Add(new DataColumn("idVenta", typeof(int)));
                dtBal.Columns.Add(new DataColumn("fechaVenta", typeof(DateTime)));
                dtBal.Columns.Add(new DataColumn("codigoVenta", typeof(string)));
                dtBal.Columns.Add(new DataColumn("totalVenta", typeof(float)));

                int cuenta = listbalanceE.Count;
                int num = cuenta + 1;
                float vtot = 0;
                float total = 0;
                for (int i = 0; i < num; i++)
                {


                    if (i != cuenta)
                    {
                        int numero = i + 1;
                        int idventa = listbalanceE[i].idventa;
                        DateTime fecha = listbalanceE[i].fechaVenta;
                        string codigoVenta = listbalanceE[i].codigoVenta;
                        float totalVenta = listbalanceE[i].totalVenta;

                        vtot = vtot + totalVenta;

                        DataRow row1 = dtBal.NewRow();
                        row1["#"] = numero;
                        row1["idVenta"] = idventa;
                        row1["fechaVenta"] = fecha;
                        row1["codigoVenta"] = codigoVenta;
                        row1["totalVenta"] = totalVenta;

                        dtBal.Rows.Add(row1);
                    }
                    else
                    {
                        total = vtot;

                        DataRow row1 = dtBal.NewRow();
                        row1["#"] = i + 1;
                        row1["idVenta"] = 0;
                        row1["fechaVenta"] = DateTime.Now.ToString("dd-MM-yyyy");
                        row1["codigoVenta"] = "total=";
                        row1["totalVenta"] = total;

                        dtBal.Rows.Add(row1);

                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // If you are using the Professional version, enter your serial key below.
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            // Create test DataSet with five DataTables
            DataSet dataSet = new DataSet();
            for (int i = 0; i < 2; i++)
            {
                if (i!=1)
                {
                    clBalanceE objbalance = new clBalanceE();
                    clBalanceL objbalanceL = new clBalanceL();
                    
                    List<clBalanceE> listbalanceE = new List<clBalanceE>();
                    DataTable dtBal = new DataTable();
                    listbalanceE = objbalanceL.mtdListarBal(objbalance);
                    dtBal.Columns.Add(new DataColumn("#", typeof(int)));
                    dtBal.Columns.Add(new DataColumn("idVenta", typeof(int)));
                    dtBal.Columns.Add(new DataColumn("fechaVenta", typeof(DateTime)));
                    dtBal.Columns.Add(new DataColumn("codigoVenta", typeof(string)));
                    dtBal.Columns.Add(new DataColumn("totalVenta", typeof(float)));

                    int cuenta = listbalanceE.Count;
                    int num = cuenta + 1;
                    float vtot = 0;
                    float total = 0;
                    for (int j = 0; j < cuenta; j++)
                    {

                        if (j != cuenta)
                        {
                            int numero = j + 1;
                            int idventa = listbalanceE[j].idventa;
                            DateTime fecha = listbalanceE[j].fechaVenta;
                            string codigoVenta = listbalanceE[j].codigoVenta;
                            float totalVenta = listbalanceE[j].totalVenta;

                            vtot = vtot + totalVenta;
                            dtBal.Rows.Add(new object[] { numero, idventa, fecha, codigoVenta, totalVenta });

                        }
                        else
                        {
                            total = vtot;

                            dtBal.Rows.Add(new object[] { "", "", "", "", "", "", total });

                        }
                      
                    }
                    dataSet.Tables.Add(dtBal);

                }
                else
                {
                    clBalanceL objbalanceL = new clBalanceL();
                    List<clBalanceE> listbalanceE = new List<clBalanceE>();
                    DataTable dtBal = new DataTable();
                    listbalanceE = objbalanceL.mtdListarBalC();
                    dtBal.Columns.Add(new DataColumn("#", typeof(int)));
                    dtBal.Columns.Add(new DataColumn("idVenta", typeof(int)));
                    dtBal.Columns.Add(new DataColumn("fechaVenta", typeof(DateTime)));
                    dtBal.Columns.Add(new DataColumn("codigoVenta", typeof(string)));
                    dtBal.Columns.Add(new DataColumn("idProducto", typeof(int)));
                    dtBal.Columns.Add(new DataColumn("nombre producto", typeof(string)));
                    dtBal.Columns.Add(new DataColumn("cantidad", typeof(int)));
                    dtBal.Columns.Add(new DataColumn("precio", typeof(float)));
                    dtBal.Columns.Add(new DataColumn("valortotal", typeof(float)));
                

                    int cuenta = listbalanceE.Count;
                    int num = cuenta + 2;
                    float vtot = 0;
                    float total = 0;
                    for (int j = 0; j < cuenta; j++)
                    {

                        if (j !=cuenta)
                        {
                            int numero = j + 1;
                            int idventa = listbalanceE[j].idventa;
                            DateTime fecha = listbalanceE[j].fechaVenta;
                            string codigoVenta = listbalanceE[j].codigoVenta;
                            int idProducto=listbalanceE[j].idProducto;
                            string nombre=listbalanceE[j].nombre;
                            int cantidad = listbalanceE[j].cantidad;
                            float precio = listbalanceE[j].precio;
                            float valortotal = precio * cantidad;
                            
                            dtBal.Rows.Add(new object[] { numero, idventa, fecha, codigoVenta,idProducto,nombre,cantidad,precio,valortotal });

                        }
                        else
                        {
                            total = vtot;
                            int numero=0;
                            int idventa = 0;
                            DateTime fecha = DateTime.Now;
                            string codigoVenta = "";
                            int idProducto=0;
                            string nombre = "";
                            int cantidad = 0;
                            float precio = 0;


                            dtBal.Rows.Add(new object[] { numero, idventa, fecha, codigoVenta, idProducto, nombre, cantidad, precio, total });

                        }
                       
                    }
                    dataSet.Tables.Add(dtBal);

                }





            }

            // Create and fill a sheet for every DataTable in a DataSet
            var workbook = new ExcelFile();
            foreach (DataTable dtBal in dataSet.Tables)
            {
                ExcelWorksheet worksheet = workbook.Worksheets.Add(dtBal.TableName);

                // Insert DataTable to an Excel worksheet.
                worksheet.InsertDataTable(dtBal,
                    new InsertDataTableOptions()
                    {
                        ColumnHeaders = true
                    });
            }
            string ahora = DateTime.Now.ToString("yyyy-MM-dd-hh-m-s");


         
        

            string nombreArchivo = "reporte" + ahora;
         
            workbook.Save("D:/reporte"+ahora+".xlsx");
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Archivo creado correctamente guardado en: D:/reporte"+ahora+".xlsx');", true);

        }

        protected void btnfiltro_Click(object sender, EventArgs e)
        {
            string desde = txtDesde.Text;
            string hasta = txthasta.Text;
            
            

            if (desde== ""||hasta == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('los campos estan vacios');", true);

            }
            else
            {


                int consult = 1;
                clBalanceE objbalance = new clBalanceE();
                clBalanceL objbalanceL = new clBalanceL();
                objbalance.desde = DateTime.Parse(txtDesde.Text);
                objbalance.Hasta = DateTime.Parse(txthasta.Text);
                objbalance.num = consult;
                List<clBalanceE> listbalanceE = new List<clBalanceE>();
                DataTable dtBal = new DataTable();
                listbalanceE = objbalanceL.mtdListarBal(objbalance);
                dtBal.Columns.Add(new DataColumn("#", typeof(int)));
                dtBal.Columns.Add(new DataColumn("idVenta", typeof(int)));
                dtBal.Columns.Add(new DataColumn("fechaVenta", typeof(DateTime)));
                dtBal.Columns.Add(new DataColumn("codigoVenta", typeof(string)));
                dtBal.Columns.Add(new DataColumn("totalVenta", typeof(float)));

                int cuenta = listbalanceE.Count;
                int num = cuenta + 1;
                float vtot = 0;
                float total = 0;
                for (int i = 0; i < num; i++)
                {


                    if (i != cuenta)
                    {
                        int numero = i + 1;
                        int idventa = listbalanceE[i].idventa;
                        DateTime fecha = listbalanceE[i].fechaVenta;
                        string codigoVenta = listbalanceE[i].codigoVenta;
                        float totalVenta = listbalanceE[i].totalVenta;

                        vtot = vtot + totalVenta;

                        DataRow row = dtBal.NewRow();
                        row["#"] = numero;
                        row["idVenta"] = idventa;
                        row["fechaVenta"] = fecha;
                        row["codigoVenta"] = codigoVenta;
                        row["totalVenta"] = totalVenta;

                        dtBal.Rows.Add(row);
                    }
                    else
                    {
                        total = vtot;

                        DataRow row = dtBal.NewRow();
                        row["#"] = i + 1;
                        row["idVenta"] = 0;
                        row["fechaVenta"] = DateTime.Now.ToString("dd-MM-yyyy");
                        row["codigoVenta"] = "total=";
                        row["totalVenta"] = total;

                        dtBal.Rows.Add(row);

                    }





                }

                gvBalance.DataSource = dtBal;
                gvBalance.DataBind();
            }
        }
    }
}