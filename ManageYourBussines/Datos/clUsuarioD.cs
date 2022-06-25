using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.clConexion;

namespace ManageYourBussines.Datos
{
    public class clUsuarioD
    {
        public clUsuarioE mtdLogin(clUsuarioE objDatos)
        {
            string consulta = "select * from  cliente  where emailCliente='" + objDatos.emailCliente + "' and claveCliente='" + objDatos.claveCliente + "'";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            clUsuarioE objDatosCliente = new clUsuarioE();

            if (tblDatos.Rows.Count == 1)
            {
                objDatosCliente.idCliente = int.Parse(tblDatos.Rows[0]["idCliente"].ToString());
                objDatosCliente.documento = tblDatos.Rows[0]["documentoCliente"].ToString();
                objDatosCliente.nombreCliente = tblDatos.Rows[0]["nombreCliente"].ToString();
                objDatosCliente.telefono = tblDatos.Rows[0]["telefono"].ToString();
                objDatosCliente.apellidosCliente = tblDatos.Rows[0]["apellidosCliente"].ToString();
                objDatosCliente.direccion = tblDatos.Rows[0]["direccion"].ToString();
                objDatosCliente.emailCliente = tblDatos.Rows[0]["emailCliente"].ToString();
                objDatosCliente.claveCliente = tblDatos.Rows[0]["claveCliente"].ToString();

            }
            else
            {
                objDatosCliente = null;

            }
            return objDatosCliente;
        }

        public int mtdRegistrar(clUsuarioE objDatosCliente)
        {
            string sql = "insert into cliente(documento,nombreCliente,apellidos,telefono,direccion,emailCliente,claveCliente)" +
                "values ('" + objDatosCliente.documento + "' ,'" + objDatosCliente.nombreCliente + "','" + objDatosCliente.apellidosCliente + "','" + objDatosCliente.telefono + "','" + objDatosCliente.direccion + "','" + objDatosCliente.emailCliente + "' ,'" + objDatosCliente.claveCliente + "')";

            clConexion objConexion = new clConexion();

            int resulatdo = objConexion.mtdConectado(sql);
            return resulatdo;



        }



       
        



       
   



        public int mtdEditar(clUsuarioE objDatos)
        {
            string sql = "Update cliente set documento='" + objDatos.documento + "', nombreCliente='" + objDatos.nombreCliente + "'," +
                "apellidos='" + objDatos.apellidosCliente + "',telefono='" + objDatos.telefono + "',direccion='" + objDatos.direccion + "',emailCliente='" + objDatos.emailCliente + "',claveCliente='" + objDatos.claveCliente + "' where idCliente=" + objDatos.idCliente + "";

            clConexion objConexion = new clConexion();
            int result = objConexion.mtdConectado(sql);
            return result;
        }




        public clUsuarioE mtdEmpleado(clUsuarioE objDatos)
        {

            string consulta = "SELECT * FROM cliente WHERE idCliente = " + objDatos.idCliente + "";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            clUsuarioE objDatosUsuario = new clUsuarioE();

            if (tblDatos.Rows.Count == 1)
            {

                objDatosUsuario.documento = tblDatos.Rows[0]["documentoCliente"].ToString();
                objDatosUsuario.nombreCliente = tblDatos.Rows[0]["nombreCliente"].ToString();
                objDatosUsuario.apellidosCliente = tblDatos.Rows[0]["apellidosCliente"].ToString();
                objDatosUsuario.telefono = tblDatos.Rows[0]["telefono"].ToString();
                objDatosUsuario.direccion = tblDatos.Rows[0]["direccion"].ToString();
                objDatosUsuario.emailCliente = tblDatos.Rows[0]["emailCliente"].ToString();
                objDatosUsuario.claveCliente = tblDatos.Rows[0]["claveCliente"].ToString();
            }
            else
            {
                objDatosUsuario = null;
            }
            return objDatosUsuario;
        }
    }
}
