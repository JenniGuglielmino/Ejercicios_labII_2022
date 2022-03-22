using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";
            int cantidadNumeros = 5;
            int numero;
            float promedio;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            int suma = 0;
            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.Write("Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out numero);

                if (maximo < numero)
                {
                    maximo = numero;
                }
                if (minimo > numero)
                {
                    minimo = numero;
                }

                suma += numero;
            }

            promedio = (float)suma / cantidadNumeros;
            Console.WriteLine("El promedio de los numeros ingresados es {0}", promedio);

            Console.WriteLine("El numero mayor es {0}", maximo);

            Console.WriteLine("El numero menor es {0}", minimo);

            Console.ReadKey();
        }
    }
}
