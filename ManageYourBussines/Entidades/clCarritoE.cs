using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Entidades
{
    public class clCarritoE
    {
        public int idproducto { get; set; }

        public string nombre { get; set; }

        public string describcion { get; set; }

        public float precio { get; set; }

        public int cantidadstock { get; set; }

        public int catidad { get; set; }

        public int idcliente { get; set; }

        public int registro { get; set; }

        public int idcarrito { get; set; }

        public string Imagen { get; set; }

    }
}