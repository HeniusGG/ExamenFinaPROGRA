using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Usuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReportesUsuarios.aspx");
        }

        protected void Mascotas_Click(object sender, EventArgs e)
        {
            Response.Redirect("ResportesMascotas.aspx");
        }

        protected void Citas_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReportesCitas.aspx");
        }

        protected void Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ingresar.aspx");
        }
    }
}