﻿using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Datos
{
    public class clUsuarioD
    {

        //public clUsuarioE mtdLogin(clUsuarioE objDatos)
        //{

        //    string consulta = "select * from  cliente  where email='" + objDatos.email + "' and clave='" + objDatos.clave + "'";
        //    ClConexion objConexion = new ClConexion();
        //    DataTable tblDatos = new DataTable();
        //    tblDatos = objConexion.mtdDesconectado(consulta);
        //    clUsuarioE objDatosCliente = new clUsuarioE();
        //    //int valor = tblDatos.Rows.Count;
        //    if (tblDatos.Rows.Count == 1)
        //    {
        //        objDatosCliente.idCliente = int.Parse(tblDatos.Rows[0]["idCliente"].ToString());
        //        objDatosCliente.documento = tblDatos.Rows[0]["documento"].ToString();
        //        objDatosCliente.nombreCliente = tblDatos.Rows[0]["nombreCliente"].ToString();
        //        objDatosCliente.telefono = tblDatos.Rows[0]["telefono"].ToString();
        //        objDatosCliente.apellidos = tblDatos.Rows[0]["apellidos"].ToString();
        //        objDatosCliente.direccion = tblDatos.Rows[0]["direccion"].ToString();
        //        objDatosCliente.email = tblDatos.Rows[0]["email"].ToString();
        //        objDatosCliente.clave = tblDatos.Rows[0]["clave"].ToString();

        //    }
        //    else
        //    {
        //        objDatosCliente = null;

        //    }
        //    return objDatosCliente;
        //}



        //public string recoverPassword(string userRequesting)
        //{


        //    using (var command = new SqlCommand())
        //    {
              
        //        command.CommandText = "select *from cliente where LoginName=@user or Email=@mail";
        //        command.Parameters.AddWithValue("@user", userRequesting);
        //        command.Parameters.AddWithValue("@mail", userRequesting);
        //        command.CommandType = CommandType.Text;
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.Read() == true)
        //        {
        //            string userName = reader.GetString(3) + ", " + reader.GetString(4);
        //            string userMail = reader.GetString(6);
        //            string accountPassword = reader.GetString(2);
        //            var mailService = new servicioCorreo.correoSoporteSistema();
        //            mailService.sendMail(
        //              subject: "solicitud:recuperar contraseña",
        //              body: "Hola, " + userName + "\nYou Requested to Recover your password.\n" +
        //              "your current password is: " + accountPassword +
        //              "\nHowever, we ask that you change your password inmediately once you enter the system.",
        //              recipientMail: new List<string> { userMail }
        //              );
        //            return "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
        //              "Please check your mail: " + userMail +
        //              "\nHowever, we ask that you change your password inmediately once you enter the system.";
        //        }
        //        else
        //            return "No tiene una cuenta con este usuario o contraseña";

        //    }
        //}
            


       


            public int mtdRegistrar(clUsuarioE objDatosCliente)
        {
            string sql = "insert into cliente(documento,nombreCliente,apellidos,telefono,direccion,email,clave)" +
                "values ('" + objDatosCliente.documento + "' ,'" + objDatosCliente.nombreCliente + "','" + objDatosCliente.apellidos + "','"+ objDatosCliente.telefono+"','"+objDatosCliente.direccion+"','" + objDatosCliente.email + "' ,'" + objDatosCliente.clave + "')";
            ClConexion objConexion = new ClConexion();
            int resulatdo = objConexion.mtdConectado(sql);
            return resulatdo;



        }
    }
}