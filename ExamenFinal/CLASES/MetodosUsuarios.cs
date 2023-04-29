using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ExamenFinal
{
    public class MetodosUsuarios
    {
        public static int Agregar(string login_usuario, string clave_usuario, string nombre_usuario)
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Conexion.ConexionDB())
                {
                    SqlCommand cmd = new SqlCommand("AGREGAR_USUARIO", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@login_usuario", login_usuario));
                    cmd.Parameters.Add(new SqlParameter("@clave_usuario", clave_usuario));
                    cmd.Parameters.Add(new SqlParameter("@nombre_usuario", nombre_usuario));


                    retorno = cmd.ExecuteNonQuery();

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

        public static int Modificar(string login_usuario, string clave_usuario, string nombre_usuario)
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Conexion.ConexionDB())
                {
                    SqlCommand cmd = new SqlCommand("MODIFICAR_USUARIO", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                   
                    cmd.Parameters.Add(new SqlParameter("@login_usuario", login_usuario));
                    cmd.Parameters.Add(new SqlParameter("@clave_usuario", clave_usuario));
                    cmd.Parameters.Add(new SqlParameter("@nombre_usuario", nombre_usuario));


                    retorno = cmd.ExecuteNonQuery();

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



        public static int Borrar(string Codigo)
        {

            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Conexion.ConexionDB())
                {
                    SqlCommand cmd = new SqlCommand("ELIMINAR_USUARIO", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@Codigo", Codigo));

                    retorno = cmd.ExecuteNonQuery();

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