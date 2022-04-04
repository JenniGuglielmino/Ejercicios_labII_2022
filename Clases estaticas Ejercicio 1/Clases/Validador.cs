using System;

namespace Clases
{
    public static class Validador
    {
        /// <summary>
        /// Verifica que el numero ingresado este dentro del rango
        /// </summary>
        /// <param name="valor">Numero ingresado</param>
        /// <param name="min">Numero minimo</param>
        /// <param name="max">Numero maximo</param>
        /// <returns>true si esta dentro del rango, false si no lo esta</returns>
        public static bool Validar(int valor, int min, int max)
        {
            if (valor >= min && valor >= max)
            {
                return true;
            }
            return false;
        }
    }
}
