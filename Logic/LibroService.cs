using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using _3_DAO;

namespace Logic
{
    public class LibroService
    {
        public static Libro ObtenerLibro()
        {
            //LibroDAO libroDao = new LibroDAO();
            Libro libro = LibroDAO.getLibro();
            return libro;
        }

        public static List<Libro> ObtenerLibros(string connectionString)
        {
            try
            {
                return LibroDAO.GetLibros(connectionString);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void GenerarError()
        {
            try
            {
                int.Parse("Hola mundo");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        /*
         * string cadena1 = "Hola";
         * string cadena2 = "hola";
         * if(cadena1 == cadena2) => No para strings
         * if(cadena1.equals(cadena2)) => Esto es correcto
         * if(cadena2.equals(cadena1)) => Esto es correcto
         */
        public static int NuevoLibro(Libro libro)
        {
            try
            {
                if (libro.Titulo.Equals(""))
                {
                    throw new Exception("El título no debe quedar vacío");
                }
                return LibroDAO.SaveBook(libro);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
