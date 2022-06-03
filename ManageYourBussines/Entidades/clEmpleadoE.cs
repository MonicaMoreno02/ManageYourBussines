using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Entidades
{
    public class clEmpleadoE
    {
        public int idEmpleado { get; set; }
        public  string documento { get; set; }
        public  string nombreEmpleado { get; set; }
        public  string apellidos { get; set; }
        public  string tipoEmpleado { get; set; }
        public  string email { get; set; }
        public  string clave { get; set; }
        public  int idSeguridad { get; set; }
    }
}