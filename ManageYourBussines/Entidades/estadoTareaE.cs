using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Entidades
{
    public class estadoTareaE
    {
        public int idEmpleado { get; set; }
        public int idTareasEmpleado { get; set; }
        public int idTareas { get; set; }
        public string nombreTarea { get; set; }
        public string descripcionTarea { get; set; }
        public string estado { get; set; }

        public int tiempo { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaTerminacion { get; set; }
    }
}