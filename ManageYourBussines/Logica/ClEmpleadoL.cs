using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using ManageYourBussines.Presentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class ClEmpleadoL
    {
        public DataTable mtdListarEmple()
        {
            clEmpleadoD objEmpleadosD = new clEmpleadoD();
            List<clEmpleadoE> listarEmpleado = new List<clEmpleadoE>();
            listarEmpleado = objEmpleadosD.mtdListarEmpleado();
            DataTable empleado = new DataTable();
            DataTable seguridadSocial = new DataTable();

           
            empleado.Columns.Add(new DataColumn("documento", typeof(string)));
            empleado.Columns.Add(new DataColumn("nombres", typeof(string)));
            empleado.Columns.Add(new DataColumn("apellidos", typeof(string)));
            empleado.Columns.Add(new DataColumn("tipoEmpleado", typeof(string)));
            seguridadSocial.Columns.Add(new DataColumn("porcentajePension", typeof(float)));
            seguridadSocial.Columns.Add(new DataColumn("porcentajeSalud", typeof(float)));


            int cuenta = listarEmpleado.Count;
            int num = cuenta +1;
            float stot = 0;
            float pension = 40000;
            float salud = 40000;
            float salario = 1000000;

            for (int i = 0; i < num; i++)
            {
                if(i != cuenta)
                {
                    int numero = i + 1;
                    string documento = listarEmpleado[i].documento;
                    string nombres = listarEmpleado[i].nombres;
                    string apellidos = listarEmpleado[i].apellidos;
                    string tipoEmpleado = listarEmpleado[i].tipoEmpleado;
                    string porcentajePension = listarEmpleado[i].porcentajePension;
                    string porcentajeSalud = listarEmpleado[i].porcentajeSalud;
                    

                    stot = salario - salud - pension;

                    DataRow row = empleado.NewRow();
                   
                    row["documento"] = documento;
                    row["nombres"] = nombres;
                    row["apellidos"] = apellidos;
                    row["tipoEmpleado"] = tipoEmpleado;
                    row["porcentajePension"] = porcentajePension;
                    row["porcentajeSalud"] = porcentajeSalud;
                   
                    empleado.Rows.Add(row);
                }
                

                
            }
            return empleado;
        }
    }

}





