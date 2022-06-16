using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class clEmpleadosL
    {
        public List<clEmpleadosE> mtdListarEmpleado()
        {
            clEmpleadosD objProducto = new clEmpleadosD();
            List<clEmpleadosE> objProductoD = new List<clEmpleadosE>();
            objProductoD = objProducto.mtdListarEmpleado();
            return objProductoD;

        }
    }
}