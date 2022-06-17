using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class clEmpleadoL
    {
        public clEmpleadoE mtdLoginE(clEmpleadoE objDatos)
        {
            clEmpleadoD objDatosUsuarios = new clEmpleadoD();
            clEmpleadoE objDatosEmpleD = new clEmpleadoE();

            objDatosEmpleD = objDatosUsuarios.mtdLoginE(objDatos);
            return objDatosEmpleD;



        }

        public clEmpleadoE recoverPassword(clEmpleadoE empleRequesting)
        {
            clEmpleDao userDao = new clEmpleDao();
            return userDao.recoverPassword(empleRequesting);
        }
    }
}