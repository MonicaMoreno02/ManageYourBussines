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
                lbpocicion.Text = lista.ToString();


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

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            int idemple = 1;
            int idtarea = int.Parse(lbidtarea.Text);
            int pocicion = int.Parse(lbpocicion.Text);
            int cuenta = gvmateriales.Rows.Count;
            for (int i = 0; i < cuenta; i++)
            {

                string valor = gvmateriales.Rows[i].Cells[1].Text;
                int idmat = int.Parse(valor);

                string pocicicion = gvtareas.Rows[pocicion].Cells[4].Text;
                int pos = int.Parse(valor);

                string valor1 = gvmateriales.Rows[i].Cells[4].Text;
                int cantidad = int.Parse(valor);

                string valor2 = gvmateriales.Rows[i].Cells[3].Text;
                float precio = float.Parse(valor2);
                int num = 0;
                ; float tot = precio * cantidad;
                if (cantidad > 0)
                {
                    num = num + 1;
                    clTareaEpleE objmat = new clTareaEpleE();
                    objmat.idTareas = idtarea;
                    objmat.idmaterial = idmat;
                    objmat.cantidad = cantidad;
                    objmat.totalmat = tot;
                    objmat.idEmpleado = idemple;
                    objmat.pos = pos;
                    objmat.num = num;


                    clTareaEpleL objmeterial = new clTareaEpleL();
                    int filas = objmeterial.mtdlistarmat(objmat);

                    if (filas > 0)
                    {

                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('la tare seasigno correctamente ');", true);



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
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('jhhh');", true);
                    }


                }
            }
        }

        protected void btnpendiente_Click(object sender, EventArgs e)
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
            gvterminar.DataSource = null;
            gvterminar.DataBind();
            gvprogreso.DataSource = null;
            gvprogreso.DataBind();
        }

        protected void btnprogreso_Click(object sender, EventArgs e)
        {
            int idemple = 1;
            string progreso = "proceso";
            estadoTareaE objTareas = new estadoTareaE();
            objTareas.idEmpleado = idemple;
            objTareas.estado = progreso;


            estadoTareaL objtareaL = new estadoTareaL();
            DataTable tareas = new DataTable();
            List<estadoTareaE> listartarea = new List<estadoTareaE>();
            //Session["objeto"] = objCarritoL.mtdListcar();
            listartarea = objtareaL.mtdList(objTareas);
            gvprogreso.DataSource = listartarea;
            gvprogreso.DataBind();

            gvtareas.DataSource = null;
            gvtareas.DataBind();
            gvmateriales.DataSource = null;
            gvmateriales.DataBind();
            gvterminar.DataSource = null;
            gvterminar.DataBind();

        }

        protected void btnterminado_Click(object sender, EventArgs e)
        {
            int idemple = 1;
            string progreso = "terminado";
            estadoTareaE objTareas = new estadoTareaE();
            objTareas.idEmpleado = idemple;
            objTareas.estado = progreso;


            estadoTareaL objtareaL = new estadoTareaL();
            DataTable tareas = new DataTable();
            List<estadoTareaE> listartarea = new List<estadoTareaE>();
            //Session["objeto"] = objCarritoL.mtdListcar();
            listartarea = objtareaL.mtdList(objTareas);
            gvterminar.DataSource = listartarea;
            gvterminar.DataBind();
            gvtareas.DataSource = null;
            gvtareas.DataBind();
            gvmateriales.DataSource = null;
            gvmateriales.DataBind();
          

        }

        protected void gvprogreso_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int lista = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = gvprogreso.Rows[lista];

            string valor = gvprogreso.Rows[lista].Cells[1].Text;
            int cantidades = int.Parse(valor);
            lbidtarea.Text = valor.ToString();
            lbpocicion.Text = lista.ToString();

            clTareaEpleE objter = new clTareaEpleE();
            objter.idTareas = cantidades;

            clTareaEpleL objmeterial = new clTareaEpleL();
            int filas = objmeterial.mtdlistarter(objter);
        }
    }
}
