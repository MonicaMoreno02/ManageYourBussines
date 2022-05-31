using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Entidades
{
    public class clDetallesE

    {
        public string nombreCliente { get; set; }
        public DateTime  fechaVenta{ get; set; }
        public int  codigoVenta{ get; set; }
        public float  totalVenta{ get; set; }
        public string  nombreEmpleado{ get; set; }
        public int  cantidad{ get; set; }
        public float  valorTotal{ get; set; }
        public string  nombreProducto{ get; set; }
    }
}