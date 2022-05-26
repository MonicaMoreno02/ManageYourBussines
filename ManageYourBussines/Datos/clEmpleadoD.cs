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

        public List<clEmpleadoE> mtdListarEmpleado()
        {
            string sql = "select EMPLEADO.documento,empleado.nombres,empleado.apellidos,empleado.tipoEmpleado,seguridadSocial.porcentajePension,seguridadSocial.porcentajeSalud from empleado, seguridadSocial where seguridadSocial.idSeguridadSocial = empleado.idSeguridadSocial";
            clConexion objConexion = new clConexion();
            DataTable tblEmpleado = new DataTable();
            tblEmpleado = objConexion.mtdDesconectado(sql);

            DataTable tblseguridadSocial = new DataTable();
            tblseguridadSocial = objConexion.mtdDesconectado(sql);

            List<clEmpleadoE> listarEmpleado = new List<clEmpleadoE>();

            int catnReg = tblEmpleado.Rows.Count;


            for (int i = 0; i < catnReg; i++)
            {
                clEmpleadoE objDatosEmpleado = new clEmpleadoE();
                objDatosEmpleado.idEmpleado = int.Parse(tblEmpleado.Rows[i]["idImagen"].ToString());
                objDatosEmpleado.documento = tblEmpleado.Rows[i]["documento"].ToString();
                objDatosEmpleado.nombres = tblEmpleado.Rows[i]["nombres"].ToString();
                objDatosEmpleado.apellidos = tblEmpleado.Rows[i]["apellidos"].ToString();
                objDatosEmpleado.tipoEmpleado = tblEmpleado.Rows[i]["tipoEmpleado"].ToString();
                objDatosEmpleado.idseguridadSocial = int.Parse(tblseguridadSocial.Rows[i]["idseguridadSocial"].ToString());
                objDatosEmpleado.porcentajePension = tblseguridadSocial.Rows[i]["porcentajePension"].ToString();
                objDatosEmpleado.porcentajeSalud = tblseguridadSocial.Rows[i]["porcentajePension"].ToString();


                listarEmpleado.Add(objDatosEmpleado);
            }

            return listarEmpleado;


        }


    }


}