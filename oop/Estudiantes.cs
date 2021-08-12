using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Estudiantes
    {
        private string dni = "11456789";

        //FORMA CORTA DE GET y SET
        public string Nombre { get; set; }

        //FORMA LARGA DE GET y SET TRADICIONAL
        /*private string Nombre;
        public void setNombre(string nombre_param)
        {
            Nombre = nombre_param;
        }
        public string getNombre()
        {
            return Nombre;
        }*/

        private int edad;

        private string direccion;

        //CONSTRUCTOR
        public Estudiantes(string dni_param)
        {
            dni = dni_param;
            Console.WriteLine("Entrada el constructor de la clase que recibe el parametro de DNI");
        }
        public Estudiantes(string dni_param,int edad_param)
        {
            Console.WriteLine("Entrada el constructor de la clase que recibe el parametro de DNI y la EDAD");
        }
        public Estudiantes(int edad_param_bis, string nombre_param)
        {
            Console.WriteLine("Entrada el constructor de la clase que recibe el parametro de EDAD y NOMBRE");
        }
        public Estudiantes()
        {
            Console.WriteLine("Entrada el constructor de la clase");
        }
        public void saludar()
        {
            Console.WriteLine("Hola yo soy estudiante de Programación");
        }
        public void saludar(string materia)
        {
            Console.WriteLine("Hola yo soy estudiante de Programacion, y estoy estudiando {0}",materia);
        }
        //GETTERS Y SETTERS
        public string getDni()
        {
            return dni;
        }
        public void setEdad(int edad_param)
        {
            if (edad_param<18)
            {
                Console.WriteLine("No tenes edad suficiente para registrarte");
                edad = 0;
            }
            else
            {
                Console.WriteLine("Bienvenido/a a mi sitio de cerveza artesanal");
                edad = edad_param;
            }
        }
        public int getEdad()
        {
            return edad;
        }
        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }
        public string getDireccion()
        {
            return direccion;
        }
    }
}
