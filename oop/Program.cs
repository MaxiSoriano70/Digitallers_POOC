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

            /*Estudiantes e2 = new Estudiantes();
            e2.saludar();
            Console.WriteLine("El DNI del estudiante es {0}", e2.getDni());
            Console.ReadLine();*/

            /*Estudiantes e3 = new Estudiantes();
            e3.setEdad(12);
            if (e3.getEdad() != 0)
            {
                Console.WriteLine("Bienvenido/a a mi sitio de cerveza artesanal");
            }
            e3.Nombre = "Maria";
            Console.WriteLine("Gracias {0} por registrarte con nosotros.",e3.Nombre);*/

            /*if (e3.getEdad() >= 18)
            {
                Console.WriteLine("Bienvenido/a a mi sitio de cerveza artesanal");
            }
            else
            {
                Console.WriteLine("No tenes edad suficiente para registrarte");
            }*/

            /*Estudiantes e1 = new Estudiantes("11111111");
            Estudiantes e2 = new Estudiantes("22222222");
            Estudiantes e3 = new Estudiantes("33333333");

            e1.Nombre = "Maria Perez";
            e1.setEdad(20);
            e2.Nombre = "Ramiro Gomez";
            e2.setEdad(33);
            e3.Nombre = "Carla Rodriguez";
            e3.setEdad(32);*/

            /*Console.WriteLine("Estudiante 1: {0}, {1} años, DNI: {2}",e1.Nombre,e1.getEdad(),e1.getDni());
            Console.WriteLine("Estudiante 2: {0}, {1} años, DNI: {2}", e2.Nombre, e2.getEdad(), e2.getDni());
            Console.WriteLine("Estudiante 3: {0}, {1} años, DNI: {2}", e3.Nombre, e3.getEdad(), e3.getDni());*/

            /*Estudiantes e1 = new Estudiantes();
            Estudiantes e2 = new Estudiantes("11111111");
            Estudiantes e3 = new Estudiantes("11111111",12);
            e2.saludar();
            e2.saludar("PHP");*/
            //Console.ReadLine();
            //ADMINISTRATIVO
            /*Administrativo a1 = new Administrativo();
            a1.Trabajar();
            a1.Nombre = "Florencio Rodriguez";
            a1.Legajo = 123;
            a1.setSueldo(50000);
            Console.WriteLine("{0}, {1}, ${2}",a1.Nombre,a1.Legajo,a1.getSueldo());

            Vendedor v1 = new Vendedor();
            v1.Trabajar();
            v1.Nombre = "Marta Perez";
            v1.Legajo = 545655;
            //v1.setSueldo=100000;
            v1.setSueldo(100000);
            Console.WriteLine("{0}, {1}, ${2}", v1.Nombre, v1.Legajo, v1.getSueldo());*/
            //VENDEDOR
            /*Vendedor v1 = new Vendedor();
            v1.ventas = 1000000;
            v1.setSueldo(50000);
            Console.WriteLine("El sueldo del vendedor es " + v1.getSueldo());*/

            //SUBAMINITRATIVO
            /*Administrativo a2 = new Administrativo();
            Console.WriteLine(a2.metodoPadre());
            SubAdministrativo s1 = new SubAdministrativo();
            Console.WriteLine(s1.metodoPadre());*/

            /*ClaseA ca = new ClaseA(5);
            ClaseB cb = new ClaseB(111);
            ClaseB cb2 = new ClaseB("Cadena parámetro");
            ClaseB cb3 = new ClaseB(5555, "Parámetro loco");
            Console.WriteLine(cb3.imprimir());*/

            ClaseB cb = new ClaseB(6662);
            ClaseC cc = new ClaseC();
            cb.AttrC = cc;
            //Console.WriteLine(cb.AttrC);
            /*
             *Clase C cc2=cb.AttrC;
             *ccs.imprimirMensaje();
             */
            cb.AttrC.imprimirMensaje();

            Console.ReadLine();
        }
    }
}