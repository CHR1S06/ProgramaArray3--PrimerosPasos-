using System;

namespace ProgramaArray3.EstructuraArray
{
    public class ArrayEstrc
    {
        // Propiedad para el arreglo, accesible desde fuera de la clase
        public int[] Arreglo { get; private set; }

        // Método para inicializar el arreglo con valores
        public void StructureArray()
        {
            Console.Write("Por favor introduce la cantidad de elementos del arreglo: ");

            int elementos;
            while (true)
            {
                try
                {
                    elementos = Convert.ToInt32(Console.ReadLine());
                    if (elementos > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor introduzca un valor válido.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error de entrada: " + ex.Message);
                }
            }

            Arreglo = new int[elementos];

            for (int i = 0; i < Arreglo.Length; i++)
            {
                Console.Write($"Por favor introduzca el valor del elemento ({i}): ");

                while (true)
                {
                    try
                    {
                        int valorElementos = Convert.ToInt32(Console.ReadLine());
                        Arreglo[i] = valorElementos;
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error de entrada: " + ex.Message);
                    }
                }
            }
        }
    }
}
