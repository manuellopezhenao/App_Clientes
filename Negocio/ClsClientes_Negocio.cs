using System;
using System.Collections.Generic;
using System.Linq;
using Datos;

namespace Negocio
{
    public class ClsClientes_Negocio
    {
        public int pos; public Decimal total, cuota2;

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
            if(sw==1)
            {
                ClsClientes_Datos ObjetoDatos = new ClsClientes_Datos();
                ObjetoDatos.Fnt_AgregarCliente(cliente);
                msn = "El cliente " + cliente["nombres"] + " Ha sido registrado con exito";
            }
            else
            {
                msn = "El Cliente: "+ cliente["id"] + "Ya se encuentra registrado";
            }
        }
        
        public Dictionary<string, String> Fnt_ConsultarCliente(Dictionary<string, String> cliente)
        {
            ClsClientes_Datos ObjetoConsultar = new ClsClientes_Datos();
            if (cliente["id"] != "" && ObjetoConsultar.sw ==0)
            {
                ObjetoConsultar.Ftn_ConsultarDatos(cliente["id"]);

                for (int i = cliente.Count - 1; i >= 0; i--)
                {
                    var result = cliente.ElementAt(i);
                    if (i != 0)
                    {
                        cliente[result.Key] = Convert.ToString(ObjetoConsultar.Lectura[i-1]);
                    }
                }
                msn = "";
            }
            else
            {
                msn = "No se econtro el cliente: " + cliente["id"];
            }
            return cliente;

        }
        public void Fnt_CalcularCuota(String monto, int cuota)
        {
            ClsClientes_Datos ObjCalcular = new ClsClientes_Datos();
            ObjCalcular.Fnt_ConsultarCuota(monto, cuota);
            cuota2 = Convert.ToDecimal(ObjCalcular.cuota2);
            total = Convert.ToDecimal(ObjCalcular.total);
            pos = Convert.ToInt32(ObjCalcular.pos_interes);
        }

        public void Fnt_ActualizarCliente(String id, String contacto, String correo, String edad, String ingesos, String empresa, String contactoE, int estado)
        {
            
                if (((((((id == "") || (contacto == "") || (correo == "") || (edad == "ingresos") || (empresa == "") || (contactoE == "") ))))))
                {
                    sw = 1;
                    msn = "Debe diligenciar toda la informacion Solicitada";
                    return;
                }
            
            if (sw ==0)
            {
                ClsClientes_Datos ObjetoDatos = new ClsClientes_Datos();
                ObjetoDatos.Fnt_Actualizar(id, contacto, correo, edad, ingesos, empresa, contactoE, estado);
                msn = "Datos actualizados con exito";
            }
        }

    }
}
