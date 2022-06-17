using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Entidades
{
    public class clTareasE
    {
        public int idTareas { get; set; }
        public string nombreTareas { get; set; }
        public string descripcionTareas { get; set; }
        public int idTareasEmpleado { get; set; }
        public int idEmpleado { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaTerminacion { get; set; }
        public string estado { get; set; }
        public int tiempo { get; set; }
    }
}