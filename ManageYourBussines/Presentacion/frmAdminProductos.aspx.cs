using ManageYourBussines.Entidades;
using ManageYourBussines.Logica;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageYourBussines.Presentacion
{
    public partial class frmAdminProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static List<clProductoE> mtdListarProducto()
        {
            clProductoL objProductoL = new clProductoL();
            List<clProductoE> listarProductos = new List<clProductoE>();
            listarProductos = objProductoL.mtdListarP();
            return listarProductos;

        }

        //Boton que agrega productos Cristian Salcedo

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
                if (ext == ".jpeg")
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

                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Error al insertar Datos');", true);

                }
            }

        }

        int idProductos = 0;
        //Boton que elimina un producto Cristian Salcedo
        protected void txtEliminar_Click(object sender, EventArgs e)
        {
            
                idProductos = int.Parse(txtIdProducto.Text);
                clProductoL objDatosL = new clProductoL();
                int resultado = objDatosL.mtdEliminar(idProductos);
            
        }

        //Boton que actualiza los datos del producto Cristian Salcedo

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            clProductoE objDatosE = new clProductoE();
            objDatosE.idProducto = int.Parse(txtIdProductoEditar.Text);
            objDatosE.nombreProducto = txtNombreEditar.Text;
            objDatosE.descripcion = txtDescripcionEditar.Text;
            objDatosE.precio = float.Parse(txtPrecioEditar.Text);
            objDatosE.cantidadStock = int.Parse(txtCantidadStockEditar.Text);
            objDatosE.largo = txtLargoEditar.Text;
            objDatosE.ancho = txtAnchoEditar.Text;
            objDatosE.profundidad = txtProfundidadEditar.Text;
            objDatosE.material = txtMaterialEditar.Text;
            objDatosE.caracteristicas = txtCaracteristicasEditar.Text;

            //Sacamos le url y guardamos la imagen en la base de datos Cristian Salcedo

            string ext = Path.GetExtension(FuEditarImagen.FileName);

            if (ext != "")
            {
                if (ext == ".jpeg")
                {
                    string imagen = objDatosE.precio + ext;

                    objDatosE.imagen = "recursos/images/" + imagen;

                    clProductoL objDatosL = new clProductoL();
                    int resultado = objDatosL.mtdEditar(objDatosE);
                    if (resultado != 0)
                    {
                        string ruta = objDatosE.imagen;
                        FuEditarImagen.SaveAs(Server.MapPath(ruta));
                        txtImagenE.Text = "";

                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Datos editados correctamente');", true);

                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Error al editar datos');", true);

                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Error, el tipo de imagen no es compatible, debe ser .jpeg');", true);

                }

            }
            else
            {

                objDatosE.imagen = txtImagenE.Text;
                clProductoL objDatosL = new clProductoL();
                int resultado = objDatosL.mtdEditar(objDatosE);
                if (resultado != 0)
                {
                    txtImagenE.Text = "";
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Datos editados correctamente');", true);


                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Error al editar datos');", true);

                }
            }

        }
    }
    
}