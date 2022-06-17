using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static ManageYourBussines.Datos.ClConexion;

namespace ManageYourBussines.Datos
{
    public class clMarerialesD
    {
        public List<clMaterialesE> mtdListarD()
        {

            string sql = "select * from materiales";
            clConexion objConexion = new clConexion();
            DataTable tblMateriales = new DataTable();
            tblMateriales = objConexion.mtdDesconectado(sql);

            List<clMaterialesE> ListaMateriales = new List<clMaterialesE>();

            int cantReg = tblMateriales.Rows.Count;
            for (int i = 0; i < cantReg; i++)
            {

                clMaterialesE objMaterial = new clMaterialesE();

                objMaterial.idmaterial = int.Parse(tblMateriales.Rows[i]["idmaterial"].ToString());
                objMaterial.nombrematerial = tblMateriales.Rows[i]["nombrematerial"].ToString();
                objMaterial.precio = float.Parse(tblMateriales.Rows[i]["precio"].ToString());


                ListaMateriales.Add(objMaterial);
            }

            return ListaMateriales;
        }
    }
}