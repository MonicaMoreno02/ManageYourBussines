using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class clRegistroTareasL
    {
        public int mtdRegistrarTarea(clRegistroTareasE objDatos)
        {
            clRegistroTareasD objRegistroD = new clRegistroTareasD();
            int resultado = objRegistroD.mtdRegistrarTarea(objDatos);
            return resultado;

        }
    }
}