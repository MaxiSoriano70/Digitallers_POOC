using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm1
{
    public class Clase
    {
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public Aula Aula { get; set; }
        public Clase() { }
        public Clase(DateTime inicio, DateTime fin, Aula aula)
        {
            Inicio = inicio;
            Fin = fin;
            Aula = aula;
        }

    }
}