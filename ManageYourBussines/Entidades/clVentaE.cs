using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Entidades
{
    public class clVentaE:clProductoE
    {
        public int idVenta { get; set; }
        public DateTime fechaVenta { get; set; }
        public string codigoVenta { get; set; }
        public float totalVenta { get; set; }
        public int idCliente { get; set; }
        public int idEmpleado { get; set; }

        public int idDetallesVenta { get; set; }
    
        public int cantidad { get; set; }
        public float valorTotal { get; set; }
        
        public string fechaVen { get; set; }
        public int filas { get; set; }

    }
}