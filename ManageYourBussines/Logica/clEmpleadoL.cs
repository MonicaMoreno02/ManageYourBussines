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
        public List<clEmpleadoE> mtdListarEmpleadoL()
        {
            clEmpleadoD objEmpleadoD = new clEmpleadoD();
            List<clEmpleadoE> ListaEmpleados = new List<clEmpleadoE>();

            ListaEmpleados = objEmpleadoD.mtdListarEmpleadoD();

            return ListaEmpleados;
        }

        public int mtdRegistrarEmple(clEmpleadoE objDatosEmple)
        {
            clEmpleadoD objEmpleadosD = new clEmpleadoD();
            int result = objEmpleadosD.mtdRegistrar(objDatosEmple);
            return result;
        }
    }
}