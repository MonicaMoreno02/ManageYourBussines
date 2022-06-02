using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Entidades
{
    public class clVentaE
    {
        int idVenta { get; set; }
        DateTime fechaVenta { get; set; }
        string codigoVenta { get; set; }
        float totalVenta { get; set; }
        int idCliente { get; set; }
        int idEmpleado { get; set; }
    }
}