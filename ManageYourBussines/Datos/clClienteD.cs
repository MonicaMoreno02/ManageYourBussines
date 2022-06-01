using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.ClConexion;

namespace ManageYourBussines.Datos
{
    public class clClienteD
    {

        //Listar Datos de los clientes
        public List<clClienteE> mtdListarD()
        {
            string sql = "select * from cliente";
            clConexion objConexion = new clConexion();
            DataTable tblCliente = new DataTable();
            tblCliente = objConexion.mtdDesconectado(sql);

            List<clClienteE> listarCliente = new List<clClienteE>();

            int cantReg = tblCliente.Rows.Count;
            for (int i = 0; i < cantReg; i++)
            {

                clClienteE objDatosClientes = new clClienteE();


                objDatosClientes.idCliente = int.Parse(tblCliente.Rows[i]["idCliente"].ToString());
                objDatosClientes.documento = tblCliente.Rows[i]["documento"].ToString();
                objDatosClientes.nombres = tblCliente.Rows[i]["nombreCliente"].ToString();
                objDatosClientes.apellidos = tblCliente.Rows[i]["apellidos"].ToString();
                objDatosClientes.telefono = tblCliente.Rows[i]["telefono"].ToString();
                objDatosClientes.direccion = tblCliente.Rows[i]["direccion"].ToString();
                objDatosClientes.email = tblCliente.Rows[i]["email"].ToString();
                objDatosClientes.clave = tblCliente.Rows[i]["clave"].ToString();


                listarCliente.Add(objDatosClientes);
            }
            return listarCliente;
        }

        //Listar Detalles de venta
        public List<clDetallesE> mtdListarDetallesD( )
        {
            string sql = "select cliente.nombreCliente , venta.fechaVenta, venta.codigoVenta, venta.totalVenta, empleado.nombreEmpleado, detallesVenta.cantidad, detallesVenta.valorTotal, producto.nombreProducto"+
                " from cliente inner join venta on cliente.idCliente = venta.idCliente inner join empleado on venta.idEmpleado = empleado.idEmpleado" + 
                " inner join detallesVenta on detallesVenta.idVenta = venta.idVenta"+
                " inner join producto on producto.idProducto = detallesVenta.idProducto";
            clConexion objConexion = new clConexion();
            DataTable tblDetallesVenta = new DataTable();
            tblDetallesVenta = objConexion.mtdDesconectado(sql);

            List<clDetallesE> listarDetallesVenta = new List<clDetallesE>();

            int cantReg = tblDetallesVenta.Rows.Count;
            for (int i = 0; i < cantReg; i++)
            {

                clDetallesE objDatosDetalle = new clDetallesE();

                objDatosDetalle.nombreCliente = tblDetallesVenta.Rows[i]["nombreCliente"].ToString();
                objDatosDetalle.fechaVenta = DateTime.Parse(tblDetallesVenta.Rows[i]["fechaVenta"].ToString());
                objDatosDetalle.codigoVenta = int.Parse(tblDetallesVenta.Rows[i]["codigoVenta"].ToString());
                objDatosDetalle.totalVenta = float.Parse(tblDetallesVenta.Rows[i]["totalVenta"].ToString());
                objDatosDetalle.nombreEmpleado = tblDetallesVenta.Rows[i]["nombreEmpleado"].ToString();
                objDatosDetalle.cantidad = int.Parse(tblDetallesVenta.Rows[i]["cantidad"].ToString());
                objDatosDetalle.valorTotal = float.Parse(tblDetallesVenta.Rows[i]["valorTotal"].ToString());
                objDatosDetalle.nombreProducto = tblDetallesVenta.Rows[i]["nombreProducto"].ToString();


                listarDetallesVenta.Add(objDatosDetalle);
            }
            return listarDetallesVenta;
        }


    }
}