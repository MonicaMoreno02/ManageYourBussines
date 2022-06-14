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
            objProductoD = objProducto.mtdListarProductos();
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
        public List<clProductoE> mtdListarProd(clProductoE objDatosPac)
        {
            clProductoD obcarritoD = new clProductoD();
            List<clProductoE> lista=new List<clProductoE>();
            lista = obcarritoD.mtdList(objDatosPac);
            return lista;

        }
        //Metodo para recibir objeto de datos y enviarlo a Datos Cristian Salcedo
        public int mtdAgregar(clProductoE objDatosProducto)
        {
            clProductoD objDatosD = new clProductoD();
            int resultado = objDatosD.mtdAgregarD(objDatosProducto);
            return resultado;

        }
        //Metodo para recibir un parametro a eliminar y enviarlo a datos Cristian Salcedo

        public int mtdEliminar(int idProductos)
        {
            clProductoD objDatosD = new clProductoD();
            int resultado = objDatosD.mtdEliminarD(idProductos);
            return resultado;

        }


        //Metodo para recibir objeto de datos a editar y enviarlo a datos Cristian Salcedo
        public int mtdEditar(clProductoE objDatosE)
        {
            clProductoD objDatosD = new clProductoD();
            int resultado = objDatosD.mtdEditarD(objDatosE);
            return resultado;

        }

    }
}