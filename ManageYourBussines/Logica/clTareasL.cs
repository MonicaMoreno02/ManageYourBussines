using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class clTareasL
    {
        public DataTable mtdListarTareas()
        {
            clTareasD objTareasD = new clTareasD();
            List<clTareasE> listarTareas = new List<clTareasE>();
            listarTareas = objTareasD.mtdListarTareas();
            DataTable tareas = new DataTable();



            tareas.Columns.Add(new DataColumn("Documento", typeof(string)));
            tareas.Columns.Add(new DataColumn("Nombres", typeof(string)));
            tareas.Columns.Add(new DataColumn("Apellidos", typeof(string)));
            tareas.Columns.Add(new DataColumn("tipoEmpleado", typeof(string)));
            tareas.Columns.Add(new DataColumn("nombreTarea", typeof(string)));
            tareas.Columns.Add(new DataColumn("descripcionTarea", typeof(string)));
            tareas.Columns.Add(new DataColumn("fechaInicio", typeof(string)));
            tareas.Columns.Add(new DataColumn("fechaTerminacion", typeof(string)));
            tareas.Columns.Add(new DataColumn("estado", typeof(string)));


            int cuenta = listarTareas.Count;
            int num = cuenta + 1;
           

            for (int i = 0; i < num; i++)
            {
                if (i != cuenta)
                {
                    int numero = i + 1;
                    string Documento = listarTareas[i].documento;
                    string Nombres = listarTareas[i].nombres;
                    string Apellidos = listarTareas[i].apellidos;
                    string tipoEmpleado = listarTareas[i].tipoEmpleado;
                    string NombreTarea = listarTareas[i].nombreTarea;
                    string DescripcionTarea = listarTareas[i].descripcionTarea;
                    string FechaInicio = listarTareas[i].fechaInicio;
                    string FechaTerminacion = listarTareas[i].fechaTerminacion;
                    string estado = listarTareas[i].estado;


                   

                    DataRow row = tareas.NewRow();


                    row["documento"] = Documento;
                    row["nombres"] = Nombres;
                    row["apellidos"] = Apellidos;
                    row["tipoEmpleado"] = tipoEmpleado;
                    row["nombreTarea"] = NombreTarea;
                    row["descripcionTarea"] = DescripcionTarea;
                    row["fechaInicio"] = FechaInicio;
                    row["fechaTerminacion"] = FechaTerminacion;
                    row["estado"] = estado;


                    tareas.Rows.Add(row);
                }



            }
            return tareas;
        }
    }
}
            
     
    
