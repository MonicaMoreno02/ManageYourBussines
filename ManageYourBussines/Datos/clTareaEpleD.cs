using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.ClConexion;

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
            return resutado;

        }
    }
}