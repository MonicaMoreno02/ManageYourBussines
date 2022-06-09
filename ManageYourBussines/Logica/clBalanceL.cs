using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class clBalanceL
    {
        public List<clBalanceE> mtdListarBal(clBalanceE objbalance)
        {
            clBalanceD objBalanceD = new clBalanceD();
            List<clBalanceE> listaClientes = new List<clBalanceE>();
            listaClientes = objBalanceD.mtdListar(objbalance);
            return listaClientes;

        }
        
            public List<clBalanceE> mtdListarDetalles(clBalanceE objdtalles)
        {
            clBalanceD objBalanceD = new clBalanceD();
            List<clBalanceE> listaClientes = new List<clBalanceE>();
            listaClientes = objBalanceD.mtdListarDeta(objdtalles);
            return listaClientes;

        }
        public List<clBalanceE> mtdListarBalC()
        {
            clBalanceD objBalanceD = new clBalanceD();
            List<clBalanceE> listaClientes = new List<clBalanceE>();
            listaClientes = objBalanceD.mtdListarBal();
            return listaClientes;

        }

    }
}