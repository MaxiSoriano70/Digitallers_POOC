using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm1
{
    public class Curso
    {
        public int Id_Curso { get; set; }
        public int Cantidad_Estudiantes {
            get
            {
                return Estudiantes.Count;
            }    
        }
        public int Cantidad_Clases{
            get
            {
                return Clases.Count;
            }
        }
        public List<Estudiantes> Estudiantes { set; get; }
        public Instructor Instructor { get; set; }
        public List<Clase> Clases { get; set; }
        public Materia Materia { get; set; }
        public Curso() { }
        public Curso(int id,List<Estudiantes> estudiantes, Instructor instructor, List<Clase> clases,Materia materia)
        {
            Id_Curso = id;
            Estudiantes = estudiantes;
            Instructor = instructor;
            Clases = clases;
            Materia = materia;
        }
    }
}