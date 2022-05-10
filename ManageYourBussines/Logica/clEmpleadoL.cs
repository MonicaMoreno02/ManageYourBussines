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
        public clEmpleadoE mtdLogin(clEmpleadoE objDatos)
        {
            clEmpleadoD objDatosUsuarios = new clEmpleadoD();
            clEmpleadoE objDatosEmpleD = new clEmpleadoE();

            objDatosEmpleD = objDatosUsuarios.mtdLogin(objDatos);
            return objDatosEmpleD;



        }
    }
}