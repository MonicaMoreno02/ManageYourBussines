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
            string sql = "select * from venta inner join detallesVenta on venta.idVenta=detallesVenta.idVenta inner join producto on detallesVenta.idProducto = producto.idProducto";
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
                objDatosVenta.codigoVenta = tblVenta.Rows[i]["codigoVenta"].ToString();
                //objDatosVenta.totalVenta = float.Parse(tblVenta.Rows[i]["totalVenta"].ToString());
                objDatosVenta.idCliente = int.Parse(tblVenta.Rows[i]["idVenta"].ToString());
                objDatosVenta.idDetallesVenta = int.Parse(tblVenta.Rows[i]["idDetallesVenta"].ToString());
                objDatosVenta.idProducto = int.Parse(tblVenta.Rows[i]["idProducto"].ToString());
                objDatosVenta.cantidad = int.Parse(tblVenta.Rows[i]["cantidad"].ToString());
                //objDatosVenta.valorTotal = int.Parse(tblVenta.Rows[i]["valorTotal"].ToString());
                objDatosVenta.nombre = (tblVenta.Rows[i]["nombreProducto"].ToString());
                objDatosVenta.precio = float.Parse(tblVenta.Rows[i]["precio"].ToString());


                listarVenta.Add(objDatosVenta);
            }
            return listarVenta;
        }
    }
}