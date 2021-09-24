using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;

namespace _3_DAO
{
    public class EditorialDAO
    {
        private static string StringConexion = Properties.Settings.Default.ConexionLibros;
        private static SqlConnection objConexion = null;
        public static List<Editorial> ObtenerEditoriales()
        {
            List<Editorial> editoriales = new List<Editorial>();
            try
            {
                objConexion = new SqlConnection(StringConexion);
            }
            catch(Exception ex)
            {
                throw new Exception("Se ha producido un error en la conexion" + Environment.NewLine + ex.Message);
            }
            SqlCommand cmd = new SqlCommand("select id_editorial,nombre from editoriales",objConexion);
            SqlDataReader rd = null;
            try
            {
                objConexion.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Editorial ed = new Editorial();
                    ed.Id_editorial = Convert.ToInt32(rd["id_editorial"]);
                    ed.Nombre = rd["nombre"].ToString();
                    editoriales.Add(ed);
                }
                return editoriales;
            }
            catch(Exception ex)
            {
                throw new Exception("Se ha producido un error en la conexion" + Environment.NewLine + ex.Message);
            }
            finally
            {
                objConexion.Close();
            }

        }
    }
}
