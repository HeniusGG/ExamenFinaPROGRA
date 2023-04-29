using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExamenFinal
{
    public class Usuarios
    {
        public static string Clave_Usuario { get; set; }
        public static string Nombre_Usuario { get; set; }


        public static int ValidarUsuario()
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Conexion.ConexionDB())
                {
                    SqlCommand cmd = new SqlCommand("VALIDAR_USUARIO", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@clave_usuario", Clave_Usuario));
                    cmd.Parameters.Add(new SqlParameter("@nombre_usuario", Nombre_Usuario));

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            string valor = rdr[0].ToString();   
                            retorno = 1;
                         
                        }
                    }

                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }
            return retorno;
        }
    }
}