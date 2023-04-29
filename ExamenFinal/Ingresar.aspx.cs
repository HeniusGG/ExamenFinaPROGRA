using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal
{
    public partial class Ingresar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ingre_Click(object sender, EventArgs e)
        {
            Usuarios.Clave_Usuario = clave_usuario.Text;
            Usuarios.Nombre_Usuario = nombre_usuario.Text;

            if (Usuarios.ValidarUsuario() > 0)
            {
                Response.Redirect("inicio.aspx");
            }
        }
    }
}