using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
