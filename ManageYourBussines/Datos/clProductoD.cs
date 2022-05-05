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
    {
        public List<clProductoE> mtdListar()
        {
            string sql = "select * from producto ";
            clConexion objConexion = new clConexion();
            DataTable tblProducto = new DataTable();
            tblProducto = objConexion.mtdDesconectado(sql);

            List<clProductoE> listarProducto = new List<clProductoE>();

            int catnReg = tblProducto.Rows.Count;

            for (int i = 0; i < catnReg; i++)
            {
                clProductoE objDatosProducto = new clProductoE();
                objDatosProducto.idProducto = int.Parse(tblProducto.Rows[i]["idProducto"].ToString());
                objDatosProducto.nombre = tblProducto.Rows[i]["nombre"].ToString();
                objDatosProducto.descripcion = tblProducto.Rows[i]["descripcion"].ToString();
                objDatosProducto.precio = float.Parse(tblProducto.Rows[i]["precio"].ToString());
                objDatosProducto.imagen = tblProducto.Rows[i]["imagen"].ToString();
                


                listarProducto.Add(objDatosProducto);
            }

            return listarProducto;

        }
    }
    }
