using ManageYourBussines.Entidades;
using ManageYourBussines.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{
    public partial class frmTareasEmple : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idemple = 1;
            clTareasE objTarea = new clTareasE();
            objTarea.idTareas = idemple;

            tareasL objtareaL = new tareasL();
            DataTable tareas = new DataTable();
            List<clTareasE> listartarea = new List<clTareasE>();
            //Session["objeto"] = objCarritoL.mtdListcar();
            listartarea = objtareaL.mtdList(objTarea);


            gvtareas.DataSource = listartarea;
            gvtareas.DataBind();
        }

        protected void gvtareas_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "aceptar")
            {
                int lista = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvtareas.Rows[lista];
                string valor = gvtareas.Rows[lista].Cells[1].Text;
                int cantidades = int.Parse(valor);
                lbidtarea.Text = valor.ToString();



                clMaterialesL objmateriales = new clMaterialesL();
                DataTable tareas = new DataTable();
                List<clMaterialesE> listarmateriales = new List<clMaterialesE>();
                //Session["objeto"] = objCarritoL.mtdListcar();
                listarmateriales = objmateriales.mtdList();
                DataTable material = new DataTable();
                material.Columns.Add(new DataColumn("#", typeof(int)));
                material.Columns.Add(new DataColumn("id", typeof(int)));
                material.Columns.Add(new DataColumn("nombre", typeof(string)));
                material.Columns.Add(new DataColumn("precio", typeof(string)));
                material.Columns.Add(new DataColumn("cantidad", typeof(string)));

                int cuenta = listarmateriales.Count;

                for (int i = 0; i < cuenta; i++)
                {
                    int numero = i + 1;
                    int idmarerial = listarmateriales[i].idmaterial;
                    string nombre = listarmateriales[i].nombrematerial;
                    float precio = listarmateriales[i].precio;
                    int cantidad = 0;

                    DataRow row1 = material.NewRow();
                    row1["#"] = numero;
                    row1["id"] = idmarerial;
                    row1["nombre"] = nombre;
                    row1["precio"] = precio;
                    row1["cantidad"] = cantidad;
                    material.Rows.Add(row1);



                }
                gvmateriales.DataSource = material;
                gvmateriales.DataBind();

                int idemple = 1;

                clTareasE objTarea = new clTareasE();
                objTarea.idTareas = idemple;

                tareasL objtareaL = new tareasL();

                List<clTareasE> listartarea = new List<clTareasE>();
                //Session["objeto"] = objCarritoL.mtdListcar();
                listartarea = objtareaL.mtdList(objTarea);


                gvtareas.DataSource = listartarea;
                gvtareas.DataBind();
            }
        }

        protected void gvmateriales_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "sumar")
            {

                int lista = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvmateriales.Rows[lista];
                string valor = gvmateriales.Rows[lista].Cells[4].Text;
                int cantidades = int.Parse(valor);


                clMaterialesL objmateriales = new clMaterialesL();
                DataTable tareas = new DataTable();
                List<clMaterialesE> listarmateriales = new List<clMaterialesE>();
                //Session["objeto"] = objCarritoL.mtdListcar();
                listarmateriales = objmateriales.mtdList();
                DataTable material = new DataTable();
                material.Columns.Add(new DataColumn("#", typeof(int)));
                material.Columns.Add(new DataColumn("id", typeof(int)));
                material.Columns.Add(new DataColumn("nombre", typeof(string)));
                material.Columns.Add(new DataColumn("precio", typeof(string)));
                material.Columns.Add(new DataColumn("cantidad", typeof(string)));

                int cuenta = listarmateriales.Count;

                for (int i = 0; i < cuenta; i++)
                {


                    if (i != lista)
                    {
                        valor = gvmateriales.Rows[i].Cells[4].Text;
                        cantidades = int.Parse(valor);


                        int numero = i + 1;
                        int idmarerial = listarmateriales[i].idmaterial;
                        string nombre = listarmateriales[i].nombrematerial;
                        float precio = listarmateriales[i].precio;
                        int cantidad = cantidades;

                        DataRow row1 = material.NewRow();
                        row1["#"] = numero;
                        row1["id"] = idmarerial;
                        row1["nombre"] = nombre;
                        row1["precio"] = precio;
                        row1["cantidad"] = cantidad;
                        material.Rows.Add(row1);
                    }
                    else
                    {

                        valor = gvmateriales.Rows[i].Cells[4].Text;
                        cantidades = int.Parse(valor);

                        int cantidad = cantidades + 1;
                        int numero = i + 1;
                        int idmarerial = listarmateriales[i].idmaterial;
                        string nombre = listarmateriales[i].nombrematerial;
                        float precio = listarmateriales[i].precio;


                        DataRow row1 = material.NewRow();
                        row1["#"] = numero;
                        row1["id"] = idmarerial;
                        row1["nombre"] = nombre;
                        row1["precio"] = precio;
                        row1["cantidad"] = cantidad;
                        material.Rows.Add(row1);

                    }


                }
                gvmateriales.DataSource = material;
                gvmateriales.DataBind();




            }
            if (e.CommandName == "restar")
            {
                int lista = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvmateriales.Rows[lista];
                string valor = gvmateriales.Rows[lista].Cells[4].Text;
                int cantidades = int.Parse(valor);


                clMaterialesL objmateriales = new clMaterialesL();
                DataTable tareas = new DataTable();
                List<clMaterialesE> listarmateriales = new List<clMaterialesE>();
                //Session["objeto"] = objCarritoL.mtdListcar();
                listarmateriales = objmateriales.mtdList();
                DataTable material = new DataTable();
                material.Columns.Add(new DataColumn("#", typeof(int)));
                material.Columns.Add(new DataColumn("id", typeof(int)));
                material.Columns.Add(new DataColumn("nombre", typeof(string)));
                material.Columns.Add(new DataColumn("precio", typeof(string)));
                material.Columns.Add(new DataColumn("cantidad", typeof(string)));

                int cuenta = listarmateriales.Count;

                for (int i = 0; i < cuenta; i++)
                {


                    if (i != lista)
                    {
                        valor = gvmateriales.Rows[i].Cells[4].Text;
                        cantidades = int.Parse(valor);


                        int numero = i + 1;
                        int idmarerial = listarmateriales[i].idmaterial;
                        string nombre = listarmateriales[i].nombrematerial;
                        float precio = listarmateriales[i].precio;
                        int cantidad = cantidades;

                        DataRow row1 = material.NewRow();
                        row1["#"] = numero;
                        row1["id"] = idmarerial;
                        row1["nombre"] = nombre;
                        row1["precio"] = precio;
                        row1["cantidad"] = cantidad;
                        material.Rows.Add(row1);
                    }
                    else
                    {

                        valor = gvmateriales.Rows[i].Cells[4].Text;
                        cantidades = int.Parse(valor);

                        int cantidad = cantidades - 1;
                        int numero = i + 1;
                        int idmarerial = listarmateriales[i].idmaterial;
                        string nombre = listarmateriales[i].nombrematerial;
                        float precio = listarmateriales[i].precio;


                        DataRow row1 = material.NewRow();
                        row1["#"] = numero;
                        row1["id"] = idmarerial;
                        row1["nombre"] = nombre;
                        row1["precio"] = precio;
                        row1["cantidad"] = cantidad;
                        material.Rows.Add(row1);

                    }


                }
                gvmateriales.DataSource = material;
                gvmateriales.DataBind();



            }

        }
    }
    }
