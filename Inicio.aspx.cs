using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using Logic;
namespace Capas
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //LibroService libroService = new LibroService();
            Libro libro = LibroService.ObtenerLibro();
            lb_titulo.Text = libro.Titulo;
            lb_editorial.Text = libro.Editorial;
        }
    }
}