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

        //metodo de recuperacion de contraseña del empleado y metodo de el login del empleado

        public clEmpleadoE mtdLoginE(clEmpleadoE objDatos)
        {
            clEmpleadoD objDatosUsuarios = new clEmpleadoD();
            clEmpleadoE objDatosEmpleD = new clEmpleadoE();

            objDatosEmpleD = objDatosUsuarios.mtdLoginE(objDatos);
            return objDatosEmpleD;



        }
        public clEmpleadoE mtdLoginProveedor(clEmpleadoE objDatos)
        {
            clEmpleadoD objDatosUsuarios = new clEmpleadoD();
            clEmpleadoE objDatosEmpleD = new clEmpleadoE();

            objDatosEmpleD = objDatosUsuarios.mtdLoginProveedor(objDatos);
            return objDatosEmpleD;



        }

        public clEmpleadoE recoverPassword(clEmpleadoE empleRequesting)
        {
            clEmpleDao userDao = new clEmpleDao();
            return userDao.recoverPassword(empleRequesting);
        }





        //Metodo para listar los empleados
        public List<clEmpleadoE> mtdListarEmpleadoL()
        {
            clEmpleadoD objEmpleadoD = new clEmpleadoD();
            List<clEmpleadoE> ListaEmpleados = new List<clEmpleadoE>();

            ListaEmpleados = objEmpleadoD.mtdListarEmpleadoD();

            return ListaEmpleados;
        }


        //Metodo para registrar los empleados

        public int mtdRegistrarEmple(clEmpleadoE objDatosEmple)
        {
            clEmpleadoD objEmpleadosD = new clEmpleadoD();
            int result = objEmpleadosD.mtdRegistrar(objDatosEmple);
            return result;
        }



        //Metodo para editar los empleados

        public int mtdEditar(clEmpleadoE objDatosEmpleado)
        {
            clEmpleadoD objEmpleadoD = new clEmpleadoD();
            int resultado = objEmpleadoD.mtdEditar(objDatosEmpleado);

            return resultado;
        }



        //Metodo para eliminar los empleados

        public int mtdEliminar(int idEmpleado)
        {
            clEmpleadoD objEmpleadoD = new clEmpleadoD();
            int resultado = objEmpleadoD.mtdEliminar(idEmpleado);

            return resultado;
        }

        public List<clSeguridadE> mtdListarSeguridad()
        {
            clEmpleadoD objSeguridad = new clEmpleadoD();
            List<clSeguridadE> ListaSeguridadSocial = new List<clSeguridadE>();
            ListaSeguridadSocial = objSeguridad.mtdListarSeguridadD();

            return ListaSeguridadSocial;
        }










        

    
}
}