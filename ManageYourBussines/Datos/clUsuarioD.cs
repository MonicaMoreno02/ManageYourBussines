using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.ClConexion;

namespace ManageYourBussines.Datos
{
    public class clUsuarioD
    {
        public clUsuarioE mtdLogin(clUsuarioE objDatos)
        {
            string consulta = "select * from  cliente  where email='" + objDatos.email + "' and clave='" + objDatos.clave + "'";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            clUsuarioE objDatosCliente = new clUsuarioE();

            if (tblDatos.Rows.Count == 1)
            {
                objDatosCliente.idCliente = int.Parse(tblDatos.Rows[0]["idCliente"].ToString());
                objDatosCliente.documento = tblDatos.Rows[0]["documento"].ToString();
                objDatosCliente.nombreCliente = tblDatos.Rows[0]["nombreCliente"].ToString();
                objDatosCliente.telefono = tblDatos.Rows[0]["telefono"].ToString();
                objDatosCliente.apellidos = tblDatos.Rows[0]["apellidos"].ToString();
                objDatosCliente.direccion = tblDatos.Rows[0]["direccion"].ToString();
                objDatosCliente.email = tblDatos.Rows[0]["email"].ToString();
                objDatosCliente.clave = tblDatos.Rows[0]["clave"].ToString();

            }
            else
            {
                objDatosCliente = null;

            }
            return objDatosCliente;
        }

        public int mtdRegistrar(clUsuarioE objDatosCliente)
        {
            string sql = "insert into cliente(documento,nombres,apellidos,telefono,direccion,email,clave)" +
                "values ('" + objDatosCliente.documento + "' ,'" + objDatosCliente.nombreCliente + "','" + objDatosCliente.apellidos + "','" + objDatosCliente.telefono + "','" + objDatosCliente.direccion + "','" + objDatosCliente.email + "' ,'" + objDatosCliente.clave + "')";

            clConexion objConexion = new clConexion();

            int resulatdo = objConexion.mtdConectado(sql);
            return resulatdo;



        }
    }
}