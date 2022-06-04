using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.ClConexion;

namespace ManageYourBussines.Datos
{
    public int mtdRegistrarTarea(clRegistrotareasE objDatosRegistro)
    {
        string consulta = "update tareas set descripcionTarea='" + objDatosRegistro.nombreTarea + "',descripcion='" + objDatosRegistro.descripcionTarea +;

        clConexion objConexion = new clConexion();
        int resultado = objConexion.mtdConectado(consulta);
        return resultado;

    }


}