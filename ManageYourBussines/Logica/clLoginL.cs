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
        //metodo de login clientes en logicas
        public clUsuarioE mtdLoginUsuario(clUsuarioE objDatosU) 
        {
            clLoginD objLoginD = new clLoginD();

            clUsuarioE objLoginE = new clUsuarioE();
            objLoginE = objLoginD.mtdLoginUsuario(objDatosU);
            return objDatosU;

        
        }
        //metodo de login en logica para empleados 
        public clEmpleadoE mtdLoginEmpleado(clEmpleadoE objDatosEm) 
        { 
            clLoginD objLoginEn= new clLoginD();
            clEmpleadoE objDatosE= new clEmpleadoE();
            objDatosE = objLoginEn.mtdLoginEmpleado(objDatosEm);
            return objDatosEm;


        }

        public clUsuarioE mtdEmpleado(clUsuarioE objDatos)
        {
            clLoginD objEmpleadoD = new clLoginD();
            clUsuarioE objDatosEmpleado = new clUsuarioE();
            objDatosEmpleado = objEmpleadoD.mtdEmpleado(objDatos);
            return objDatosEmpleado;
        }

        //metodo para editar  los cliente s
        public int mtdEditarPersona(clUsuarioE objDatos)
        {
            clLoginD objUsuarioD = new clLoginD();
            int r = objUsuarioD.mtdEditar(objDatos);
            return r;
        }

    }
}