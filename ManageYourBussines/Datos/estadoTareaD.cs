using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.ClConexion;

namespace ManageYourBussines.Datos
{
    public class estadoTareaD
    {
        public List<estadoTareaE> mtdListaD(estadoTareaE objid)
        {
            string sql = "select * from empleado inner join tareasEmpleado on empleado.idEmpleado=TareasEmpleado.idEmpleado inner join tareas on tareasEmpleado.idTareas=tareas.idTareas where estado ='"+ objid.estado+"'";
            clConexion objConexion = new clConexion();
            DataTable tblTareas = new DataTable();
            tblTareas = objConexion.mtdDesconectado(sql);

            List<estadoTareaE> listartarea = new List<estadoTareaE>();

            int cantReg = tblTareas.Rows.Count;
            for (int i = 0; i < cantReg; i++)
            {

                estadoTareaE objdatosTarea = new estadoTareaE();
                objdatosTarea.idEmpleado = int.Parse(tblTareas.Rows[i]["idEmpleado"].ToString());

                objdatosTarea.idTareas = int.Parse(tblTareas.Rows[i]["idTareas"].ToString());
                objdatosTarea.nombreTarea = tblTareas.Rows[i]["nombreTarea"].ToString();
                objdatosTarea.descripcionTarea = tblTareas.Rows[i]["descripcionTarea"].ToString();
                objdatosTarea.tiempo = int.Parse(tblTareas.Rows[i]["tiempo"].ToString());
                objdatosTarea.estado = tblTareas.Rows[i]["estado"].ToString();
                objdatosTarea.fechaInicio = DateTime.Parse(tblTareas.Rows[i]["fechaInicio"].ToString());
                objdatosTarea.fechaTerminacion = DateTime.Parse(tblTareas.Rows[i]["fechaTerminacion"].ToString());
                listartarea.Add(objdatosTarea);
            }
            return listartarea;

        }
    }
}