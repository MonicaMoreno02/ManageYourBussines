using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Entidades
{
    public class clSeguridadE
    {

        public int idSeguridadSocial { get; set; }
        public float porcentajePension { get; set; }
        public float porcentajeSalud { get; set; }
        public float smlv { get; set; }
        public DateTime fecha { get; set; }
    }
}