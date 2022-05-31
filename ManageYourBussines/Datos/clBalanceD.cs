using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.ClConexion;

namespace ManageYourBussines.Datos
{
    public class clBalanceD
    {
                public List<clBalanceE> mtdListar()
        {
            string sql = "select * from venta";
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
                objbalance.codigoVenta=tblBalance.Rows[i]["codigoVenta"].ToString();
                objbalance.totalVenta = int.Parse(tblBalance.Rows[i]["totalVenta"].ToString());
                objbalance.idventa = int.Parse(tblBalance.Rows[i]["idVenta"].ToString()); ;
                listarBal.Add(objbalance);
            }

            return listarBal;

        }
        
             public List<clBalanceE> mtdListarDeta(clBalanceE objdetalles)
        {
            string sql = "select * from detallesVenta where idVenta="+objdetalles.idventa;
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
    }
}