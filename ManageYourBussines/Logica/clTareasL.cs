using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class clTareasL
    {
        public int mtdRegistrarTarea(clTareasE objdatosClien)
        {
            clTareasD objClientesD = new clTareasD();
            int resultado = objClientesD.mtdRegistrarTarea(objdatosClien);
            return resultado;
        }
        public List<clTareasE> mtdListarTareas()
        {
            clTareasD objVenta = new clTareasD();
            List<clTareasE> objVentaD = new List<clTareasE>();
            objVentaD = objVenta.mtdListarTar();
            return objVentaD;
        }
    }
}