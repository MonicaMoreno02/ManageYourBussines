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
        public List<clVentaE> mtdListarVenta(clVentaE objfactura)
        {
            string sql = "select * from venta inner join detallesVenta on venta.idVenta=detallesVenta.idVenta inner join producto on detallesVenta.idProducto = producto.idProducto where (idCliente=" + objfactura.idCliente + ") and(codigoVenta = '" + objfactura.codigoVenta + "')";
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
                objDatosVenta.valorTotal = float.Parse(tblVenta.Rows[i]["valorTotal"].ToString());
                objDatosVenta.nombre = (tblVenta.Rows[i]["nombreProducto"].ToString());
                objDatosVenta.precio = float.Parse(tblVenta.Rows[i]["precio"].ToString());


                listarVenta.Add(objDatosVenta);
            }
            return listarVenta;
        }
        public List<clVentaE> mtdRegistrar(clVentaE objDatosV)
        {
            string sql = "insert into venta ( fechaVenta,codigoVenta,totalVenta,idCliente)" +
                "  values('" + objDatosV.fechaVen + "','" + objDatosV.codigoVenta + "'," + objDatosV.valorTotal + "," + objDatosV.idCliente + ")";


            clConexion objConexion = new clConexion();
            int resutado = objConexion.mtdConectado(sql);
            //return resutado;

            sql = "";

            sql = " select IDENT_CURRENT('Venta')";
            clConexion objConexion1 = new clConexion();
            DataTable tblVenta = new DataTable();
            tblVenta = objConexion1.mtdDesconectado(sql);

            List<clVentaE> listarVenta = new List<clVentaE>();

            int cantReg = tblVenta.Rows.Count;
            clVentaE objDatosVenta = new clVentaE();
            objDatosVenta.idVenta = int.Parse(tblVenta.Rows[0][0].ToString());
            objDatosVenta.filas = resutado;
            listarVenta.Add(objDatosVenta);
            return listarVenta;
        }

        public int mtdRegistrarDeta(clVentaE objDatosV)
        {
            string sql = "insert into detallesVenta ( idVenta,idProducto,cantidad,valorTotal)" +
                "  values(" + objDatosV.idVenta + "," + objDatosV.idProducto + "," + objDatosV.cantidad + "," + objDatosV.valorTotal + ")";


            clConexion objConexion = new clConexion();
            int resutado = objConexion.mtdConectado(sql);
            return resutado;
        }
        public int mtdElim(clVentaE objDatosV)
        {
            string sql = "delete carrito where idCliente=" + objDatosV.idCliente;
              


            clConexion objConexion = new clConexion();
            int resutado = objConexion.mtdConectado(sql);
            return resutado;
        }
    }

}
    