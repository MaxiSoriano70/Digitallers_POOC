using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm1
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_get_click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            Response.Redirect("Fin.aspx?nombre="+nombre+"&apellido="+apellido);
        }
        protected void btn_context_click(object sender, EventArgs e)
        {
            Context.Items["Nombre"] = txt_nombre.Text;
            Context.Items["Apellido"] = txt_apellido.Text;
            Server.Transfer("Fin.aspx");
        }
    }
}