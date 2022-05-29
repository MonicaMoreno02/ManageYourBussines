﻿using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{
    public partial class frmcarrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string valor = Convert.ToString(Request.QueryString["idC"]);
            lbidC.Attributes.Add("style", "DISPLAY:none");
            lbidC.Text = valor;

            int idClien = int.Parse(valor);
            clCarritoE objcarrito = new clCarritoE();
            objcarrito.idcliente = idClien;
            clCarritoL objCarritoL = new clCarritoL();
            DataTable carrito = new DataTable();
            List<clCarritoE> listarCar = new List<clCarritoE>();
            //Session["objeto"] = objCarritoL.mtdListcar();
            carrito = objCarritoL.mtdListcar(objcarrito);


            gvCar.DataSource = carrito;
            gvCar.DataBind();

        }

        protected void gvCar_RowCommand(object sender, GridViewCommandEventArgs e)
        {



            if (e.CommandName == "eliminar")
            {

                string valor = Convert.ToString(Request.QueryString["idC"]);
                lbidC.Attributes.Add("style", "DISPLAY:none");
                lbidC.Text = valor;

                int idClien = int.Parse(valor);
                clCarritoE objcarrito = new clCarritoE();
                objcarrito.idcliente = idClien;
                clCarritoL objCarritoL = new clCarritoL();
                DataTable carrito = new DataTable();
                List<clCarritoE> listarCar = new List<clCarritoE>();
                //Session["objeto"] = objCarritoL.mtdListcar();
                carrito = objCarritoL.mtdListcar(objcarrito);

                int lista = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvCar.Rows[lista];
             
                int cuen = carrito.Rows.Count;
                cuen = cuen - 2;
                if (cuen >= lista)
                {
                    int idproducto = int.Parse(carrito.Rows[lista]["idproducto"].ToString());
                    int idcliente = int.Parse(carrito.Rows[lista]["idcliente"].ToString());


                    clCarritoE objcarritos = new clCarritoE();

                    objcarritos.idcliente = idcliente;
                    objcarritos.idproducto = idproducto;
                    clCarritoL objVehiculoL = new clCarritoL();
                    int filas = objVehiculoL.mtdEliminarCar(objcarritos);

                    if (filas > 0)
                    {

                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('eliminado correctamente');", true);
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('error');", true);

                    }
                    string valor1 = Convert.ToString(Request.QueryString["idC"]);
                    lbidC.Attributes.Add("style", "DISPLAY:none");
                    lbidC.Text = valor;

                    int idClien1 = int.Parse(valor);
                    clCarritoE objcarrito1 = new clCarritoE();
                    objcarrito1.idcliente = idClien;
                    clCarritoL objCarritoL1 = new clCarritoL();
                    DataTable dt = new DataTable();
                    List<clCarritoE> listarCar1 = new List<clCarritoE>();
                    //Session["objeto"] = objCarritoL.mtdListcar();
                    carrito = objCarritoL.mtdListcar(objcarrito);



                    gvCar.DataSource = dt;
                    gvCar.DataBind();
                }



            }
            if (e.CommandName == "aumentar")
            {
                int lista = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvCar.Rows[lista];
                string valor = gvCar.Rows[lista].Cells[5].Text;
                string stock = gvCar.Rows[lista].Cells[8].Text;
                int cantidad = int.Parse(valor);
                int stock1=int.Parse(stock);
                cantidad = cantidad + 1;
                if (stock1>=cantidad)
                {
                    string valor1 = Convert.ToString(Request.QueryString["idC"]);
                    lbidC.Attributes.Add("style", "DISPLAY:none");
                    lbidC.Text = valor1;

                    int idClien = int.Parse(valor1);
                    clCarritoE objcarrito = new clCarritoE();
                    objcarrito.idcliente = idClien;
                    clCarritoL objCarritoL = new clCarritoL();
                    DataTable carrito = new DataTable();
                    List<clCarritoE> listarCar = new List<clCarritoE>();
                    //Session["objeto"] = objCarritoL.mtdListcar();
                    carrito = objCarritoL.mtdListcar(objcarrito);

                    int cuen = carrito.Rows.Count;
                    cuen = cuen - 2;
                    if (cuen >= lista)
                    {


                        int idproducto = int.Parse(carrito.Rows[lista]["idproducto"].ToString());
                        int idcliente = int.Parse(carrito.Rows[lista]["idcliente"].ToString());

                        clCarritoE objcarritos = new clCarritoE();
                        objcarritos.idproducto = idproducto;
                        objcarritos.idcliente = idcliente;
                        objcarritos.catidad = cantidad;
                        clCarritoL objcarritoL = new clCarritoL();

                        int filas = objcarritoL.mtdaumentar(objcarritos);

                        string valor2 = Convert.ToString(Request.QueryString["idC"]);
                        lbidC.Attributes.Add("style", "DISPLAY:none");
                        lbidC.Text = valor1;

                        int idClien2 = int.Parse(valor1);
                        clCarritoE objcarrito2 = new clCarritoE();
                        objcarrito2.idcliente = idClien;
                        clCarritoL objCarritoL2 = new clCarritoL();
                        DataTable carrito2 = new DataTable();
                        List<clCarritoE> listarCar2 = new List<clCarritoE>();
                        //Session["objeto"] = objCarritoL.mtdListcar();
                        carrito = objCarritoL.mtdListcar(objcarrito);

                    }
                }
                
            }
            if (e.CommandName == "disminuir")
            {
                int lista = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvCar.Rows[lista];
                string valor = gvCar.Rows[lista].Cells[5].Text;
                int cantidad = int.Parse(valor);
                cantidad = cantidad - 1;
                if (cantidad>=0)
                {
                    string valor1 = Convert.ToString(Request.QueryString["idC"]);
                    lbidC.Attributes.Add("style", "DISPLAY:none");
                    lbidC.Text = valor1;

                    int idClien = int.Parse(valor1);
                    clCarritoE objcarrito = new clCarritoE();
                    objcarrito.idcliente = idClien;
                    clCarritoL objCarritoL = new clCarritoL();
                    DataTable carrito = new DataTable();
                    List<clCarritoE> listarCar = new List<clCarritoE>();
                    //Session["objeto"] = objCarritoL.mtdListcar();
                    carrito = objCarritoL.mtdListcar(objcarrito);

                    int cuen = carrito.Rows.Count;
                    cuen = cuen - 2;
                    if (cuen >= lista)
                    {
                        int idproducto = int.Parse(carrito.Rows[lista]["idproducto"].ToString());
                        int idcliente = int.Parse(carrito.Rows[lista]["idcliente"].ToString());

                        clCarritoE objcarritos = new clCarritoE();
                        objcarritos.idproducto = idproducto;
                        objcarritos.idcliente = idcliente;
                        objcarritos.catidad = cantidad;
                        clCarritoL objcarritoL = new clCarritoL();

                        int filas = objcarritoL.mtdaumentar(objcarritos);

                        int idClien2 = int.Parse(valor1);
                        clCarritoE objcarrito2 = new clCarritoE();
                        objcarrito2.idcliente = idClien;
                        clCarritoL objCarritoL2 = new clCarritoL();
                        DataTable carrito2 = new DataTable();
                        List<clCarritoE> listarCar2 = new List<clCarritoE>();
                        //Session["objeto"] = objCarritoL.mtdListcar();
                        carrito = objCarritoL.mtdListcar(objcarrito); ;
                    }
                }

                
            }



        }

    }


    }
