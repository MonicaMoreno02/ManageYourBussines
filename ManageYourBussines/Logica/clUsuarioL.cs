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
            return objDatosCliente;



        }

        public clUsuarioE recoverPassword(clUsuarioE userRequesting)
        {
            clUserDao userDao = new clUserDao();
            return userDao.recoverPassword(userRequesting);
        }

        public int mtdRegistrarCliente(clUsuarioE objdatosClien)
        {
            clUsuarioD objClientesD = new clUsuarioD();
            int resultado = objClientesD.mtdRegistrar(objdatosClien);
            return resultado;
        }


    }
}