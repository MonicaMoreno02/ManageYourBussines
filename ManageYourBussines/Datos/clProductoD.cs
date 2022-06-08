using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.ClConexion;

namespace ManageYourBussines.Datos
{
    public class clProductoD
    {/// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
        public List<clProductoE> mtdListar()
        {
            string sql = "SELECT * FROM imagen INNER JOIN producto ON imagen.idProducto = producto.idProducto; ";
            clConexion objConexion = new clConexion();
            DataTable tblProducto = new DataTable();
            tblProducto = objConexion.mtdDesconectado(sql);

            List<clProductoE> listarProducto = new List<clProductoE>();

            int catnReg = tblProducto.Rows.Count;

            for (int i = 0; i < catnReg; i++)
            {
                clProductoE objDatosProducto = new clProductoE();
                objDatosProducto.idImagen = int.Parse(tblProducto.Rows[i]["idImagen"].ToString());
                objDatosProducto.imagen = tblProducto.Rows[i]["imagen"].ToString();
                objDatosProducto.material = tblProducto.Rows[i]["material"].ToString();
                objDatosProducto.caracteristicas = tblProducto.Rows[i]["caracteristicas"].ToString();
                objDatosProducto.idProducto = int.Parse(tblProducto.Rows[i]["idProducto"].ToString());
                objDatosProducto.nombre = tblProducto.Rows[i]["nombreProducto"].ToString();
                objDatosProducto.precio = float.Parse(tblProducto.Rows[i]["precio"].ToString());
                objDatosProducto.descripcion = tblProducto.Rows[i]["descripcion"].ToString();
                objDatosProducto.cantidadStock = int.Parse(tblProducto.Rows[i]["cantidadStock"].ToString());

                listarProducto.Add(objDatosProducto);
            }

            return listarProducto;

        }
        public List<clProductoE> mtdListarDetalles(clProductoE objdatos)
        {
            string sql = "select * from producto where idProducto ="+objdatos.idProducto+"";
            clConexion objConexion = new clConexion();
            DataTable tblProducto = new DataTable();
            tblProducto = objConexion.mtdDesconectado(sql);

            List<clProductoE> listarProducto = new List<clProductoE>();

            int cantReg = tblProducto.Rows.Count;
            for (int i = 0;i<cantReg;i++)
            {

                clProductoE objDatosProductos = new clProductoE();
            
               
                objDatosProductos.idProducto = int.Parse(tblProducto.Rows[i]["idProducto"].ToString());
                objDatosProductos.imagen = tblProducto.Rows[i]["imagen"].ToString();
                objDatosProductos.nombre = tblProducto.Rows[i]["nombreProducto"].ToString();
                objDatosProductos.precio = float.Parse(tblProducto.Rows[i]["precio"].ToString());
                objDatosProductos.descripcion = tblProducto.Rows[i]["descripcion"].ToString();
                objDatosProductos.material = tblProducto.Rows[i]["material"].ToString();
                objDatosProductos.caracteristicas = tblProducto.Rows[i]["caracteristicas"].ToString();
                objDatosProductos.cantidadStock = int.Parse(tblProducto.Rows[i]["cantidadStock"].ToString());



              listarProducto.Add(objDatosProductos);
            }
            return listarProducto;
        }
        public List<clProductoE> mtdList(clProductoE objproductos)
        {
            string sql = "select * from producto where idProducto =" + objproductos.idProducto + "";
            clConexion objConexion = new clConexion();
            DataTable tblProducto = new DataTable();
            tblProducto = objConexion.mtdDesconectado(sql);

            List<clProductoE> listarProducto = new List<clProductoE>();

            int catnReg = tblProducto.Rows.Count;

            for (int i = 0; i < catnReg; i++)
            {
                clProductoE objDatosProducto = new clProductoE();
               
                objDatosProducto.imagen = tblProducto.Rows[i]["imagen"].ToString();
                objDatosProducto.material = tblProducto.Rows[i]["material"].ToString();
                objDatosProducto.caracteristicas = tblProducto.Rows[i]["caracteristicas"].ToString();
                objDatosProducto.idProducto = int.Parse(tblProducto.Rows[i]["idProducto"].ToString());
                objDatosProducto.nombre = tblProducto.Rows[i]["nombreProducto"].ToString();
                objDatosProducto.precio = float.Parse(tblProducto.Rows[i]["precio"].ToString());
                objDatosProducto.descripcion = tblProducto.Rows[i]["descripcion"].ToString();
                objDatosProducto.cantidadStock =int.Parse( tblProducto.Rows[i]["cantidadStock"].ToString());


                listarProducto.Add(objDatosProducto);
            }

            return listarProducto;

        }
    }
}

