using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class estadoTareaL
    {
        public List<estadoTareaE> mtdList(estadoTareaE objid)
        {
            estadoTareaD objClienteD = new estadoTareaD();
            List<estadoTareaE> litarTareas = new List<estadoTareaE>();

            litarTareas = objClienteD.mtdListaD(objid);
            return litarTareas;
        }

    }
}