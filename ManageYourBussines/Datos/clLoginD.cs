using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Datos
{
    public class clLoginD
    {
        public clUsuarioE mtdLoginUsuario(clUsuarioE objDatoscli)
        {
             //metodo de login para  el clientes 

            string consulta = "select * from cliente where email='" + objDatoscli.email + "'";
            ClConexion objConexion = new ClConexion();
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

        //metodo de login para empleados
        public clEmpleadoE mtdLoginEmpleado(clEmpleadoE objDatosEmple)
        {
            string consulta = "select * from empleado where emailEmpleado='" + objDatosEmple.emailEmpleado + "'";
            ClConexion objConexion = new ClConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);

            clEmpleadoE objDatosCliente = new clEmpleadoE();

            if (tblDatos.Rows.Count == 1)
            {
                objDatosEmple.idEmpleado = int.Parse(tblDatos.Rows[0]["idEmpleado"].ToString());
                objDatosEmple.documentoE = tblDatos.Rows[0]["documentoE"].ToString();
                objDatosEmple.nombreEmpleado = tblDatos.Rows[0]["nombreEmpleado"].ToString();
                objDatosEmple.apellidosEmple = tblDatos.Rows[0]["apellidosEmple"].ToString();
                objDatosEmple.tipoEmpleado = tblDatos.Rows[0]["tipoEmpleado"].ToString();

                objDatosEmple.emailEmpleado = tblDatos.Rows[0]["emailEmpleado"].ToString();
                objDatosEmple.claveEmpleado = tblDatos.Rows[0]["claveEmpleado"].ToString();
            }
            else
            {
                objDatosEmple = null;

            }
            return objDatosEmple;
        }

        //metodo para editar  los clientes
        public int mtdEditar(clUsuarioE objDatos)
        {
            string sql = "Update cliente set documento='" + objDatos.documento + "', nombreCliente='" + objDatos.nombreCliente + "'," +
                "apellidos='" + objDatos.apellidos + "',telefono='"+objDatos.telefono+"',direccion='"+objDatos.direccion+"',email='" + objDatos.email + "',clave='" + objDatos.clave + "' where idCliente=" + objDatos.idCliente + "";

            ClConexion objConexion = new ClConexion();
            int result = objConexion.mtdConectado(sql);
            return result;
        }

       
    }

}