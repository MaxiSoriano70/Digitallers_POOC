using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class ClaseB:ClaseA
    {
        public string AtributoClaseB { get; set; }
        public ClaseB(string c) : base(c)
        {
            /*
             * ClaseB c1= new ClaseB (12);
             * ClaseA c1= new ClaseA (12);
             */
        }
        public ClaseB(int n):base(n) { }
        public ClaseB(int n, string c) : base(n)
        {
            AtributoClaseB = c;
            Console.WriteLine("Constructor de la ClaseB que recibio {0} como parámetro", AtributoClaseB);
        }
        public override string imprimir()
        {
            return base.imprimir()+" y de la ClaseB tambien";
        }
    }
}
