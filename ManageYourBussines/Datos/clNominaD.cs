using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.ClConexion;

namespace ManageYourBussines.Datos
{
    public class clNominaD
    {

        public List<clNominaE> mtdListarEmpleado()
        {
            string sql = "select EMPLEADO.documento,empleado.nombres,empleado.apellidos,empleado.tipoEmpleado,seguridadSocial.porcentajePension,seguridadSocial.porcentajeSalud from empleado, seguridadSocial where seguridadSocial.idSeguridadSocial = empleado.idSeguridadSocial";
            clConexion objConexion = new clConexion();
            DataTable tblEmpleado = new DataTable();
            tblEmpleado = objConexion.mtdDesconectado(sql);

            DataTable tblseguridadSocial = new DataTable();
            tblseguridadSocial = objConexion.mtdDesconectado(sql);

            List<clNominaE> listarEmpleado = new List<clNominaE>();

            int catnReg = tblEmpleado.Rows.Count;


            for (int i = 0; i < catnReg; i++)
            {
                clNominaE objDatosEmpleado = new clNominaE();


                objDatosEmpleado.documento = tblEmpleado.Rows[i]["documento"].ToString();
                objDatosEmpleado.nombres = tblEmpleado.Rows[i]["nombres"].ToString();
                objDatosEmpleado.apellidos = tblEmpleado.Rows[i]["apellidos"].ToString();
                objDatosEmpleado.tipoEmpleado = tblEmpleado.Rows[i]["tipoEmpleado"].ToString();
                objDatosEmpleado.porcentajePension = tblseguridadSocial.Rows[i]["porcentajePension"].ToString();
                objDatosEmpleado.porcentajeSalud = tblseguridadSocial.Rows[i]["porcentajePension"].ToString();


                listarEmpleado.Add(objDatosEmpleado);
            }

            return listarEmpleado;


        }


    }


}