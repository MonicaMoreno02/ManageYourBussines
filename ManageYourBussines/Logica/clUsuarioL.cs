using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class clUsuarioL
    {
        public clUsuarioE mtdLogin(clUsuarioE objDatos)
        {
            clUsuarioD objDatosClienteD = new clUsuarioD();

            clUsuarioE objDatosCliente = new clUsuarioE();
            objDatosCliente = objDatosClienteD.mtdLogin(objDatos);
            //int va = objDatosClienteD.mtdLogin(objDatos);
            return objDatosCliente;



            }

            //public string recuperaContraseña(string usuarioRequerido)
            //{
            //    //return clClienteD.usuarioRequerido(usuarioRequerido);
            //}


            public int mtdRegistrarCliente(clUsuarioE objdatosClien)
        {
            clUsuarioD objClientesD = new clUsuarioD();
            int resultado = objClientesD.mtdRegistrar(objdatosClien);
            return resultado;
        }



        public clUsuarioE mtdEmpleado(clUsuarioE objDatos)
        {
            clUsuarioD objEmpleadoD = new clUsuarioD();
            clUsuarioE objDatosEmpleado = new clUsuarioE();
            objDatosEmpleado = objEmpleadoD.mtdEmpleado(objDatos);
            return objDatosEmpleado;
        }

        //metodo para editar  los cliente s
        public int mtdEditarPersona(clUsuarioE objDatos)
        {
            clUsuarioD objUsuarioD = new clUsuarioD();
            int r = objUsuarioD.mtdEditar(objDatos);
            return r;
        }


    }
}