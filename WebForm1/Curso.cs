using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm1
{
    public class Curso
    {
        public List<Estudiantes> Estudiantes { set; get; }
        public Instructor Instructor { get; set; }
        public List<Clase> Clases { get; set; }
        public Materia Materia { get; set; }
        public Curso() { }
        public Curso(List<Estudiantes> estudiantes, Instructor instructor, List<Clase> clases,Materia materia)
        {
            Estudiantes = estudiantes;
            Instructor = instructor;
            Clases = clases;
            Materia = materia;
        }
    }
}