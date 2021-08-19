using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm1
{
    public class Estudiantes:Persona
    {
        public bool Regular { get; set; }
        public Estudiantes() { }
        public Estudiantes(string d, string n, string a, bool r): base (d,n,a)
        {
            Regular = r;
        }
        public Estudiantes(string n, string a, bool r) : base(n, a)
        {
            Regular = r;
        }
    }
}