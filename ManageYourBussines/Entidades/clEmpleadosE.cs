using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Entidades
{
    public class clEmpleadosE
    {
        public int idEmpleado { get; set; }
        public string documento { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string tipoEmpleado { get; set; }
        public string porcentajePension { get; set; }
        public string porcentajeSalud { get; set; }
        public int idseguridadSocial { get; set; }
        public int idAño { get; set; }
        public string año { get; set; }
        public float salario { get; set; }

    }
}