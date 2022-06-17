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
        public int mtdRegistrarTarea(clTareasE objDatosTarea)
        {
            string sql = "insert into tareas(nombreTarea,descripcionTarea,estado,tiempo)" +
             "values ('" + objDatosTarea.nombreTareas + "' ,'" + objDatosTarea.descripcionTareas + "','"+objDatosTarea.estado+"','"+objDatosTarea.tiempo+"')";
            clConexion objConexion = new clConexion();
            int resulatdo = objConexion.mtdConectado(sql);
            return resulatdo;
        }
        public List<clTareasE> mtdListarTar()
        {
            string sql = "select * from tareas";
            clConexion objConexion = new clConexion();
            DataTable tblTarea = new DataTable();
            tblTarea = objConexion.mtdDesconectado(sql);

            List<clTareasE> listarTarea = new List<clTareasE>();
            int canReg = tblTarea.Rows.Count;
            for (int i = 0; i < canReg; i++)
            {
                clTareasE objDatosTarea = new clTareasE();
                objDatosTarea.idTareas = int.Parse(tblTarea.Rows[i]["idTareas"].ToString());
                objDatosTarea.nombreTareas = tblTarea.Rows[i]["nombreTareas"].ToString();
                objDatosTarea.descripcionTareas = tblTarea.Rows[i]["descripcionTareas"].ToString();
                objDatosTarea.estado = tblTarea.Rows[i]["estado"].ToString();
                objDatosTarea.tiempo = int.Parse(tblTarea.Rows[i]["nombreTareas"].ToString());

                listarTarea.Add(objDatosTarea);
            }
            return listarTarea;
        }
    }
}