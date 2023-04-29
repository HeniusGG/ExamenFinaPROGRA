using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal
{
    public partial class ReportesUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (MetodosUsuarios.Agregar(Login.Text, Clave.Text, Nombre.Text) > 0)
            {
                Conexion.RegistrarAlerta(this, "Articulo ingresado");
                LlenarGrid();
            }
            else
            {
                Conexion.RegistrarAlerta(this, "Error!");
            }
        }

        protected void LlenarGrid()
        {

            try
            {
                string constr = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

                using (SqlConnection con = new SqlConnection(constr))
                {

                    using (SqlCommand cmd = new SqlCommand("MOSTRAR_USUARIOS"))
                    {

                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                GridView1.DataSource = dt;
                                GridView1.DataBind();


                            }
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (MetodosUsuarios.Modificar(Login.Text, Clave.Text, Nombre.Text) > 0)
            {
                Conexion.RegistrarAlerta(this, "Articulo Modificado");
                LlenarGrid();
            }
            else
            {
                Conexion.RegistrarAlerta(this, "Error!");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (int.Parse(Login.Text) >= 0)
            {
                if (MetodosUsuarios.Borrar(Login.Text) > 0)
                {
                    Conexion.RegistrarAlerta(this, "Articulo Borrado");
                    LlenarGrid();
                }
                else
                {
                    Conexion.RegistrarAlerta(this, "Error!");
                }

            }
            else
            {
                Conexion.RegistrarAlerta(this, "Dijite un ID");
            }
        }
    }
}