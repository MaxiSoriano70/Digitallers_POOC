using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm1
{
    public class Colecciones
    {
        public Array getArray()
        {
            Array array = new int[] { 14, 24, 48, 96 };
            return array;
        }
        public List<string> getListStrings()
        {
            List<string> listadoString = new List<string>();
            listadoString.Add("Hola");
            listadoString.Add("Mundo");
            listadoString.Add("Otra palabra");
            listadoString.Remove("Mundo");
            //listadoString.Clear();
            return listadoString;
        }
        public List<Persona> grtPersonas()
        {
            List<Persona> personas = new List<Persona>();
            Persona p1 =new Persona("1234578","MAria","Perez");
            Persona p2 = new Persona("85236479","MArta", "Gonzalez");
            Persona p3 = new Persona("75984354","MAxi", "Rodrigues");
            personas.Add(p1);
            personas.Add(p3);
            personas.Add(p2);
            return personas;
        }
    }
}