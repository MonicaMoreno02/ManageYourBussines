using ManageYourBussines.Datos;
using ManageYourBussines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageYourBussines.Logica
{
    public class clTareaEpleL
    {
        public int mtdlistarmat(clTareaEpleE objmat)
        {
            clTareaEpleD objmatD = new clTareaEpleD();
            List<clTareaEpleE> listaClientes = new List<clTareaEpleE>();

            int filas = objmatD.mtdListamate(objmat);
            return filas;
        }

        public int mtdlistarter(clTareaEpleE objter)
        {
            clTareaEpleD objmatD = new clTareaEpleD();
            List<clTareaEpleE> listaClientes = new List<clTareaEpleE>();

            int filas = objmatD.mtdListarter(objter);
            return filas;
        }

    }
}