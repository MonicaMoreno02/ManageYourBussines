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
         
            string sql = "select * from empleado";
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
                objEmpleado.email = tblEmpleados.Rows[i]["emailEmpleado"].ToString();
                objEmpleado.clave = tblEmpleados.Rows[i]["claveEmpleado"].ToString();

                ListaEmpleados.Add(objEmpleado);
            }

            return ListaEmpleados;
        }


        public int mtdRegistrar(clEmpleadoE objDatosEmpleados)
        {
            string sql = "insert into empleado(documento,nombreEmpleado,apellidos," +
                "tipoEmpleado,emailEmpleado,claveEmpleado)" +
                "values('" + objDatosEmpleados.documento + "','" + objDatosEmpleados.nombreEmpleado + "'" +
                ",'" + objDatosEmpleados.apellidos + "','" + objDatosEmpleados.tipoEmpleado + "'," +
                "'" + objDatosEmpleados.email + "','" + objDatosEmpleados.clave + "')";

            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(sql);

            return resultado;
        }

        public int mtdEditar(clEmpleadoE objDatos)
        {
            string sql = "Update Empleado set documento='" + objDatos.documento + "', nombreEmpleado='" + objDatos.nombreEmpleado + "'," +
                "apellidos='" + objDatos.apellidos + "',tipoEmpleado='" + objDatos.tipoEmpleado + "',emailEmpleado='" + objDatos.email + "',claveEmpleado='" +
                objDatos.clave + "' where idEmpleado=" + objDatos.idEmpleado +  "";

            clConexion objConexion = new clConexion();
            int result = objConexion.mtdConectado(sql);
            return result;
        }


        public int mtdEliminar(int idEmpleado)
        {
            string sql = "delete from empleado where idEmpleado=" + idEmpleado + "";

            clConexion objConexion = new clConexion();
            int result = objConexion.mtdConectado(sql);
            return result;
        }

        public List<clSeguridadE> mtdListarSeguridadD()
        {

            string sql = "select * from seguridadSocial";
            clConexion objConexion = new clConexion();
            DataTable tblSeguridad = new DataTable();
            tblSeguridad = objConexion.mtdDesconectado(sql);

            List<clSeguridadE> ListaSeguridad = new List<clSeguridadE>();

            int cantReg = tblSeguridad.Rows.Count;
            for (int i = 0; i < cantReg; i++)
            {

                clSeguridadE objSeguridad = new clSeguridadE();

                objSeguridad.idSeguridadSocial = int.Parse(tblSeguridad.Rows[i]["idSeguridadSocial"].ToString());
                objSeguridad.porcentajePension = float.Parse(tblSeguridad.Rows[i]["porcentajePension"].ToString());
                objSeguridad.porcentajeSalud = float.Parse(tblSeguridad.Rows[i]["porcentajeSalud"].ToString());
                objSeguridad.smlv = float.Parse(tblSeguridad.Rows[i]["smlv"].ToString());
                objSeguridad.año = int.Parse(tblSeguridad.Rows[i]["año"].ToString());
                

                ListaSeguridad.Add(objSeguridad);
            }

            return ListaSeguridad;
        }


    }
}