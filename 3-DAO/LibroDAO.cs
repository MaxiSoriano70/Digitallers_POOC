using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;

namespace _3_DAO
{
    public class LibroDAO
    {
        private static string StringConexion = Properties.Settings.Default.ConexionLibros;
        public static Libro getLibro()
        {
            Libro libro = new Libro();
            libro.Titulo = "Test Libro";
            libro.Editorial.Nombre = "Test Editorial";
            return libro;
        }

        public static List<Libro> GetLibros(string connectionString)
        {
            List<Libro> libros = new List<Libro>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "select * from consulta_libros";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        Libro libro = new Libro();
                        Autor autor = new Autor();
                        Editorial editorial = new Editorial();
                        libro.Id = Convert.ToInt32(rd["id_libro"]);
                        libro.Titulo = rd["titulo"].ToString();
                        autor.Nombre = rd["autor"].ToString();
                        editorial.Nombre = rd["editorial"].ToString();
                        //libro.Editorial = editorial;
                        //libro.Autor = autor;
                        libro.setEditorial(editorial);
                        libro.setAutor(autor);
                        libros.Add(libro);
                    }
                    return libros;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            
        }

        public static int SaveBook(Libro libro)
        {
            using(SqlConnection conexion = new SqlConnection(StringConexion))
            {
                try
                {
                    string query = "insert into libros(titulo,id_autor,id_editorial) values " +
                        "(@titulo,@autor,@editorial)";

                    SqlCommand cmb = new SqlCommand(query,conexion);
                    
                    SqlParameter paramTitulo = new SqlParameter("@titulo", libro.Titulo);
                    SqlParameter paramAutor = new SqlParameter("@autor", libro.Autor.Id);
                    SqlParameter paramEditorial = new SqlParameter("@editorial", libro.Editorial.Id_editorial);

                    cmb.Parameters.Add(paramTitulo);
                    cmb.Parameters.Add(paramAutor);
                    cmb.Parameters.Add(paramEditorial);

                    conexion.Open();
                    return cmb.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public static Libro GetLibroPorId(int id_libro)
        {
            using(SqlConnection conexion = new SqlConnection(StringConexion))
            {
                Libro libro = new Libro();
                try
                {
                    string query = "select id_libro,titulo,id_autor,id_editorial from libros where id_libro = @id";
                    SqlCommand cmb = new SqlCommand(query, conexion);
                    SqlParameter param_id = new SqlParameter("@id", id_libro);
                    cmb.Parameters.Add(param_id);
                    conexion.Open();
                    SqlDataReader rd = cmb.ExecuteReader();
                    while (rd.Read())
                    {
                        Editorial ed = new Editorial();
                        Autor au = new Autor();
                        libro.Id = Convert.ToInt32(rd["id_libro"]);
                        libro.Titulo = rd["titulo"].ToString();
                        au.Id = Convert.ToInt32(rd["id_autor"]);
                        ed.Id_editorial = Convert.ToInt32(rd["id_editorial"]);
                        libro.Autor = au;
                        libro.Editorial = ed;
                    }
                    return libro;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conexion.Close();
                }
            }
        } 
    }
}
