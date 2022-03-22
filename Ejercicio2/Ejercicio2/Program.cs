using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 2";
            int numero;
            double resultadoCuadrado;
            double resultadoCubo;
            Console.Write("Ingrese un numero: ");
            int.TryParse(Console.ReadLine(), out numero);
            do
            {
                Console.WriteLine("ERROR. ¡Reingresar numero!");
                Console.Write("Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out numero);
            } while ((numero < 0));

            resultadoCuadrado = Math.Pow(numero, 2);
            resultadoCubo = Math.Pow(numero, 3);
            Console.WriteLine($"El cuadrado del numero ingresado es {resultadoCuadrado}, el cubo {resultadoCubo}");
            Console.ReadKey();
        }
    }
}
