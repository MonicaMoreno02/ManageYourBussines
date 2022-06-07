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
    public partial class frmVenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string idc = Convert.ToString(Session["idc"]);
            int idClien = int.Parse(idc);



            clCarritoE objcarrito = new clCarritoE();
            objcarrito.idcliente = idClien;
            clCarritoL objCarritoL = new clCarritoL();
            DataTable carrito = new DataTable();
            List<clCarritoE> listarCar = new List<clCarritoE>();
            //Session["objeto"] = objCarritoL.mtdListcar();
            carrito = objCarritoL.mtdListcar(objcarrito);

            int cuen = carrito.Rows.Count-1;
            int  cue = cuen - 1;

           string fechaVen = DateTime.Now.ToString("yyyy-MM-dd");

            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var Charsarr = new char[8];
            var random = new Random();

            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }

            var resultString = new String(Charsarr);
            string codigoVent=resultString.ToString();

            float valortotal = float.Parse(carrito.Rows[cuen][9].ToString());

            clVentaE objVenta = new clVentaE();

            objVenta.fechaVen= fechaVen;
            objVenta.codigoVenta = codigoVent;
            objVenta.valorTotal= valortotal;
            objVenta.idCliente = idClien;
            
            clVentaL objVehiculoL = new clVentaL();
            List<clVentaE> lisDetalles = new List<clVentaE>();
            lisDetalles = objVehiculoL.mtdRegistrarV(objVenta);

            int filas = lisDetalles[0].filas;

            if (filas > 0)
            {
                for (int i = 0; i < cuen; i++)
                {


                    clVentaE objDetVenta = new clVentaE();
                    objDetVenta.idVenta = lisDetalles[0].idVenta;
                    objDetVenta.idProducto = int.Parse(carrito.Rows[i][1].ToString());
                    objDetVenta.cantidad= int.Parse(carrito.Rows[i][7].ToString());
                    objDetVenta.valorTotal= float.Parse(carrito.Rows[i][9].ToString());
                    clVentaL objdetallesL = new clVentaL();

                    int filas1 = objdetallesL.mtdRegistrarDetalles(objDetVenta);



                }

                clVentaE objelimCar = new clVentaE();
                objVenta.idCliente = idClien;
                clVentaL objelimL = new clVentaL();
              
                 int fil = objelimL.mtdelimin(objVenta);

            }
            else
            {
              
            }


            clVentaE objfactura = new clVentaE();
            objfactura.idCliente = idClien;
            objfactura.codigoVenta = codigoVent;
            clVentaL objVentaL = new clVentaL();

            List<clVentaE> lista = new List<clVentaE>();
            DataTable datos = new  DataTable();
            lista = objVentaL.mtdListarVenta(objfactura);
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
                    DataRow row = datos.NewRow();
                    row["#"] = numero;
                    row["nombre"] = nombre;
                    row["codigoVenta"] = codigoVenta;
                    row["precio"] = precio;
                    row["cantidad"] = cantidad;
                    row["total"] = total;
                    datos.Rows.Add(row);

                }
                else
                {
                    string fech = lista[0].fechaVenta.ToString("yyyy/MM/dd");

                    vtot = vtot + total;
                    DataRow row = datos.NewRow();
                    row["#"] = i+1;
                    row["nombre"] = fech;
                    row["codigoVenta"] = "";
                    row["precio"] = 0;
                    row["cantidad"] =0;
                    row["total"] = vtot;
                    datos.Rows.Add(row);


                }

            }

            GridView1.DataSource = datos;
            GridView1.DataBind();
            GridView1.UseAccessibleHeader = true;
            //GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void btnPdf_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            DataSet dataset = new DataSet();
            for(int i = 0; i < 5; i++)
            {
                clVentaL objVenta = new clVentaL();
                List<clVentaE> listVenta = new List<clVentaE>();
                listVenta = objVenta.mtdListarVenta();

                DataTable dataTable = new DataTable("Table " + (i + 1));
                dataTable.Columns.Add(new DataColumn("#", typeof(int)));
                dataTable.Columns.Add(new DataColumn("nombre", typeof(string)));
                dataTable.Columns.Add(new DataColumn("codigoVenta", typeof(string)));
                dataTable.Columns.Add(new DataColumn("precio", typeof(float)));
                dataTable.Columns.Add(new DataColumn("cantidad", typeof(int)));
                dataTable.Columns.Add(new DataColumn("total", typeof(float)));

                int cuenta = listVenta.Count;
                int num = cuenta + 1;
                float vtot = 0;
                float total = 0;
                for(int j= 0; j < cuenta; j++)
                {
                    if (i != cuenta)
                    {
                        int numero = j + 1;
                        string nombre = listVenta[j].nombre;
                        string codigoVenta = listVenta[j].codigoVenta;
                        float precio = listVenta[j].precio;
                        int cantidad = listVenta[j].cantidad;
                        total = precio * cantidad;
                        vtot = vtot + total;
                        dataTable.Rows.Add(new object[] { numero, nombre, codigoVenta, precio, cantidad, total });
                    }
                    else
                    {
                        int numero=0;
                        string nombre = "";
                        string codigoVenta = "";
                        float precio = 0;
                        int cantidad = 0;
                        total = vtot;
                        dataTable.Rows.Add(new object[] { numero, nombre, codigoVenta, precio, cantidad, vtot });
                    }
                }
                dataset.Tables.Add(dataTable);
            }
            var workbook = new ExcelFile();
            foreach (DataTable dataTable in dataset.Tables)
            {
                ExcelWorksheet worksheet = workbook.Worksheets.Add(dataTable.TableName);

                // Insert DataTable to an Excel worksheet.
                worksheet.InsertDataTable(dataTable,
                    new InsertDataTableOptions()
                    {
                        ColumnHeaders = true
                    });
            }
            string ahora = DateTime.Now.ToString("yyyy-MM-dd-hh-m-s");
           
            workbook.Save(" D:/report" + ahora+".pdf");

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Archivo creado correctamente guardado en: D:/report.pdf');", true);
        }
    }
}