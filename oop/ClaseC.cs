using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class ClaseC:Object
    {
        public void imprimirMensaje()
        {
            Console.WriteLine("Metodo imprimir de la Clase C");
        }
        public override string ToString()
        {
            return "Metodo ToString de la Clase C";
        }
    }
}
