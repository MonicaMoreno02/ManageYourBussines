using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class clSugerenciasL
    {
        //Metodo para recibir objeto de datos y enviarlo a Datos Cristian Salcedo
        public int mtdAgregar(clSugerenciasE objDatosL)
        {
            clSugerenciasD objDatosD = new clSugerenciasD();
            int filas = objDatosD.mtdAgregarD(objDatosL);
            return filas;
        }

        //Metodo que trae todos los datos de la tabla sugerencias Cristian Salcedo

        public List<clSugerenciasE> mtdListarS()
        {
            clSugerenciasD objSugerencias = new clSugerenciasD();
            List<clSugerenciasE> objListaS = new List<clSugerenciasE>();
            objListaS = objSugerencias.mtdListar();
            return objListaS;
        }
    }
}