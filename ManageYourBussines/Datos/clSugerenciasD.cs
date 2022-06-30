using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Datos
{
    public class clSugerenciasD
    {
        //metodo que agrega la sugerencia del cliente en la base de datos Cristian Salcedo

        public int mtdAgregarD(clSugerenciasE objDatosL)
        {
            string sql = "insert into sugerencias (opinion, idCliente) values('" + objDatosL.opinion + "'," + objDatosL.idCliente + ")";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(sql);
            return resultado;

        }

        //Metodo que lista los datos de la tabla sugerencias Cristian Salcedo

        public List<clSugerenciasE> mtdListar()
        {
            string sql = "select sugerencias.idSugerencias, sugerencias.opinion, cliente.nombreCliente from sugerencias inner join cliente on sugerencias.idCliente = cliente.idCliente";


            clConexion objConexion = new clConexion();
            DataTable tblSugerencias = new DataTable();
            tblSugerencias = objConexion.mtdDesconectado(sql);

            List<clSugerenciasE> listarSugerencias = new List<clSugerenciasE>();

            int catnReg = tblSugerencias.Rows.Count;

            for (int i = 0; i < catnReg; i++)
            {
                clSugerenciasE objDatosSugerencias = new clSugerenciasE();
                objDatosSugerencias.idSugerencias = int.Parse(tblSugerencias.Rows[i]["idSugerencias"].ToString());
                objDatosSugerencias.nombreCliente = tblSugerencias.Rows[i]["nombreCliente"].ToString();
                objDatosSugerencias.opinion = tblSugerencias.Rows[i]["opinion"].ToString();

                listarSugerencias.Add(objDatosSugerencias);
            }

            return listarSugerencias;
        }
    }
}
