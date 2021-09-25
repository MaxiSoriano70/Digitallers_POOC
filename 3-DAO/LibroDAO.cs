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
            libro.Editorial = "Test Editorial";
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
                        libro.Id = Convert.ToInt32(rd["id_libro"]);
                        libro.Titulo = rd["titulo"].ToString();
                        libro.Autor = rd["autor"].ToString();
                        libro.Editorial = rd["editorial"].ToString();
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
        public static int SeveBook(Libro libro)
        {
            using (SqlConnection conexion = new SqlConnection(StringConexion))
            {
                try
                {
                    string query = "insert into libros(titulo,id_autor,id_editorial) values" + "(@titulo,@autor,@editorial)";
                    SqlCommand cmb = new SqlCommand(query, conexion);
                    //REMPLAZA
                    SqlParameter paramTitulo = new SqlParameter("@titulo", libro.Titulo);
                    SqlParameter paramAutor = new SqlParameter("@autor", libro.Autor);
                    SqlParameter paramEditorial = new SqlParameter("@editorial", libro.Editorial);
                    //AGREGA
                    cmb.Parameters.Add(paramTitulo);
                    cmb.Parameters.Add(paramAutor);
                    cmb.Parameters.Add(paramEditorial);
                    conexion.Open();
                    //ANALIZAMOS SI SE REALIZO LA QUERY CORRECTAMENTE si inserta correctamente 1 sino 0
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
    }
}
