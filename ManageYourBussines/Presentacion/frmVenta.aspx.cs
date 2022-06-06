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
                }
            }

            gvfactura.DataSource = lista;
            gvfactura.DataBind();
            gvfactura.UseAccessibleHeader = true;
            //GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
}