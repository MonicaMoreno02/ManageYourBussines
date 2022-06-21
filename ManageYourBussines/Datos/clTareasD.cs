using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.clConexion;

namespace ManageYourBussines.Datos
{
    public class clTareasD
    {
        public int mtdRegistrarTarea(clTareasE objDatosTarea)
        {
            string sql = "insert into tareas(nombreTarea,descripcionTarea,estado,tiempo)" +
             "values ('" + objDatosTarea.nombreTarea + "' ,'" + objDatosTarea.descripcionTarea + "','" + objDatosTarea.estado + "','" + objDatosTarea.tiempo + "')";
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
                objDatosTarea.nombreTarea = tblTarea.Rows[i]["nombreTarea"].ToString();
                objDatosTarea.descripcionTarea = tblTarea.Rows[i]["descripcionTarea"].ToString();
                objDatosTarea.estado = tblTarea.Rows[i]["estado"].ToString();
                objDatosTarea.tiempo = int.Parse(tblTarea.Rows[i]["tiempo"].ToString());

                listarTarea.Add(objDatosTarea);
            }
            return listarTarea;
        }
        public int mtdEditar(clTareasE objDatos)
        {
            string sql = "Update tareas set nombreTarea='" + objDatos.nombreTarea + "', descripcionTarea='" + objDatos.descripcionTarea + "'," +
               "estado='" + objDatos.estado + "',tiempo='" + objDatos.tiempo + "' where idTareas=" + objDatos.idTareas + "";

            clConexion objConexion = new clConexion();
            int result = objConexion.mtdConectado(sql);
            return result;
        }
        public int mtdEliminar(int idTareas)
        {
            string sql = "delete from tareas where idTareas=" + idTareas + "";

            clConexion objConexion = new clConexion();
            int result = objConexion.mtdConectado(sql);
            return result;
        }
    }
}
