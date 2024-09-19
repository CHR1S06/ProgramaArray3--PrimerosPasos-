using ProgramaArray3.EstructuraArray;
using System;
using System.Linq;

namespace ProgramaArray3.Validaciones
{
    public class ValorMenor
    {
        private int[] arregloVM;

        public void ValidacionMenorValor()
        {
            ArrayEstrc arrayEstrc = new ArrayEstrc();
            arrayEstrc.StructureArray(); // Inicializamos el arreglo

            arregloVM = arrayEstrc.Arreglo; // Guardamos el arreglo

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPresione cualquier tecla para continuar con las validaciones.");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();

            if (arregloVM != null && arregloVM.Length > 0)
            {
                int valorMinimo = arregloVM.Min();
                Console.WriteLine($"El elemento de menor valor es: {valorMinimo}");
            }
            else
            {
                Console.WriteLine("El arreglo está vacío o no ha sido inicializado como es debido.");
            }
        }

        public int[] GetArreglo()
        {
            return arregloVM;
        }
    }
}
