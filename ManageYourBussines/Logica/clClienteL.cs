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
        public List<clClienteE> mtdListarL()
        {
            clClienteD objClienteD =new  clClienteD();
            List<clClienteE> listaClientes = new List<clClienteE>();

            listaClientes = objClienteD.mtdListarD();
            return listaClientes;
        }
    }
}