using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            // El encapsulamiento establece que los atributos de una clase
            // deben ser privados, y los metodos de accesos publicos
            // Estudiantes e1 = new Estudiantes();
            /*e1.dni = "11456789";
            e1.nombre = "Maria Perez";
            e1.edad = 74;
            e1.materia = "PHP";
            e1.regular = true;*/
            //Console.WriteLine("El nombre de la estudiante es {0}",e1.nombre);

            Estudiantes e2 = new Estudiantes();
            e2.setDni("11456789");
            e2.saludar();
            Console.WriteLine("El DNI del estudiante es {0}", e2.getDni());
            Console.ReadLine();
        }
    }
}
