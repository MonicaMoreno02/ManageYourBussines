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
        public List<clTareasE> mtdListaD(clTareasE objid)
        {
            string sql = "select * from tareas where estado = 'pendiente' ";
            clConexion objConexion = new clConexion();
            DataTable tblTareas = new DataTable();
            tblTareas = objConexion.mtdDesconectado(sql);

            List<clTareasE> listartarea = new List<clTareasE>();

            int cantReg = tblTareas.Rows.Count;
            for (int i = 0; i < cantReg; i++)
            {

                clTareasE objdatosTarea = new clTareasE();
                objdatosTarea.idTareas = int.Parse(tblTareas.Rows[i]["idTareas"].ToString());
                objdatosTarea.nombreTarea = tblTareas.Rows[i]["nombreTarea"].ToString();
                objdatosTarea.describciontarea = tblTareas.Rows[i]["descripcionTarea"].ToString();
                objdatosTarea.tiempo = int.Parse(tblTareas.Rows[i]["tiempo"].ToString());
                objdatosTarea.estado = tblTareas.Rows[i]["estado"].ToString();
                  listartarea.Add(objdatosTarea);
            }
            return listartarea;

        }
    }
}