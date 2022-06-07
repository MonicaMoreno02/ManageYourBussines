using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Datos
{
    public class clEmpleDao
    {
        public clEmpleadoE recoverPassword(clEmpleadoE empleRequesting)
        {
            string consulta = "SELECT * FROM empleado WHERE emailEmpleado='" + empleRequesting.emailEmpleado + "'";
            ClConexion objConexion = new ClConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            clEmpleadoE objDatosUsuario = new clEmpleadoE();

            if (tblDatos.Rows.Count == 1)
            {
                objDatosUsuario.idEmpleado = int.Parse(tblDatos.Rows[0]["idEmpleado"].ToString());
                objDatosUsuario.nombreEmpleado = tblDatos.Rows[0]["nombreEmpleado"].ToString();
                objDatosUsuario.emailEmpleado = tblDatos.Rows[0]["emailEmpleado"].ToString();
                objDatosUsuario.claveEmpleado = tblDatos.Rows[0]["claveEmpleado"].ToString();

                var mailService = new servicioEmail.systemSupportMail();
                mailService.sendMail(
                  subject: "Solicitud de recuperación de contraseña",
                  body: "Hola, " + objDatosUsuario.nombreEmpleado + "\nUsted solicitó recuperar su contraseña.\n" +
                  "Tu contraseña actual es: " + objDatosUsuario.claveEmpleado,
                  recipientMail: new List<string> { objDatosUsuario.emailEmpleado }
                  );
            }
            else
            {
                objDatosUsuario = null;
            }
            return objDatosUsuario;

        }
    }
}