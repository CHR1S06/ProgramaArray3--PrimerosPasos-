using ProgramaArray3.EstructuraArray;
using ProgramaArray3.Validaciones;
using System;

namespace ProgramaArray3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancia y ejecutar la validación de menor valor
            ValorMenor valorMenor = new ValorMenor();
            valorMenor.ValidacionMenorValor();

            // Obtener el arreglo de ValorMenor
            int[] arreglo = valorMenor.GetArreglo();

            // Crear instancia y ejecutar la validación de valores repetidos
            ValorRepetido valorRepetido = new ValorRepetido();
            valorRepetido.ValidacionVR(arreglo);

            // Mensaje final para salir
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPresione cualquier tecla para salir.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
