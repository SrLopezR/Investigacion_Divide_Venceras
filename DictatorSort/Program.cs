using System;
using System.Collections.Generic;

class DictatorSort
{
    // Método que elimina los números que no están en orden ascendente
    static int[] DictatorSortAlgorithm(int[] array)
    {
        List<int> sortedArray = new List<int>();

        // El dictador solo deja pasar los números que están en orden ascendente
        sortedArray.Add(array[0]); // El primer número siempre se conserva

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] >= sortedArray[sortedArray.Count - 1])
            {
                sortedArray.Add(array[i]);
            }
            else
            {
                Console.WriteLine($"Dictador: Eliminando {array[i]} porque no sigue el orden.");
            }
        }

        return sortedArray.ToArray();
    }

    static void Main()
    {
        // Arreglo de ejemplo
        int[] array = { 4, 2, 7, 1, 9, 5 };

        Console.WriteLine("Arreglo original:");
        Console.WriteLine(string.Join(" ", array));

        // Aplicar DictatorSort
        int[] sortedArray = DictatorSortAlgorithm(array);

        // Mostrar el arreglo "ordenado" por el dictador
        Console.WriteLine("\nArreglo después de DictatorSort (con elementos eliminados):");
        Console.WriteLine(string.Join(" ", sortedArray));
    }
}
