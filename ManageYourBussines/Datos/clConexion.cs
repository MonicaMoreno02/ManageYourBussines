﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Datos
{
    public class clConexion
    {


        SqlConnection conexion = null;
        public clConexion()
        {

            conexion = new SqlConnection("Data Source=DESKTOP-MUAS3NV\\SQLEXPRESS;Initial Catalog=dbManage;Integrated Security=True");
            conexion.Open();
        }

        public DataTable mtdDesconectado(string sql)//select
        {
            SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion);
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            conexion.Close();

            return tblDatos;
        }

        public int mtdConectado(string sql)//Insert,Update,Delete
        {
            SqlCommand comando = new SqlCommand(sql, conexion);
            int filasAfectadas = comando.ExecuteNonQuery();
            conexion.Close();
            return filasAfectadas;
        }

    }
}