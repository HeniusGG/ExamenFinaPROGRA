using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ExamenFinal
{
    public class Conexion
    {
        public static void RegistrarAlerta(Page page, string mensaje)
        {
            // Obtener el objeto ClientScriptManager
            ClientScriptManager cs = page.ClientScript;
            // Definir el bloque de script que mostrará la alerta
            string script = "<script>alert(" + "'" + mensaje + "'" + ");</script>";
            // Registrar el script para que se ejecute al cargar la página
            cs.RegisterStartupScript(typeof(Page), "AlertScript", script);
        }


        public static SqlConnection ConexionDB()
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

                SqlConnection conexion = new SqlConnection(con);

                conexion.Open();

                return conexion;
            }
            catch (Exception error)
            {
                return null;
            }



        }
    }
}