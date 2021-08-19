using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm1
{
    public class Materia
    {
        public string Nombre { get; set; }
        public string Programa { get; set; }
        public Materia() { }
        public Materia(string n,string p)
        {
            Nombre = n;
            Programa = p;
        }
    }
}