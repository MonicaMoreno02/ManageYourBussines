using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class clProductoL
    {/// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
        public List<clProductoE> mtdListarP()
        {
            clProductoD objProducto = new clProductoD();
            List<clProductoE> objProductoD = new List<clProductoE>();
            objProductoD = objProducto.mtdListar();
            return objProductoD;

        }
    }
}