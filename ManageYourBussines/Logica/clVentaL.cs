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
        public List<clVentaE> mtdListarVenta()
        {
            clVentaD objVenta = new clVentaD();
            List<clVentaE> objVentaD = new List<clVentaE>();
            objVentaD = objVenta.mtdListarVenta();
            return objVentaD;
        }
    }
}