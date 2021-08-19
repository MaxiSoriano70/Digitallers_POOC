using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm1
{
    public class Persona
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Persona() { }
        public Persona (string n,string a)
        {
            Nombre = n;
            Apellido = a;
        }
        public Persona(string d, string n, string a)
        {
            Dni = d;
            Nombre = n;
            Apellido = a;
        }
    }
}