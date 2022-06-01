using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Entidades
{
    public class clVentaE
    {
        public int idVenta { get; set; }
        public DateTime fechaVenta { get; set; }
        public string codigoVenta { get; set; }
        public float totalVenta { get; set; }
        public int idCliente { get; set; }
        public int idEmpleado { get; set; }
    }
}