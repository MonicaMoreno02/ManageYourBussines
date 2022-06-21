using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Entidades
{
    public class clTareasE
    {
        public int idTareas { get; set; }
        public string nombreTarea { get; set; }
        public string descripcionTarea { get; set; }
        public string estado { get; set; }
        public int tiempo { get; set; }
    }
}