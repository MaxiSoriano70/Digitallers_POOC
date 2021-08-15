using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Nombre = "Roberto";
            p.Apellido = "Rodriguez";
            txt_nombre.Text = p.Nombre;
            txt_apellido.Text = p.Apellido;
        }
    }
}