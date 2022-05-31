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
        public List<clProductoE> mtdListarD(clProductoE objdatos)
        {
            clProductoD objProducto = new clProductoD();
            List<clProductoE> listarProductos = new List<clProductoE>();
            listarProductos = objProducto.mtdListarDetalles(objdatos);
            return listarProductos;
        }
        public List<clProductoE> mtdListarProducto()
        {
            clProductoD objProducto = new clProductoD();
            List<clProductoE> objProductoD = new List<clProductoE>();
            objProductoD = objProducto.mtdListarProducto();
            return objProductoD;
        }
    }
}