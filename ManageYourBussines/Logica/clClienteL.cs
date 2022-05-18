using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class clClienteL
    {
        public clClienteE mtdLogin(clClienteE objDatos)
        {
            clClienteD objDatosClienteD = new clClienteD();
         
            clClienteE objDatosCliente = new clClienteE();
            objDatosCliente = objDatosClienteD.mtdLogin(objDatos);
            return objDatosCliente;

            

        }

        //public string recuperaContraseña(string usuarioRequerido)
        //{
        //    //return clClienteD.usuarioRequerido(usuarioRequerido);
        //}


        public int mtdRegistrarCliente(clClienteE objdatosClien)
        {
            clClienteD objClientesD = new clClienteD();
            int resultado = objClientesD.mtdRegistrar(objdatosClien);
            return resultado;
        }



    }
}