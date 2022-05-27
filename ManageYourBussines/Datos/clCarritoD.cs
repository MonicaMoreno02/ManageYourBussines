using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.ClConexion;

namespace ManageYourBussines.Datos
{
    public class clCarritoD
    {
        public int mtdRegistrar(clCarritoE objDatosCarrito)
        {
            string sql = "insert into carrito (idproducto,nombre,describcion,precio,cantidadstock,cantidad," +
                  "Imagen,idcliente)" +

                  "values('" + objDatosCarrito.idproducto + "','" + objDatosCarrito.nombre + "'," +
                  "'" + objDatosCarrito.describcion + "','" + objDatosCarrito.precio + "','" + objDatosCarrito.cantidadstock + "'," +
                  "'" + objDatosCarrito.catidad + "','" + objDatosCarrito.Imagen + "'," +
              "'" + objDatosCarrito.idcliente + "')";

            clConexion objConexion = new clConexion();
            int resutado = objConexion.mtdConectado(sql);
            return resutado;

        }
        public int mtdValidarCar(clCarritoE objDatosPro)
        {
            int numer = 2;
            string sql = "select count(*) from carrito where idcliente=" + objDatosPro.idcliente;
            clConexion objConexion = new clConexion();
            DataTable tblCAR = new DataTable();
            tblCAR = objConexion.mtdDesconectado(sql);





            numer = int.Parse(tblCAR.Rows[0][0].ToString());






            return numer;




        }

        public int mtdValidarPro(clCarritoE objDatosPro)
        {
            int numer = 2;
            string sql = " select count(*) carrito from carrito where idcliente =" + objDatosPro.idcliente + "and  idproducto=" + objDatosPro.idproducto;
            clConexion objConexion = new clConexion();
            DataTable tblCAR = new DataTable();
            tblCAR = objConexion.mtdDesconectado(sql);





            numer = int.Parse(tblCAR.Rows[0][0].ToString());







            return numer;




        }
        public List<clCarritoE> mtdListar()
        {
            string sql = "select * from carrito";
            clConexion objConexion = new clConexion();
            DataTable tblCarrito = new DataTable();
            tblCarrito = objConexion.mtdDesconectado(sql);

            List<clCarritoE> listarCarrito = new List<clCarritoE>();

            int catnReg = tblCarrito.Rows.Count;

            for (int i = 0; i < catnReg; i++)
            {
                clCarritoE objDatoscarrito = new clCarritoE();
                objDatoscarrito.idcarrito = int.Parse(tblCarrito.Rows[i]["idcarrito"].ToString());
                objDatoscarrito.idcliente = int.Parse(tblCarrito.Rows[i]["idcliente"].ToString());
                objDatoscarrito.idproducto = int.Parse(tblCarrito.Rows[i]["idproducto"].ToString());
                objDatoscarrito.cantidadstock = int.Parse(tblCarrito.Rows[i]["cantidadstock"].ToString());
                objDatoscarrito.catidad = int.Parse(tblCarrito.Rows[i]["cantidad"].ToString());
                objDatoscarrito.precio = float.Parse(tblCarrito.Rows[i]["precio"].ToString());
                objDatoscarrito.describcion = tblCarrito.Rows[i]["describcion"].ToString();
                objDatoscarrito.Imagen = tblCarrito.Rows[i]["imagen"].ToString();
                objDatoscarrito.nombre = tblCarrito.Rows[i]["nombre"].ToString();




                listarCarrito.Add(objDatoscarrito);
            }

            return listarCarrito;

        }

        public int mtdEliminar(clCarritoE objDatoscar)
        {
            string sql = "DELETE FROM  carrito where (idproducto = " + objDatoscar.idproducto + ")and idcliente =(" + objDatoscar.idcliente + ")";


            clConexion objConexion = new clConexion();
            int resutado = objConexion.mtdConectado(sql);
            return resutado;
        }

        public int mtdEditar(clCarritoE objDatosCar)
        {
            string sql = "UPDATE carrito  SET cantidad =" + objDatosCar.catidad + " WHERE ( idcliente =" + objDatosCar.idcliente + ")and ( idproducto=" + objDatosCar.idproducto + " )";




            clConexion objConexion = new clConexion();
            int resutado = objConexion.mtdConectado(sql);
            return resutado;
        }
    }
}