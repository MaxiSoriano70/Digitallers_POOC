﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Estudiantes
    {
        private string dni;
        private string nombre;
        private int edad;
        private string materia;
        private bool regular;

        public void saludar()
        {
            Console.WriteLine("Hola yo soy estudiante de Programación");
        }
        //GETTERS Y SETTERS
        public void setDni(string dni_param)
        {
            dni = dni_param;
        }
        public string getDni()
        {
            return dni;
        }
    }
}
