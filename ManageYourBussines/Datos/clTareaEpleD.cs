using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.clConexion;

namespace ManageYourBussines.Datos
{
    public class clTareaEpleD
    {
        public int mtdListamate(clTareaEpleE objdatosmat)
        {
            string sql = "insert into materialestarea (idmateriales,idTarea,cantidad,totalmat)" +

                  "values('" + objdatosmat.idmaterial + "','" + objdatosmat.idTareas + "'," +
                  "'" + objdatosmat.cantidad + "','" + objdatosmat.totalmat + "')";

            clConexion objConexion = new clConexion();
            int resutado = objConexion.mtdConectado(sql);
           int num = objdatosmat.num;
            if (num == 1)
            {
                string ahora = DateTime.Now.ToString("yyyy/MM/dd");
                string ahora1 = DateTime.Now.ToString("yyyy-MM-dd");
                DateTime nuevaFecha = Convert.ToDateTime(ahora1);
                nuevaFecha = nuevaFecha.AddDays(objdatosmat.pos);
                string fec1 = nuevaFecha.ToString("yyyy/MM/dd");


                sql = "insert into tareasEmpleado (idTareas,idEmpleado,fechaInicio,FechaTerminacion)" +

                  "values('" + objdatosmat.idTareas + "','" + objdatosmat.idEmpleado + "'," +
                  "'" + ahora + "','" + fec1 + "')";

                clConexion objConexion1 = new clConexion();
                int resutado1 = objConexion1.mtdConectado(sql);
                string estado = "proceso";

                sql = "Update tareas set estado='" + estado + "' where idTareas="+objdatosmat.idTareas+"";
                clConexion objConexion2 = new clConexion();
                int resutado2 = objConexion2.mtdConectado(sql);


            }
            return resutado;
           

        }

        public int mtdListarter(clTareaEpleE objdatosmat)
        {
             string sql = "Update tareas set estado='terminado' where idTareas=" + objdatosmat.idTareas + "";

            clConexion objConexion = new clConexion();
            int resutado = objConexion.mtdConectado(sql);
            return resutado;
        }

    }
}