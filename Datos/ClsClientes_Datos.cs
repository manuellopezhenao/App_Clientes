using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ClsClientes_Datos
    {

        public void Fnt_AgregarCliente(Dictionary<String,String> cliente)
        {
            Fnt_Agregar(cliente);
        }
        protected void Fnt_Agregar(Dictionary<String, String> cliente)
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_AgregarCliente", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            foreach (KeyValuePair<string, string> result in cliente)
            {
                con.Parameters.AddWithValue("@" + result.Key, result.Value);
            }
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
    }
}