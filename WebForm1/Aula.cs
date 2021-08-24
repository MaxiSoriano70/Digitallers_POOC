using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm1
{
    public class Aula
    {
        public string Codigo { get; set; }
        public int Capacidad { get; set; }
        public Aula() { }
        public Aula(string codigo, int capacidad) {
            Codigo = codigo;
            Capacidad = capacidad;
        }
    }
}