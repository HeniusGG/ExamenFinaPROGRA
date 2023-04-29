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
    public partial class ResportesMascotas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void Ver_Click(object sender, EventArgs e)
        {

        }

        protected void LlenarGrid()
        {

            try
            {
                string constr = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

                using (SqlConnection con = new SqlConnection(constr))
                {

                    using (SqlCommand cmd = new SqlCommand("MOSTRAR_MASCOTAS"))
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
    }
}