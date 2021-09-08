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
    }
}
