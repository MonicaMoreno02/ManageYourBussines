using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.ClConexion;

namespace ManageYourBussines.Datos
{
        public class clTareasD
        {

            public List<clTareasE> mtdListarTareas()
            {
            string sql = "select empleado.Nombres,empleado.Apellidos,empleado.TipoEmpleado, tareas.nombreTarea, tareas.descripcionTarea,tareasEmpleado.fechaInicio,tareasEmpleado.FechaTerminacion,tareasEmpleado.estadofrom empleado inner join tareasEmpleado onempleado.idEmpleado = tareasEmpleado.idEmpleado innerjoin tareas on tareas.idTareas = tareasEmpleado.idTareas";
            clConexion objConexion = new clConexion();
            DataTable tblTareas = new DataTable();
                tblTareas = objConexion.mtdDesconectado(sql);


            List<clTareasE> listarTareas = new List<clTareasE>();

                int catnReg = tblTareas.Rows.Count;


                for (int i = 0; i < catnReg; i++)
                {
                    clTareasE objDatosTareas = new clTareasE();


                objDatosTareas.documento = tblTareas.Rows[i]["documento"].ToString();
                objDatosTareas.nombres = tblTareas.Rows[i]["nombres"].ToString();
                objDatosTareas.apellidos = tblTareas.Rows[i]["apellidos"].ToString();
                objDatosTareas.tipoEmpleado = tblTareas.Rows[i]["tipoEmpleado"].ToString();
                objDatosTareas.nombreTarea = tblTareas.Rows[i][" nombreTarea"].ToString();
                objDatosTareas.descripcionTarea = tblTareas.Rows[i]["descripcionTarean"].ToString();
                objDatosTareas.fechaInicio = tblTareas.Rows[i]["fechaInicio"].ToString();
                objDatosTareas.fechaTerminacion = tblTareas.Rows[i]["fechaTerminacion"].ToString();
                objDatosTareas.estado = tblTareas.Rows[i]["estado"].ToString();













       
                  listarTareas.Add(objDatosTareas);
                }

                return listarTareas;


            }


        }


    
}