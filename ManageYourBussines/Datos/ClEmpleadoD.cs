using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.clConexion;

namespace ManageYourBussines.Datos
{
    public class clEmpleadoD
    {
        //metodo de login  del empleado
        public clEmpleadoE mtdLogin(clEmpleadoE objDatos)
        {

            string consulta = "select * from  empleado  where emailEmpleado='" + objDatos.emailEmpleado+ "' and claveEmpleado='" + objDatos.claveEmpleado + "'";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            clEmpleadoE objDatosEmple = new clEmpleadoE();

            if (tblDatos.Rows.Count == 1)
            {



                if (tblDatos.Rows[0][4].ToString() == "Vendedor")
                {
                    objDatosEmple.idEmpleado = int.Parse(tblDatos.Rows[0]["idEmpleado"].ToString());
                    objDatosEmple.documentoEmpleado = tblDatos.Rows[0]["documento"].ToString();
                    objDatosEmple.nombreEmpleado = tblDatos.Rows[0]["nombresEmpleado"].ToString();
                    objDatosEmple.apellidoEmpleado = tblDatos.Rows[0]["apellidosEmpleado"].ToString();
                    objDatosEmple.tipoEmpleado = tblDatos.Rows[0]["tipoEmpleado"].ToString();
                    objDatosEmple.emailEmpleado = tblDatos.Rows[0]["emailEmpleado"].ToString();
                    objDatosEmple.claveEmpleado = tblDatos.Rows[0]["claveEmpleado"].ToString();

                }

            }
            else
            {
                objDatosEmple = null;

            }
            return objDatosEmple;
        }

    




    public List<clEmpleadoE> mtdListarEmpleadoD()
        {
         
            string sql = "select * from empleado";
            clConexion objConexion = new clConexion ();
            DataTable tblEmpleados = new DataTable();
            tblEmpleados = objConexion.mtdDesconectado(sql);

            List<clEmpleadoE> ListaEmpleados = new List<clEmpleadoE>();

            int cantReg = tblEmpleados.Rows.Count;
            for (int i = 0; i < cantReg; i++)
            {

                clEmpleadoE objEmpleado = new clEmpleadoE();

                objEmpleado.idEmpleado = int.Parse(tblEmpleados.Rows[i]["idEmpleado"].ToString());
                objEmpleado.documentoEmpleado = tblEmpleados.Rows[i]["documentoEmpleado"].ToString();
                objEmpleado.nombreEmpleado = tblEmpleados.Rows[i]["nombresEmpleado"].ToString();
                objEmpleado.apellidoEmpleado = tblEmpleados.Rows[i]["apellidoEmpleado"].ToString();
                objEmpleado.tipoEmpleado = tblEmpleados.Rows[i]["TipoEmpleado"].ToString();
                objEmpleado.emailEmpleado = tblEmpleados.Rows[i]["emailEmpleado"].ToString();
                objEmpleado.claveEmpleado = tblEmpleados.Rows[i]["claveEmpleado"].ToString();

                ListaEmpleados.Add(objEmpleado);
            }

            return ListaEmpleados;
        }


        public int mtdRegistrar(clEmpleadoE objDatosEmpleados)
        {
            string sql = "insert into empleado(documentoEmpleado,nombreEmpleado,apellidosEmpleado," +
                "tipoEmpleado,emailEmpleado,claveEmpleado)" +
                "values('" + objDatosEmpleados.documentoEmpleado + "','" + objDatosEmpleados.nombreEmpleado + "'" +
                ",'" + objDatosEmpleados.apellidoEmpleado + "','" + objDatosEmpleados.tipoEmpleado + "'," +
                "'" + objDatosEmpleados.emailEmpleado + "','" + objDatosEmpleados.claveEmpleado + "')";

            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(sql);

            return resultado;
        }

        public int mtdEditar(clEmpleadoE objDatos)
        {
            string sql = "Update Empleado set documentoEmpleado='" + objDatos.documentoEmpleado + "', nombreEmpleado='" + objDatos.nombreEmpleado + "'," +
                "apellidoEmpleado='" + objDatos.apellidoEmpleado + "',tipoEmpleado='" + objDatos.tipoEmpleado + "',emailEmpleado='" + objDatos.emailEmpleado + "',claveEmpleado='" +
                objDatos.claveEmpleado + "' where idEmpleado=" + objDatos.idEmpleado +  "";

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
                objSeguridad.fecha = int.Parse(tblSeguridad.Rows[i]["fecha"].ToString());
                

                ListaSeguridad.Add(objSeguridad);
            }

            return ListaSeguridad;
        }


    }
}