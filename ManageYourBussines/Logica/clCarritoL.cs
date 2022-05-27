using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Presentacion
{
    public class clCarritoL
    {
        public int mtdRegistrarCar(clCarritoE objDatosClie)
        {
            clCarritoD objCarritoD = new clCarritoD();
            int result = objCarritoD.mtdRegistrar(objDatosClie);
            return result;

        }
        public int Mtdcar(clCarritoE objDatosPro)
        {
            clCarritoD objCarD = new clCarritoD();

            int numer = objCarD.mtdValidarCar(objDatosPro);
            return numer;



        }

        public int MtdcarPro(clCarritoE objDatosPro)
        {
            clCarritoD objCarProD = new clCarritoD();

            int numer = objCarProD.mtdValidarPro(objDatosPro);
            return numer;



        }
        public DataTable mtdListcar()
        {

            clCarritoD objCarritoD = new clCarritoD();
            List<clCarritoE> listarProductos = new List<clCarritoE>();
            listarProductos = objCarritoD.mtdListar();
            DataTable carrito = new DataTable();
            carrito.Columns.Add(new DataColumn("#", typeof(int)));
            carrito.Columns.Add(new DataColumn("idproducto", typeof(string)));
            carrito.Columns.Add(new DataColumn("idcliente", typeof(string)));
            carrito.Columns.Add(new DataColumn("imagen", typeof(string)));
            carrito.Columns.Add(new DataColumn("nombre", typeof(string)));
            carrito.Columns.Add(new DataColumn("describcion", typeof(string)));
            carrito.Columns.Add(new DataColumn("precio", typeof(float)));
            carrito.Columns.Add(new DataColumn("cantidad", typeof(int)));
            carrito.Columns.Add(new DataColumn("cantidadStock", typeof(int)));
            carrito.Columns.Add(new DataColumn("total", typeof(float)));

            int cuenta = listarProductos.Count;
            int num = cuenta + 1;
            float vtot = 0;
            float total = 0;
            for (int i = 0; i < num; i++)
            {



                if (i != cuenta)
                {
                    int numero = i + 1;
                    int idproducto = listarProductos[i].idproducto;
                    int idcliente = listarProductos[i].idcliente;
                    string imagen = listarProductos[i].Imagen;
                    string nombre = listarProductos[i].nombre;
                    string describcion = listarProductos[i].describcion;
                    float precio = listarProductos[i].precio;
                    int cantidad = listarProductos[i].catidad;
                    int cantidadstok = listarProductos[i].cantidadstock;
                    total = precio * cantidad;
                    vtot = vtot + total;

                    DataRow row = carrito.NewRow();
                    row["#"] = numero;
                    row["idproducto"] = idproducto;
                    row["idcliente"] = idcliente;
                    row["imagen"] = imagen;
                    row["nombre"] = nombre;
                    row["describcion"] = describcion;
                    row["precio"] = precio;
                    row["cantidad"] = cantidad;
                    row["cantidadstock"] = cantidadstok;
                    row["total"] = total;
                    carrito.Rows.Add(row);
                }
                else
                {
                    total = vtot;

                    DataRow row = carrito.NewRow();
                    row["#"] = i + 1;
                    row["imagen"] = "";
                    row["nombre"] = "vtotal";
                    row["describcion"] = "";
                    row["precio"] = 0;
                    row["cantidad"] = 0;
                    row["cantidadstock"] = 0;
                    row["total"] = total;
                    carrito.Rows.Add(row);

                }







            }
            return carrito;

        }

        public int mtdEliminarCar(clCarritoE objDatosPac)
        {
            clCarritoD obcarritoD = new clCarritoD();
            int result = obcarritoD.mtdEliminar(objDatosPac);
            return result;

        }


        public int mtdaumentar(clCarritoE objDatosPac)
        {
            clCarritoD obCarD = new clCarritoD();
            int result = obCarD.mtdEditar(objDatosPac);
            return result;

        }
    }
}