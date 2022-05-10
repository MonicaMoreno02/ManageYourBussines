using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Datos
{
    public class clEmpleadoD
    {

         public clEmpleadoE mtdLogin(clEmpleadoE objDatos)
        {

            string consulta = "select * from  empleado  where email='" + objDatos.email + "' and clave='" + objDatos.clave + "'";
            ClConexion objConexion = new ClConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            clEmpleadoE objDatosEmple = new clEmpleadoE();

            if (tblDatos.Rows.Count == 1)
            {
                objDatosEmple.idEmpleado = int.Parse(tblDatos.Rows[0]["idEmpleado"].ToString());
                objDatosEmple.documento = tblDatos.Rows[0]["documento"].ToString();
                objDatosEmple.nombres = tblDatos.Rows[0]["nombres"].ToString();
                objDatosEmple.apellidos = tblDatos.Rows[0]["apellidos"].ToString();
                objDatosEmple.tipoEmpleado = tblDatos.Rows[0]["tipoEmpleado"].ToString();
         
                objDatosEmple.email = tblDatos.Rows[0]["email"].ToString();
                objDatosEmple.clave = tblDatos.Rows[0]["clave"].ToString();

            }
            else
            {
                objDatosEmple = null;

            }
            return objDatosEmple;
        }

    }
}