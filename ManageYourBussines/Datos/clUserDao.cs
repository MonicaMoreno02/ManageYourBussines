﻿using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.clConexion;

namespace ManageYourBussines.Datos
{
    public class clUserDao: clConexion
    {
        public clUsuarioE recoverPassword(clUsuarioE userRequesting)
        {
            string consulta = "SELECT * FROM cliente WHERE emailCliente='" + userRequesting.emailCliente + "'";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            clUsuarioE objDatosUsuario = new clUsuarioE();

            if (tblDatos.Rows.Count == 1)
            {
                objDatosUsuario.idCliente = int.Parse(tblDatos.Rows[0]["idCliente"].ToString());
                objDatosUsuario.nombreCliente = tblDatos.Rows[0]["nombreCliente"].ToString();
                objDatosUsuario.emailCliente = tblDatos.Rows[0]["emailCliente"].ToString();
                objDatosUsuario.claveCliente = tblDatos.Rows[0]["claveCliente"].ToString();

                var mailService = new MailServices.systemSupportMail();
                mailService.sendMail(
                  subject: "Solicitud de recuperación de contraseña",
                  body: "Hola, " + objDatosUsuario.nombreCliente + "\nUsted solicitó recuperar su contraseña.\n" +
                  "Tu contraseña actual es: " + objDatosUsuario.claveCliente,
                  recipientMail: new List<string> { objDatosUsuario.emailCliente }
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