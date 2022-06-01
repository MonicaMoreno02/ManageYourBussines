using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.ClConexion;

namespace ManageYourBussines.Datos
{
    public class clVentaD
    {
     public List<clVentaE> mtdListarVenta()
        {
            string sql = "select * from venta";
            clConexion objConexion = new clConexion();
            DataTable tblVenta = new DataTable();
            tblVenta = objConexion.mtdDesconectado(sql);

            List<clVentaE> listarVenta = new List<clVentaE>();

            int cantReg = tblVenta.Rows.Count;

            for (int i = 0; i < cantReg; i++)
            {
                clVentaE objDatosVenta = new clVentaE();
                objDatosVenta.idVenta = int.Parse(tblVenta.Rows[i]["idVenta"].ToString());
                objDatosVenta.fechaVenta = DateTime.Parse(tblVenta.Rows[i]["fechaVenta"].ToString());
                objDatosVenta.codigoVenta = tblVenta.Rows[i]["largo"].ToString();
                objDatosVenta.totalVenta = float.Parse(tblVenta.Rows[i]["totalVenta"].ToString());
                objDatosVenta.idCliente = int.Parse(tblVenta.Rows[i]["idVenta"].ToString());
                objDatosVenta.idEmpleado = int.Parse(tblVenta.Rows[i]["idVenta"].ToString());


                listarVenta.Add(objDatosVenta);
            }
            return listarVenta;
        }
    }
}