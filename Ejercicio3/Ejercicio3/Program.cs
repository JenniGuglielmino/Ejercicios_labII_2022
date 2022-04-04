using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 3";
            int numero;
            int contador;
            Console.Write("Ingrese un numero: ");
            int.TryParse(Console.ReadLine(), out numero);
            do
            {
                Console.WriteLine("ERROR. ¡Reingresar numero!");
                Console.Write("Ingrese un numero: ");
            } while (!int.TryParse(Console.ReadLine(), out numero));
            for (int i = 2; i <= numero - 1; i++)
            {
                contador = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contador++;
                    }
                }
                if (contador == 2)
                {
                    Console.WriteLine("La cantidad de numeros primos hasta {0}, es {1}", numero, i);
                }
            }
            Console.ReadKey();
        }
    }
}
