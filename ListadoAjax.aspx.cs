using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using Logic;
using System.Web.Services;
using System.Web.Script.Services;

namespace Capas
{
    public partial class ListadoAjax : System.Web.UI.Page
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["ConexionLibros"].ConnectionString;
        public static string MensajeError = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod, ScriptMethod(ResponseFormat=ResponseFormat.Json, UseHttpGet =true)]
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


        [WebMethod, ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet =true)]
        public static List<Editorial> ObtenerEditoriales()
        {
            return EditorialService.ObtenerEditoriales();
        }

        [WebMethod, ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet =false)]
        public static Libro ObtenerLibroPorId(int id_libro_param)
        {
            try
            {
                return LibroService.GetLibroPorId(id_libro_param);
            }catch(Exception ex)
            {
                throw new Exception("No se pudo obtener el libro");
            }
        }
        [WebMethod, ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = false)]
        public static string ActualizarLibro(Libro libro)
        {
            try
            {
                //return LibroService.UpdateLibro(libro);
                int respuesta = LibroService.UpdateLibro(libro);
                if (respuesta == 0)
                {
                    throw new Exception("No se pudo actualizar el libro");
                }
                return "Ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}