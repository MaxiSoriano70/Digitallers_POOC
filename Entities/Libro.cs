using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        /*public Editorial Editorial { get; set; }
        public Autor Autor { get; set; }*/
        public Editorial Editorial { get; set; }
        public Autor Autor { get; set; }


        public void setAutor(Autor autor_param)
        {
            Autor = autor_param;
        }

        public void setEditorial(Editorial editorial_param)
        {
            Editorial = editorial_param;
        }

    }
}
