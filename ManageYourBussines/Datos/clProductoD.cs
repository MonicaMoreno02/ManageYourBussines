using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.clConexion;

namespace ManageYourBussines.Datos
{
    public class clProductoD
    {/// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
        public List<clProductoE> mtdListar()
        {
            string sql = "SELECT * FROM producto WHERE idProducto <= 12; ";
            clConexion objConexion = new clConexion ();
            DataTable tblProducto = new DataTable();
            tblProducto = objConexion.mtdDesconectado(sql);

            List<clProductoE> listarProducto = new List<clProductoE>();

            int catnReg = tblProducto.Rows.Count;

            for (int i = 0; i < catnReg; i++)
            {
                clProductoE objDatosProducto = new clProductoE();
                objDatosProducto.idProducto = int.Parse(tblProducto.Rows[i]["idProducto"].ToString());
                  
                objDatosProducto.nombreProducto = tblProducto.Rows[i]["nombreProducto"].ToString();
                objDatosProducto.precio = float.Parse(tblProducto.Rows[i]["precio"].ToString());
                objDatosProducto.descripcion = tblProducto.Rows[i]["descripcion"].ToString();
                objDatosProducto.precio = float.Parse(tblProducto.Rows[i]["precio"].ToString());
                objDatosProducto.cantidadStock = int.Parse(tblProducto.Rows[i]["cantidadStock"].ToString());
                objDatosProducto.largo = tblProducto.Rows[i]["largo"].ToString();
                objDatosProducto.ancho = tblProducto.Rows[i]["ancho"].ToString();
                objDatosProducto.profundidad = tblProducto.Rows[i]["profundidad"].ToString();
                objDatosProducto.material = tblProducto.Rows[i]["material"].ToString();
                objDatosProducto.caracteristicas = tblProducto.Rows[i]["caracteristicas"].ToString();
                objDatosProducto.imagen = tblProducto.Rows[i]["imagen"].ToString();

                listarProducto.Add(objDatosProducto);
            }

            return listarProducto;

        }
        public List<clProductoE> mtdListarDetalles(clProductoE objdatos)
        {
            string sql = "select * from producto where idProducto ="+objdatos.idProducto+"";
            clConexion  objConexion = new clConexion();
            DataTable tblProducto = new DataTable();
            tblProducto = objConexion.mtdDesconectado(sql);

            List<clProductoE> listarProducto = new List<clProductoE>();

            int cantReg = tblProducto.Rows.Count;
            for (int i = 0;i<cantReg;i++)
            {

                clProductoE objDatosProductos = new clProductoE();
            
               
                objDatosProductos.idProducto = int.Parse(tblProducto.Rows[i]["idProducto"].ToString());
                objDatosProductos.imagen = tblProducto.Rows[i]["imagen"].ToString();
                objDatosProductos.nombreProducto = tblProducto.Rows[i]["nombreProductoProductoProducto"].ToString();
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
                objDatosProducto.nombreProducto = tblProducto.Rows[i]["nombreProducto"].ToString();
                objDatosProducto.precio = float.Parse(tblProducto.Rows[i]["precio"].ToString());
                objDatosProducto.descripcion = tblProducto.Rows[i]["descripcion"].ToString();
                objDatosProducto.cantidadStock =int.Parse( tblProducto.Rows[i]["cantidadStock"].ToString());


                listarProducto.Add(objDatosProducto);
            }
            return listarProducto;
        }



        public List<clProductoE> mtdListarProducto()
        {
            string sql = "SELECT * FROM producto ";
            clConexion objConexion = new clConexion();
            DataTable tblProducto = new DataTable();
            tblProducto = objConexion.mtdDesconectado(sql);

            List<clProductoE> listarProducto = new List<clProductoE>();

            int catnReg = tblProducto.Rows.Count;

            for (int i = 0; i < catnReg; i++)
            {
                clProductoE objDatosProducto = new clProductoE();
                objDatosProducto.idProducto = int.Parse(tblProducto.Rows[i]["idProducto"].ToString());
                objDatosProducto.nombreProducto = tblProducto.Rows[i]["nombreProducto"].ToString();
                objDatosProducto.descripcion = tblProducto.Rows[i]["descripcion"].ToString();
                objDatosProducto.precio = float.Parse(tblProducto.Rows[i]["precio"].ToString());
                objDatosProducto.cantidadStock =int.Parse ( tblProducto.Rows[i]["cantidadStock"].ToString());
                objDatosProducto.largo = tblProducto.Rows[i]["largo"].ToString();
                objDatosProducto.ancho = tblProducto.Rows[i]["ancho"].ToString();
                objDatosProducto.profundidad = tblProducto.Rows[i]["profundidad"].ToString();
                objDatosProducto.material = tblProducto.Rows[i]["material"].ToString();
                objDatosProducto.caracteristicas = tblProducto.Rows[i]["caracteristicas"].ToString();
                objDatosProducto.imagen = tblProducto.Rows[i]["imagen"].ToString();

                listarProducto.Add(objDatosProducto);
            }

            return listarProducto;

        }


        //Metodo que trae todos los datos de la tabla producto Cristian Salcedo
        public List<clProductoE> mtdListarProductos()
        {
            string sql = "select * from producto";
            clConexion objConexion = new clConexion();
            DataTable tblProducto = new DataTable();
            tblProducto = objConexion.mtdDesconectado(sql);

            List<clProductoE> listarProducto = new List<clProductoE>();

            int catnReg = tblProducto.Rows.Count;

            for (int i = 0; i < catnReg; i++)
            {
                clProductoE objDatosProducto = new clProductoE();
                objDatosProducto.idProducto = int.Parse(tblProducto.Rows[i]["idProducto"].ToString());
                objDatosProducto.nombreProducto = tblProducto.Rows[i]["nombreProducto"].ToString();
                objDatosProducto.descripcion = tblProducto.Rows[i]["descripcion"].ToString();
                objDatosProducto.precio = float.Parse(tblProducto.Rows[i]["precio"].ToString());
                objDatosProducto.cantidadStock = int.Parse(tblProducto.Rows[i]["cantidadStock"].ToString());
                objDatosProducto.largo = tblProducto.Rows[i]["largo"].ToString();
                objDatosProducto.ancho = tblProducto.Rows[i]["ancho"].ToString();
                objDatosProducto.profundidad = tblProducto.Rows[i]["profundidad"].ToString();
                objDatosProducto.material = tblProducto.Rows[i]["material"].ToString();
                objDatosProducto.caracteristicas = tblProducto.Rows[i]["caracteristicas"].ToString();
                objDatosProducto.imagen = tblProducto.Rows[i]["imagen"].ToString();



                listarProducto.Add(objDatosProducto);
            }

            return listarProducto;

        }

        //metodo para insertar productos a la base de datos Cristian Salcedo

        public int mtdAgregarD(clProductoE objDatosD)
        {
            string sql = "insert into producto (nombreProducto, descripcion, precio, cantidadStock, largo, ancho, profundidad, material, caracteristicas, imagen) values('" + objDatosD.nombreProducto + "'," +
               "'" + objDatosD.descripcion + "'," + objDatosD.precio + "," + objDatosD.cantidadStock + "," +
               "'" + objDatosD.largo + "','" + objDatosD.ancho + "','" + objDatosD.profundidad + "','" + objDatosD.material + "','" + objDatosD.caracteristicas + "','" + objDatosD.imagen + "')";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(sql);
            return resultado;

        }

        //Metodo para eliminar datos del producto en la base de datos Cristian Salcedo
        public int mtdEliminarD(int idProductos)
        {
            string sql = "delete  from producto where idProducto=" + idProductos + "";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(sql);
            return resultado;
        }

        //Metodo para editar datos del producto en la base de datos Cristian Salcedo

        public int mtdEditarD(clProductoE objDatosE)
        {
            //if (objDatosE.imagen != "")
            //{

                string sql = "update producto " +
                    "set nombreProducto='" + objDatosE.nombreProducto + "',descripcion='" + objDatosE.descripcion + "',precio=" + objDatosE.precio + "" +
                    ",cantidadStock=" + objDatosE.cantidadStock + ",largo='" + objDatosE.largo + "',ancho=" + objDatosE.ancho + "," +
                    "profundidad='" + objDatosE.profundidad + "',material='" + objDatosE.material + "',caracteristicas='" + objDatosE.caracteristicas + "',imagen='" + objDatosE.imagen + "' where idProducto = " + objDatosE.idProducto + "";

                clConexion objConexionS = new clConexion();
                int resultadoS = objConexionS.mtdConectado(sql);
                return resultadoS;
            //}
            //else
            //{
            //    string sqlN = "update producto " +
            //       "set nombreProducto='" + objDatosE.nombreProducto + "',descripcion='" + objDatosE.descripcion + "',precio=" + objDatosE.precio + "" +
            //       ",cantidadStock=" + objDatosE.cantidadStock + ",largo='" + objDatosE.largo + "',ancho=" + objDatosE.ancho + "," +
            //       "profundidad='" + objDatosE.profundidad + "',material='" + objDatosE.material + "',caracteristicas='" + objDatosE.caracteristicas + "' where idProducto = " + objDatosE.idProducto + "";

            //    clConexion objConexion = new clConexion();
            //    int resultado = objConexion.mtdConectado(sqlN);
            //    return resultado;
            //}
        }

    }
}

