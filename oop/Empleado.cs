using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Empleado
    {
        public string Nombre { get; set; }
        public int Legajo { get; set; }
        //public double Sueldo { get; set; }
        protected double Sueldo;
        public void Trabajar()
        {
            Console.WriteLine("Estoy trababjando como un empleado");
        }
        public virtual void setSueldo(double s)
        {
            Sueldo = s;
        }
        public double getSueldo()
        {
            return Sueldo;
        }
        public virtual string metodoPadre()
        {
            return "Hola ";
        }
    }
}
