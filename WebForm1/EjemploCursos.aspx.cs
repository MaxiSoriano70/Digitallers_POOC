using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm1
{
    public partial class EjemploCursos : System.Web.UI.Page
    {
        protected Curso MiCurso;
        protected void Page_Load(object sender, EventArgs e)
        {
            CrearCursos();
        }
        protected void CrearCursos()
        {
            Estudiantes es1 = new Estudiantes("12345678","Maria", "Perez",true);
            Estudiantes es2 = new Estudiantes("1237895","Pedro", "Ramirez", true);
            Estudiantes es3 = new Estudiantes("12312354","Noelia", "Jota", true);
            List<Estudiantes> estudiantes = new List<Estudiantes>();
            estudiantes.Add(es1);
            estudiantes.Add(es2);
            estudiantes.Add(es3);

            Materia m1 = new Materia("PHP", "Programa de PHP");
            Materia m2 = new Materia("C#", "Programa de C#");
            List<Materia> materias = new List<Materia>();
            materias.Add(m1);
            materias.Add(m2);

            Instructor i1 =new Instructor("85236478","Carla","Garcia",materias);
            Aula a1 = new Aula("0010",15);
            Aula a2 = new Aula("0012",10);

            Clase c1 = new Clase(DateTime.Parse("8/24/2021 7:00:00 PM"), DateTime.Parse("8/24/2021 10:00:00 PM"), a1);
            Clase c2 = new Clase(DateTime.Parse("8/31/2021 7:00:00 PM"), DateTime.Parse("8/31/2021 10:00:00 PM"), a1);
            Clase c3 = new Clase(DateTime.Parse("9/7/2021 7:00:00 PM"),DateTime.Parse("9/7/2021 10:00:00 PM"),a2);
            List<Clase> clases = new List<Clase>();
            clases.Add(c1);
            clases.Add(c2);
            clases.Add(c3);
            MiCurso = new Curso(estudiantes, i1, clases, m1);
        }
    }
}