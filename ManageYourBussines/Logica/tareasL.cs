using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class tareasL
    {
        public List<clTareasE> mtdList(clTareasE objid)
        {
            clTareasD objClienteD = new clTareasD();
            List<clTareasE> listaClientes = new List<clTareasE>();

            listaClientes = objClienteD.mtdListaD(objid);
            return listaClientes;
        }
    }
}