using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Compilation;
using Entities;
using Logic;
using System.Web.Services;
using System.Web.Script.Services;

namespace Capas
{
    public partial class ListadoAjax : System.Web.UI.Page
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["ConexionLibros"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod,ScriptMethod(ResponseFormat=ResponseFormat.Json,UseHttpGet=true)]
        public static List<Libro> ObtenerLibrosAjax()
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["ConexionLibros"].ConnectionString;
            List<Libro> libros = LibroService.ObtenerLibros(connectionString);
            return libros;
        }
        [WebMethod, ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public static List<Autor> ObtenerAutores()
        {
            return AutorService.GetAutores();
        }
        [WebMethod, ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public static List<Editorial> ObtenerEditoriales()
        {
            return EditorialService.ObtenerEditoriales();
        }
    }
}