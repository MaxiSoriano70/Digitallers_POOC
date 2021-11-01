using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int suma = 0;

            foreach(int n in numeros)
            {
                suma += n;
            }

            Console.WriteLine("El resultado de la suma de los números es: " + suma);



            List<int> pares = new List<int>();

            for(int i=0; i< numeros.Count; i++)
            {
                if(numeros[i] % 2 == 0)
                {
                    pares.Add(numeros[i]);
                }
            }


            Console.WriteLine("--------- Números Pares --------------");
            foreach(int p in pares)
            {
                Console.WriteLine(p);
            }



            int sumaLinq = numeros.Sum();

            Console.WriteLine("------------ Suma con Linq ----------");
            Console.WriteLine(sumaLinq);




            //List<int> paresLinq =  numeros.Where(function => lambda)
            
            
            List<int> paresLinq = numeros.Where(num => num % 2 == 0).ToList();
            
            
            //var test = numeros.Where(num => num % 2 == 0);

            //Console.WriteLine(test.GetType());


            Console.WriteLine("------ Numeros pares con linq ------------");
            foreach(int p in paresLinq)
            {
                Console.WriteLine(p);
            }

            /*
             * 4/2 = 2 R=0;
             * 5/2 = 2 R=1
             * */



            List<string> letras = new List<string> { "j", "a", "w", "p", "o" };


            List<string> consonantes = letras.Where(letra => letra != "a" && letra != "e" && letra != "i" 
            && letra != "o" && letra != "u").ToList();


            foreach(string consonante in consonantes)
            {
                Console.WriteLine(consonante);
            }

            

            Console.ReadLine();
        }
    }
}
