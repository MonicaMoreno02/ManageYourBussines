using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.clConexion;

namespace ManageYourBussines.Datos
{
    public class clEmpleadosD
    {
        public List<clEmpleadosE> mtdListarEmpleado()
        {
            string sql = "select *from empleados inner join seguridadSocial on empleados.idSeguridadSocial";
            clConexion objConexion = new clConexion();
            DataTable tblEmpleado = new DataTable();
            tblEmpleado = objConexion.mtdDesconectado(sql);

            DataTable tblseguridadSocial = new DataTable();
            tblseguridadSocial = objConexion.mtdDesconectado(sql);

            List<clEmpleadosE> listarEmpleado = new List<clEmpleadosE>();

            int catnReg = tblEmpleado.Rows.Count;


            for (int i = 0; i < catnReg; i++)
            {
                clEmpleadosE objDatosEmpleado = new clEmpleadosE();


                objDatosEmpleado.documento = tblEmpleado.Rows[i]["documentoE"].ToString();
                objDatosEmpleado.nombres = tblEmpleado.Rows[i]["nombreEmpleados"].ToString();
                objDatosEmpleado.apellidos = tblEmpleado.Rows[i]["apellidosEmple"].ToString();
                objDatosEmpleado.tipoEmpleado = tblEmpleado.Rows[i]["tipoEmpleado"].ToString();
                objDatosEmpleado.porcentajePension = tblseguridadSocial.Rows[i]["porcentajePension"].ToString();
                objDatosEmpleado.porcentajeSalud = tblseguridadSocial.Rows[i]["porcentajePension"].ToString();
                //objDatosEmpleado.año = tblseguridadSocial.Rows[i]["año"].ToString();
                //objDatosEmpleado.salario = float.Parse(tblseguridadSocial.Rows[i]["salario"].ToString());

                listarEmpleado.Add(objDatosEmpleado);
            }

            return listarEmpleado;


        }


    }
}