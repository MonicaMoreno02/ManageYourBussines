using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{
    public partial class frmNomina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clEmpleadosD objEmpleadosD = new clEmpleadosD();
            List<clEmpleadosE> listarEmpleado = new List<clEmpleadosE>();
            listarEmpleado = objEmpleadosD.mtdListarEmpleado();
            DataTable empleado = new DataTable();
            DataTable seguridadSocial = new DataTable();



            empleado.Columns.Add(new DataColumn("Documento", typeof(string)));
            empleado.Columns.Add(new DataColumn("Nombres", typeof(string)));
            empleado.Columns.Add(new DataColumn("Apellidos", typeof(string)));
            empleado.Columns.Add(new DataColumn("tipoEmpleado", typeof(string)));
            empleado.Columns.Add(new DataColumn("porcentajePension", typeof(float)));
            empleado.Columns.Add(new DataColumn("porcentajeSalud", typeof(float)));
            empleado.Columns.Add(new DataColumn("Salariominimo", typeof(float)));


            int cuenta = listarEmpleado.Count;
            int num = cuenta + 1;
            float stot = 0;
            float pension = 40000;
            float salud = 40000;
            float salario = 1000000;

            for (int i = 0; i < num; i++)
            {
                if (i != cuenta)
                {
                    int numero = i + 1;
                    string Documento = listarEmpleado[i].documento;
                    string Nombres = listarEmpleado[i].nombres;
                    string Apellidos = listarEmpleado[i].apellidos;
                    string tipoEmpleado = listarEmpleado[i].tipoEmpleado;
                    string porcentajePension = listarEmpleado[i].porcentajePension;
                    string porcentajeSalud = listarEmpleado[i].porcentajeSalud;


                    stot = salario - salud - pension;

                    DataRow row = empleado.NewRow();


                    row["documento"] = Documento;
                    row["nombres"] = Nombres;
                    row["apellidos"] = Apellidos;
                    row["tipoEmpleado"] = tipoEmpleado;
                    row["porcentajePension"] = porcentajePension;
                    row["porcentajeSalud"] = porcentajeSalud;
                    row["Salariominimo"] = stot;

                    empleado.Rows.Add(row);
                }


                GridView1.DataSource = empleado;
                GridView1.DataBind();
                


            }
        }
    }
}
    
