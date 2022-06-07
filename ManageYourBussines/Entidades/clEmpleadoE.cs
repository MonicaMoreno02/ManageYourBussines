using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Entidades
{
    public class clEmpleadoE
    {
        public int idEmpleado { get; set; }
        public string documentoE { get; set; }
        public string nombreEmpleado { get; set; }
        public string apellidosEmple { get; set; }
        public string tipoEmpleado { get; set; }
        public string emailEmpleado{ get; set; }
        public string claveEmpleado { get; set; }

        public int idSeguridadSocial { get; set; }
    }
}