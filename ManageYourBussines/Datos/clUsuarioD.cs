using ManageYourBussines.Entidades;
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

        public clUsuarioE mtdLogin(clUsuarioE objDatos)
        {

            string consulta = "select * from  cliente  where emailCliente='" + objDatos.email + "' and claveCliente='" + objDatos.clave + "'";
            ClConexion objConexion = new ClConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            clUsuarioE objDatosCliente = new clUsuarioE();
            //int valor = tblDatos.Rows.Count;
            if (tblDatos.Rows.Count == 1)
            {
                objDatosCliente.idCliente = int.Parse(tblDatos.Rows[0]["idCliente"].ToString());
                objDatosCliente.documento = tblDatos.Rows[0]["documento"].ToString();
                objDatosCliente.nombreCliente = tblDatos.Rows[0]["nombreCliente"].ToString();
                objDatosCliente.telefono = tblDatos.Rows[0]["telefono"].ToString();
                objDatosCliente.apellidos = tblDatos.Rows[0]["apellidos"].ToString();
                objDatosCliente.direccion = tblDatos.Rows[0]["direccion"].ToString();
                objDatosCliente.email = tblDatos.Rows[0]["emailCliente"].ToString();
                objDatosCliente.clave = tblDatos.Rows[0]["claveCliente"].ToString();

            }
            else
            {
                objDatosCliente = null;

            }
            return objDatosCliente;
        }



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
            string sql = "insert into cliente(documento,nombreCliente,apellidos,telefono,direccion,emailCliente,claveCliente)" +
                "values ('" + objDatosCliente.documento + "' ,'" + objDatosCliente.nombreCliente + "','" + objDatosCliente.apellidos + "','"+ objDatosCliente.telefono+"','"+objDatosCliente.direccion+"','" + objDatosCliente.email + "' ,'" + objDatosCliente.clave + "')";
            ClConexion objConexion = new ClConexion();
            int resulatdo = objConexion.mtdConectado(sql);
            return resulatdo;



        }



        public int mtdEditar(clUsuarioE objDatos)
        {
            string sql = "Update cliente set documento='" + objDatos.documento + "', nombreCliente='" + objDatos.nombreCliente + "'," +
                "apellidos='" + objDatos.apellidos + "',telefono='" + objDatos.telefono + "',direccion='" + objDatos.direccion + "',emailCliente='" + objDatos.email + "',claveCliente='" + objDatos.clave + "' where idCliente=" + objDatos.idCliente + "";

            ClConexion objConexion = new ClConexion();
            int result = objConexion.mtdConectado(sql);
            return result;
        }




        public clUsuarioE mtdEmpleado(clUsuarioE objDatos)
        {

            string consulta = "SELECT * FROM cliente WHERE idCliente = " + objDatos.idCliente + "";
            ClConexion objConexion = new ClConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            clUsuarioE objDatosUsuario = new clUsuarioE();

            if (tblDatos.Rows.Count == 1)
            {

                objDatosUsuario.documento = tblDatos.Rows[0]["documento"].ToString();
                objDatosUsuario.nombreCliente = tblDatos.Rows[0]["nombreCliente"].ToString();
                objDatosUsuario.apellidos = tblDatos.Rows[0]["apellidos"].ToString();
                objDatosUsuario.telefono = tblDatos.Rows[0]["telefono"].ToString();
                objDatosUsuario.direccion = tblDatos.Rows[0]["direccion"].ToString();
                objDatosUsuario.email = tblDatos.Rows[0]["emailCliente"].ToString();
                objDatosUsuario.clave = tblDatos.Rows[0]["claveCliente"].ToString();
            }
            else
            {
                objDatosUsuario = null;
            }
            return objDatosUsuario;
        }
    }
}