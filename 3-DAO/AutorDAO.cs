using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entities;
using System.Data.SqlClient;

namespace _3_DAO
{
    public class AutorDAO
    {
        private static string StringConexion = Properties.Settings.Default.ConexionLibros;
        
        
        
        private static SqlConnection objConexion = null;
        
        
        
        
        public static List<Autor> ObtenerAutores()
        {
            List<Autor> autores = new List<Autor>();
            try
            {
                objConexion = new SqlConnection(StringConexion);
            }catch(Exception ex)
            {
                throw new Exception("Se ha producido un error en la conexión" + Environment.NewLine + ex.Message);
            }
            SqlCommand objCommand = new SqlCommand("select id_autor,nombre from autores", objConexion);
            SqlDataReader objReader = null;
            try
            {
                objConexion.Open();
                objReader = objCommand.ExecuteReader();
                while (objReader.Read())
                {
                    Autor autor = new Autor();
                    autor.Id = Convert.ToInt32(objReader["id_autor"]);
                    autor.Nombre = objReader["nombre"].ToString();
                    autores.Add(autor);
                }
                return autores;
            }catch(Exception ex)
            {
                throw new Exception("Se ha producido un error en la tabla autores." + Environment.NewLine + ex.Message);
            }
            finally
            {
                objConexion.Close();
            }
        }
    }
}
