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
        protected Array miArray;
        protected IEnumerator<int> iEnum;
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Persona p = new Persona();
            p.Nombre = "Roberto";
            p.Apellido = "Rodriguez";
            txt_nombre.Text = p.Nombre;
            txt_apellido.Text = p.Apellido;*/
        }
        protected void Form_Submit(object sender, EventArgs e)
        {
            nombre_ingresado.Text = txt_nombre.Text;
            apellido_ingresado.Text = txt_apellido.Text;
        }
        protected void getArray()
        {
            Colecciones c = new Colecciones();
            miArray = c.getArray();
            //iEnum = (IEnumerator<int>)miArray.GetEnumerator();
        }
    }
}