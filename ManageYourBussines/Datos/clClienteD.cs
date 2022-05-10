using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Datos
{
    public class clClienteD
    {

        public clClienteE mtdLogin(clClienteE objDatos)
        {

            string consulta = "select * from  cliente  where email='" + objDatos.email + "' and clave='" + objDatos.clave + "'";
            ClConexion objConexion = new ClConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            clClienteE objDatosCliente = new clClienteE();

            if (tblDatos.Rows.Count == 1)
            {
                objDatosCliente.idCliente = int.Parse(tblDatos.Rows[0]["idCliente"].ToString());
                objDatosCliente.documento = tblDatos.Rows[0]["documento"].ToString();
                objDatosCliente.nombres = tblDatos.Rows[0]["nombres"].ToString();
                objDatosCliente.telefono = tblDatos.Rows[0]["telefono"].ToString();
                objDatosCliente.apellidos = tblDatos.Rows[0]["apellidos"].ToString();
                objDatosCliente.direccion = tblDatos.Rows[0]["direccion"].ToString();
                objDatosCliente.email = tblDatos.Rows[0]["email"].ToString();
                objDatosCliente.clave = tblDatos.Rows[0]["clave"].ToString();

            }
            else
            {
                //objDatosCliente = null;
                if (tblDatos.Rows.Count == 1)
                {
                    objDatosCliente.idCliente = int.Parse(tblDatos.Rows[0]["idCliente"].ToString());
                    objDatosCliente.documento = tblDatos.Rows[0]["documento"].ToString();
                    objDatosCliente.nombres = tblDatos.Rows[0]["nombres"].ToString();
                    objDatosCliente.telefono = tblDatos.Rows[0]["telefono"].ToString();
                    objDatosCliente.apellidos = tblDatos.Rows[0]["apellidos"].ToString();
                    objDatosCliente.direccion = tblDatos.Rows[0]["direccion"].ToString();
                    objDatosCliente.email = tblDatos.Rows[0]["email"].ToString();
                    objDatosCliente.clave = tblDatos.Rows[0]["clave"].ToString();

                }
                return objDatosCliente;

            }
            return objDatosCliente;
        }


      


            public int mtdRegistrar(clClienteE objDatosCliente)
        {
            string sql = "insert into cliente(documento,nombres,apellidos,telefono,direccion,email,clave)" +
                "values ('" + objDatosCliente.documento + "' ,'" + objDatosCliente.nombres + "','" + objDatosCliente.apellidos + "','"+ objDatosCliente.telefono+"','"+objDatosCliente.direccion+"','" + objDatosCliente.email + "' ,'" + objDatosCliente.clave + "')";
            ClConexion objConexion = new ClConexion();
            int resulatdo = objConexion.mtdConectado(sql);
            return resulatdo;



        }
    }
}