using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Entidades
{
    public class clTareasE
    {
        public int idTareasEmpleado { get; set; }
        public int idTareas { get; set; }
        public int idEmpleado { get; set; }

        public DateTime fechaInicio { get; set; }
        public DateTime fechaTerminacion { get; set; }
        public string nombreTarea { get; set; }
        public string descripcionTarea { get; set; }



    }
}