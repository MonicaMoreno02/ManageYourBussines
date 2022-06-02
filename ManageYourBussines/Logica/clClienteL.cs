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

        //Listamos los datos de los clientes
        public List<clClienteE> mtdListarL()
        {
            clClienteD objClienteD =new  clClienteD();
            List<clClienteE> listaClientes = new List<clClienteE>();

            listaClientes = objClienteD.mtdListarD();
            return listaClientes;
        }

        //Listamos los datos de los detalles de ventas de cada cliente
        public List<clDetallesE> mtdListarDetallesL(int idCliente)
        {
            clClienteD objListarDetalles = new clClienteD();
            List<clDetallesE> listaDetalles = new List<clDetallesE>();

            listaDetalles = objListarDetalles.mtdListarDetallesD(idCliente);
            return listaDetalles;
        }
    }
}