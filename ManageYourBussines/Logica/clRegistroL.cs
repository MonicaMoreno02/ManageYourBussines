using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ManageYourBussines.Logica
{
    public class clRegistroL
    {
        public int mtdRegistrarTarea(clRegistroE objDatosRegistro)
        {
            clRegistroD objDatos = new clRegistroD();
            int resultado = objDatos.mtdRegistrarTareaD(objDatosRegistro);
            return resultado;
        }
    }
}