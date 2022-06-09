using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class clVentaL
    {
        public List<clVentaE> mtdListarVenta(clVentaE objfactura)
        {
            clVentaD objVenta = new clVentaD();
            List<clVentaE> objVentaD = new List<clVentaE>();
            objVentaD = objVenta.mtdListarVenta(objfactura);
            return objVentaD;
        }
        public List<clVentaE> mtdRegistrarV(clVentaE objDatosPac)
        {
            clVentaD obVehiculoD = new clVentaD();
            List<clVentaE> objVentaD = new List<clVentaE>();
           objVentaD = obVehiculoD.mtdRegistrar(objDatosPac);
            return objVentaD;

        }

        public int mtdRegistrarDetalles(clVentaE objDatosPac)
        {
            clVentaD obVehiculoD = new clVentaD();
           
           int filas = obVehiculoD.mtdRegistrarDeta(objDatosPac);
            return filas;

        }
        public int mtdelimin(clVentaE objDatosPac)
        {
            clVentaD obVehiculoD = new clVentaD();

            int filas = obVehiculoD.mtdElim(objDatosPac);
            return filas;

        }
    }
}