using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class clMaterialesL
    {
        public List<clMaterialesE> mtdList()
        {
            clMarerialesD objMateialD = new clMarerialesD();
            List<clMaterialesE> listaClientes = new List<clMaterialesE>();

            listaClientes = objMateialD.mtdListarD();
            return listaClientes;
        }
    }
}