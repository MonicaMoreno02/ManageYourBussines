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



<<<<<<< HEAD
          
=======
            tareas.Columns.Add(new DataColumn("Documento", typeof(string)));
>>>>>>> 8f261e408640d8a56e2d55601d9a649276b7428d
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
<<<<<<< HEAD

=======
           
>>>>>>> 8f261e408640d8a56e2d55601d9a649276b7428d

            for (int i = 0; i < num; i++)
            {
                if (i != cuenta)
                {
                    int numero = i + 1;
<<<<<<< HEAD
                 
                    string Nombres = listarTareas[i].nombres;
                    string Apellidos = listarTareas[i].apellidos;
                    string tipoEmpleado = listarTareas[i].tipoEmpleado;
                    string nombreTarea = listarTareas[i].nombreTarea;
=======
                    string Documento = listarTareas[i].documento;
                    string Nombres = listarTareas[i].nombres;
                    string Apellidos = listarTareas[i].apellidos;
                    string tipoEmpleado = listarTareas[i].tipoEmpleado;
                    string NombreTarea = listarTareas[i].nombreTarea;
>>>>>>> 8f261e408640d8a56e2d55601d9a649276b7428d
                    string DescripcionTarea = listarTareas[i].descripcionTarea;
                    string FechaInicio = listarTareas[i].fechaInicio;
                    string FechaTerminacion = listarTareas[i].fechaTerminacion;
                    string estado = listarTareas[i].estado;


<<<<<<< HEAD

=======
                   
>>>>>>> 8f261e408640d8a56e2d55601d9a649276b7428d

                    DataRow row = tareas.NewRow();


<<<<<<< HEAD
                   
                    row["nombres"] = Nombres;
                    row["apellidos"] = Apellidos;
                    row["tipoEmpleado"] = tipoEmpleado;
                    row["nombreTarea"] = nombreTarea;
=======
                    row["documento"] = Documento;
                    row["nombres"] = Nombres;
                    row["apellidos"] = Apellidos;
                    row["tipoEmpleado"] = tipoEmpleado;
                    row["nombreTarea"] = NombreTarea;
>>>>>>> 8f261e408640d8a56e2d55601d9a649276b7428d
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
<<<<<<< HEAD
=======
            
     
    
>>>>>>> 8f261e408640d8a56e2d55601d9a649276b7428d
