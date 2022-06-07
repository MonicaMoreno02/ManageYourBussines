using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class clLoginL
    {
        public clUsuarioE mtdLoginUsuario(clUsuarioE objDatosU) 
        {
            clLoginD objLoginD = new clLoginD();

            clUsuarioE objLoginE = new clUsuarioE();
            objLoginE = objLoginD.mtdLoginUsuario(objDatosU);
            return objDatosU;

        
        }
        public int mtdLoginEmpleado(clEmpleadoE objDatosEm) 
        { 
            clLoginD objLoginEn= new clLoginD();
            clEmpleadoE objDatosE= new clEmpleadoE();
            //objDatosE = objLoginEn.mtdLoginEmpleado(objDatosEm);
            int va = objLoginEn.mtdLoginEmpleado(objDatosEm);
            return va;


        }


    }
}