using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Entidades
{
    public class clBalanceE
    {
        public int idventa { get; set; }
        public DateTime fechaVenta { get; set; }
        public string codigoVenta { get; set; }
        public float totalVenta { get; set; }
        public int idcliente { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public float valorTotal { get; set; }
        public int idDetallesVenta { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }
         public DateTime desde { get; set; }
        public DateTime Hasta { get; set; }         
        public int num { get; set; }

        
    }
}