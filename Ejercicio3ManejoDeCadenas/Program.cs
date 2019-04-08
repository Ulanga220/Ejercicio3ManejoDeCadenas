using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3ManejoDeCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string nombre, apellido;

             Console.WriteLine("Parte1");
             Console.WriteLine("Ingrese su nombre");
             nombre = Console.ReadLine();

             Console.WriteLine("Ingrese su apellido");
             apellido = Console.ReadLine();

             Console.WriteLine($"Su nombre completo es: {nombre} {apellido}");
             Console.WriteLine($"Su nombre es: {nombre} y su apellido es:{apellido}");
             Console.ReadKey();

             string unaCadena;
             Console.WriteLine("Ingrese lo que vió");
             unaCadena = Console.ReadLine();

             if (string.IsNullOrEmpty(unaCadena))
             {
                 Console.WriteLine("Ud. ingresó nada");
                 Console.ReadKey();
             }
             else if (string.IsNullOrWhiteSpace(unaCadena))
             {
                 Console.WriteLine("Ud. ingresó un espacio vacío");
                 Console.ReadKey();
             }

             else
             {
                 Console.WriteLine($"Ud ingresó: {unaCadena}");

                 Console.ReadKey();
             };

             string cadena2;
             Console.WriteLine("Ingrese el nombre de su madre");
             cadena2 = Console.ReadLine();
             Console.WriteLine($"La longitud del texto ingresado es: {cadena2.Length}");

             if (cadena2.Contains("a"))
             { Console.WriteLine("El texto ingresado contiene la letra 'a'"); }
             else
             { Console.WriteLine("El texto ingreado no contiene la letra 'a'"); };
             Console.ReadLine();

             string cadena3, cadena4;
             Console.WriteLine("Cuéntanos, ¿Con quién vives?");
             cadena3 = Console.ReadLine();
             Console.WriteLine("De su familia, ¿Quién es el próximo en cumplir años?");
             cadena4 = Console.ReadLine();

             // if (cadena3.Contains(cadena4))
             // { Console.WriteLine("El próximo cumpleaños coincide con una persona que vive con vos"); }
             // else
             // { Console.WriteLine("El próximo cumpleaños no es de alguien que viva con vos"); };
             // Console.ReadLine();

             int resultado1;

             resultado1 = String.Compare(cadena3, cadena4, true);

             if (resultado1 > 0 )
              { Console.WriteLine("El próximo cumpleaños coincide con una persona que vive con vos"); }
                 else
                 { Console.WriteLine("El próximo cumpleaños no es de alguien que viva con vos"); };
                 Console.ReadLine(); 


             string cadena5, corte1, corte2;
             Console.WriteLine("Ingrese un usuario con un mínimo de 5 carácteres");
             cadena5 = Console.ReadLine();
             corte1 = (cadena5.Substring(0, 2));
             corte2 = (cadena5.Substring(cadena5.Length -2, 2));

             if (cadena5.Length < 5 || String.IsNullOrWhiteSpace(cadena5))
             { Console.WriteLine("Ingresó un usuario con menos de 5 carácteres"); }
             else
             {Console.WriteLine($"Los primeros dos caracteres ingresados son: {corte1} y los últimos dos son: {corte2}"); }
             Console.ReadLine(); */

            string cadena6;
            Console.WriteLine("Ingrese su nombre y su edad");
            cadena6 = Console.ReadLine();
            Console.Write("Lo que ingresó fue: ");
            Console.WriteLine(cadena6.Replace(" ",""));
            Console.ReadKey();































        }
    }
}
