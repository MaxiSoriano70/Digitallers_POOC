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
    }
}
