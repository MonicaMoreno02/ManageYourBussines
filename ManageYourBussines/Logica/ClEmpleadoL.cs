using ManageYourBussines.Entidades;
using ManageYourBussines.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class clEmpleadoL
    {
        public List<clEmpleadoE> mtdListarEmpleado()
        {
            clEmpleadoD objEmpleado = new clEmpleadoD();
            List<clEmpleadoE> objEmpleadosD = new List<clEmpleadoE>();
            objEmpleadosD = objEmpleado.mtdListar();
            return objEmpleadosD;

        }
    }
}

