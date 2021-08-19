using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm1
{
    public partial class Colecciones1 : System.Web.UI.Page
    {
        protected Array miArray;
        protected List<string> listCadenas;
        protected List<Persona> listadoPersonas;
        protected void Page_Load(object sender, EventArgs e)
        {
            getArray();
            getListCadena();
            obtenerPersonas();
        }
        protected void getArray()
        {
            Colecciones c = new Colecciones();
            miArray = c.getArray();
        }
        protected void getListCadena()
        {
            Colecciones c = new Colecciones();
            listCadenas = c.getListStrings();
        }
    }
}