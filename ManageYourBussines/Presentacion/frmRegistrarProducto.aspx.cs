using ManageYourBussines.Entidades;
using ManageYourBussines.Logica;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{
    public partial class frmRegistrarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            clProductoE objDatosProducto = new clProductoE();
            objDatosProducto.nombreProducto = txtAsignarNombre.Text;
            objDatosProducto.descripcion = txtAsignarDescripcion.Text;
            objDatosProducto.precio = float.Parse(txtAsignarPrecio.Text);
            objDatosProducto.cantidadStock = int.Parse(txtAsignarCantidadStock.Text);
            objDatosProducto.largo = txtAsignarLargo.Text;
            objDatosProducto.ancho = txtAsignarAncho.Text;
            objDatosProducto.profundidad = txtAsignarProfundidad.Text;
            objDatosProducto.material = txtAsignarMaterial.Text;
            objDatosProducto.caracteristicas = txtAsignarCaracteristicas.Text;


            //Sacamos le url y guardamos la imagen en la base de datos Cristian Salcedo

            string ext = Path.GetExtension(fuImagen.FileName);

            if (ext != "")
            {
                if (ext == ".jpeg" || ext == ".jpg")
                {
                    string imagen = objDatosProducto.precio + ext;

                    objDatosProducto.imagen = "recursos/images/" + imagen;

                    clProductoL objDatosL = new clProductoL();
                    int resultado = objDatosL.mtdAgregar(objDatosProducto);
                    if (resultado != 0)
                    {
                        string ruta = objDatosProducto.imagen;
                        fuImagen.SaveAs(Server.MapPath(ruta));
                        txtAsignarNombre.Text = "";
                        txtAsignarDescripcion.Text = "";
                        txtAsignarPrecio.Text = "";
                        txtAsignarCantidadStock.Text = "";
                        txtAsignarLargo.Text = "";
                        txtAsignarAncho.Text = "";
                        txtAsignarProfundidad.Text = "";
                        txtAsignarMaterial.Text = "";
                        txtAsignarCaracteristicas.Text = "";
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Datos insertados correctamente');", true);

                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Error al insertar Datos');", true);

                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Error, el tipo de imagen no es compatible, debe ser .jpeg');", true);

                }
            }
            else
            {
                clProductoL objDatosL = new clProductoL();
                int resultado = objDatosL.mtdAgregar(objDatosProducto);

                if (resultado != 0)
                {
                    string ruta = objDatosProducto.imagen;
                    fuImagen.SaveAs(Server.MapPath(ruta));
                    txtAsignarNombre.Text = "";
                    txtAsignarDescripcion.Text = "";
                    txtAsignarPrecio.Text = "";
                    txtAsignarCantidadStock.Text = "";
                    txtAsignarLargo.Text = "";
                    txtAsignarAncho.Text = "";
                    txtAsignarProfundidad.Text = "";
                    txtAsignarMaterial.Text = "";
                    txtAsignarCaracteristicas.Text = "";
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Datos insertados correctamente');", true);

                    Response.Redirect("frmAdminProductos.aspx");    

                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Error al insertar Datos');", true);

                }
            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmAdminProductos.aspx");

        }
    }
    }
