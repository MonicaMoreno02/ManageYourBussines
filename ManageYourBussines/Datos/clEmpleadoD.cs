﻿using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Datos
{
    public class clEmpleadoD
    {

        public clEmpleadoE mtdLogin(clEmpleadoE objDatos)
        {

            string consulta = "select * from  empleado  where emailCliente='" + objDatos.emailEmpleado + "' and claveCliente='" + objDatos.claveEmpleado + "'";
            ClConexion objConexion = new ClConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            clEmpleadoE objDatosEmple = new clEmpleadoE();

            if (tblDatos.Rows.Count == 1)
            {



                if (tblDatos.Rows[0][4].ToString() == "Vendedor")
                {
                    objDatosEmple.idEmpleado = int.Parse(tblDatos.Rows[0]["idEmpleado"].ToString());
                    objDatosEmple.documentoE = tblDatos.Rows[0]["documentoE"].ToString();
                    objDatosEmple.nombreEmpleado = tblDatos.Rows[0]["nombreEmpleado"].ToString();
                    objDatosEmple.apellidosEmple = tblDatos.Rows[0]["apellidosEmple"].ToString();
                    objDatosEmple.tipoEmpleado = tblDatos.Rows[0]["tipoEmpleado"].ToString();

                    objDatosEmple.emailEmpleado = tblDatos.Rows[0]["emailCliente"].ToString();
                    objDatosEmple.claveEmpleado = tblDatos.Rows[0]["claveCliente"].ToString();

                }

            }
            else
            {
                objDatosEmple = null;

            }
            return objDatosEmple;
        }

    }
}