using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Datos
{
    public class clEmpleadoD
    {

        public clEmpleadoE mtdLoginE(clEmpleadoE objDatos)
        {

          
            string consulta = "SELECT * FROM empleado  WHERE email='" + objDatos.emailEmpleado + "'AND clave='" + objDatos.claveEmpleado + "'";
            ClConexion objConexion = new ClConexion();
      

            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            clEmpleadoE objDatosEmple = new clEmpleadoE();

            if (tblDatos.Rows.Count == 1)
            {



                //if (tblDatos.Rows[0][4].ToString() == "Vendedor")
                
                    objDatosEmple.idEmpleado = int.Parse(tblDatos.Rows[0]["idEmpleado"].ToString());
                    objDatosEmple.documentoE = tblDatos.Rows[0]["documento"].ToString();
                    objDatosEmple.nombreEmpleado = tblDatos.Rows[0]["nombreEmpleado"].ToString();
                    objDatosEmple.apellidosEmple = tblDatos.Rows[0]["apellidos"].ToString();
                    objDatosEmple.tipoEmpleado = tblDatos.Rows[0]["tipoEmpleado"].ToString();

                    objDatosEmple.emailEmpleado = tblDatos.Rows[0]["email"].ToString();
                    objDatosEmple.claveEmpleado = tblDatos.Rows[0]["clave"].ToString();

                

            }
            else
            {
                objDatosEmple = null;

            }
            return objDatosEmple;
        }

    }
}