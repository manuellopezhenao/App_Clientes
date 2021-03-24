using System;
using System.Collections.Generic;
using Datos;

namespace Negocio
{
    public class ClsClientes_Negocio
    {
        public String msn;
        int sw = 0;
        public void Fnt_AgregarCliente(Dictionary<string, String> cliente)
        {

            foreach (KeyValuePair<string, string> result in cliente)
            {
                if(result.Value == "")
                {
                    sw = 1;
                    msn = "Debe diligenciar toda la informacion Solicitada";
                    return;
                }
            }  
            if(sw==0)
            {
                ClsClientes_Datos ObjetoDatos = new ClsClientes_Datos();
                ObjetoDatos.Fnt_AgregarCliente(cliente);
                msn = "El cliente " + cliente["nombres"] + " Ha sido registrado con exito";
            }
        }
    }
}
