using Clases;
using System;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int suma = 0;
            int numeroIngresado;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese numero: ");
                int.TryParse(Console.ReadLine(), out numeroIngresado);

                if (Validador.Validar(numeroIngresado, -100, 100))
                {
                    if (numeroIngresado < min)
                    {
                        min = numeroIngresado;
                    }
                    else if (numeroIngresado > max)
                    {
                        max = numeroIngresado;
                    }
                }
                else
                {
                    Console.WriteLine("El numero ingresado esta fuera de rango");
                }
                suma += numeroIngresado;
            }

            Console.WriteLine($"Minimo: {min}.Maximo: {max}. Promedio {suma / 10}");
            Console.ReadKey();
        }
    }
}
