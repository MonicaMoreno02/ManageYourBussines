using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.ClConexion;

namespace ManageYourBussines.Datos
{
    public class clClienteD
    {

        public List<clClienteE> mtdListarD()
        {
            string sql = "select * from cliente";
            clConexion objConexion = new clConexion();
            DataTable tblCliente = new DataTable();
            tblCliente = objConexion.mtdDesconectado(sql);

            List<clClienteE> listarCliente = new List<clClienteE>();

            int cantReg = tblCliente.Rows.Count;
            for (int i = 0; i < cantReg; i++)
            {

                clClienteE objDatosClientes = new clClienteE();


                objDatosClientes.idCliente = int.Parse(tblCliente.Rows[i]["idCliente"].ToString());
                objDatosClientes.documento = tblCliente.Rows[i]["documento"].ToString();
                objDatosClientes.nombres = tblCliente.Rows[i]["nombres"].ToString();
                objDatosClientes.apellidos = tblCliente.Rows[i]["apellidos"].ToString();
                objDatosClientes.telefono = tblCliente.Rows[i]["telefono"].ToString();
                objDatosClientes.direccion = tblCliente.Rows[i]["direccion"].ToString();
                objDatosClientes.email = tblCliente.Rows[i]["email"].ToString();
                objDatosClientes.clave = tblCliente.Rows[i]["clave"].ToString();


                listarCliente.Add(objDatosClientes);
            }
            return listarCliente;
        }


    }
}