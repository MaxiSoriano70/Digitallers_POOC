using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using Logic;
using System.Web.Configuration;


namespace Capas
{
    public partial class Inicio : System.Web.UI.Page
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["ConexionLibros"].ConnectionString;
        private string connectionStringDos = WebConfigurationManager.ConnectionStrings["ConexionLibrosDos"].ConnectionString;
        protected List<Libro> libros = new List<Libro>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //LibroService libroService = new LibroService();
            /*Libro libro = LibroService.ObtenerLibro();
            lb_titulo.Text = libro.Titulo;
            lb_editorial.Text = libro.Editorial.Nombre;*/
            ListarLibros();
            //capturaError();
        }

        protected void ListarLibros() 
        {
            try
            {
                libros = LibroService.ObtenerLibros(connectionString);
            }
            catch(Exception ex)
            {
                mensaje_error.Text = ex.Message;
            }
        }


        protected void capturaError()
        {
            /*try
            {
                int a = 15;
                int b = 0;
                double resultado = a / b;
            } catch (DivideByZeroException ex)
            {
                mensaje_error.Text = "No se puede dividir por cero " + ex.Message;
            }*/
            try
            {
                //int.Parse("Hola mundo");
                /*int a = 15;
                int b = 0;
                double resultado = a / b;*/
                /*int[] array = new int[3] { 34,453,6543};
                Console.WriteLine(array[5]);*/
                /*int numero = 15;
                if(numero < 11)
                {
                    throw new Exception("El número es menor a 10");
                } */

                /*int.Parse("Hola mundo");
                
                int a = 15;
                int b = 0;
                double resultado = a / b;*/

                //mensaje_error.Text = "Aca iría el texto en condiciones normales";
                LibroService.GenerarError();
            }
            catch(FormatException ex)
            {
                mensaje_error.Text = ex.Message;
            }
            catch(DivideByZeroException ex)
            {
                mensaje_error.Text = ex.Message;
            }
            catch(Exception ex)
            {
                mensaje_error.Text = ex.Message;
            }
            finally
            {
                mensaje_final.Text = "Esto se va a ejecutar siempre";
            }
        }

        
    }
}