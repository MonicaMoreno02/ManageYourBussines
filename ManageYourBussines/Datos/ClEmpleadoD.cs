using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.ClConexion;

namespace ManageYourBussines.Datos
{
    public class clEmpleadoD
    {

        public List<clEmpleadoE> mtdListarEmpleadoD()
        {
         
            string sql = "select * from empleados";
            clConexion objConexion = new clConexion();
            DataTable tblEmpleados = new DataTable();
            tblEmpleados = objConexion.mtdDesconectado(sql);

            List<clEmpleadoE> ListaEmpleados = new List<clEmpleadoE>();

            int cantReg = tblEmpleados.Rows.Count;
            for (int i = 0; i < cantReg; i++)
            {

                clEmpleadoE objEmpleado = new clEmpleadoE();

                objEmpleado.idEmpleado = int.Parse(tblEmpleados.Rows[i]["idEmpleado"].ToString());
                objEmpleado.documento = tblEmpleados.Rows[i]["documento"].ToString();
                objEmpleado.nombreEmpleado = tblEmpleados.Rows[i]["nombreEmpleado"].ToString();
                objEmpleado.apellidos = tblEmpleados.Rows[i]["apellidos"].ToString();
                objEmpleado.tipoEmpleado = tblEmpleados.Rows[i]["TipoEmpleado"].ToString();
                objEmpleado.email = tblEmpleados.Rows[i]["email"].ToString();
                objEmpleado.clave = tblEmpleados.Rows[i]["clave"].ToString();
                objEmpleado.idSeguridad = int.Parse(tblEmpleados.Rows[i]["idSeguridad"].ToString());

                ListaEmpleados.Add(objEmpleado);
            }

            return ListaEmpleados;
        }


        public int mtdRegistrar(clEmpleadoE objDatosEmpleados)
        {
            string sql = "insert into empleado(documento,nombreEmpleado,apellidos," +
                "tipoEmpleado,email,clave,idSeguridad)" +
                "values('" + objDatosEmpleados.documento + "','" + objDatosEmpleados.nombreEmpleado + "'" +
                ",'" + objDatosEmpleados.apellidos + "','" + objDatosEmpleados.tipoEmpleado + "'," +
                "'" + objDatosEmpleados.email + "','" + objDatosEmpleados.clave + "'," +
                "'" + objDatosEmpleados.idSeguridad + ")";

            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(sql);

            return resultado;
        }

    }
}