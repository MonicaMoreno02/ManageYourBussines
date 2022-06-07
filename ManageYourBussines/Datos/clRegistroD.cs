using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.ClConexion;

namespace ManageYourBussines.Datos
{
    public class clRegistroD
    {
        public int mtdRegistrarTareaD(clRegistroE objDatosRegistroD)
        {
            string sql = "insert into tareas(nombreTarea, descripcionTarea) values('" + objDatosRegistroD.nombreTarea + "'," + objDatosRegistroD.descripcionTarea + "')";

            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(sql);
            return resultado;

        }
    }
}