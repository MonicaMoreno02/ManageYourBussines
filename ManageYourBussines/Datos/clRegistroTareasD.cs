using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.ClConexion;

namespace ManageYourBussines.Datos
{
    public int mtdRegistrarTareaD(clRegistrotareasE objDatosRegistro)
    {
        string consulta = "insert into tareas(nombreTarea, descripcionTarea) values('" + objDatosRegistro.nombreTarea + "'," + objDatosRegistro.descripcionTarea + "')";

        clConexion objConexion = new clConexion();
        int resultado = objConexion.mtdConectado(consulta);
        return resultado;

    }


}