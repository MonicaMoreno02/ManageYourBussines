using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.clConexion;

namespace ManageYourBussines.Datos
{
    public class clBalanceD
    {
        public List<clBalanceE> mtdListar(clBalanceE objbal)
        {
            string fec1=objbal.desde.ToString("yyyy/MM/dd");
            string fec2 = objbal.Hasta.ToString("yyyy/MM/dd");
            string sql;
            if (objbal.num == 0)
            {
                sql = "select * from venta";
            }
            else
            {
                sql = "select * from venta  where fechaVenta  BETWEEN '" + fec1 + "' and '" + fec2 + "'";

            }
            clConexion objConexion = new clConexion();
            DataTable tblBalance = new DataTable();
            tblBalance = objConexion.mtdDesconectado(sql);

            List<clBalanceE> listarBal = new List<clBalanceE>();

            int catnReg = tblBalance.Rows.Count;

            for (int i = 0; i < catnReg; i++)
            {
                clBalanceE objbalance = new clBalanceE();
                objbalance.idventa = int.Parse(tblBalance.Rows[i]["idVenta"].ToString());
                objbalance.fechaVenta = DateTime.Parse(tblBalance.Rows[i]["fechaVenta"].ToString());
                objbalance.codigoVenta = tblBalance.Rows[i]["codigoVenta"].ToString();
                objbalance.totalVenta = float.Parse(tblBalance.Rows[i]["totalVenta"].ToString());
                objbalance.idventa = int.Parse(tblBalance.Rows[i]["idVenta"].ToString()); ;
                listarBal.Add(objbalance);
            }

            return listarBal;

        }

        public List<clBalanceE> mtdListarDeta(clBalanceE objdetalles)
        {
            string sql = "select * from detallesVenta where idVenta=" + objdetalles.idventa;
            clConexion objConexion = new clConexion();
            DataTable tblBalance = new DataTable();
            tblBalance = objConexion.mtdDesconectado(sql);

            List<clBalanceE> listarBal = new List<clBalanceE>();

            int catnReg = tblBalance.Rows.Count;

            for (int i = 0; i < catnReg; i++)
            {
                clBalanceE objbalance = new clBalanceE();
                objbalance.idDetallesVenta = int.Parse(tblBalance.Rows[i]["idDetallesVenta"].ToString());
                objbalance.idventa = int.Parse(tblBalance.Rows[i]["idventa"].ToString());
                objbalance.idProducto = int.Parse(tblBalance.Rows[i]["idProducto"].ToString());
                objbalance.cantidad = int.Parse(tblBalance.Rows[i]["cantidad"].ToString());
                objbalance.valorTotal = float.Parse(tblBalance.Rows[i]["valorTotal"].ToString());
                listarBal.Add(objbalance);
            }

            return listarBal;

        }

        public List<clBalanceE> mtdListarBal()
        {
            string sql = "select * from venta inner join detallesVenta on venta.idVenta=detallesVenta.idVenta inner join producto on detallesVenta.idProducto=producto.idProducto";
            clConexion objConexion = new clConexion();
            DataTable tblBalance = new DataTable();
            tblBalance = objConexion.mtdDesconectado(sql);

            List<clBalanceE> listarBal = new List<clBalanceE>();

            int catnReg = tblBalance.Rows.Count;

            for (int i = 0; i < catnReg; i++)
            {
                clBalanceE objbalance = new clBalanceE();
                objbalance.idventa = int.Parse(tblBalance.Rows[i]["idVenta"].ToString());
                objbalance.fechaVenta = DateTime.Parse(tblBalance.Rows[i]["fechaVenta"].ToString());
                objbalance.codigoVenta = tblBalance.Rows[i]["codigoVenta"].ToString();
                objbalance.totalVenta = int.Parse(tblBalance.Rows[i]["totalVenta"].ToString());
                objbalance.idProducto= int.Parse(tblBalance.Rows[i]["idProducto"].ToString());
                objbalance.nombre=tblBalance.Rows[i]["nombreProducto"].ToString();
                objbalance.cantidad = int .Parse(tblBalance.Rows[i]["cantidad"].ToString());
                objbalance.precio=int.Parse(tblBalance.Rows [i]["precio"].ToString ());
                objbalance.valorTotal= int.Parse(tblBalance.Rows[i]["valorTotal"].ToString());


                listarBal.Add(objbalance);
            }
            return listarBal;
        }

        public DataTable mtdlistargraficos()
        {

            //string sql = "select producto.nombreproducto, detallesVenta.cantidad from producto inner join detallesVenta on producto.idProducto = detallesVenta.idProducto";
            string sql = "select * from producto";
            clConexion objConexion = new clConexion();

            DataTable tblGraficos = new DataTable();
            tblGraficos = objConexion.mtdDesconectado(sql);

            int catnReg = tblGraficos.Rows.Count;

            return tblGraficos;

        }
    }
}