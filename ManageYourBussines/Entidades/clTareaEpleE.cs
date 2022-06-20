using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Entidades
{
    public class clTareaEpleE
    {
        public int idTareas { get; set; }
        public int idmaterial { get; set; }
        public float total { get; set; }
        public int cantidad { get; set; }

        public float totalmat { get; set; }

    }
}