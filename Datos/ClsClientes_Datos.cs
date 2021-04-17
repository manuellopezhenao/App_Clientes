using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ClsClientes_Datos
    {
        public ClsConexion objconect_select;
        public int sw = 0;
        public SqlDataReader Lectura;
        public String interes, monto2, pos_interes;
        public Decimal total, cuota2;
        public void Fnt_AgregarCliente(Dictionary<String,String> cliente)
        {
            Fnt_Agregar(cliente);
        }
        protected void Fnt_Agregar(Dictionary<String, String> cliente)
        {
            Ftn_ConsultarDatos(cliente["id"]);
            objconect_select.connection.Close();
            if (sw == 0)
            {
                ClsConexion objconect = new ClsConexion();
                SqlCommand con = new SqlCommand("SP_AgregarCliente", objconect_select.connection);
                con.CommandType = CommandType.StoredProcedure;
                foreach (KeyValuePair<string, string> result in cliente)
                {
                    con.Parameters.AddWithValue("@" + result.Key, result.Value);
                }
                objconect.connection.Open();
                con.ExecuteNonQuery();
                objconect_select.connection.Close();
            }
        }

        public void Ftn_ConsultarDatos(String id)
        {
            objconect_select = new ClsConexion();
            ClsConexion objconect_Insertar = new ClsConexion();
            SqlCommand con;
            con = new SqlCommand("SP_BuscarCliente", objconect_Insertar.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", id);
            objconect_Insertar.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                //nombre = Convert.ToString(Lectura[0]);
                sw = 1;
            }
            //objconect.connection.Close();
        }

        public void Fnt_Actualizar(String id, String contacto, String correo, String edad, String ingresos, String empresa, String contactoE, int estado) {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con;
            con = new SqlCommand("SP_ActualizarCliente", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id",id);
            con.Parameters.AddWithValue("@Contacto", contacto);
            con.Parameters.AddWithValue("@Correo", correo);
            con.Parameters.AddWithValue("@Edad", edad);
            con.Parameters.AddWithValue("@Empresa", empresa);
            con.Parameters.AddWithValue("@Ingresos", ingresos);
            con.Parameters.AddWithValue("@ContactoE", contactoE);
            con.Parameters.AddWithValue("@FKId_TblEstadoCivil", estado);
            
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }

        public void Fnt_ConsultarCuota(String monto, int cuota)
        {
            objconect_select = new ClsConexion();
            SqlCommand con;
            con = new SqlCommand("SP_Calcular", objconect_select.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@monto", monto);
            con.Parameters.AddWithValue("@plazo", cuota);
            con.Parameters.Add("@interes", 0);
            con.Parameters["@interes"].Direction = ParameterDirection.Output;

            con.Parameters.Add("@monto_int", 0);
            con.Parameters["@monto_int"].Direction = ParameterDirection.Output;

            con.Parameters.Add("@Total", SqlDbType.Decimal);
            con.Parameters["@Total"].Direction = ParameterDirection.Output;

            con.Parameters.Add("@cuota", 0);
            con.Parameters["@cuota"].Direction = ParameterDirection.Output;

            con.Parameters.Add("@pos_interes", 0);
            con.Parameters["@pos_interes"].Direction = ParameterDirection.Output;

            objconect_select.connection.Open();//abre la conexión con el servidor de Base de datos
            con.ExecuteNonQuery();
            monto2 = Convert.ToString(con.Parameters["@monto_int"].Value);
            interes = Convert.ToString(con.Parameters["@interes"].Value);
            cuota2 = Convert.ToDecimal(con.Parameters["@cuota"].Value);
            total = Convert.ToDecimal(con.Parameters["@Total"].Value);
            pos_interes = Convert.ToString(con.Parameters["@pos_interes"].Value);
            objconect_select.connection.Close();
        }
    }



}