using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class ClaseA
    {
        //public ClaseA() { }
        public ClaseA(int n)
        {
            Console.WriteLine("Constructor de la Clase A que recibe un entero como parametro: {0}",n);
        }
        public ClaseA(string cadena)
        {
            Console.WriteLine("Constructor de la Clase A que recibe una string como parametro: {0}",cadena);
        }
        public virtual string imprimir()
        {
            return "Metodo imprimir ClaseA";
        }
    }
}
