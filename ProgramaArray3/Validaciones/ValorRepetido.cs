using ProgramaArray3.EstructuraArray;
using System;
using System.Collections.Generic;

namespace ProgramaArray3.Validaciones
{
    public class ValorRepetido
    {
        public void ValidacionVR(int[] arregloValorRepetido)
        {
            if (arregloValorRepetido == null || arregloValorRepetido.Length == 0)
            {
                Console.WriteLine("El arreglo está vacío o no ha sido inicializado.");
                return;
            }

            var contador = new Dictionary<int, int>();

            // Contar las ocurrencias de cada valor
            foreach (int valor in arregloValorRepetido)
            {
                if (contador.ContainsKey(valor))
                {
                    contador[valor]++;
                }
                else
                {
                    contador[valor] = 1;
                }
            }

            // Revisar si hay algún valor repetido
            bool hayRepetido = false;
            foreach (var kvp in contador)
            {
                if (kvp.Value > 1)
                {
                    Console.WriteLine($"El valor {kvp.Key} se repite {kvp.Value} veces.");
                    hayRepetido = true;
                }
            }

            if (!hayRepetido)
            {
                Console.WriteLine("No hay ningún valor repetido en el arreglo.");
            }
        }
    }
}
