using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Entity1
{
    public partial class Index : System.Web.UI.Page
    {
        protected string ValorExtended;

        protected void Page_Load(object sender, EventArgs e)
        {
            List<int> numeros = new List<int>();
            numeros.Add(5);
            numeros.Add(25);
            numeros.Add(83);
            Generico(numeros);

            //ValorExtended = Extendida.Extension("hola");
            //valor_extended.Text = ValorExtended;
            ClaseA ca = new ClaseA();
            ClaseB cb = new ClaseB();
            valor_clasea.Text = ca.Saludar();
            valor_claseb.Text = cb.Saludar();
            valor_extended.Text = cb.NuevoMetodo();
            int resultado = cb.Sumar(235, 125);
            valor_suma.Text = "El resultado de la suma es :" + resultado;

            var cadena = "CADENA";
            valor_inferencia.Text = cadena.ToLower();

            var variableAnonima = new { Titulo = "Soy el titulo de una propiedad anónima", AtributoDos = "Soy otro atributo", AtributoTres = 123 };
            valor_tipo_anonima.Text = variableAnonima.GetType().Name;
            valor_titulo.Text = variableAnonima.Titulo;
            valor_prop1.Text = variableAnonima.AtributoDos;
            valor_prop2.Text = variableAnonima.AtributoTres.ToString();


            /* Clase Parcial */
            ParcialA pa = new ParcialA();
            valor_parcial_a.Text = pa.MetodoUno();
            valor_parcial_b.Text = pa.MetodoDos();
            valor_parcial_c.Text = pa.MetodoTres();
            /* ----------------------------- */

        }


        protected string Saludar()
        {
            return "Hola que tal";
        }

        public void Generico<T>(T value)
        {
            dato_generico.Text = value.GetType().Name;
        }

        

        /*
         * value.ToCharArray()
         * "hola" => "h","o","l","a"
         * char[] array => 
         * Array.Reverse(array) => "a","l","o","h"
         * new String(array) => Transformo el array de char en un nuevo string
         */
    }
}