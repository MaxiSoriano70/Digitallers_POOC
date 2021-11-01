using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity1
{
    public static class Extendida
    {
        public static string Extension(this string value)
        {
            char[] array = value.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }

        public static string NuevoMetodo(this ClaseA ca)
        {
            return "Soy un metodo agregado a la clase a a través de la extensión de tipo";
        }

        public static int Sumar(this ClaseA ca,int n1, int n2)
        {
            return n1 + n2;
        }
    }
}